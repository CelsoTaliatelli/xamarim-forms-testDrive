using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Models;
using TesteDrive.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgendaView : ContentPage
	{
        public AgendamentoViewModel viewModel { get; set; }

        public AgendaView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.viewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.viewModel;
		}

        /*private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", "Nome:" + viewModel.Agendamento.Nome, "Ok");
        }*/

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento",
                async (msg) =>
                {
                    var confirma = await DisplayAlert("Salvar Agendamento",
                        "Deseja mesmo enviar o agendamento?",
                        "Sim", "Não");

                    if (confirma)
                    {
                        DisplayAlert("Agendamento",
                        "Nome:" + viewModel.Agendamento.Nome,
                        "Ok");
                    }

                
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
        }
    }
}
