using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class SavageDuck : Duck
    {
        public SavageDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }
        public override void display()
        {
            Console.WriteLine("im a savage Duck");
        }
    }
}
