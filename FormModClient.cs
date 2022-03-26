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
    public partial class FormModClient : Form
    {
        public FormModClient()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.EliminarCliente(Convert.ToInt32(textBox1.Text));
            this.Close();
            conectar.desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.ModificarCliente(Convert.ToInt32(textBox1.Text), textBoxNombreCliente.Text, textBoxDireccionCliente.Text, Convert.ToInt32(textBoxTelCliente.Text), textBoxCorreoCLiente.Text);
            this.Close();
            conectar.desconectar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
