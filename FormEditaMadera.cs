using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaBD
{
    public partial class FormEditaMadera : Form
    {
        int idMadera;

        public FormEditaMadera(int id, string tipoMadera, string tamano, double precioCompra, double precioVenta, int cantidad)
        {
            InitializeComponent();

            idMadera = id;
            TBtipoMadera.Text = tipoMadera;
            TBtamano.Text = tamano;
            TBprecioCompra.Text = Convert.ToString(precioCompra);
            TBprecioVenta.Text = Convert.ToString(precioVenta);
            TBcantidad.Text = Convert.ToString(cantidad);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form formularioMaderas = new FormMaderas();
            formularioMaderas.Show();
            this.Close();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.ActualizarMadera(idMadera, TBtipoMadera.Text, TBtamano.Text, Convert.ToDouble(TBprecioCompra.Text), Convert.ToDouble(TBprecioVenta.Text), Convert.ToInt32(TBcantidad.Text));
            Form formularioMaderas = new FormMaderas();
            formularioMaderas.Show();
            this.Close();
            conectar.desconectar();
        }
    }
}
