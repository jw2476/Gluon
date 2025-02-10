namespace Gluon.Reactive;
public sealed class Observer<T>(
    Action<T> onNext,
    Action<Exception> onError,
    Action onCompleted) : IObserver<T>
{
    public void OnCompleted()
    {
        onCompleted();
    }

    public void OnError(Exception error)
    {
        onError(error);
    }

    public void OnNext(T value)
    {
        onNext(value);
    }
}
