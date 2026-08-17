using System;
using System.Text;
using System.Collections.Generic;
using Assignment_05_OOP_02.Delivery_Address;


namespace Assignment_05_OOP_04.Shipment
{
    public abstract class Shipment
    {
        private string _TrackingCode = string.Empty;
        private string _Description = string.Empty;
        private double _Weight;
        private decimal _DeliveryFee;
        private DeliveryAddress _Destination;

        public string TrackingCode
        {
            get { return _TrackingCode; }
            private set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _TrackingCode = value;
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _Description = value;
            }
        }

        public double Weight
        {
            get { return _Weight; }
            set
            {
                if (value > 0)
                    _Weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return _DeliveryFee; }
            private set
            {
                if (value > 0)
                    _DeliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return _Destination; }
            set { _Destination = value; }
        }

        public virtual double EstimatedCost { get { return (double)_DeliveryFee + (_Weight * 5); } }

        public Shipment(string trackingCode)
        {
            this.TrackingCode = trackingCode;
            this.Description = "Unknown";
            this.Weight = 1;
            this.DeliveryFee = 50;
            this.Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.TrackingCode = trackingCode;
            this.Description = description;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
            this.Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public virtual void PrintShipment()
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

        public void UpdateWeight(double weight)
        {
            Weight = weight;
        }

        public void UpdateWeight(double PackingWeight,double weight)
        {
            Weight = PackingWeight + weight;
        }


    }
}