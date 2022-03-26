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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();


            Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView1.DataSource = conectar.detallesVenta();
            conectar.desconectar();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistraVenta_Click(object sender, EventArgs e)
        {
            Form formularioRegistraVenta = new FormRegistraVenta();
            formularioRegistraVenta.Show();
            this.Close();
        }

        private void btnDetallesVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnDetallesVenta_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            Form formularioDetallesVenta = new FormDetallesVenta(id);
            formularioDetallesVenta.Show();
        }
    }
}
