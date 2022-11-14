using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida.Modelo
{
    class Plato : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }

        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }

        private string pais;

        public string Pais
        {
            get { return pais; }
            set { pais = value;
                NotifyPropertyChanged("Pais");
            }
        }

        private Boolean soja;

        public Boolean Soja
        {
            get { return soja; }
            set { soja = value;
                NotifyPropertyChanged("Soja");
            }
        }

        private Boolean gluten;

        public Boolean Gluten
        {
            get { return gluten; }
            set
            {
                gluten = value;
                NotifyPropertyChanged("Gluten");
            }
        }

        private Boolean sulfitos;

        public Boolean Sulfitos
        {
            get { return sulfitos; }
            set
            {
                sulfitos = value;
                NotifyPropertyChanged("Sulfitos");
            }
        }

        private Boolean leche;

        public Boolean Leche
        {
            get { return leche; }
            set
            {
                leche = value;
                NotifyPropertyChanged("Leche");
            }
        }
        public Plato(){ }

        public Plato(string nombre, string imagen, string pais, bool soja, bool gluten, bool sulfitos, bool leche)
        {
            Nombre = nombre;
            Imagen = imagen;
            Pais = pais;
            Soja = soja;
            Leche = leche;
            Gluten = gluten;
            Sulfitos = sulfitos;
        }
        public static ObservableCollection<Plato> GetSamples(String path)
        {
            ObservableCollection<Plato> ejemplos = new ObservableCollection<Plato>();
            // C:/Users/alumno/Downloads/imagenesComida
            // soja - gluten - sulfitos - leche
            Plato hamburguesa = new Plato("Hamburguesa", path + "/burguer.jpg","USA", false, true, true, true);
            Plato dumplings = new Plato("Dumplings", path + "/dumplings.jpg", "China", true, true, false, false);
            Plato tacos = new Plato("Tacos", path + "/tacos.jpg", "Mexico", false, true, true, false);
            Plato cerdo = new Plato("Cerdo agridulce", path + "/cerdoagridulce.jpg", "China", true, true, true, false);
            Plato hotdog = new Plato("HotDog", path + "/hotdog.jpg", "USA", true, true, true, true);
            Plato fajitas = new Plato("Fajitas", path + "/fajitas.jpg", "Mexico", false, true, true, false);

            ejemplos.Add(hamburguesa);
            ejemplos.Add(dumplings);
            ejemplos.Add(tacos);
            ejemplos.Add(cerdo);
            ejemplos.Add(hotdog);
            ejemplos.Add(fajitas);

            return ejemplos;
        }
    }
}
