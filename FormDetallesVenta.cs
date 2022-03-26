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
    public partial class FormDetallesVenta : Form
    {
        public FormDetallesVenta(int idVenta)
        {
            int id = idVenta;

            InitializeComponent();
            labelID.Text = Convert.ToString(id);

            Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView1.DataSource = conectar.muestraDetalleVenta(id);
            conectar.desconectar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
