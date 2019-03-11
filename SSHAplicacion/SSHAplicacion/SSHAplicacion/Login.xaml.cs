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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            clickedd();
        }

        private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
          
        }
        async void clickedd()
        {
            lbClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    await Navigation.PushAsync(new Registro());
                }
                )

            });


        }
    }
}