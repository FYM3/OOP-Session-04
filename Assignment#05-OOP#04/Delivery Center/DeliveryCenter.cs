using Assignment_05_OOP_04.Driver;
using Assignment_05_OOP_04.IInsurable;
using Assignment_05_OOP_04.ITrackable;
using Assignment_05_OOP_04.Shipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05_OOP_02.Delivery_Center
{
    public class DeliveryCenter
    {

        private Shipment[] _shipment = new Shipment[20];

        private Driver driver = null!;

        public string CenterName = string.Empty;

        public Driver Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public Shipment this[int index]
        {
            get
            {
                return _shipment[index];
            }
            set
            {
                if (index >= 0 && index < _shipment.Length)
                    _shipment[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipment.Length; i++)
                {
                    if (_shipment[i] != null &&
                        _shipment[i].TrackingCode == trackingCode)
                    {
                        return _shipment[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipment.Length; i++)
            {
                if (_shipment[i] == null)
                {
                    _shipment[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < _shipment.Length; i++)
            {
                if (_shipment[i] != null &&
                    _shipment[i].TrackingCode == trackingCode)
                {
                    _shipment[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment shipment in _shipment)
            {
                if (shipment != null)
                    shipment.PrintShipment();
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (Shipment shipment in _shipment)
            {
                if (shipment != null)
                {
                    ITrackable trackableShipment = (ITrackable)shipment;
                    Console.WriteLine(trackableShipment.GetTrackingStatus());
                }
            }
        }

        public void PrintCalculateInsurance()
        {
            foreach (Shipment shipment in _shipment)
            {
                if (shipment != null)
                {
                    IInsurable insurable = (IInsurable)shipment;
                    Console.WriteLine(insurable.CalculateInsurance());
                }
            }
        }

    }

}