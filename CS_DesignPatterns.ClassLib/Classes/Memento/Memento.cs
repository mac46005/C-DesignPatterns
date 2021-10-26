using System;

namespace CS_DesignPatterns.ClassLib.Classes.Memento{
    //* The Memento Design Pattern provide means to keep track of the states of an object

    //* This is the Memento generic structure to wrap the objects to keep state
    public class Memento<T> where T : ICloneable{
        private T StateObj{get;set;}
        public T GetState(){
            return StateObj;
        }
        public void SetState(T stateObj){
            StateObj = (T)stateObj.Clone();
        }
    }
}