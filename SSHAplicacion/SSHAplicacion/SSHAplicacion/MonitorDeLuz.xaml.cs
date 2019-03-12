using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSHAplicacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MonitorDeLuz : ContentPage
	{
		public MonitorDeLuz ()
		{
			InitializeComponent ();
            
		}

        private void SF1_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            if (e.Value.ToString() == "True"){
                F1.Source = "focoON.png";
                lb1.Text = "Foco 1: Encendido";
                
            }
            else
            {
                F1.Source = "focoOFF.png";
                lb1.Text = "Foco 1: Apagado";
            }
        }

        private void SF2_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            if (e.Value.ToString() == "True")
            {
                F2.Source = "focoON.png";
                lb2.Text = "Foco 1: Encendido";

            }
            else
            {
                F2.Source = "focoOFF.png";
                lb2.Text = "Foco 1: Apagado";
            }
        }
    }
}