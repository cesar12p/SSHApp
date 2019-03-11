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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notificaciones());
        }

        async private void Monitoreo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Monitoreo());
        }

        async private void Agregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Agregar());
        }

        async private void Configuraciones_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Config());
        }
    }
}