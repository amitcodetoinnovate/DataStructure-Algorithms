using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ParkingLot
{
    public class ParkingLot
    {
        public List<ParkingFloor> parkingFloors;
        public List<Entrance> entrances;

        public Address address;

        public string ParkinLotName;

        public bool IsParkingSpaceAvailable(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool UpdateParkingAttendant(ParkingAttendant parkingAttendant, int gateId)
        {
            throw new NotImplementedException();
        }




    }
}
