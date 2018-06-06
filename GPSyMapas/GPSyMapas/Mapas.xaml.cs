using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GPSyMapas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mapas : ContentPage
	{
		public Mapas ()
		{
			InitializeComponent ();
            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(20.3195875, -99.7074997), Distance.FromMiles(0.5)));

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(20.3195875, -99.7074997),
                Label = "Esta es tu ubicación",
                Address = "Aquí estas tú"
            };

            Mapa.Pins.Add(pin);

		}
	}
}