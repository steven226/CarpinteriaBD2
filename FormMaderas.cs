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
    public partial class FormMaderas : Form
    {
        int idMadera;
        string tipoMadera;
        string tamano;
        double precioCompra;
        double precioVenta;
        int cantidad;

        public FormMaderas()
        {
            InitializeComponent();

            Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView1.DataSource = conectar.detallesMadera();

            conectar.desconectar();
        }

        private void btnRegistraArticulo_Click(object sender, EventArgs e)
        {
            Form formularioRegistraMadera = new FormRegistraMadera();
            formularioRegistraMadera.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarArticulo_Click(object sender, EventArgs e)
        {
            Form formularioEditaMadera = new FormEditaMadera(idMadera, tipoMadera, tamano, precioCompra, precioVenta, cantidad);
            formularioEditaMadera.Show();
            this.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i != -1)
            {
                idMadera = (int)dataGridView1.Rows[i].Cells["id"].Value;
                tipoMadera = (string)dataGridView1.Rows[i].Cells["madera"].Value;
                tamano = (string)dataGridView1.Rows[i].Cells["tamaño"].Value;
                precioCompra = (double)dataGridView1.Rows[i].Cells["preciocompra"].Value;
                precioVenta = (double)dataGridView1.Rows[i].Cells["precioventa"].Value;
                cantidad = (int)dataGridView1.Rows[i].Cells["cantidad"].Value;
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el elemento seleccionado", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion conectar = new Conexion();
                conectar.eliminarMadera(idMadera);
                conectar.desconectar();

                Form formularioMaderas = new FormMaderas();
                formularioMaderas.Show();

                this.Close();
            }
        }
    }
}
