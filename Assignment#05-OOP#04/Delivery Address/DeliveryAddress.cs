using System;
using System.Text;
using System.Collections.Generic;

namespace Assignment_05_OOP_02.Delivery_Address
{
    public struct DeliveryAddress
    {
        public string City { set; get; }
        public string Street { set; get; }
        public int BuildingNumber { set; get; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.City = city;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"City: {City},Street: {Street},Building Number: {BuildingNumber}";
        }
    }
}
