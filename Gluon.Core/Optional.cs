namespace Gluon.Core;

internal readonly struct Optional<T> : IOptional<T>
{
    private readonly T? _value;

    public Optional()
    {
        HasValue = false;
        _value = default;
    }

    public Optional(T value)
    {
        HasValue = true;
        _value = value;
    }

    public bool HasValue { get; }

    public TResult Match<TResult>(Func<T, TResult> OnSomething, Func<TResult> OnNothing)
    {
        return HasValue ? OnSomething(_value!) : OnNothing();
    }
}
