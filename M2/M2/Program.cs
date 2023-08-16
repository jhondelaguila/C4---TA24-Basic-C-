using System;
using System.Collections.Generic;
using System.Threading;


namespace M2
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
            char[] nombre = { 'J', 'h', 'o', 'n' };

            Console.WriteLine("FASE 1:");
            foreach (char letra in nombre)
            {
                Console.WriteLine(letra);
            }

            // FASE 2
            List<char> nombreList = new List<char>(nombre);

            Console.WriteLine("\nFASE 2:");
            foreach (char letra in nombreList)
            {
                if (char.IsDigit(letra))
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
                else if (EsVocal(letra))
                {
                    Console.WriteLine("VOCAL");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                }
            }

            // FASE 3
            Dictionary<char, int> contadorLetras = new Dictionary<char, int>();
            foreach (char letra in nombreList)
            {
                if (char.IsLetter(letra))
                {
                    if (contadorLetras.ContainsKey(letra))
                    {
                        contadorLetras[letra]++;
                    }
                    else
                    {
                        contadorLetras[letra] = 1;
                    }
                }
            }

            Console.WriteLine("\nFASE 3:");
            foreach (var kvp in contadorLetras)
            {
                Console.WriteLine($"Lletra: {kvp.Key}, Apareix {kvp.Value} vegades");
            }

            // FASE 4
            char[] apellido = { 'D', 'e', 'l', ' ', 'Á', 'g', 'u', 'i', 'l', 'a' };
            List<char> apellidoList = new List<char>(apellido);
            apellidoList.Insert(0, ' ');  // Agregar un espacio al principio

            List<char> fullName = new List<char>();
            fullName.AddRange(nombreList);
            fullName.AddRange(apellidoList);

            Console.WriteLine("\nFASE 4:");
            Console.WriteLine("FullName: " + string.Join(", ", fullName));
        }

        static bool EsVocal(char letra)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return Array.Exists(vocales, v => v == letra);
        }

        static void Milestone2()
        {
            Console.Write("Introduce la altura para la escala de números: ");
            int alturaEscala = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscala de números:");
            for (int i = 1; i <= alturaEscala; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nIntroduce la altura para la pirámide invertida: ");
            int alturaPiramide = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPirámide invertida:");
            for (int i = alturaPiramide; i >= 1; i--)
            {
                for (int j = 1; j <= alturaPiramide - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Milestone3()
        {
            int hour = 0;
            int minutes = 0;
            int seconds = 0;

            while (true)
            {
                Console.WriteLine($"{hour:D2}:{minutes:D2}:{seconds:D2}");
                Thread.Sleep(1000); // Espera 1 segundo

                seconds++;

                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;

                    if (minutes == 60)
                    {
                        minutes = 0;
                        hour++;

                        if (hour == 24)
                        {
                            hour = 0;
                        }
                    }
                }
            }
        }
    }
}
