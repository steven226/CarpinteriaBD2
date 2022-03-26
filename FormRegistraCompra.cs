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
    public partial class FormRegistraCompra : Form
    {
        public FormRegistraCompra()
        {
            InitializeComponent();

            Conexion conectar = new Conexion();
            conectar.conectar();

            dataGridView1.DataSource = conectar.ConsultaM();
            conectar.desconectar();
        }

       
        private void registrarCompra_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            double totalCompra = 0;
            double  costo = 0;
            int totalFilas = dataGridView1.Rows.Count;

            for(i=0; i <totalFilas-1; i++)
            {
                costo = Convert.ToDouble(dataGridView1.Rows[i].Cells["precio"].Value.ToString()) * Convert.ToInt32(dataGridView1.Rows[i].Cells["Cantidad"].Value.ToString());
                totalCompra += costo;
            }


            if (MessageBox.Show("Confirmar la compra con un valor total de "+totalCompra, "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion conectar = new Conexion();
                conectar.registrarCompra(textBox1.Text, dateTimePicker1.Text, totalCompra);
                for (i = 0; i < totalFilas - 1; i++)
                {
                    int idMadera = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value.ToString());
                    double precioc = Convert.ToDouble(dataGridView1.Rows[i].Cells["precio"].Value.ToString());
                    int cantidadc = Convert.ToInt32(dataGridView1.Rows[i].Cells["Cantidad"].Value.ToString());
                    if(cantidadc > 0)
                    {
                        conectar.registraDetalleCompra(idMadera, precioc, cantidadc);
                    }
                    
                }

               
                this.Close();
                conectar.desconectar();
                Form formularioCompra = new FormCompra();
                formularioCompra.Show();
                this.Close();
            }
        }

        private void cancelar_Click_1(object sender, EventArgs e)
        {
            Form formularioCompra = new FormCompra();
            formularioCompra.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
