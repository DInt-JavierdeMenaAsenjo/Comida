using System;
using System.Collections.Generic;
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
            set { imagen = value; }
        }

        private string[] alergenos;

        public string[] Alergenos
        {
            get { return alergenos; }
            set { alergenos = value; }
        }

        private string pais;

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public Plato(){ }

        public Plato(string nombre, string imagen, string[] alergenos, string pais)
        {
            Nombre = nombre;
            Imagen = imagen;
            Alergenos = alergenos;
            Pais = pais;
        }
        public static List<Plato> GetSamples()
        {
            List<Plato> ejemplos = new List<Plato>();

            string[] alergenosBurger = new string[] { 
                "Soja",
                "Leche",
                "Gluten"
            };
            /*string[] alergenosDumplings = new string[] {
                "Soja",
                "Leche",
                "Gluten"
            };

            Plato hamburguesa = new Plato("Hamburguesa","Assets/burger.png",alergenosBurger);
            Plato dumplings = new Plato("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Plato tacos = new Plato("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);*/

            return ejemplos;
        }
    }
}
