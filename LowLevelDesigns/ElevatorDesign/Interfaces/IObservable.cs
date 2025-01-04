namespace LowLevelDesigns.ElevatorDesign.Interfaces
{
    public interface IObservable
    {
        public void AddObserver(IObserver observer);
        public void NotifyObservers(object arg);
    }
}
