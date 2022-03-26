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
    public partial class GestionUsers : Form
    {
        public GestionUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.eliminarUser(Convert.ToInt32(textBoxID.Text));
            this.Close();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

            Conexion conectar = new Conexion();
            conectar.ActualizarUser(Convert.ToInt32(textBoxID.Text),textBoxNombre.Text,textBoxPass.Text,textBoxRol.Text);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
