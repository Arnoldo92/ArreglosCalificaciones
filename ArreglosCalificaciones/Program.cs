using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        //Ejercicio con arrreglos, if y for.
        //----------------------------------quimica y fisica
        // ALUMNO PABLO:   calificaciones       10   y  8
        // ALUMNO LUIS:    calificaciones  9 y 9
        // ALUMNO RODOLFO:  calificaciones  8 y  10
        // ALUMNO ANA:     calificaciones  10 y  8
        // ALUMNO GABRRIELA: calificaciones  9 y  7
        private float[] quimica;
        private float[] fisica;
        private float[] promFinal;
        private string[] alumnos;

        public void Calificaciones()
        {
            alumnos = new string[5] { "LUIS", "PABLO", "ANA", "RODOLFO", "GABRIELA" };


            quimica = new float[5];


            fisica = new float[5];

            Console.WriteLine("     CALIFICACIONES DE LA MATERIA DE QUIMICA: \n");
            for (int x = 0; x < alumnos.Length; x++)
            {
                Console.WriteLine("Ingresar la calificacion de " + alumnos[x] + ": ");
                String gradeCaptureQuimica = Console.ReadLine();
                quimica[x] = float.Parse(gradeCaptureQuimica);
            }
            Console.Clear();

            Console.WriteLine("     CALIFICACIONES DE LA MATERIA DE FISICA: \n");
            for (int x = 0; x < alumnos.Length; x++)
            {
                Console.WriteLine("Ingrese la calificacion de  " + alumnos[x] + ": ");
                String gradeCaptureFisica = Console.ReadLine();
                fisica[x] = float.Parse(gradeCaptureFisica);
            }

            Console.Clear();
        }
        public void calcularPromedio()
        {
            promFinal = new float[5];
            float maxGrade = 0;
            float totalQuimica = 0;
            float totalFisica = 0;

            Console.WriteLine("     CALIFICACIONES DE LOS ALUMNOS: \n");
            for (int i = 0; i < alumnos.Length; i++)
            {
                promFinal[i] = (quimica[i] + fisica[i]) / 2;
                if (promFinal[i] >= maxGrade)
                {
                    maxGrade = promFinal[i];
                }

                Console.WriteLine("alumnos " + alumnos[i] + "  |  quimica " + quimica[i] + "  |  fisica: " + fisica[i] + "  |  el promedio general es: " + promFinal[i]);

            }

            //------------------------------------------------------------------------------------------------------------------------------------//
            for (int i = 0; i < quimica.Length; i++)
            {
                totalQuimica = totalQuimica + quimica[i];
            }

            for (int i = 0; i < fisica.Length; i++)
            {
                totalFisica = totalFisica + fisica[i];
            }
            Console.WriteLine("\n");
            Console.WriteLine("  promedio general de cada clase \n");
            Console.WriteLine("Promedio de la clase de quimica " + totalQuimica / 5 + "\n Promedio de la clase de Fisica: " + totalFisica / 5);

            Console.WriteLine("\n");
            Console.WriteLine("     La clase de mayor promedio es \n");

            if (totalQuimica > totalFisica)
            {
                Console.WriteLine("Clase Quimica");
            }
            else
            {
                Console.WriteLine("Clase Fisica");
            }


        }


        static void Main(string[] args)
        {
            Program grades = new Program();
            grades.Calificaciones();
            grades.calcularPromedio();
            Console.ReadKey();
        }
    }
}