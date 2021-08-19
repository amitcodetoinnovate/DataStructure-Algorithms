using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ParkingLot
{
    public class Vehicle
    {
        public string licenseNumber;
        public VehicleType VehicleType;
        public ParkingTicket parkingTicket;
        public PaymentInfo PaymentInfo;
    }
}
