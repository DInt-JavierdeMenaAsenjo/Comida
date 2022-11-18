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
        private Plato comidaSeleccionada;
        public Plato ComidaSeleccionada
        {
            get { return comidaSeleccionada; }
            set
            {
                comidaSeleccionada = value;
                NotifyPropertyChanged("ComidaSeleccionada");
            }
        }

        public void LimpiaSeleccion()
        {
            ComidaSeleccionada = null;
        }
        private ObservableCollection<Plato> lista;

        public ObservableCollection<Plato>  Lista
        {
            get { return lista; }
            set { lista = value;
                NotifyPropertyChanged("Lista");
            }
        }

        private ObservableCollection<String> tipos;

        public ObservableCollection<String> Tipos
        {
            get { return tipos; }
            set
            {
                tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }
        public MainWindowVM()
        {
            Tipos = new ObservableCollection<string>();
            string path = "C:/Users/alumno/Downloads/imagenesComida";
            Tipos.Add("USA");
            Tipos.Add("Mexico");
            Tipos.Add("China");
            Lista = Plato.GetSamples(path);
        }

        public void IniciaChecks()
        {

            ComidaSeleccionada.Leche = false;
            ComidaSeleccionada.Gluten = false;
            ComidaSeleccionada.Soja = false;
            ComidaSeleccionada.Sulfitos = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
