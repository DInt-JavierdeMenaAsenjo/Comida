using Comida.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida.VistasModelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> lista;

        public ObservableCollection<Plato>  Lista
        {
            get { return lista; }
            set { lista = value;
                NotifyPropertyChanged("Lista");
            }
        }
        public MainWindowVM()
        {
            string path = "C:/Users/alumno/Downloads/imagenesComida";
            Lista = Plato.GetSamples(path);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
