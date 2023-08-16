using System;
using System.Collections.Generic;

namespace M4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Milestone 1 ###");
            //Milestone1();
            Console.WriteLine("\n### Milestone 2 ###");
            //Milestone2();
            Console.WriteLine("\n### Milestone 3 ###");
            Milestone3();
        }

        static void Milestone1()
        {
            // FASE 1
            int billete5 = 5, billete10 = 10, billete20 = 20, billete50 = 50, billete100 = 100, billete200 = 200, billete500 = 500;
            int total = 0;

            string[] menu = { "Plato 1", "Plato 2", "Plato 3", "Plato 4", "Plato 5" };
            int[] precios = { 10, 15, 20, 25, 30 };

            // FASE 2
            List<string> pedido = new List<string>();
            List<int> preciosPedido = new List<int>();

            Console.WriteLine("Menú:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]} - {precios[i]}€");
            }

            int opcion = 1;
            do
            {
                try
                {
                    Console.Write("Elige un plato (1-5): ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion >= 1 && opcion <= 5)
                    {
                        pedido.Add(menu[opcion - 1]);
                        preciosPedido.Add(precios[opcion - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Introduce un número entre 1 y 5.");
                    }

                    Console.Write("¿Deseas seguir pidiendo? (1: Si / 0: No): ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Introduce un número válido.");
                }
            } while (opcion == 1);

            // FASE 3
            Console.WriteLine("Pedido:");
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine($"{pedido[i]} - {preciosPedido[i]}€");
                total += preciosPedido[i];
            }

            Console.WriteLine($"Total: {total}€");

            try
            {
                Console.WriteLine("Introduce el precio con el que pagarás: ");
                int pago = Convert.ToInt32(Console.ReadLine());

                int cambio = pago - total;

                if (cambio >= 0)
                {
                    Console.WriteLine($"Cambio: {cambio}€");

                    int[] billetes = { billete500, billete200, billete100, billete50, billete20, billete10, billete5 };
                    Console.WriteLine("Entregar:");
                    for (int i = 0; i < billetes.Length; i++)
                    {
                        int cantidad = cambio / billetes[i];
                        if (cantidad > 0)
                        {
                            Console.WriteLine($"{cantidad} billetes de {billetes[i]}€");
                            cambio -= cantidad * billetes[i];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El pago es insuficiente. Por favor, introduce una cantidad válida.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Introduce un número válido.");
            }
        }

        static void Milestone2()
        {
            // FASE 1
            int billete5 = 5, billete10 = 10, billete20 = 20, billete50 = 50, billete100 = 100, billete200 = 200, billete500 = 500;
            int total = 0;

            string[] menu = { "Plato 1", "Plato 2", "Plato 3", "Plato 4", "Plato 5" };
            int[] precios = { 10, 15, 20, 25, 30 };

            // FASE 2
            List<string> pedido = new List<string>();
            List<int> preciosPedido = new List<int>();

            Console.WriteLine("Menú:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]} - {precios[i]}€");
            }

            int opcion = 1;
            do
            {
                try
                {
                    Console.Write("Elige un plato (1-5): ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion >= 1 && opcion <= 5)
                    {
                        pedido.Add(menu[opcion - 1]);
                        preciosPedido.Add(precios[opcion - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Introduce un número entre 1 y 5.");
                    }

                    Console.Write("¿Deseas seguir pidiendo? (1: Si / 0: No): ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Introduce un número válido.");
                    opcion = 1;
                }
            } while (opcion == 1);

            // FASE 3
            Console.WriteLine("Pedido:");
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine($"{pedido[i]} - {preciosPedido[i]}€");
                total += preciosPedido[i];
            }

            Console.WriteLine($"Total: {total}€");

            try
            {
                Console.WriteLine("Introduce el precio con el que pagarás: ");
                int pago = Convert.ToInt32(Console.ReadLine());

                int cambio = pago - total;

                if (cambio >= 0)
                {
                    Console.WriteLine($"Cambio: {cambio}€");

                    int[] billetes = { billete500, billete200, billete100, billete50, billete20, billete10, billete5 };
                    Console.WriteLine("Entregar:");
                    for (int i = 0; i < billetes.Length; i++)
                    {
                        int cantidad = cambio / billetes[i];
                        if (cantidad > 0)
                        {
                            Console.WriteLine($"{cantidad} billetes de {billetes[i]}€");
                            cambio -= cantidad * billetes[i];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El pago es insuficiente. Por favor, introduce una cantidad válida.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Introduce un número válido.");
            }
        }

        static void Milestone3()
        {
            // FASE 1
            int billete5 = 5, billete10 = 10, billete20 = 20, billete50 = 50, billete100 = 100, billete200 = 200, billete500 = 500;
            int total = 0;

            string[] menu = { "Plato 1", "Plato 2", "Plato 3", "Plato 4", "Plato 5" };
            int[] precios = { 10, 15, 20, 25, 30 };

            // FASE 2
            List<string> pedido = new List<string>();
            List<int> preciosPedido = new List<int>();

            Console.WriteLine("Menú:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]} - {precios[i]}€");
            }

            int opcion = 0;
            do
            {
                try
                {
                    Console.Write("Elige un plato (1-5): ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion < 1 || opcion > 5)
                    {
                        throw new OpcionInvalidaException("Opción inválida. Debe ser un número entre 1 y 5.");
                    }

                    pedido.Add(menu[opcion - 1]);
                    preciosPedido.Add(precios[opcion - 1]);

                    Console.Write("¿Deseas seguir pidiendo? (1: Si / 0: No): ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion != 1 && opcion != 0)
                    {
                        throw new RespuestaInvalidaException("Respuesta inválida. Introduce 1 para 'Si' o 0 para 'No'.");
                    }
                }
                catch (OpcionInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (opcion == 1);

            // FASE 3
            Console.WriteLine("Pedido:");
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine($"{pedido[i]} - {preciosPedido[i]}€");
                total += preciosPedido[i];
            }

            Console.WriteLine($"Total: {total}€");

            try
            {
                Console.WriteLine("Introduce el precio con el que pagarás: ");
                int pago = Convert.ToInt32(Console.ReadLine());

                int cambio = pago - total;

                if (cambio >= 0)
                {
                    Console.WriteLine($"Cambio: {cambio}€");

                    int[] billetes = { billete500, billete200, billete100, billete50, billete20, billete10, billete5 };
                    Console.WriteLine("Entregar:");
                    for (int i = 0; i < billetes.Length; i++)
                    {
                        int cantidad = cambio / billetes[i];
                        if (cantidad > 0)
                        {
                            Console.WriteLine($"{cantidad} billetes de {billetes[i]}€");
                            cambio -= cantidad * billetes[i];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El pago es insuficiente. Por favor, introduce una cantidad válida.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Introduce un número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Número demasiado grande.");
            }
        }
    
    }

    public class OpcionInvalidaException : Exception
    {
        public OpcionInvalidaException(string mensaje) : base(mensaje) { }
    }

    public class RespuestaInvalidaException : Exception
    {
        public RespuestaInvalidaException(string mensaje) : base(mensaje) { }
    }
}
