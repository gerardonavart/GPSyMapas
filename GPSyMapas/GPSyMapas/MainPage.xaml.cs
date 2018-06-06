using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GPSyMapas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnGPS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GPS());
        }

        private void btnMapas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mapas());
        }
    }
}
