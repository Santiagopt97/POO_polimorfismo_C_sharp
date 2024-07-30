using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        protected string Nombre { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public double PesoEnKg { get; set; }

        public Animal(string nombre, string genero, string especie, double pesoEnKg)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Genero = genero;
            Especie = especie;
            PesoEnKg = pesoEnKg;
        }

        public virtual void Hablar(){
            Console.WriteLine("El animal está hablando.");
        }

        public virtual void Desplazarse(){
            Console.WriteLine("El animal se mueve");
        }
    }
}