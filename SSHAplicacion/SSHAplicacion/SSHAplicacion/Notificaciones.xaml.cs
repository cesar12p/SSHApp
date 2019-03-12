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
	public partial class Notificaciones : ContentPage
	{
		public Notificaciones ()
		{
			InitializeComponent ();
		}

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            try
            {
                UserManager manager = new UserManager();
                var res = await manager.getUsuarios();
                
                if (res != null)
                {
      
                    lstUsuarios.ItemsSource = res;
                    
                    
                    
                }
            }
            catch (Exception e1)
            {

            }
        }
    }
}