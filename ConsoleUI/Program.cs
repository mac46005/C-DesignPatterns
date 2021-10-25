using System;
using CS_DesignPatterns.ClassLib.Classes;
using PracticeDesignPatterns.ClassLib.Classes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = HelloWorldSingleton.SingleInstance;
            Console.WriteLine(hello.HelloThere("Marco Preciado"));
        }
    }
}
