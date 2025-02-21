using System.Reflection;
using System.Windows;
using System.Windows.Data;
using Gluon.Core;

namespace Pion.Core;

public sealed record ElementGenerator
{
    private readonly Type _type;
    private readonly string _elementFullName;

    private static readonly List<string> _globalPropertyNames = [];

    private ElementGenerator(Type type)
    {
        _type = type;
        _elementFullName = _type.FullName
            ?? throw new ArgumentException();
    }

    private static string PrintType(Type type)
    {
        var typeDefinition = type.FullName
                ?? throw new ArgumentException(); ;
        if (type.GetGenericArguments().Length == 0)
        {
            return typeDefinition;
        }
        var genericArguments = type.GetGenericArguments();
        var unmangledName = typeDefinition[..typeDefinition.IndexOf('`')];
        return unmangledName + "<" + string.Join(",", genericArguments.Select(PrintType)) + ">";
    }

    private string GenerateBindings()
    {
        var properties = _type
            .GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy)
            .Where(field =>
                field.Name.EndsWith("Property") &&
                field.FieldType == typeof(DependencyProperty))
            .Select(field =>
            {
                var name = field.Name[..^8];
                var dp = (DependencyProperty?)field.GetValue(null)
                    ?? throw new ArgumentException();

                var metadata = dp.GetMetadata(field.DeclaringType) as FrameworkPropertyMetadata;
                var mode = (dp.ReadOnly, metadata?.BindsTwoWayByDefault ?? false) switch
                {
                    (true, false) => BindingMode.OneWayToSource,
                    (false, false) => BindingMode.OneWay,
                    (false, true) => BindingMode.TwoWay,
                    _ => throw new ArgumentException(),
                };

                var bindingType = mode switch
                {
                    BindingMode.OneWayToSource => "out ReadOnlyBinding",
                    BindingMode.OneWay => "ReadWriteBinding",
                    BindingMode.TwoWay => "out ReadWriteBinding",
                    _ => throw new ArgumentException(),
                };


                var isGlobalProperty = _type.GetProperty(name)?.PropertyType == null;
                if (isGlobalProperty)
                {
                    if (_globalPropertyNames.Contains(name))
                    {
                        return null;
                    }

                    _globalPropertyNames.Add(name);
                }

                var type = _type.GetProperty(name)?.PropertyType
                    ?? metadata?.DefaultValue.GetType()
                    ?? throw new ArgumentException();

                var typeName = PrintType(type);

                var assignment = mode switch
                {
                    BindingMode.OneWayToSource => "value = new();",
                    BindingMode.TwoWay => @$"
var metadata = {_elementFullName}.{name}Property.GetMetadata(typeof({field.DeclaringType!.FullName}))
    ?? throw new ArgumentException(""Can't get metadata."");
value = new(({typeName})metadata.DefaultValue);",
                    _ => ""
                };

                var targetElementName = isGlobalProperty
                    ? typeof(FrameworkElement).FullName!
                    : _elementFullName;

                return @$"
public static {targetElementName} With{name}(this {targetElementName} self, {bindingType}<{typeName}> value)
{{
    {assignment.Indent()}
    self.SetBinding({_elementFullName}.{name}Property, value);
    return self;
}}";
            })
            .OfType<string>()
            .ToList();

        return string.Join(Environment.NewLine, properties).Trim();
    }

    private string GenerateEvents()
    {
        var events = _type
            .GetEvents(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy)
            .Select(e =>
            {
                var name = e.Name;

                var eventArgs = e.EventHandlerType?.GetMethod("Invoke")?.GetParameters()[1].ParameterType
                    ?? throw new ArgumentException();
                var eventPayload = eventArgs != typeof(RoutedEventArgs) ? eventArgs : typeof(Unit);
                var eventPayloadName = PrintType(eventPayload);

                return $@"
public static {_elementFullName} On{name}(this {_elementFullName} self, out IObservable<{eventPayloadName}> handler)
{{
    var subject = new Subject<{eventPayloadName}>();
    self.{name} += (_, {(eventPayload == typeof(Unit) ? "_" : "e")}) => subject.OnNext({(eventPayload == typeof(Unit) ? "new()" : "e")});
    handler = subject;

    return self;
}}";
            });

        return string.Join(Environment.NewLine, events).Trim();
    }

    public string Generate()
    {
        return @$"
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{{
    {GenerateBindings().Indent()}

    {GenerateEvents().Indent()}
}}";
    }

    public static string Generate(Type type)
    {
        return new ElementGenerator(type).Generate();
    }

    public static string Generate<T>()
    {
        return new ElementGenerator(typeof(T)).Generate();
    }
}
