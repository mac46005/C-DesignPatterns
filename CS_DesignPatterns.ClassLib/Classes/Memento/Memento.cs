using System;

namespace CS_DesignPatterns.ClassLib.Classes.Memento{
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