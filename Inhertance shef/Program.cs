using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef1 = new Chef();
            Chef chef2 = new Chef(); // object based on normal chef class

            ItalianChef chef3 = new ItalianChef(); //object from Italian Chef Class

            Console.WriteLine("This is now from normal chef");

            chef1.MakeSalad();
            chef2.MakeChicken();
            //chef2.MakePasta();
            

            Console.WriteLine("This is new from Italian Chef");
            chef3.MakeChicken();
           

            //freese
            Console.ReadKey();
        }
    }
}
