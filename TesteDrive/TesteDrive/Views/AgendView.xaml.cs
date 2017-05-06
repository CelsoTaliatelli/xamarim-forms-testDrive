using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgendView : ContentPage
	{
		public AgendView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Title = veiculo.Nome;
		}
	}
}
