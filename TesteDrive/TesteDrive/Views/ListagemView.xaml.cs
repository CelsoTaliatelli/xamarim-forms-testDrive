using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Models;
using Xamarin.Forms;

namespace TesteDrive.Views
{
    
	public partial class ListagemView : ContentPage
	{
        
		public ListagemView()
		{
			InitializeComponent();
            

		}

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView(veiculo));

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "Selecionado", 
                (msg) => 
                {
                    Navigation.PushAsync(new DetalheView(msg));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "Selecionado");
              
        }
    }

}
