using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new Mallard();
            Duck model = new ModelDuck();
            Duck savage = new SavageDuck();
            //################## MALLARD #####################
            Console.WriteLine("PRIMERA ESPECIE DE PATO");
            mallard.performFly();
            mallard.performQuack();
            mallard.display();
            //################## MODEL #####################
            Console.WriteLine("\nSEGUNDA ESPECIE DE PATO");
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
            model.performQuack();
            model.display();
            //################## SAVAGE #####################
            Console.WriteLine("\nTERCERA ESPECIE DE PATO");
            savage.setFlyBehavior(new FlyRocketPowered());
            savage.performFly();
            savage.setQuackBehavior(new MuteQuack());
            savage.performQuack();
            savage.display();
            Console.ReadKey();

        }
    }
}
