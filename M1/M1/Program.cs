using System;

namespace M1
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
            string nom = "Juan";
            string cognom1 = "Perez";
            string cognom2 = "Gonzalez";

            int dia = 1;
            int mes = 1;
            int any = 1979;

            Console.WriteLine($"{cognom1} {cognom2}, {nom}");
            Console.WriteLine($"{dia}/{mes}/{any}");

            // FASE 2
            const int AnyTraspas = 1948;
            int IntervalAnyTraspas = 4;
            int anysTraspas = (any - AnyTraspas) / IntervalAnyTraspas;

            Console.WriteLine($"Anys de traspàs entre {AnyTraspas} i {any}: {anysTraspas}");

            // FASE 3
            bool esAnyTraspas = (any % IntervalAnyTraspas == 0);
            string fraseAnyTraspas = "El meu any de naixement és de traspàs.";
            string fraseNoAnyTraspas = "El meu any de naixement no és de traspàs.";

            if (esAnyTraspas)
            {
                Console.WriteLine(fraseAnyTraspas);
            }
            else
            {
                Console.WriteLine(fraseNoAnyTraspas);
            }

            // FASE 4
            string nomComplet = $"{nom} {cognom1} {cognom2}";
            string dataNaixement = $"{dia:D2}/{mes:D2}/{any}";
            string fraseTraspas = esAnyTraspas ? fraseAnyTraspas : fraseNoAnyTraspas;

            Console.WriteLine($"El meu nom és {nomComplet}");
            Console.WriteLine($"Vaig néixer el {dataNaixement}");
            Console.WriteLine(fraseTraspas);
        }

        static void Milestone2()
        {
            double decimalNumber = 123.4567;

            int integerNumber = (int)decimalNumber;
            float floatNumber = (float)decimalNumber;
            string stringNumber = decimalNumber.ToString();

            Console.WriteLine($"Valor en int: {integerNumber}");
            Console.WriteLine($"Valor en float: {floatNumber}");
            Console.WriteLine($"Valor en string: {stringNumber}");
        }

        static void Milestone3()
        {
            // Milestone 3
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = array.Length;
            int temp;

            for (int i = 0; i < n / 2; i++)
            {
                temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }

            Console.WriteLine("Array después de la rotación:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}