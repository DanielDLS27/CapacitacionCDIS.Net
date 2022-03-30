using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opc;
            int numRetiros=0;
            int[] retiros;
            int[,] cantBilletesYMonedas = new int[10,2];

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("--------------- Banco CDIS ---------------");
                    Console.WriteLine("1. Ingresar la cantidad de retiros hechos por los usuarios.");
                    Console.WriteLine("2. Revisar la cantidad entregada de billetes y monedas.\n");
                    Console.WriteLine("Ingresa la opcion: ");
                    opc = int.Parse(Console.ReadLine());
                } while (opc != 1 && opc != 2);

                switch (opc)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("¿Cuantos retiros se hicieron (maximo 10) ?");
                            numRetiros = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                        } while (numRetiros < 0 || numRetiros > 10);

                        retiros = new int[numRetiros];

                        for (int i = 0; i < numRetiros; i++)
                        {
                            bool cantidadCorrecta = false;
                            do
                            {
                                Console.Write("Ingrese la cantidad del retiro #" + (i + 1) + ": ");
                                retiros[i] = int.Parse(Console.ReadLine());
                                if (retiros[i] < 0 || retiros[i] > 50000)
                                {
                                    Console.WriteLine("La cantidad de retiro debe estar entre 0 y 50000");
                                }
                                else
                                {
                                    cantidadCorrecta = true;
                                }
                            } while (!cantidadCorrecta);
                        }

                        int monedas = 0;
                        int billetes = 0;

                        for (int i = 0; i < retiros.Length; i++)
                        {
                            int aux = retiros[i];
                            monedas = 0;
                            billetes = 0;

                            while (aux >= 500)
                            {
                                aux = aux - 500;
                                billetes++;
                            }
                            while (aux >= 200)
                            {
                                aux = aux - 200;
                                billetes++;
                            }
                            while (aux >= 100)
                            {
                                aux = aux - 100;
                                billetes++;
                            }
                            while (aux >= 50)
                            {
                                aux = aux - 50;
                                billetes++;
                            }
                            while (aux >= 20)
                            {
                                aux = aux - 20;
                                billetes++;
                            }
                            while (aux >= 10)
                            {
                                aux = aux - 10;
                                monedas++;
                            }
                            while (aux >= 5)
                            {
                                aux = aux - 5;
                                monedas++;
                            }
                            while (aux >= 1)
                            {
                                aux = aux - 1;
                                monedas++;
                            }

                            cantBilletesYMonedas[i, 0] = billetes;
                            cantBilletesYMonedas[i, 1] = monedas;
                        }

                        Console.WriteLine("Presiona 'enter' para continuar ...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("Cantidad de retiros: " + numRetiros);
                        for (int i = 0; i < numRetiros; i++)
                        {
                            Console.WriteLine("\nRetiro #" + (i + 1) + ": ");
                            Console.WriteLine("Cantidad de billetes usados: " + cantBilletesYMonedas[i, 0]);
                            Console.WriteLine("Cantidad de monedas usadas: " + cantBilletesYMonedas[i, 1]);
                        }

                        Console.WriteLine("Presiona 'enter' para continuar ...");
                        Console.ReadLine();
                        break;
                }

                Console.ReadLine();
            }while (true);

        }
    }
}
