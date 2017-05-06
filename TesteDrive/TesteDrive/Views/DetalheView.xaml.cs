﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Models;
using TesteDrive.ViewModels;
using TesteDrive.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalheView : ContentPage
	{

        public Veiculo Veiculo { get; set; }
        public DetalheView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Veiculo = veiculo;
            this.BindingContext = new DetalheViewModel(veiculo);
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendaView(Veiculo));
        }
    }
}