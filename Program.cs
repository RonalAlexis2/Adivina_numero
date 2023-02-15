using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_Numero
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instanciamos la clase Numero 
            Numero numA = new Numero();
            Numero numB = new Numero();

            //quemamos el valor que queremos que adivine el usuario
            numA.Llenar(84632);

            //ciclo hacer mientras 
            do
            {
                do
                { //solicitamos al usuario ingresar los numero
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el numero");

                } // solicitamos llenar siempre que este en true
                while (numB.Llenar(int.Parse(Console.ReadLine())) == true);

            }//mientras validar sea diferente de 5, indica que ingresaron 5 veces el numero correcto
            while (validar(numA, numB) != 5);

            Console.WriteLine("Haz ganado");

            Console.ReadKey();
        }

        //creamos metodo validar en el cual se evaluara si el numero ingresado es correcto o no
        static int validar(Numero _numA, Numero _numB)
        {
            //declaramos variables y las inicializamos
            int ban = 0, i = 0, j = 0;

            // recorremos los vectores para compararlos y ponerles el signo segun la logica
            for (i = 0; i < 5; i++)
            {
                if (_numA.valor[i] == _numB.valor[i])
                {
                    Console.WriteLine(_numA.valor[i] + "(+)");
                    ban++;
                }
                else
                {
                    for (j = 0; j < 5; j++)
                    {
                        if (_numA.valor[i] == _numB.valor[j])
                        {
                            Console.WriteLine(_numA.valor[i] + "(-)");
                        }
                    }
                }
            }

            return ban;
        }
    }
}
