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
            String userValidation = "dach";
            String passValidation = "1996";
           
            await Navigation.PushAsync(new Ventana2(txtUser.Text,textPass.Text ));
        }
        
    }
}
