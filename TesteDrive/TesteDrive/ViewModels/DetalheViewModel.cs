using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TesteDrive.Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace TesteDrive.ViewModels
{
    public class DetalheViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }
        public bool TemFreiosABS
        {
            get
            {
                return Veiculo.TemFreiosABS;
            }
            set
            {
                Veiculo.TemFreiosABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));

                //if (temFreiosABS)
                //DisplayAlert("Freio ABS", "Ligado", "Ok");
                //else
                //DisplayAlert("Freio ABS", "Desligado", "Ok");
            }
        }

        public bool TemAR
        {
            get
            {
                return Veiculo.TemArCondicionado;
            }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));

                //if (temFreiosABS)
                //DisplayAlert("Freio ABS", "Ligado", "Ok");
                //else
                //DisplayAlert("Freio ABS", "Desligado", "Ok");
            }
        }

        public bool TemPlayer
        {
            get
            {
                return Veiculo.TemPlayer;
            }
            set
            {
                Veiculo.TemPlayer = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));

                //if (temFreiosABS)
                //DisplayAlert("Freio ABS", "Ligado", "Ok");
                //else
                //DisplayAlert("Freio ABS", "Desligado", "Ok");
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;

            }
        }
        public string TextoABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", Veiculo.FREIO_ABS);
            }
        }

        public string TextoAR
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", Veiculo.AR_CONDICIONADO);
            }
        }

        public string TextoPlayer
        {
            get
            {
                return string.Format("MP3 Player - R$ {0}", Veiculo.MP3_PLAYER);
            }
        }

        public string Total
        {
            get
            {
                return string.Format("Total - R${0}");
            }
        }

        public DetalheViewModel(Veiculo veiculo)
        {

            this.Veiculo = veiculo;
            ProximoCommand = new Command(() =>
            {
                MessagingCenter.Send(veiculo, "Proximo");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ProximoCommand { get; set; }
    }
}
