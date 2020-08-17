using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "tanjiro", "nezuko", "zenitsu", "inosuke", "genya", "kanao", "tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };
            double[] distancia = new double[7];

            double total = 0;
            total += estatura[0];
            total += estatura[1];
            total += estatura[2];
            total += estatura[3];
            total += estatura[4];
            total += estatura[5];
            total += estatura[6];
            double promedio = total / 7;
            Console.WriteLine("promedio = " + promedio);

            for (int i = 0; i < distancia.Length; i++)
            {
                distancia[i] = Math.Sqrt((estatura[i] - promedio) * (estatura[i] - promedio)) + (estatura[i] - promedio) * (estatura[i] - promedio);
            }

            double totaldistancia = 0;
            totaldistancia += distancia[0];
            totaldistancia += distancia[1];
            totaldistancia += distancia[2];
            totaldistancia += distancia[3];
            totaldistancia += distancia[4];
            totaldistancia += distancia[5];
            totaldistancia += distancia[6];
            double promediodistancia = totaldistancia / 7;
            Console.WriteLine("promedio distancia = " + promediodistancia);
        }
    }
}
