using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio255
{
    class Pedido
    {
        private int id;
        private string estado;

        public Pedido(int id, string estado)
        {
            this.id = id;
            this.estado = estado;
        }

        public string Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }

        override
        public string ToString()
        {
            return estado;
        }
    }
}
