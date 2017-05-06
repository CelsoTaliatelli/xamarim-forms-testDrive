using System;
using System.Collections.Generic;
using System.Text;
using TesteDrive.Models;

namespace TesteDrive.ViewModels
{
   
    public class AgendamentoViewModel
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
        public TimeSpan HoraAgendamento
        {
            get
            {
                return Agendamento.HoraAgendamento;
            }
            set
            {
                Agendamento.HoraAgendamento = value;
            }
        }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.Agendamento = new Agendamento();
            this.Agendamento.Veiculo = Veiculo;
        }
    }
}
