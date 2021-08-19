using System;

namespace LowLevelDesigns.ParkingLot
{
    public class PaymentInfo
    {
        public double Amount;
        public DateTime PaymeDateTime;
        public int TransactionId;
        public ParkingTicket ParkingTicket;
        public PaymentStatus PaymentStatus;
    }
}