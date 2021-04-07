using System;
using System.Globalization;
using System.Collections.Generic;
using ExercAreas.Entities;
using ExercAreas.Entities.Enums;

namespace ExercAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFigura = new List<Figura>();

            Console.Write("Entre com a Quantidade de areas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados Figura {i}: ");
                Console.Write("Rentagulo ou Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (PRETO/ AZUL/ VERMELHO): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                                
                if(ch == 'r')
                {
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaFigura.Add(new Retangulo(cor, altura, largura));
                }

                if (ch == 'c')
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    listaFigura.Add(new Circulo(cor, raio));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Area das Figuras:");

            foreach (Figura item in listaFigura)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
               
            }
           
            

        }
    }
}
