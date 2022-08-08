using System;

namespace Matrices_multidimencionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //int j;

            //double[,] ventas = new double[4, 3] { { 100, 120, 205 }, { 115, 196, 308 }, { 157, 172, 245 }, { 130, 180, 281 } };

            //for (i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Fila {0}", i);
            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(ventas[i, j]);
            //    }

            //}

            byte i, j, numAlumnos, salones;
            double sumaCali = 0, promedio, califMin = 10, califMax = 0;

            Console.WriteLine("ingrese el numero de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            double[,] calificaciones = new double[salones, numAlumnos];

            for (i = 0; i < salones; i++)
            {

                Console.WriteLine("salon {0}", i);

                for(j=0; j< numAlumnos; j++)
                {
                    Console.WriteLine("ingrese la calificación del alumno {0}", i);
                    Console.WriteLine("Ingrese la calificacion: ");
                    calificaciones[i,j] = Convert.ToDouble(Console.ReadLine());

                    sumaCali += calificaciones[i,j];
                }

            }

            promedio = sumaCali / (numAlumnos*salones);

            for (i = 0; i < salones; i++)
            {

                for (j = 0; j < numAlumnos; j++)
                {
                    if (calificaciones[i, j] < califMin)
                    {
                        califMin = calificaciones[i, j];
                    }
                }

                    
            }

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < numAlumnos; j++)
                {
                    if (calificaciones[i,j] > califMax)
                    {
                        califMax = calificaciones[i,j];
                    }
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificacion mínima es: {0}", califMin);
            Console.WriteLine("La calificacion máxima es: {0}", califMax);


        }
    }
}
