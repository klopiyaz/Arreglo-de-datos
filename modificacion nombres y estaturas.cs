using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "tanjiro", "nezuko", "zenitsu", "inosuke", "genya", "kanao", "tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };

            for (int j = 0; j > estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                        string temp = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = temp;
                        Console.WriteLine(nombres[i] + " con estatura  de = " + estatura[i]);
                    }
                }
            }
        }
    }
}
