using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2DS2FD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Navegación entre ventanas
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
