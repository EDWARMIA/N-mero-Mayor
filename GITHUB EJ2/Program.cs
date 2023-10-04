using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITHUB_EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int cantidadNumeros;
                Console.Write("Ingrese la cantidad de números a comparar: ");
                if (int.TryParse(Console.ReadLine(), out cantidadNumeros))
                {
                    if (cantidadNumeros > 0)
                    {
                        int numeroMaximo = int.MinValue;

                        for (int i = 1; i <= cantidadNumeros; i++)
                        {
                            Console.Write($"Ingrese el número {i}: ");
                            if (int.TryParse(Console.ReadLine(), out int numero))
                            {
                                if (numero > numeroMaximo)
                                {
                                    numeroMaximo = numero;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                                i--; // Restar 1 al contador para repetir la entrada del número.
                            }
                        }

                        Console.WriteLine($"El número más alto es: {numeroMaximo}");
                    }
                    else
                    {
                        Console.WriteLine("La cantidad de números debe ser mayor que cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }

                Console.ReadLine();
            }
        }

    }
}

