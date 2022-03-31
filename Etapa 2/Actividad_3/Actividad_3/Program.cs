using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes;
            int cantEstudiantes = 0;
            string matricula = null;
            string nombre = null;
            int edad =0;
            double cuotaEscolar=0;
            int nivelSNI=0;
            int opcEst;
            int opcServ;
            int opcBeca;
            bool realizaServicio;
            int porcentaje = 0;
            bool error0 = true;
            bool error1 = true;
            bool error2 = true;
            bool error3 = true;
            bool error4 = true;
            bool error5 = true;
            bool error6 = true;

            while (error0)
            {
                try
                {
                    Console.WriteLine("Ingrese cantidad de estudiantes: ");
                    cantEstudiantes = int.Parse(Console.ReadLine());
                    error0 = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            estudiantes = new Estudiante[cantEstudiantes];

            for(int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante #" +( i + 1));
                while (error1)
                {
                    try
                    {
                        Console.Write("Ingrese Matricula: "); //en mi caso la matricula es tipo string, no hace mucho uso de la exception
                        matricula = Console.ReadLine();
                        error1 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error1 = true;
                while (error2)
                {
                    try
                    {
                        Console.Write("\nIngrese Nombre: "); //con el nombre ocurre lo mismo que la matricula
                        nombre = Console.ReadLine();
                        error2 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error2 = true;
                while (error3)
                {
                    try
                    {
                        Console.Write("\nIngrese Edad: ");
                        edad = int.Parse(Console.ReadLine());
                        error3 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error3 = true;
                while (error4)
                {
                    try
                    {
                        Console.Write("\nIngrese Cuota Escolar: ");
                        cuotaEscolar = double.Parse(Console.ReadLine());
                        error4 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error4 = true;
                Console.WriteLine();

                Console.WriteLine("El estudiante es de:\n\nLicenciatura (1)\nPosgrado (2)");
                opcEst = int.Parse(Console.ReadLine());
                while(opcEst != 1 && opcEst != 2)
                {
                    Console.WriteLine("Ingrese opcion valida\n\nEl estudiante es de:\n\nLicenciatura (1)\nPosgrado (2)");
                    opcEst = int.Parse(Console.ReadLine());
                }
                if(opcEst == 1)
                {
                    Console.WriteLine("Realiza servicio social?\n\nSI (1)\nNO (2)");
                    opcServ = int.Parse(Console.ReadLine());
                    while (opcServ != 1 && opcServ != 2)
                    {
                        Console.WriteLine("Ingrese opcion valida\n\nRealiza servicio social?\n\nSI (1)\nNO (2)");
                        opcEst = int.Parse(Console.ReadLine());
                    }

                    realizaServicio = true;

                    Console.WriteLine("Cuenta con beca?\n\nSI (1)\nNO (2)");
                    opcBeca = int.Parse(Console.ReadLine());
                    while (opcBeca != 1 && opcBeca != 2)
                    {
                        Console.WriteLine("Ingrese opcion valida\n\nCuenta con beca?\n\nSI (1)\nNO (2)");
                        opcBeca = int.Parse(Console.ReadLine());
                    }
                    if(opcBeca == 1)
                    {
                        while (error5)
                        {
                            try
                            {
                                Console.WriteLine("Ingrese porcentaje de la beca: ");
                                porcentaje = int.Parse(Console.ReadLine());
                                error5 = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        error5 = true;
                    }

                    EstudianteLicenciatura b = new EstudianteLicenciatura(matricula, nombre, edad, cuotaEscolar, realizaServicio);
                    estudiantes[i] = b;
                    estudiantes[i].asignarBeca(porcentaje);
                }

                if(opcEst == 2)
                {
                    while (error6)
                    {
                        try
                        {
                            Console.WriteLine("Ingrese nivel de SNI: ");
                            nivelSNI = int.Parse(Console.ReadLine());
                            error6 = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    error6 = true;
                    Console.WriteLine("Cuenta con beca?\n\nSI (1)\nNO (2)");
                    opcBeca = int.Parse(Console.ReadLine());
                    while (opcBeca != 1 && opcBeca != 2)
                    {
                        Console.WriteLine("Ingrese opcion valida\n\nCuenta con beca?\n\nSI (1)\nNO (2)");
                        opcBeca = int.Parse(Console.ReadLine());
                    }
                    if (opcBeca == 1)
                    {
                        while (error5)
                        {
                            try
                            {
                                Console.WriteLine("Ingrese porcentaje de la beca: ");
                                porcentaje = int.Parse(Console.ReadLine());
                                error5 = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        error5 = true;
                    }

                    EstudiantePosgrado a = new EstudiantePosgrado(matricula, nombre, edad, cuotaEscolar, nivelSNI);
                    estudiantes[i] = a;
                    estudiantes[i].asignarBeca(porcentaje);
                }

                //estudiantes[i] = new Estudiante(matricula, nombre, edad, cuotaEscolar);
            }

            for(int i = 0;i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante #"+( i + 1)+"\n");
                Console.WriteLine(estudiantes[i].mostrarDatos());
            }

            Console.ReadLine();
        }
    }
}
