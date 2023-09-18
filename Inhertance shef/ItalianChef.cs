using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shef
{
    internal class ItalianChef : Chef
    {

        public void MakePasta()
        {
            Console.WriteLine("makes pasta");
        }
        public override void MakeSalad()
        {

            Console.WriteLine("The chef makes Italian salad");
        }
    }
}
           
        
    

