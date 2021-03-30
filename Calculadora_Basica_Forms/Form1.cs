using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica_Forms
{
    public partial class Form1 : Form
    {

        int maxCaracteres = 10;
        int maxDecimales = 6;
        int maxTotal;
        bool bPunto = false;
        bool operar = false;
        char operacion;
        float num1, num2;
        String numero = "";
        Operaciones operando = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                //No poner más ceros
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "0";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "0";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text="1";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text=numero + "1";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text=numero + "1";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "2";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "2";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "2";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "3";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "3";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "3";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "4";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "4";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "4";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "5";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "5";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "5";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "6";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "6";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "6";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "7";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "7";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "7";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "8";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "8";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "8";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero == "0")
            {
                txtNumero.Text = "9";
            }
            else if (numero.Length < maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + "9";
            }
            else if (bPunto && numero.Length < maxTotal)
            {
                txtNumero.Text = numero + "9";
            }
            else
            {
                //Podemos poner un mensaje "Exedio maximo de caracteres de ser necesario"
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length > 0)
            {
                if (!operar)
                {
                    num1 = float.Parse(numero);
                    txtNumero.Text="";
                    txtResultado.Text=numero;
                    operar = true;
                    bPunto = false;
                    operacion = '+';
                }
                else
                {
                    num1 = float.Parse(txtResultado.Text);
                    num2 = float.Parse(numero);
                    txtNumero.Text="";
                    txtResultado.Text = operando.operación(operacion, num1, num2) + "";
                    bPunto = false;
                    operacion = '+';
                }
            }
            if (operando.error)
            {
                txtNumero.Text = "";
                txtResultado.Text = "";
                maxCaracteres = 10;
                maxDecimales = 6;
                bPunto = false;
                operar = false;
                numero = "";
                operando.error = false;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length > 0)
            {
                if (!operar)
                {
                    num1 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = numero;
                    operar = true;
                    bPunto = false;
                    operacion = '-';
                }
                else
                {
                    num1 = float.Parse(txtResultado.Text);
                    num2 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = operando.operación(operacion, num1, num2) + "";
                    bPunto = false;
                    operacion = '-';
                }
            }
            if (operando.error)
            {
                txtNumero.Text = "";
                txtResultado.Text = "";
                maxCaracteres = 10;
                maxDecimales = 6;
                bPunto = false;
                operar = false;
                numero = "";
                operando.error = false;
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length > 0)
            {
                if (!operar)
                {
                    num1 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = numero;
                    operar = true;
                    bPunto = false;
                    operacion = '*';
                }
                else
                {
                    num1 = float.Parse(txtResultado.Text);
                    num2 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = operando.operación(operacion, num1, num2) + "";
                    bPunto = false;
                    operacion = '*';
                }
            }
            if (operando.error)
            {
                txtNumero.Text = "";
                txtResultado.Text = "";
                maxCaracteres = 10;
                maxDecimales = 6;
                bPunto = false;
                operar = false;
                numero = "";
                operando.error = false;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length > 0)
            {
                if (!operar)
                {
                    num1 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = numero;
                    operar = true;
                    bPunto = false;
                    operacion = '/';
                }
                else
                {
                    num1 = float.Parse(txtResultado.Text);
                    num2 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = operando.operación(operacion, num1, num2) + "";
                    bPunto = false;
                    operacion = '/';
                }
            }
            if (operando.error)
            {
                txtNumero.Text = "";
                txtResultado.Text = "";
                maxCaracteres = 10;
                maxDecimales = 6;
                bPunto = false;
                operar = false;
                numero = "";
                operando.error = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length > 0)
            {
                if (!operar)
                {

                }
                else
                {
                    num1 = float.Parse(txtResultado.Text);
                    num2 = float.Parse(numero);
                    txtNumero.Text = "";
                    txtResultado.Text = operando.operación(operacion, num1, num2) + "";
                    bPunto = false;
                    operar = false;
                }
                if (operando.error)
                {
                    txtNumero.Text = "";
                    txtResultado.Text = "";
                    maxCaracteres = 10;
                    maxDecimales = 6;
                    bPunto = false;
                    operar = false;
                    numero = "";
                    operando.error = false;
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtResultado.Text = "";
            maxCaracteres = 10;
            maxDecimales = 6;
            bPunto = false;
            operar = false;
            numero = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length == 0)
            {

            }
            else if (numero.Substring(numero.Length - 1, 1).Equals("."))
            {
                txtNumero.Text = (numero.Substring(0, numero.Length- 1));
                bPunto = false;
            }
            else
            {
                txtNumero.Text = (numero.Substring(0, numero.Length - 1));
            }
        }

        private void btnPuno_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;
            if (numero.Length == 0)
            {
                txtNumero.Text = "0.";
                numero = txtNumero.Text;
                maxTotal = numero.Length + maxDecimales;
                bPunto = true;
            }
            else if (numero.Length <= maxCaracteres && !bPunto)
            {
                txtNumero.Text = numero + ".";
                numero = txtNumero.Text;
                maxTotal = numero.Length + maxDecimales;
                bPunto = true;
            }
            else
            {

            }
        }
    }
}
