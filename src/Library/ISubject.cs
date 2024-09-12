namespace Ucu.Poo.Observer;

public interface ISubject
{ 
    void Subscribe(IObserver observer);

    void Unsubscribe(IObserver observer);

    void Notify(Temperature temperature);
}