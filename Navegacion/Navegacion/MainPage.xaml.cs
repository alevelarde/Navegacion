using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void siguente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Practica_2());
        }
    }
}
