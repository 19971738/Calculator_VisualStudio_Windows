using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//String muestra = "0.";

namespace Pract2_Calc_Test
{
    public partial class Form1 : Form
    {
        //String muestraDePantalla = "0.";
        String binario = "";
        String valor1 = "";
        String valor2 = "";
        String operador = "";
        bool operacion = false, operacionDouble=false;
        bool puntito = false;
        int resultadoINT,X,c,k,memoria1,memoria2;
        double resultadoDOUBLE;
        double memoria, Radianes;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pantalla.Text != "0.")
            {
                if (!operacion)
                {
                    valor1 = valor1 + "0";
                    pantalla.Text = valor1 + ".";
                }
                else
                {
                    valor2 = valor2 + "0";
                    pantalla.Text = valor2 + ".";
                    operacion = false;
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "2";
                pantalla.Text = valor1 + ".";
            }
            else
            {
                valor2 = valor2 + "2";
                pantalla.Text = valor2 + ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            resultadoDOUBLE = Convert.ToDouble(valor1);
            memoria = resultadoDOUBLE;
            resultadoDOUBLE = Math.Log(memoria);
            pantalla.Text = resultadoDOUBLE.ToString() + ".";
            valor1 = resultadoDOUBLE.ToString();
            valor2 = "";
            operacion = false;
            puntito = false;
            operacionDouble = false;
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {

        }

        private void Numero1_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "1";
              
            }
            else
            {
                valor2 = valor2 + "1";

            }
            imprimesigno(puntito);
        }

