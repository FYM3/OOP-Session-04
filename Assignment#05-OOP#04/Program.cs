using Assignment_05_OOP_02.Delivery_Address;
using Assignment_05_OOP_02.Delivery_Center;
using Assignment_05_OOP_02.Express_Shipment;
using Assignment_05_OOP_02.International_Shipment;
using Assignment_05_OOP_02.Standard_Shipment;

namespace Assignment_05_OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1,Q2) => Part 01 — Theoretical Questions

            // Q1 Abstraction

            // a)  What is Abstraction in Object-Oriented Programming? 
            // b)  Why is abstraction considered one of the four pillars of OOP ?

            // Answer a)
            // Abstraction is the process of hiding implementation details and showing only the essential features of an object to the user.

            // Answer b)
            // Abstraction helps hide complex implementation details and exposes only the necessary functionality to the user.


            // Q2  Abstract Classes vs. Interfaces 

            // a)  What is the difference between an Abstract Class and an Interface?
            // b)  When would you choose an Interface instead of an Abstract Class?
            // c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            // Answer a)
            // An Abstract Class can contain fields, constructors, implemented methods,and abstract methods.
            // An Interface mainly defines a contract that a class must implement.
            // A class can inherit from only one Abstract Class,but it can implement multiple Interfaces.

            // Answer b)
            // When I would choose an Interface when different classes need to follow
            // the same contract or behavior, even if they are not related by inheritance.

            // Answer c)
            // No, a class cannot inherit from multiple Abstract Classes.
            // Yes, a class can implement multiple Interfaces.

            #endregion


            #region 8Q) => Main() Checklist 

            // a) Create StandardShipment
            StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 5, 70, new DeliveryAddress());

            // b) Create ExpressShipment
            ExpressShipment expressShipment = new ExpressShipment("SH002", "Phone", 0, 70, new DeliveryAddress(), 30);

            // c) Create InternationalShipment
            InternationalShipment internationalShipment = new InternationalShipment("SH003", "Monitor", 20, 50, new DeliveryAddress(), "Germany", 110);

            // Delivery Center
            DeliveryCenter deliveryCenter = new DeliveryCenter();

            // d) Add all shipments
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);



            // e) Print all shipment details
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            deliveryCenter.PrintAllShipments();


            // f) Print Tracking Status
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");
            deliveryCenter.PrintTrackingStatuses();


            // g) Print Insurance
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine("==========================================");
            deliveryCenter.PrintCalculateInsurance();



            // h) ITrackable[] Polymorphism
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("ITrackable[] Polymorphism");
            Console.WriteLine("==========================================");

            ITrackable.ITrackable[] trackableShipments = { standardShipment, expressShipment, internationalShipment };

            foreach (ITrackable.ITrackable shipment in trackableShipments)
                Console.WriteLine(shipment.GetTrackingStatus());



            // i) IInsurable[] Polymorphism
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("IInsurable[] Polymorphism");
            Console.WriteLine("==========================================");

            IInsurable.IInsurable[] insurableShipments = { standardShipment, expressShipment, internationalShipment };

            foreach (IInsurable.IInsurable shipment in insurableShipments)
                Console.WriteLine(shipment.CalculateInsurance());

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            Console.WriteLine("==========================================");


            #endregion

        }
    }
}
