using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Practica_2 : ContentPage
    {
        public Practica_2()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Datos ingresados", "Hola Tus datos personales son:\n Nombre:" + nombre.Text + "\n Apellidos: " + ape_pat.Text + " " + ape_mat.Text + "\n Direccion:  " + direccion.Text + "\n Telefono: " + telefono.Text + "\n TUS DATOS ESCOLARES SON:\n Carrera: " + carrera.Text + "\n Semestre: " + semestre.Text + "\n Matricula: " + matricula.Text + "\n TUS DATOS DE CONTACTO SON: \n Correo: " + correo.Text + "\n GitHub: " + github.Text + "ok", "cancel");
        }

        private void regresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void siguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculadora());
        }
    }
}