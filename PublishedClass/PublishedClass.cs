using System;

namespace ClassLibrary1
{
    //delegate type
    public delegate void MyDelegate(int x, int y);
    public class PublishedClass
    {
        //private delegate
        private MyDelegate mydelegate;
        //step1:create the event 
        public event MyDelegate myEvent
        {
            
            add {mydelegate += value; }
            remove {mydelegate -= value; }
        }
   
        //step2:Raise Event
    public void RaiseEvent(int a,int b)
    {
        if (this.mydelegate != null)
        {
            this.mydelegate(a, b);
        }
    }
    }
}
