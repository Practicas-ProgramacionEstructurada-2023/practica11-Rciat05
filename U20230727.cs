using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            
        }

        static int[] numeros = new int[5];

        static int cantidadNumeros = 0; 

        static void IngresarNumeros(){
            Console.WriteLine("\n Ingresa un número hasta 5 (ingresa -1 para finalizar)");
            cantidadNumeros = 0;

            while (cantidadNumeros < numeros.Length)
            {
                Console.Write("Número #{0}: ", cantidadNumeros + 1);
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1);
                    break;

                numeros[cantidadNumeros]= numero;    
                cantidadNumeros++;
            }

        }

        static int CalcularSuma {
            
        }

    }
}