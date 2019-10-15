using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {

        // Field Inheritance 
        private int basePrivateInt;
        protected int baseProtectedInt;

        //Constructors 

        public Base() { }
        public Base(int privateint, int protectedint)
        {
            this.basePrivateInt = privateint;
            this.baseProtectedInt = protectedint;

        }

         
        // Methods
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod");
        }

        public virtual void PrintState()
        {
            Console.WriteLine("Base Class Object");
            Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tbaseProtected: {0}", baseProtectedInt);
        }
    }
}
