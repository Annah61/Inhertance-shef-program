using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shef
{
    internal class Chef
    {
        public void MakeChicken() 
        {
            Console.WriteLine("The chef makes chicken");
        }
        public virtual void MakeSalad() { 

            Console.WriteLine("The chef makes salad");
        }
    }


} 
