using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, carta2 = 0, cartaAd = 0, total = 0, contador = 1, max = 0, sumacartas = 0, jugadoresactivos = 0;
            string otracarta = "s";

            Console.Write("Ingrese el numero de jugadores = ");
            int jugadores = int.Parse(Console.ReadLine());
            jugadoresactivos = jugadores;
            string[] nombres = new string[jugadores];
            int[] puntaje = new int[jugadores];

            while (jugadores < 0 || jugadores > 5)
            {
                Console.WriteLine("No se puede jugar con ese numero de jugadores");
                Console.Write("Ingrese el numero de jugadores = ");
                jugadores = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Como te llamas = ");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++)
            { // Esta condición es redundante, porque ya tengo el ciclo FOR para cada jugador
                Console.WriteLine("\nBienvenido jugador: " + nombres[i]);
                carta = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                Console.Write("\nCarta1 = " + carta);
                Console.Write("   Carta2 = " + carta2);
                total = carta + carta2;
                puntaje[i] = total;// Este es uno de los errores, el primer total no se almacenaba así que si uno no pedía cartas adicionales NUNCA guardaba el puntaje

                Console.Write("\nllevas = " + total);
                while (sumacartas < 21)
                {
                    Console.WriteLine(" \nOtra carta? (s/n): ");
                    otracarta = Console.ReadLine();
                    while (otracarta != "s" && otracarta != "n")
                    {
                        Console.WriteLine("Error, no se acepta otra respuesta");
                        Console.WriteLine(" \nOtra carta? (s/n): ");
                        otracarta = Console.ReadLine();
                    }
                    if (otracarta == "s")
                    {
                        cartaAd = aleatorio.Next(1, 11);
                        Console.WriteLine("\nCarta Adicional = " + cartaAd);
                        total = cartaAd + total;
                        Console.WriteLine("llevas = " + total);
                        puntaje[i] = total;
                        if (total > 21)
                        {
                            Console.WriteLine(" (Pierdes)");
                            break;
                        }
                        else if (total == 21)
                        {
                            Console.WriteLine(" (Ganas)");
                            break;
                        }
                        else {
                            Console.Write("perdio con = " + puntaje[i])
                             }              
                    }
                    if (otracarta == "n")
                    {
                        Console.WriteLine("Terminaste con = " + total);
                        break;
                    }
                }
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " = " + puntaje[i]);
            }
            for (int j = 0; j < nombres.Length - 1; j++)
            {
                for (int i = 0; i < nombres.Length - 1; i++)
                {
                    if (puntaje[i] < puntaje[i + 1])
                    {
                        int tmp = puntaje[i];
                        puntaje[i] = puntaje[i + 1];
                        puntaje[i + 1] = tmp;

                        string tmp2 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp2;
                    }
                }
            }
            Console.WriteLine("El ganador es = " + nombres[0]);
            Console.WriteLine("El segundo lugar es = " + nombres[1]);
            Console.WriteLine("el ganador es = " + max);
        }
    }
}
