using System;
using CS_DesignPatterns.ClassLib.Interfaces.Factory;

//* Factory Design Pattern
//? This is a creational pattern that uses a specialized object to create other objects, abstracting the use of concrete objects. This is a pattern extensivelly used in strategies to reduce coupling in the code.
//* The concrete class with specific implementations for the interface method
namespace CS_DesignPatterns.ClassLib.Classes.Factory{
    public class Middleware1 : IMiddleware
    {
        //* Implementing the interface method
        public void DoAction()
        {
            Console.WriteLine("Executing action from Middleware1");
        }
    }
}