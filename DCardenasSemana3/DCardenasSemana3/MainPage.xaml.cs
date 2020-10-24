using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DCardenasSemana3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrirVentanaDos_Clicked(object sender, EventArgs e)
        {
            
           if(txtUser.Text == "admin" && textPass.Text == "12345")
            {
                await Navigation.PushAsync(new Ventana2(txtUser.Text, textPass.Text));
            }
            else
            {
                DisplayAlert("Error", "Acceso no Autorizado", "ok");
            }
            
        }
        
    }
}
