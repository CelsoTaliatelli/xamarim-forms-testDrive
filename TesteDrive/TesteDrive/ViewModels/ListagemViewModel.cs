using System;
using System.Collections.Generic;
using System.Text;
using TesteDrive.Models;
using Xamarin.Forms;

namespace TesteDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if(value != null)
                MessagingCenter.Send(veiculoSelecionado, "Selecionado");
            }
        }
        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
