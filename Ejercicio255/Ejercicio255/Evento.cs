using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio255
{
    class Evento
    {
        String nombre_columna;
        double tiempo;

        public Evento(string nombre_columna, double tiempo)
        {
            this.nombre_columna = nombre_columna;
            this.tiempo = tiempo;
        }

        public string Nombre_columna { get => nombre_columna; set => nombre_columna = value; }
        public double Tiempo { get => tiempo; set => tiempo = value; }
    }
}
