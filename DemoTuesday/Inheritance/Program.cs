using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // test method inheritance 

            // created two new objects

            Child c = new Child();
            GrandChild1 gc = new GrandChild1();

            Console.WriteLine("calling methos from grandchild");
            gc.BaseMethod();
            gc.ChildMethod();
            gc.GrandChildMethod();
            Console.WriteLine();

            Console.WriteLine("Calling methods from child");
            c.BaseMethod();
            c.ChildMethod();
            // c.GrandChildMethod();
            Console.WriteLine();

            // test base class fields 
            Base bc = new Base(123, 132);
            bc.PrintState();

            // test child print state
            Child c2 = new Child(123, 456, 789);
            c2.PrintState();


            



        }
    }
}
