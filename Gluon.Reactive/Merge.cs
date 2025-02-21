namespace Gluon.Reactive;

public sealed class Merge<T>(
    IObservable<T> left,
    IObservable<T> right)
    : IObservable<T>
{
    public IDisposable Subscribe(IObserver<T> observer)
    {
        var leftSub = left.Subscribe(observer);
        var rightSub = right.Subscribe(observer);

        return new Subscription(() =>
        {
            leftSub.Dispose();
            rightSub.Dispose();
        });
    }
}
