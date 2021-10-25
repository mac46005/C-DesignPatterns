using CS_DesignPatterns.ClassLib.Interfaces.Factory;

//* Factory Design Pattern
//? This is a creational pattern that uses a specialized object to create other objects, abstracting the use of concrete objects. This is a pattern extensively used in strategies to reduce coupling in the code

namespace CS_DesignPatterns.ClassLib.Classes.Factory{
    //* The factory class that will be used to instantiate the concrete classes depending on a condition.
    public class MiddlewareFactory{
        public IMiddleware GetMiddleware(int which){
            switch(which){
                case 1: return new Middleware1();
                case 2: return new Middleware2();
                default: return new Middleware1();
            }
        }
    }
}