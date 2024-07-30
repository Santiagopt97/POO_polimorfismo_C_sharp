using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models
{
    public class Pez : Animal
    {
        public override void Hablar()
        {
            base.Hablar();
            Console.WriteLine("bloop.");
        }
        public override void Desplazarse()
        {
            base.Desplazarse();
            Console.WriteLine("El pez se desplaza en el agua.");
        }
    }
}