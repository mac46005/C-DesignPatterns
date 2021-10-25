using System;
using CS_DesignPatterns.ClassLib.Interfaces.Factory;

namespace CS_DesignPatterns.ClassLib.Classes.Factory{
    public class Middleware1 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("Executing action from Middleware1");
        }
    }
}