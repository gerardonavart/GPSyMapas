using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GPSyMapas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GPS : ContentPage
	{
		public GPS ()
		{
			InitializeComponent ();
		}

        private async void Posicion(object sender,EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

            LongitudLabel1.Text = string.Format("{0:0.0000000}", position.Longitude);
            LatitudLabel1.Text = string.Format("{0:0.0000000}", position.Latitude);
        }
	}
}