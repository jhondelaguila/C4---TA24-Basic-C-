using System;
using System.Linq;

namespace M3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Milestone 1 ###");
            Milestone1();
            Console.WriteLine("\n### Milestone 2 ###");
            Milestone2();
            Console.WriteLine("\n### Milestone 3 ###");
            Milestone3();
        }

        static void Milestone1()
        {
            // FASE 1
            string ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6;

            Console.WriteLine("FASE 1:");
            Console.Write("Introduce el nombre de la ciudad 1: ");
            ciudad1 = Console.ReadLine();
            Console.Write("Introduce el nombre de la ciudad 2: ");
            ciudad2 = Console.ReadLine();
            Console.Write("Introduce el nombre de la ciudad 3: ");
            ciudad3 = Console.ReadLine();
            Console.Write("Introduce el nombre de la ciudad 4: ");
            ciudad4 = Console.ReadLine();
            Console.Write("Introduce el nombre de la ciudad 5: ");
            ciudad5 = Console.ReadLine();
            Console.Write("Introduce el nombre de la ciudad 6: ");
            ciudad6 = Console.ReadLine();

            Console.WriteLine("\nNombres de ciudades introducidos:");
            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudad2);
            Console.WriteLine(ciudad3);
            Console.WriteLine(ciudad4);
            Console.WriteLine(ciudad5);
            Console.WriteLine(ciudad6);

            // FASE 2
            string[] arrayCiutats = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };

            Console.WriteLine("\nFASE 2:");
            Array.Sort(arrayCiutats);
            foreach (string ciudad in arrayCiutats)
            {
                Console.WriteLine(ciudad);
            }

            // FASE 3
            string[] arrayCiutatsModificades = new string[arrayCiutats.Length];
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                arrayCiutatsModificades[i] = arrayCiutats[i].Replace('a', '4');
            }

            Console.WriteLine("\nFASE 3:");
            Array.Sort(arrayCiutatsModificades);
            foreach (string ciudadModificada in arrayCiutatsModificades)
            {
                Console.WriteLine(ciudadModificada);
            }

            // FASE 4
            Console.WriteLine("\nFASE 4:");
            foreach (string ciudad in arrayCiutats)
            {
                char[] nombreInvertido = ciudad.Reverse().ToArray();
                string nombreInvertidoStr = new string(nombreInvertido);
                Console.WriteLine(nombreInvertidoStr);
            }
        }

        static void Milestone2()
        {
            double[,] notasAlumnos = new double[5, 3];

            // Llenar el array con notas
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Alumno {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Ingrese nota {j + 1}: ");
                    double nota = Convert.ToDouble(Console.ReadLine());
                    notasAlumnos[i, j] = nota;
                }
                Console.WriteLine();
            }

            // Calcular promedio y mostrar si ha aprobado o suspendido
            for (int i = 0; i < 5; i++)
            {
                double sumaNotas = 0;
                for (int j = 0; j < 3; j++)
                {
                    sumaNotas += notasAlumnos[i, j];
                }
                double promedio = sumaNotas / 3;
                string estado = promedio >= 5 ? "aprobado" : "suspendido";
                Console.WriteLine($"Alumno {i + 1}: Promedio = {promedio:F2}, {estado}");
            }
        }

        static void Milestone3()
        {
            Console.Write("Introduce un número N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Secuencia de Fibonacci hasta " + n + ":");

            int first = 0;
            int second = 1;
            int next;

            Console.Write(first + " " + second + " ");

            for (int i = 2; i <= n; i++)
            {
                next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;
            }
        }
    }
}
