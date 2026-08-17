using System;
using System.Text;
using Assignment_05_OOP_04;
using System.Collections.Generic;
using Assignment_05_OOP_04.Shipment;
using Assignment_05_OOP_04.IInsurable;
using Assignment_05_OOP_04.ITrackable;
using Assignment_05_OOP_02.Delivery_Address;


namespace Assignment_05_OOP_02.Standard_Shipment
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {

        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost { get { return DeliveryFee + (decimal)(Weight * 5); } }

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
            Console.WriteLine("--------------------");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05M;
        }
    }
}