using System;
using System.Text;
using System.Collections.Generic;
using Assignment_05_OOP_04.Shipment;
using Assignment_05_OOP_04.ITrackable;
using Assignment_05_OOP_02.Delivery_Address;


namespace Assignment_05_OOP_02.Express_Shipment
{
    public class ExpressShipment : Shipment, ITrackable
    {
        private decimal _ExtraFee;

        public decimal ExtraFee
        {
            get { return _ExtraFee; }
            set
            {
                if (value >= 0)
                    _ExtraFee = value;
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + ExtraFee;

        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine('\n');
            Console.WriteLine("---AllShipments---");
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"DeliveryFee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Extra Fee: {ExtraFee}");
            Console.WriteLine("--------------------");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
    }
}
