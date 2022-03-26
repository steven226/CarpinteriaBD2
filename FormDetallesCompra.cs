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
    public partial class FormDetallesCompra : Form
    {
        public FormDetallesCompra(int idCompra)
        {
            int  id = idCompra;
            
            InitializeComponent();
            labelID.Text = Convert.ToString(id);

            Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView2.DataSource = conectar.muestraDetalleCompra(id);
            conectar.desconectar();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void FormDetallesCompra_Load(object sender, EventArgs e)
        {
           
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
