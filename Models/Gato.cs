using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models
{
    public class Gato : Animal
    {
        public double TamañoBigotes { get; set; }
        public bool Orejas { get; set; }

        public Gato(string nombre, string genero, string especie, double pesoEnKg, double tamañoBigotes, bool orejas) : base(nombre, genero, especie, pesoEnKg)
        {
            TamañoBigotes = tamañoBigotes;
            Orejas = orejas;
        }
    }
}