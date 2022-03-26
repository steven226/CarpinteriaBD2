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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
            Conexion conectar = new Conexion();
            dataGridView1.DataSource = conectar.detallesCompra();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistraCompra_Click(object sender, EventArgs e)
        {
            Form formularioRegistraCompra = new FormRegistraCompra();
            formularioRegistraCompra.Show();
            this.Close();
        }

        private void btnDetallesCompra_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            Form formularioDetallesCompra = new FormDetallesCompra(id);
            formularioDetallesCompra.Show();
            

           /* Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView1.DataSource = conectar.muestraDetalleCompra(id);
            conectar.desconectar();*/

        }




        /*
private void FormRegistraCompra_Load(object sender, EventArgs e)
{
Conexion conectar = new Conexion();
conectar.conectar();

while (conectar.comboBoxProveedores().Read())
{
comboBox1.Items.Add(conectar.comboBoxProveedores()["nombrep"].ToString());
}

}*/
    }
}
