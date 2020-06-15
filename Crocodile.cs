using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion8
{
    class Crocodile : ITerrestriaAnimal , IMarineAnimal , IReptile
    {
        //public void Eat()
        //{
        //    Console.WriteLine("The Crocodile aets flesh");
        //}
        //public void Swin()
        //{
        //    Console.WriteLine("The Crocodile can swim four times faster than an Olympic swimmer");
        //}
        string ITerrestriaAnimal.Eat()
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }
        string IMarineAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }
        public string EatTerrestrial()
        {
            ITerrestriaAnimal objTerAnimal;
            objTerAnimal = this;
            return objTerAnimal.Eat();
        }
        public string EatMarine()
        {
            IMarineAnimal objMarAnimal;
            objMarAnimal = this;
            return objMarAnimal.Eat();
        }
        public void Drink()
        {
            Console.WriteLine("Drink fresh water");
        }

        public void Habitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Flesh");
        }
    }
}
