using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ParkingLot
{
    public class ParkingTicket
    {
        public int TicketId;
        public int LevelId;
        public int SpaceId;
        public DateTime VehicleEntryTme;
        public DateTime VehicleExpiryTime;
        public ParkingSpaceType parkingSpaceType;
        public int totalCost;

        public void UpdateTotalCost()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleExitTime(DateTime vehicleExitDateTime)
        {
            throw new NotImplementedException();
        }

    }
}
