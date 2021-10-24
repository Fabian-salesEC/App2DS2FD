using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2DS2FD
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
            double valor1 = Convert.ToDouble(txtNotaUno.Text);
            double valor2 = Convert.ToDouble(txtExaUno.Text);
            double total1 = (valor1 * 0.3) + (valor2 * 0.2);
            txtParUno.Text = Convert.ToString(total1);
            double valor3 = Convert.ToDouble(txtNotaDos.Text);
            double valor4 = Convert.ToDouble(txtExaDos.Text);
            double total2 = (valor3 * 0.3) + (valor4 * 0.2);
            txtParDos.Text = Convert.ToString(total2);
            double notaFin= Convert.ToDouble(txtParUno.Text) + Convert.ToDouble(txtParDos.Text);
            txtNotaFin.Text = Convert.ToString(notaFin);
                if(notaFin>=7)
                {
                    txtEstado.Text = "Aprobado";
                }
                else if (notaFin >= 5 && notaFin <= 6.99)
                {
                    txtEstado.Text = "Complementario";
                }
                else if (notaFin < 5)
                {
                    txtEstado.Text = "Reprobado";
                }
            }
            catch(Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }
        }
    }
}
