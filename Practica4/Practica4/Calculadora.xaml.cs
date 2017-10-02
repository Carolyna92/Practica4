using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora
        : ContentPage
    {
        double num1 = 0.0;
        double num2 = 0.0;
        string ope;

        public Calculadora()
        {
         
            InitializeComponent();
            }
         private void borrar_todo_Clicked(object sender, EventArgs e)
        {
            caja.Text = null;
            caja2.Text = null;
        }

        private void borrar_Clicked (object sender, EventArgs e)
        {
            if (caja.Text.Length > 0)
            {
                caja.Text = caja.Text.Substring(0, caja.Text.Length - 1);
                caja2.Text = caja2.Text.Substring(0, caja2.Text.Length - 1);
            }
        }

        private void division_Clicked(object sender, EventArgs e)
        {

            caja2.Text = caja2.Text + "÷";
            ope = "";
            num1 = Convert.ToDouble(caja.Text);
            ope = "division";
            caja.Text = "";

        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "7";
            caja2.Text = caja2.Text + "7";

        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "8";
            caja2.Text = caja2.Text + "8";
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "9";
            caja2.Text = caja2.Text + "9";
        }

        private void por_Clicked(object sender, EventArgs e)
        {

            caja2.Text = caja2.Text + "*";
            ope = "";
            num1 = Convert.ToDouble(caja.Text);
            ope = "multiplicacion";
            caja.Text = "";


        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "4";
            caja2.Text = caja2.Text + "4";
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "5";
            caja2.Text = caja2.Text + "5";
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "6";
            caja2.Text = caja2.Text + "6";
        }

        private void resta_Clicked(object sender, EventArgs e)
        {

            caja2.Text = caja2.Text + "-";
            ope = "";
            num1 = Convert.ToDouble(caja.Text);
            ope = "resta";
            caja.Text = "";


        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "1";
            caja2.Text = caja2.Text + "1";
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "2";
            caja2.Text = caja2.Text + "2";
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "3";
            caja2.Text = caja2.Text + "3";
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            caja2.Text = caja2.Text + "+";
            ope = "";
            num1 = Convert.ToDouble(caja.Text);
            ope = "suma";
            caja.Text = "";


        }
        private void cero_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "0";
            caja2.Text = caja2.Text + "0";
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            if (!caja.Text.Contains("."))
            {
                caja.Text = caja.Text + ".";
                caja2.Text = caja2.Text + ".";
            }
        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(caja.Text);
            switch (ope)
            {
                case "suma":
                    caja.Text = Convert.ToString(num1 + num2);
                    caja2.Text = caja2.Text + "=" + Convert.ToString(num1 + num2);
                    num1 = 0;
                    num2 = 0;
                    break;
                case "resta":
                    caja.Text = Convert.ToString(num1 - num2);
                    caja2.Text = caja2.Text + "=" + Convert.ToString(num1 - num2);
                    num1 = 0;
                    num2 = 0;
                    break;
                case "division":
                    if (num1 == 0 && num2 == 0)
                    {
                        caja.Text = "No se puede dividir entre cero";
                    }
                    else
                    {
                        caja.Text = Convert.ToString(num1 / num2);
                        caja2.Text = caja2.Text + "=" + Convert.ToString(num1 / num2);
                        num2 = 0;
                        num1 = 0;

                    }

                    break;
                case "multiplicacion":
                    caja.Text = Convert.ToString(num1 * num2);
                    caja2.Text = caja2.Text + "=" + Convert.ToString(num1 * num2);
                    num1 = 0;
                    num2 = 0;
                    break;


            }

        }

        private void absoluto_Clicked(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(caja.Text) < 0)
            {
                caja.Text = Convert.ToString(Math.Abs(Convert.ToDecimal(caja.Text)));
                caja2.Text = caja2.Text + "=" + Convert.ToString(Math.Abs(Convert.ToDecimal(caja.Text)));
            }
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
    
