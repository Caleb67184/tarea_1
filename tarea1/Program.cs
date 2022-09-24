using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = new string[5];
            double[] notas = new double[5];
            byte contador = 1;
            double total = 0;
            double promedio;
            byte cant_mayor = 0; 
            byte cant_menor = 0;
            double mayor = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el nombre del estudiante "+contador+":");
                estudiantes[i] = (Console.ReadLine());
                Console.WriteLine("Digite la nota del estudiante "+contador+":");
                notas[i] = double.Parse(Console.ReadLine());
                contador++;
                total += notas[i];
            }
            promedio = total / 5;
            mayor = notas[0];

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > mayor) {
                    mayor = notas[i];
                }
            }


            for (int i = 0; i < 5; i++)
            {
                if (notas[i] > promedio) {
                    cant_mayor++;
                }
                else
                {
                    cant_menor++;
                }
            }

            Console.WriteLine("El promedio de las notas es de: " + promedio);
            Console.WriteLine("La nota más alta es: "+mayor);
            Console.WriteLine(cant_mayor + " estudiantes tienen nota mayor al promedio");
            Console.WriteLine(cant_menor + " estudiantes tienen una nota menor al promedio");
            Console.Read();
        }
    }
}
