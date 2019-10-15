using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Child : Base
    {
        //fields
        protected int childProtectedInt;

        //constructor

            public Child() { }
            public Child(int basePrivateInt, int baseProtectedInt,
                int childProtectedInt)
                : base(basePrivateInt, baseProtectedInt)
        {
            this.childProtectedInt = childProtectedInt;
        }



        // Methods
        public void ChildMethod()
        {
            Console.WriteLine("ChildClass.ChildMethod");
        }
        public override void PrintState()
        {
            Console.WriteLine("Child Class Object");
            // Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            // Console.WriteLine("\tbaseProtected: {0}", baseProtectedInt);
            Console.WriteLine("\tchildProtectedInt: {0}", childProtectedInt);
            base.PrintState();
        }


    }
}
