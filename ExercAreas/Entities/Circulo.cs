using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercAreas.Entities.Enums;

namespace ExercAreas.Entities
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo()
        {
        }

        public Circulo(Cor cores, double raio) : base(cores)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * (Raio * Raio);
        }


    }
}
