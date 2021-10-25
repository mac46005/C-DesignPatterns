using System;
using CS_DesignPatterns.ClassLib.Interfaces.Factory;

namespace CS_DesignPatterns.ClassLib.Classes.Factory{
    public class Middleware2 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("An action from Middleware2");
        }
    }
}