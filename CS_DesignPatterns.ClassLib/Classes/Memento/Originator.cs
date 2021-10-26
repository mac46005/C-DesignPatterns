using System;

namespace CS_DesignPatterns.ClassLib.Classes.Memento{
    //* The Memento Design Pattern provide means to keep track of the states of an object

    //* This is the generic structure that will wrap the most current object state with the option to restore an object state
    public class Originator<T> where T : ICloneable{
        private T StateObj {get;set;}
        public Memento<T> CreateMemento(){
            Memento<T> m = new Memento<T>();
            m.SetState(this.StateObj);
            return m;
        }
        public void RestoreMemento(Memento<T> m){
            this.StateObj = m.GetState();
        }
        public void ShowState(T state){
            this.StateObj = state;
        }

    }
}