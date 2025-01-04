using LowLevelDesigns.ElevatorDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ElevatorDesign
{
    public class FloorController : IObserver
    {
        private ElevatorsController _elevatorsController;

        public FloorController(ElevatorsController elevatorsController)
        {
            _elevatorsController = elevatorsController;
        }

        public void Update(object sender, object arg)
        {
            if (sender is Elevator)
            {
                int floor = (int)arg;
                Console.WriteLine("Elevator is at Floor: " + floor);
            }
        }
    }
}
