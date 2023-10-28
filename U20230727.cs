namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\nMenu de opciones");
                Console.WriteLine("1. Ingresar números");
                Console.WriteLine("2. Calcular suma");
                Console.WriteLine("3. Buscar número");
                Console.WriteLine("4. Ordenar Números");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarNumeros();
                        break;
                    case 2:
                        int suma = CalcularSuma();
                        Console.WriteLine("La suma de los números es: " + suma);
                        break;
                    case 3:
                        BuscarNumero();
                        Console.ReadKey();
                        break;
                    case 4:
                        OrdenarNumeros();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("BYE BYE!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 5);
        }

        static int[] numeros = new int[5];
        static int cantidadNumeros = 0;

        static void IngresarNumeros()
        {
            Console.WriteLine("\nIngresa un número hasta 5 (ingresa -1 para finalizar)");
            cantidadNumeros = 0;

            while (cantidadNumeros < numeros.Length)
            {
                Console.Write("Número #{0}: ", cantidadNumeros + 1);
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                    break;

                numeros[cantidadNumeros] = numero;
                cantidadNumeros++;
            }
        }

        static int CalcularSuma()
        {
            int suma = 0;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                suma += numeros[i];
            }
            return suma;
        }

        static void BuscarNumero()
        {
            Console.Write("\nIngrese el número que desea buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("\nEl número fue encontrado en el arreglo.");
            else
                Console.WriteLine("\nEl número no fue encontrado en el arreglo.");
        }

        static void OrdenarNumeros()
        {
            Array.Sort(numeros, 0, cantidadNumeros);
            Console.WriteLine("\nNúmeros ordenados de manera ascendente:");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}

