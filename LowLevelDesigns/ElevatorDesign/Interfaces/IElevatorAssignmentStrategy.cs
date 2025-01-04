using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ElevatorDesign.Interfaces
{
    public interface IElevatorAssignmentStrategy
    {
        public Elevator GetElevator(int requestedFloor);
    }
}
