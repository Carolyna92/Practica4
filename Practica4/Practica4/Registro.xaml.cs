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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
            private void MostrarOnClicked(object sender, EventArgs e)
            {

                DisplayAlert("Datos_Personales", "Nombre:" + N.Text + "\nApellidos:" + AP.Text + "\nDireccion:" + D.Text + "\nTelefono:" + T.Text + "\nDatos_Escolares\nCarrera:" + C.Text + "\nSemestre:" + S.Text + "\nMatricula:" + M.Text + "\nDatos_Sociales\nCorreo:" + CE.Text + "\nGitHub:" + GH.Text, "Aceptar");
                //DisplayAlert("Datos_Escolares", "Carrera:" + C.Text + " Semestre:" + S.Text + "Matricula:" + M.Text, "Aceptar");
                //DisplayAlert("Datos_Sociales", "Correo:" + CE.Text + " GitHub:" + GH.Text, "Aceptar");

            }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculadora());
                 
        }
    }
    }
