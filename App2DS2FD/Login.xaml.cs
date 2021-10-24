using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2DS2FD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try {
                
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                if (usuario== "estudiante2021" && clave== "uisrael2021")
                {
                    await Navigation.PushAsync(new MainPage(usuario));
                }
                else
                {
                    await DisplayAlert("Error", "Usuario/Contraseña incorrectos", "OK");
                }
                
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia",ex.Message,"OK");
            }
        }
    }
}