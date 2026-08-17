using System;
using System.Text;
using System.Collections.Generic;


namespace Assignment_05_OOP_04.Delivery_Report
{
    public class DeliveryReport
    {
        public void PrintShipment(ITrackable.ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable.IInsurable shipment)
        {
            Console.WriteLine(shipment.CalculateInsurance());
        }
    }
}
