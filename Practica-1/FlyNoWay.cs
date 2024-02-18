using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly() 
        {
            Console.WriteLine("I cant fly");
        }
    }
}
