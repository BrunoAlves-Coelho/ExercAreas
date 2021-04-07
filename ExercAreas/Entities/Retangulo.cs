using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercAreas.Entities.Enums;

namespace ExercAreas.Entities
{
    class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(Cor cores, double altura, double largura) : base(cores)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double Area()
        {
            return Altura * Largura;
        }

        
    }
}
