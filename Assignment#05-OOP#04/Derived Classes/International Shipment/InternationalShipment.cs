using System;
using System.Text;
using System.Collections.Generic;
using Assignment_05_OOP_04.Shipment;
using Assignment_05_OOP_04.ITrackable;
using Assignment_05_OOP_02.Delivery_Address;


namespace Assignment_05_OOP_02.International_Shipment
{
    public class InternationalShipment : Shipment, ITrackable
    {
        private decimal _CustomsFee;
        private string _DestinationCountry = string.Empty;

        public string DestinationCountry
        {
            get { return _DestinationCountry; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _DestinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return _CustomsFee; }
            set
            {
                if (value >= 0)
                    _CustomsFee = value;
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + CustomsFee;

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry,
            decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Priority International Customs Report");
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
            Console.WriteLine($"Customs Fee: {CustomsFee}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine("--------------------");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }
    }
}
