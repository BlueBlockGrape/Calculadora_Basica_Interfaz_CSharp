using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Operaciones
    {

        public bool error = false;

        public float operación(char operador, float num1, float num2)
        {
            float respuesta = 0;

            switch (operador)
            {
                case '+':
                    respuesta = num1 + num2;
                    break;
                case '-':
                    respuesta = num1 - num2;
                    break;
                case '*':
                    respuesta = num1 * num2;
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        respuesta = 0;
                        error = true;
                    }
                    else
                    {
                        respuesta = num1 / num2;
                    }
                    break;
            }

            return respuesta;
        }

    }
}
