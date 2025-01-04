using LowLevelDesigns.ElevatorDesign.Interfaces;
using System;
using System.Collections.Generic;

namespace LowLevelDesigns.ElevatorDesign
{
    public class ElevatorsController : IObserver
    {
        private List<Elevator> _elevatorList;
        private IElevatorAssignmentStrategy _elevatorAssignmentStrategy;

        public ElevatorsController(List<Elevator> elevatorList, IElevatorAssignmentStrategy strategy)
        {
            _elevatorList = elevatorList;
            _elevatorAssignmentStrategy = strategy;
        }

        public void AddRequest(int requestedFloor, bool isUp)
        {
            Elevator elevator = _elevatorAssignmentStrategy.GetElevator(requestedFloor);
            if (elevator != null)
            {
                elevator.AddRequest(requestedFloor, isUp);
            }
        }

        public void Update(object sender, object arg)
        {
            if (sender is FloorInterface)
            {
                Tuple<int, bool> floorAndDirection = (Tuple<int, bool>)arg;
                bool isUp = floorAndDirection.Item2;
                int requestedFloor = floorAndDirection.Item1;
                Console.WriteLine($"Request from floor {requestedFloor} for {(isUp ? "Up" : "Down")}");
                AddRequest(requestedFloor, isUp);
            }
        }
    }
}
