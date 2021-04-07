using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercAreas.Entities.Enums;

namespace ExercAreas.Entities
{
    abstract class Figura
    {
        public Cor Cores { get; set; }

        public Figura()
        {
        }

        public Figura(Cor cores)
        {
            Cores = cores;
        }

        public abstract double Area();
        
      
    }
}
