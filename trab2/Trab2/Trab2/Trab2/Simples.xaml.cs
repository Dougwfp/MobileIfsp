using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trab2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Simples : ContentPage
	{
		public Simples ()
		{
			InitializeComponent ();

            List<String> itens = new List<String>()
            {
                "Xamarin", "BigData", "Analytics", "ListView", "Simples"
            };
            lv1.ItemsSource = itens;
        }
	}
}