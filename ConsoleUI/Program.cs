using System;
using CS_DesignPatterns.ClassLib.Classes;
using CS_DesignPatterns.ClassLib.Classes.Factory;
using CS_DesignPatterns.ClassLib.Interfaces.Factory;
using PracticeDesignPatterns.ClassLib.Classes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var middlewareFactory = new MiddlewareFactory();
            IMiddleware middleware = middlewareFactory.GetMiddleware(1);
            middleware.DoAction();

            middleware = middlewareFactory.GetMiddleware(2);
            middleware.DoAction();
        }
    }
}