        private void Numero3_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "3";
                
            }
            else
            {
                valor2 = valor2 + "3";
               

            }
            imprimesigno(puntito);
        }

        private void Numero4_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "4";
               
            }
            else
            {
                valor2 = valor2 + "4";
                
            }
            imprimesigno(puntito);
        }

        private void Numero5_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "5";
               
            }
            else
            {
                valor2 = valor2 + "5";
            

            }
            imprimesigno(puntito);
        }

        private void Numero6_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "6";
                
            }
            else
            {
                valor2 = valor2 + "6";
                

            }
            imprimesigno(puntito);
        }

        private void Numero7_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "7";
               
            }
            else
            {
                valor2 = valor2 + "7";
                

            }

            imprimesigno(puntito);
        }

        private void Numero8_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "8";
               
            }
            else
            {
                valor2 = valor2 + "8";
                

            }
            imprimesigno(puntito);
        }

        private void Numero9_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = valor1 + "9";
                
            }
            else
            {
                valor2 = valor2 + "9";

            }
            imprimesigno(puntito);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            pantalla.BackColor = Color.Orange;
            valor1 = "";
            pantalla.Text = "0.";
            puntito = false;
            X = 0;
            
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            operacionDouble = true;
            X++;
            if (!puntito)
            {
                valor1 = valor1 + ".";
                pantalla.Text = valor1;
                // pantalla.Text = valor2;
                 puntito = true;
            }
            if (X == 2 && puntito)
            {
                valor2 = valor2 + ".";
                pantalla.Text = valor2;
                // pantalla.Text = valor2;
                puntito = true;

            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            int longitudCadena = valor1.Length;
            if (longitudCadena > 0)
            {
                valor1 = valor1.Substring(0, longitudCadena - 1);
                if (valor1 == "")
                {
                    pantalla.Text = "0.";
                }
                else {
                    pantalla.Text = valor1+".";
         
                }
               

                
            }
            else
            {
                pantalla.Text = "0.";
            }
        }

        private void OperadorSuma_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "+";

        }

        private void OperadorResta_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "-";
        }

        private void OperadorMulti_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "*";
        }

        private void OperadorDivision_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "/";
        }

        private void SignoIgual_Click(object sender, EventArgs e)
        {
            pantalla.BackColor = Color.Blue;
            if (operacion && !operacionDouble) {
                X = 0;
                switch (operador) {
                    case "+":
                    resultadoINT=Int32.Parse(valor1) + Int32.Parse(valor2);
                        break;
                    case "-":
                        resultadoINT = Int32.Parse(valor1) - Int32.Parse(valor2);
                        break;
                    case "*":
                        resultadoINT = Int32.Parse(valor1) * Int32.Parse(valor2);
                        break;
                    case "/":
                        resultadoINT = Int32.Parse(valor1) / Int32.Parse(valor2);
                        break;
                    default:
                        break;

               }
               // pantalla.Text = num.ToString() + ".";  //Prueba
               // valor1 = num.ToString();
                pantalla.Text = resultadoINT.ToString()+"."; //Permite cambiar int a String
                valor1 = resultadoINT.ToString(); //Es una funcion por eso ponemos parentesis  
                valor2 = "";  //lo borramos
                operador = "";  //Lo borramos 
                operacion = false;
                puntito = false;
                /*
                pantalla.Text = resultado.ToString()+".";
                valor1 = resultado.ToString();
                valor2 = "";
                operador = "";        ORIGUINAL
                operacion = false;
                puntito = false;
                */
            }
            if (operacion && operacionDouble)
            {
                switch (operador)
                {
                    case "+":
                        resultadoDOUBLE = Double.Parse(valor1) + Double.Parse(valor2);
                        break;
                    case "-":
                        resultadoDOUBLE = Double.Parse(valor1) - Double.Parse(valor2);
                        break;
                    case "*":
                        resultadoDOUBLE = Double.Parse(valor1) * Double.Parse(valor2);
                        break;
                    case "/":
                        resultadoDOUBLE = Double.Parse(valor1) / Double.Parse(valor2);
                        break;
                    case "Sin":
                        resultadoDOUBLE  = Convert.ToDouble(valor1);
                        Radianes = (Math.PI * resultadoDOUBLE) / 180;
                        memoria = Radianes;
                        resultadoDOUBLE = Math.Sin(memoria);
                        X = 0;
                        break;
                    case "Cos":
                        resultadoDOUBLE = Convert.ToDouble(valor1);
                        
                        memoria = resultadoDOUBLE;
                        resultadoDOUBLE = Math.Cos(memoria);
                        X = 0;
                        break;
                    case "Exp y":
                        resultadoDOUBLE = Math.Pow(Double.Parse(valor1), Double.Parse(valor2));
                        break;
                        

                    case "Tan":
                        resultadoDOUBLE = Convert.ToDouble(valor1);
                        Radianes = (Math.PI * resultadoDOUBLE) / 180;
                        memoria = Radianes;
                        resultadoDOUBLE = Math.Tan(memoria);
                        X = 0;
                        break;
                    case "Ln":
                        resultadoDOUBLE = Convert.ToDouble(valor1);
                        memoria = resultadoDOUBLE;
                        resultadoDOUBLE = Math.Log(memoria);
                        X = 0;
                        break;

                    default:
                        break;

                }
                pantalla.Text = resultadoDOUBLE.ToString() + ".";  //Prueba
                valor1 = resultadoDOUBLE.ToString();
                //pantalla.Text = resultado.ToString()+"."; //Permite cambiar int a String
                //valor1 = resultado.ToString(); //Es una funcion por eso ponemos parentesis  
                valor2 = "";  //lo borramos
                operador = "";  //Lo borramos 
                operacion = false;
                puntito = false;
                operacionDouble = false;
                /*
                pantalla.Text = resultado.ToString()+".";
                valor1 = resultado.ToString();
                valor2 = "";
                operador = "";        ORIGUINAL
                operacion = false;
                puntito = false;
                */
            }
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void CambioSigno_Click(object sender, EventArgs e)
        {
            if (!operacion)
            {
                valor1 = (Int32.Parse(valor1) * -1).ToString();
                pantalla.Text = valor1;

            }
            else
            {
                valor2 = (Int32.Parse(valor2) * -1).ToString();
                pantalla.Text=valor2;
            }
        }

        private void FuncionCos_Click(object sender, EventArgs e)
        {
            resultadoDOUBLE = Convert.ToDouble(valor1);
            memoria = resultadoDOUBLE;
            resultadoDOUBLE = Math.Cos(memoria);
            pantalla.Text = resultadoDOUBLE.ToString() + ".";
            valor1 = resultadoDOUBLE.ToString();
            valor2 = "";
            operacion = false;
            puntito = false;
            operacionDouble = false;

            





        }

        private void NotacionCientifica_Click(object sender, EventArgs e)
        {

        }

        private void ExponentialButton_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "Exp y";
            operacionDouble = true;




        }

        private void Binary_Click(object sender, EventArgs e)
        {

            binario = "";
            resultadoINT = Convert.ToInt32(valor1);
            memoria = resultadoINT;
            
            for (int i = 8; i >= 0; i--)
            {
                int k = resultadoINT >> i;
                if ((k & 1) > 0)
                    binario = binario + "1";

                else
                    binario = binario + "0";


            }

            pantalla.Text = binario + ".";
            valor1 = binario;
            valor2 = "";
            operacion = false;
            puntito = false;
            operacionDouble = false;
        }

        private void FuncionTan_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "Tan";
            operacionDouble = true;
        }

        private void imprimesigno(bool p)
        {
            if (p && !operacion)
            {
                pantalla.Text = valor1;
                
                
            }
            if(p && operacion)
            {
                pantalla.Text = valor2;
               

            }
            if(!p && !operacion)
            {
                pantalla.Text = valor1 + ".";
               
            }
            if(!p && operacion)
            {
                pantalla.Text = valor2 + ".";
               

            }
            
        }

        private void FuncionSeno_Click(object sender, EventArgs e)
        {
            operacion = true;
            operador = "Sin";
            operacionDouble = true;
        }
    }
}
