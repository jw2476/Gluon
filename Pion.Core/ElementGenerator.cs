using System.Reflection;
using System.Windows;
using System.Windows.Data;

namespace Pion.Core;

public sealed record ElementGenerator<T> where T : FrameworkElement
{
    private static readonly string ElementName = typeof(T).Name;
    private static readonly string ElementFullName = typeof(T).FullName ?? throw new ArgumentException();

    private sealed record Property(string Name, string TypeName, BindingMode Mode)
    {
        public string Generate()
        {
            var bindingType = Mode switch
            {
                BindingMode.OneWay => "ReadWriteBinding",
                BindingMode.TwoWay => "out ReadWriteBinding",
                BindingMode.OneWayToSource => "out ReadOnlyBinding",
                _ => throw new ArgumentException()
            };

            return @$"
public static {ElementName} With{Name}(this {ElementName} self, {bindingType}<{TypeName}> value)
{{
    value = new(string.Empty);
    self.SetBinding({ElementFullName}.{Name}Property, value);
    return self;
}}
";
        }
    }

    private static string GenerateBindings()
    {
        var properties = typeof(T)
            .GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy)
            .Where(field =>
                field.Name.EndsWith("Property") &&
                field.FieldType == typeof(DependencyProperty))
            .Where(field => typeof(T).GetProperty(field.Name[..^8])?.PropertyType.Name != null)
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

                var typeName = typeof(T).GetProperty(field.Name[..^8])!.PropertyType.FullName
                    ?? throw new ArgumentException();

                var extra = mode switch
                {
                    BindingMode.OneWayToSource => "value = new();",
                    BindingMode.TwoWay => @$"
var metadata = {ElementFullName}.{name}Property.GetMetadata(typeof({field.DeclaringType!.FullName}))
    ?? throw new ArgumentException(""Can't get metadata."");
value = new(({typeName})metadata.DefaultValue);",
                    _ => ""
                };

                return @$"
public static {ElementFullName} With{name}(this {ElementFullName} self, {bindingType}<{typeName}> value)
{{
    {extra.Indent()}
    self.SetBinding({ElementFullName}.{name}Property, value);
    return self;
}}";
            })
            .ToList();

        return string.Join("\n", properties).Trim();
    }

    public static string Generate()
    {
        return @$"
namespace Gluon.UI;

public static partial class UI
{{
    {GenerateBindings().Indent()}
}}";
    }
}
