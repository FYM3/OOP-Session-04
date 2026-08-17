
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

        }
    }
}
