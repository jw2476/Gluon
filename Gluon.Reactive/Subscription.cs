namespace Gluon.Reactive;

public sealed class Subscription(Action unsubscribe) : IDisposable
{
    public void Dispose()
    {
        unsubscribe();
    }
}
