using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesigns.ParkingLot
{
    public class ParkingAttendant : Account
    {
        public Payment paymentService;

        public bool processVehicleEntry(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public PaymentInfo ProcessPayment(ParkingTicket parkingTicket, PaymentType paymentType)
        {
            throw new NotImplementedException();
        }

    }
}
