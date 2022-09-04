using System;

class Program
{
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if(value >= 0)
                {
                    counter = value;
                }
            }
        }
        
    }
    static void Main(string[] args)
    {

    }

}