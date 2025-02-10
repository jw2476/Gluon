namespace Gluon.Core;

public interface IOptional<out T>
{
    public TResult Match<TResult>(Func<T, TResult> OnSomething, Func<TResult> OnNothing);
}

public static partial class Extensions
{
    public static IOptional<T> ToOptional<T>(this T? self)
    {
        return self == null ? new Optional<T>(self!) : new Optional<T>();
    }

    public static IOptional<TResult> Map<T, TResult>(this IOptional<T> self, Func<T, TResult> func)
    {
        return self.Match<Optional<TResult>>(
            value => new(func(value)),
            () => new());
    }

    public static IOptional<TResult> FlatMap<T, TResult>(this IOptional<T> self, Func<T, IOptional<TResult>> func)
    {
        return self.Match(
            value => func(value),
            () => new Optional<TResult>());
    }

    public static IOptional<T> Flatten<T>(this IOptional<IOptional<T>> self)
    {
        return self.Match(
            optional => optional.Match<Optional<T>>(
                value => new(value),
                () => new()),
            () => new());
    }

    public static T Or<T>(this IOptional<T> self, T defaultValue)
    {
        return self.Match(
            value => value,
            () => defaultValue);
    }
}