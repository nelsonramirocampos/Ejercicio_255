using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio255
{
    public partial class Simulacion : Form
    {
        List<Pedido> pedidos;
        public Simulacion()
        {
            InitializeComponent();
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            setup();

            armar_grilla();
        }

        private void setup()
        {
            txt_distribucion_tiempo_produccion_A.Text = "60";
            txt_distribucion_tiempo_produccion_B.Text = "100";

            txt_distribucion_llegada_pedido_A.Text = "180";
            txt_distribucion_llegada_pedido_B.Text = "240";

            txt_tiempo_fin_empaque.Text = "90\" + (Cantidad_Pedida * 50\")";


            //dgv_cantidad_pedida.Rows.Add("4", "0,5");
            //dgv_cantidad_pedida.Rows.Add("7", "0,5");
            dgv_cantidad_pedida.Rows.Add("4", "0,5", "0,5", "0", "0,4999");
            dgv_cantidad_pedida.Rows.Add("7", "0,5", "1", "0,5", "0,9999");
            generarProbabilidadCantidadPedida();
        }

        private void generarProbabilidadCantidadPedida()
        {
            
        }

        private void armar_grilla()
        {
            dgv_grilla.Columns.Add(NombreColumna.EVENTO, "Evento");
            dgv_grilla.Columns.Add(NombreColumna.RELOJ, "Reloj");

            //
            dgv_grilla.Columns.Add(NombreColumna.RND_LLEGADA_PEDIDO, "RND");
            dgv_grilla.Columns.Add(NombreColumna.TIEMPO_ENTRE_LLEGADA, "Tiempo entre llegada");
            dgv_grilla.Columns.Add(NombreColumna.LLEGADA, "Llegada");

            //
            dgv_grilla.Columns.Add(NombreColumna.RND_CANTIDAD_PEDIDA, "RND");
            dgv_grilla.Columns.Add(NombreColumna.CANTIDAD_PEDIDA, "Cantidad Pedida");

            //
            dgv_grilla.Columns.Add(NombreColumna.TIEMPO_ENTRE_EMPAQUE, "Tiempo entre Empaque");
            dgv_grilla.Columns.Add(NombreColumna.EMPAQUE, "Fin Empaque");

            //
            dgv_grilla.Columns.Add(NombreColumna.RND_TIEMPO_PRODUCCION_PEDIDO, "RND");
            dgv_grilla.Columns.Add(NombreColumna.TIEMPO_ENTRE_PRODUCCION, "Tiempo entre Produccion");
            dgv_grilla.Columns.Add(NombreColumna.PRODUCCION, "Fin Produccion");


            //
            dgv_grilla.Columns.Add(NombreColumna.ESTADO_MAQUINA_PRODUCCION, "Estado Maq. Produc.");
            dgv_grilla.Columns.Add(NombreColumna.ESTADO_MAQUINA_EMPAQUE, "Estado Maq. Empaq.");


            //
            dgv_grilla.Columns.Add(NombreColumna.STOCK, "Stock");
            dgv_grilla.Columns.Add(NombreColumna.PEDIDOS_PENDIENTES, "Pedidos Pendientes");
        }

        private void Btn_simular_Click(object sender, EventArgs e)
        {
            dgv_grilla.Rows.Clear();
            this.pedidos = new List<Pedido>();

            double tiempo_simular = 2;

            evento_inicio();

            for (double i = 0; i <= tiempo_simular; i++)
            {
                string evento_columna = proximo_evento();
                
                switch (evento_columna)
                {
                    case NombreColumna.PRODUCCION:
                        evento_fin_produccion();
                    break;

                    case NombreColumna.LLEGADA:
                        evento_llegada_pedido();
                    break;

                }

                actualizar_pedidos();
            }
        }

        private void actualizar_pedidos()
        {
            int fila_ultima = dgv_grilla.Rows.Count - 1;
            string column_name = "cPedido";
            foreach (Pedido pedido in this.pedidos)
            {
                if (dgv_grilla.Columns.Contains(column_name + pedido.Id) == true)
                {
                    dgv_grilla[column_name + pedido.Id, fila_ultima].Value = pedido.Estado;
                }
                else
                {
                    dgv_grilla.Columns.Add(column_name + pedido.Id, "Pedido " + pedido.Id);
                    dgv_grilla[column_name + pedido.Id, fila_ultima].Value = pedido.Estado;
                }
            }
        }

        private void evento_llegada_pedido()
        {
            int fila_nueva = CloneWithValues();

            //1- Actualizar nombre evento y reloj
            dgv_grilla[NombreColumna.EVENTO, fila_nueva].Value = NombreEvento.LLEGADA_PEDIDO;
            dgv_grilla[NombreColumna.RELOJ, fila_nueva].Value = dgv_grilla[NombreColumna.LLEGADA, fila_nueva].Value.ToString();

            //2- Generar cantidad pedida
            double rnd_cantidad_pedida = Utilidades.rnd();
            int cantidad = calcular_cantidad(rnd_cantidad_pedida);
            dgv_grilla[NombreColumna.RND_CANTIDAD_PEDIDA, fila_nueva].Value = rnd_cantidad_pedida;
            dgv_grilla[NombreColumna.CANTIDAD_PEDIDA, fila_nueva].Value = cantidad;

            //3- Validar si tengo suficiente stock
            int stock = int.Parse(dgv_grilla[NombreColumna.STOCK, fila_nueva].Value.ToString());
            if (cantidad <= stock)
            {
                //4- Validar que la maquina de empaque este libre
                if (dgv_grilla[NombreColumna.ESTADO_MAQUINA_EMPAQUE, fila_nueva].Value.ToString() == EstadoMaquinas.L)
                {
                    //5- Actualizar estado de maquina empaque
                    dgv_grilla[NombreColumna.ESTADO_MAQUINA_EMPAQUE, fila_nueva].Value = EstadoMaquinas.Oc;

                    //5.1 Generar tiempo fin de empaque
                    double tiempo_entre_empaque = calcular_fin_empaque(cantidad);
                    dgv_grilla[NombreColumna.TIEMPO_ENTRE_EMPAQUE, fila_nueva].Value = tiempo_entre_empaque;
                    dgv_grilla[NombreColumna.EMPAQUE, fila_nueva].Value = double.Parse(dgv_grilla[NombreColumna.RELOJ, fila_nueva].Value.ToString()) + tiempo_entre_empaque;

                    //5.2 Actualizacion stock
                    dgv_grilla[NombreColumna.STOCK, fila_nueva].Value = stock - cantidad;


                    //Se crea el pedido
                    Pedido pedido_nuevo = new Pedido(this.pedidos.Count() + 1, EstadoPedido.Em);
                    this.pedidos.Add(pedido_nuevo);
                }
            }


            double rnd_llegada_pedido = Utilidades.rnd();
            double A_llegada_pedido = Double.Parse(txt_distribucion_llegada_pedido_A.Text);
            double B_llegada_pedido = Double.Parse(txt_distribucion_llegada_pedido_B.Text);
            double tiempo_entre_llegada = Distribucion.uniforme(rnd_llegada_pedido, A_llegada_pedido, B_llegada_pedido);

            dgv_grilla[NombreColumna.RND_LLEGADA_PEDIDO, fila_nueva].Value = rnd_llegada_pedido;
            dgv_grilla[NombreColumna.TIEMPO_ENTRE_LLEGADA, fila_nueva].Value = tiempo_entre_llegada;
            dgv_grilla[NombreColumna.LLEGADA, fila_nueva].Value = tiempo_entre_llegada;


            dgv_grilla[NombreColumna.RND_TIEMPO_PRODUCCION_PEDIDO, fila_nueva].Value = "";
            dgv_grilla[NombreColumna.TIEMPO_ENTRE_PRODUCCION, fila_nueva].Value = "";
            //dgv_grilla[NombreColumna.TIEMPO_ENTRE_LLEGADA, fila_nueva].Value = "";

        }

        private double calcular_fin_empaque(int cantidad)
        {
            return 90 + (cantidad * 50);
        }

        private int calcular_cantidad(double rnd_cantidad_pedida)
        {
            int cantidad = -1;
            foreach (DataGridViewRow row in dgv_cantidad_pedida.Rows)
            {
                double min = double.Parse(row.Cells["cRandMin"].Value.ToString());
                double max = double.Parse(row.Cells["cRandMax"].Value.ToString());
                if (rnd_cantidad_pedida >= min && rnd_cantidad_pedida < max)
                {
                    cantidad = int.Parse(row.Cells["cCantidad"].Value.ToString());
                    break;
                }
                else if (rnd_cantidad_pedida == max)
                {
                    cantidad = int.Parse(row.Cells["cCantidad"].Value.ToString());
                    break;
                }
            }

            return cantidad;
        }

        private void evento_fin_produccion()
        {
            int fila_nueva = CloneWithValues();

            
            //1- Actualizar nombre evento y reloj
            dgv_grilla[NombreColumna.EVENTO, fila_nueva].Value = NombreEvento.FIN_PRODUCCION;
            dgv_grilla[NombreColumna.RELOJ, fila_nueva].Value = dgv_grilla[NombreColumna.PRODUCCION, fila_nueva].Value.ToString();

            //2- Aumentar stock en 1
            dgv_grilla[NombreColumna.STOCK, fila_nueva].Value = Int32.Parse(dgv_grilla[NombreColumna.STOCK, fila_nueva].Value.ToString()) + 1;

            //3- Generar proximo fin de produccion
            double rnd_tiempo_produccion = Utilidades.rnd();
            double A_tiempo_produccion = Double.Parse(txt_distribucion_tiempo_produccion_A.Text);
            double B_tiempo_produccion = Double.Parse(txt_distribucion_tiempo_produccion_B.Text);
            double tiempo_entre_produccion = Distribucion.uniforme(rnd_tiempo_produccion, A_tiempo_produccion, B_tiempo_produccion);

            dgv_grilla[NombreColumna.RND_TIEMPO_PRODUCCION_PEDIDO, fila_nueva].Value = rnd_tiempo_produccion;
            dgv_grilla[NombreColumna.TIEMPO_ENTRE_PRODUCCION, fila_nueva].Value = tiempo_entre_produccion;
            dgv_grilla[NombreColumna.PRODUCCION, fila_nueva].Value = tiempo_entre_produccion;



            //4- Actualizacion de maquina produccion
            dgv_grilla[NombreColumna.ESTADO_MAQUINA_PRODUCCION, fila_nueva].Value = EstadoMaquinas.Oc;
            


            //5- Limpieza de columnas no utilizadas
            dgv_grilla[NombreColumna.RND_CANTIDAD_PEDIDA, fila_nueva].Value = "";
            dgv_grilla[NombreColumna.RND_LLEGADA_PEDIDO, fila_nueva].Value = "";
            dgv_grilla[NombreColumna.TIEMPO_ENTRE_LLEGADA, fila_nueva].Value = "";
            
        }

        public int CloneWithValues()
        {
            dgv_grilla.Rows.Add();

            int fila_nueva = dgv_grilla.Rows.Count - 1;

            foreach (DataGridViewColumn column in dgv_grilla.Columns)
            {
                if(dgv_grilla[column.Name, fila_nueva - 1].Value != null)
                dgv_grilla[column.Name, fila_nueva].Value = dgv_grilla[column.Name, fila_nueva - 1].Value.ToString();
            }


            return fila_nueva;
        }


        private string proximo_evento()
        {
            int fila = dgv_grilla.Rows.Count - 1;

            List<Evento> eventos = new List<Evento>();

            //Evento de llegada pedido
            if (string.IsNullOrWhiteSpace(dgv_grilla[NombreColumna.LLEGADA, fila].Value.ToString()) == false)
            {
                eventos.Add(new Evento(NombreColumna.LLEGADA, Double.Parse(dgv_grilla[NombreColumna.LLEGADA, fila].Value.ToString())));
            }

            //Evento de fin de produccion
            if (string.IsNullOrWhiteSpace(dgv_grilla[NombreColumna.PRODUCCION, fila].Value.ToString()) == false)
            {
                eventos.Add(new Evento(NombreColumna.PRODUCCION, Double.Parse(dgv_grilla[NombreColumna.PRODUCCION, fila].Value.ToString())));
            }

            eventos = eventos.OrderBy(x => x.Tiempo).ToList();

            return eventos[0].Nombre_columna;
        }

        private void evento_inicio()
        {
            dgv_grilla.Rows.Add();
            dgv_grilla[NombreColumna.EVENTO, 0].Value = NombreEvento.INICIO;

            dgv_grilla[NombreColumna.RELOJ, 0].Value = 0;


            double rnd_llegada_pedido = Utilidades.rnd();
            double A_llegada_pedido = Double.Parse(txt_distribucion_llegada_pedido_A.Text);
            double B_llegada_pedido = Double.Parse(txt_distribucion_llegada_pedido_B.Text);
            double tiempo_entre_llegada = Distribucion.uniforme(rnd_llegada_pedido, A_llegada_pedido, B_llegada_pedido);

            dgv_grilla[NombreColumna.RND_LLEGADA_PEDIDO, 0].Value = rnd_llegada_pedido;
            dgv_grilla[NombreColumna.TIEMPO_ENTRE_LLEGADA, 0].Value = tiempo_entre_llegada;
            dgv_grilla[NombreColumna.LLEGADA, 0].Value = tiempo_entre_llegada;



            double rnd_tiempo_produccion = Utilidades.rnd();
            double A_tiempo_produccion = Double.Parse(txt_distribucion_tiempo_produccion_A.Text);
            double B_tiempo_produccion = Double.Parse(txt_distribucion_tiempo_produccion_B.Text);
            double tiempo_entre_produccion = Distribucion.uniforme(rnd_tiempo_produccion, A_tiempo_produccion, B_tiempo_produccion);

            dgv_grilla[NombreColumna.RND_TIEMPO_PRODUCCION_PEDIDO, 0].Value = rnd_tiempo_produccion;
            dgv_grilla[NombreColumna.TIEMPO_ENTRE_PRODUCCION, 0].Value = tiempo_entre_produccion;
            dgv_grilla[NombreColumna.PRODUCCION, 0].Value = tiempo_entre_produccion;

            dgv_grilla[NombreColumna.ESTADO_MAQUINA_PRODUCCION, 0].Value = EstadoMaquinas.L;
            dgv_grilla[NombreColumna.ESTADO_MAQUINA_EMPAQUE, 0].Value = EstadoMaquinas.L;


            dgv_grilla[NombreColumna.STOCK, 0].Value = 100;
            dgv_grilla[NombreColumna.PEDIDOS_PENDIENTES, 0].Value = 0;
        }
    }
}
