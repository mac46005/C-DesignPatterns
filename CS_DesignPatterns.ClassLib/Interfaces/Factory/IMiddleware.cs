namespace CS_DesignPatterns.ClassLib.Interfaces.Factory{

    //* Factory Design Pattern
    //? This is a creational pattern that uses a specialized object to create other objects, abstracting the use of concrete objects. This is a pattern extensivelly used in strategies to reduce coupling in the code.

    //* A simple implementation of a Factory Pattern using an interface
    public interface IMiddleware{
        void DoAction();
    }
}