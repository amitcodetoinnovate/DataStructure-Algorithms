using LowLevelDesigns.ElevatorDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LowLevelDesigns.ElevatorDesign
{
    public class Elevator : IObservable, IElevatorInterface
    {
        public int CurrentFloor { get; private set; }
        public ElevatorState CurrentState { get; private set; } = ElevatorState.IDLE;
        private List<IObserver> _observers = new List<IObserver>();
        private SortedSet<int> _upRequests = new SortedSet<int>();
        private SortedSet<int> _downRequests = new SortedSet<int>();
        private List<int> _floorBtns;
        private const int MaxCapacity = 10;
        public int CurrentLoad { get; private set; } = 0;

        public Elevator(int currentFloor, List<int> floorBtns)
        {
            CurrentFloor = currentFloor;
            _floorBtns = floorBtns;
        }

        public void AddRequest(int floor, bool isUp)
        {
            if (isUp)
            {
                _upRequests.Add(floor);
            }
            else
            {
                _downRequests.Add(floor);
            }
            NotifyObservers(CurrentFloor);
        }

        public void Start()
        {
            while (_upRequests.Any() || _downRequests.Any())
            {
                if (CurrentState == ElevatorState.IDLE || CurrentState == ElevatorState.MOVING_UP)
                {
                    ProcessRequests(_upRequests, ElevatorState.MOVING_UP);
                    if (!_upRequests.Any())
                    {
                        CurrentState = ElevatorState.IDLE;
                    }
                }

                if (CurrentState == ElevatorState.IDLE || CurrentState == ElevatorState.MOVING_DOWN)
                {
                    ProcessRequests(_downRequests, ElevatorState.MOVING_DOWN);
                    if (!_downRequests.Any())
                    {
                        CurrentState = ElevatorState.IDLE;
                    }
                }
            }
            CurrentState = ElevatorState.IDLE;
            Console.WriteLine($"Elevator is now {CurrentState}");
        }

        private void ProcessRequests(SortedSet<int> requests, ElevatorState targetState)
        {
            if (!requests.Any()) return;

            CurrentState = targetState;
            int targetFloor;
            while (requests.Any())
            {
                if (targetState == ElevatorState.MOVING_UP)
                {
                    targetFloor = requests.Min;
                    requests.Remove(targetFloor);
                }
                else
                {
                    targetFloor = requests.Max;
                    requests.Remove(targetFloor);
                }

                MoveToFloor(targetFloor);
                OpenDoors();
                CloseDoors();
            }
        }

        private void MoveToFloor(int targetFloor)
        {
            while (CurrentFloor != targetFloor)
            {
                CurrentFloor += (CurrentState == ElevatorState.MOVING_UP) ? 1 : -1;
                Console.WriteLine($"Elevator is at floor {CurrentFloor}");
                NotifyObservers(CurrentFloor);
                Thread.Sleep(500); // Simulate movement time
            }
        }

        private void OpenDoors()
        {
            CurrentState = ElevatorState.DOOR_OPEN;
            Console.WriteLine("Doors opening...");
            Thread.Sleep(1000); // Simulate door opening time
        }

        public void CloseDoors()
        {
            if (CurrentLoad > MaxCapacity)
            {
                Console.WriteLine("Elevator is overloaded. Cannot close doors.");
                return;
            }
            CurrentState = ElevatorState.DOOR_CLOSING;
            Console.WriteLine("Doors closing...");
            Thread.Sleep(1000); // Simulate door closing time
            CurrentState = (CurrentState == ElevatorState.MOVING_UP) ? ElevatorState.MOVING_UP : ElevatorState.MOVING_DOWN;
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

        public List<int> GetFloorBtns()
        {
            return _floorBtns;
        }
        public void AddLoad(int weight)
        {
            CurrentLoad += weight;
            Console.WriteLine($"Current load is {CurrentLoad}");
        }
        public void RemoveLoad(int weight)
        {
            CurrentLoad -= weight;
            Console.WriteLine($"Current load is {CurrentLoad}");
        }
    }
}
