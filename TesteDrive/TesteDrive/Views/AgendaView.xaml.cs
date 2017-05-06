using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgendaView : ContentPage
	{
        public Agendamento Agendamento { get; set; }
        public Veiculo Veiculo
        {
            get
            {
                return Agendamento.Veiculo;
            }
            set
            {
                Agendamento.Veiculo = value;
            }
        }
        public string Nome { get { return Agendamento.Nome; } set { Agendamento.Nome = value; } }
        public string Fone { get; set; }
        public string Email { get; set; }

        
        public DateTime DataAgendamento
        {
            get
            {
                return Agendamento.DataAgendamento;
            }
            set
            {
                Agendamento.DataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento {
            get
            {
                return Agendamento.HoraAgendamento;
            }
            set
            {
                Agendamento.HoraAgendamento = value;
            }
        }


        public AgendaView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Agendamento = new Agendamento();
            this.Agendamento.Veiculo = Veiculo;
            this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", "Nome:" + Nome, "Ok");
        }
    }
}
