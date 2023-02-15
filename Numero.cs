using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_Numero
{
    public class Numero
    {
        //declaramos la variable de tipo victor, esto siempre debe ser privado por seguridad.
        public int[] valor { get; set; }

        //inicializamos en cero el vector
        public Numero()
        {
            valor = new int[5] { 0, 0, 0, 0, 0 };
        }
        
        //creamos un metodo llenar de tipo boolean y lo inicializamos en false
        public bool Llenar(int num)
        {
            bool res = false;
            int i = 4, j = 0;

            //con el try controlamos las exepciones que presente el programa
            try
            {
                //ciclo mientras con logica para ordenar los numeros ingresados por el usuario
                while (num != 0)
                {
                    valor[i] = num % 10;
                    num /= 10;
                    i--;
                }
                //validamos que el vector en la posicion 0 sea diferente a 0
                if (valor[0] != 0)
                {
                    //recorremos el vector para compararlo con su siguiente posicion
                    for (i = 0; i < valor.Length; i++)
                    {
                        for (j = i + 1; j < valor.Length; j++)
                        {
                            //evaluamos que el valor dle vector no se repita
                            if (valor[i] == valor[j])
                            {
                                res = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    res = true;
                }
            }
          // esta es la excepcion del try donde podemos usarla a favor y le damos valor
            catch (Exception)
            {
                res = true;
            }

            return res;
        }
    }
}
