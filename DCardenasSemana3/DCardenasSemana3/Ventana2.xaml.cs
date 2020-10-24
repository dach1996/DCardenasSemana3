using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DCardenasSemana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana2 : ContentPage
    {
        public Ventana2(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = user;
            lblPassword.Text = pass;
        }
    }
}