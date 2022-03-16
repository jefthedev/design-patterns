namespace ObserverPattern
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update(IObservable observable);
    }
}
