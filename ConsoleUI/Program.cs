using System;
using CS_DesignPatterns.ClassLib.Classes;
using CS_DesignPatterns.ClassLib.Classes.Factory;
using CS_DesignPatterns.ClassLib.Classes.Memento;
using CS_DesignPatterns.ClassLib.Interfaces.Factory;
using PracticeDesignPatterns.ClassLib.Classes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator<StateObject> current = new Originator<StateObject>();
            current.SetState(new StateObject{Id = 1,Name = "Object 1"});
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject{Id = 2,Name = "Object 2"});
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject{Id = 3,Name = "Object 3"});
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            CareTaker<StateObject>.RestoreState(current,0);
            current.ShowState();

            Console.Read();
        }
    }
}
