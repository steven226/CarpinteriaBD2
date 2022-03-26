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
    public partial class FormRegistraMadera : Form
    {
        public FormRegistraMadera()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form formularioMadera = new FormMaderas();
            formularioMadera.Show();
            this.Close();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.InsertarMadera(tipoMadera.Text,tamano.Text, Convert.ToDouble(precioCompra.Text), Convert.ToDouble(precioVenta.Text),Convert.ToInt32(cantidad.Text));
            Form formularioMaderas = new FormMaderas();
            formularioMaderas.Show();
            this.Close();
            conectar.desconectar();
        }
    }
}
