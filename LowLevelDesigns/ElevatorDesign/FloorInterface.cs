using LowLevelDesigns.ElevatorDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ElevatorDesign
{
    public class FloorInterface : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();

        public event EventHandler<Tuple<int, bool>> ButtonPressed;

        public void PressUpButton(int floor)
        {
            ButtonPressed?.Invoke(this, new Tuple<int, bool>(floor, true));
            NotifyObservers(new Tuple<int, bool>(floor, true));
        }

        public void PressDownButton(int floor)
        {
            ButtonPressed?.Invoke(this, new Tuple<int, bool>(floor, false));
            NotifyObservers(new Tuple<int, bool>(floor, false));
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(object arg)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this, arg);
            }
        }
    }
}
