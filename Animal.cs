using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion8
{
    public abstract class Animal
    {
        //  //Non - abstract method implementation
         public void Eat()
        {
          Console.WriteLine("Enveryanimal eats food in order to survive");

         }
          // Abstract method declaration
          public abstract void AnimalSound();
          public abstract void Habitat();
        
    }
}
