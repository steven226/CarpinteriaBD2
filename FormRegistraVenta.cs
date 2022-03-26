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
    public partial class FormRegistraVenta : Form
    {
        public FormRegistraVenta()
        {
            InitializeComponent();

            Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView1.DataSource = conectar.ConsultaM();
            conectar.desconectar();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Form formularioVenta = new FormVenta();
            formularioVenta.Show();
            this.Close();
        }

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            int i = 0;
            double totalVenta = 0;
            double costo = 0;
            int totalFilas = dataGridView1.Rows.Count;

            for (i = 0; i < totalFilas - 1; i++)
            {
                costo = Convert.ToDouble(dataGridView1.Rows[i].Cells["precio"].Value.ToString()) * Convert.ToInt32(dataGridView1.Rows[i].Cells["Cantidad"].Value.ToString());
                totalVenta += costo;
            }


            if (MessageBox.Show("Confirmar la compra con un valor total de " + totalVenta, "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion conectar = new Conexion();
                conectar.registrarVenta(textBox1.Text, dateTimePicker1.Text, totalVenta);
                for (i = 0; i < totalFilas - 1; i++)
                {
                    int idMadera = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value.ToString());
                    double preciov = Convert.ToDouble(dataGridView1.Rows[i].Cells["precio"].Value.ToString());
                    int cantidadv = Convert.ToInt32(dataGridView1.Rows[i].Cells["Cantidad"].Value.ToString());
                    if (cantidadv > 0)
                    {
                        conectar.registraDetalleVenta(idMadera, preciov, cantidadv);
                    }

                }


                this.Close();
                conectar.desconectar();
                Form formularioVenta = new FormVenta();
                formularioVenta.Show();
                this.Close();
            }
        }
    }
}
