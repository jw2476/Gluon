namespace Gluon.Core;

public static partial class Extensions
{
    public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
    {
        foreach (var item in self)
        {
            action(item);
        }
    }

    public static (IEnumerable<A>, IEnumerable<B>) Unzip<A, B>(this IEnumerable<(A, B)> self)
    {
        var array = self.ToArray();

        return (
            array.Select(x => x.Item1),
            array.Select(x => x.Item2));
    }

    public static IEnumerable<T> SelectMany<T>(this IEnumerable<IEnumerable<T>> self)
    {
        return self.SelectMany(x => x);
    }
}
