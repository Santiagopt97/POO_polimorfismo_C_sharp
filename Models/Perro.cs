using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models
{
    public class Perro : Animal
    {
        public override void Hablar(){
            base.Hablar();
            Console.WriteLine("Woof!");
        }

        public override void Desplazarse()
        {
            base.Desplazarse();
            Console.WriteLine("El perro se mueve a 4 patas.");
        }
    }
}