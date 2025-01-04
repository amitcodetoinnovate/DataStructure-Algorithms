using LowLevelDesigns.ElevatorDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ElevatorDesign.Strategy
{
    public class NearestElevatorAssignment : IElevatorAssignmentStrategy
    {
        private List<Elevator> _elevators { get; set; }
        public NearestElevatorAssignment(List<Elevator> elevators)
        {
            _elevators = elevators;
        }

        public Elevator GetElevator(int requestedFloor)
        {
            Elevator elevator = null;
            int minDistance = int.MaxValue;
            foreach (Elevator e in _elevators)
            {
                int distance = Math.Abs(elevator.CurrentFloor - requestedFloor);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    elevator = e;
                }
            }
            return elevator;
        }

    }
}
