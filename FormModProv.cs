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
    public partial class FormModProv : Form
    {
        public FormModProv()
        {
            InitializeComponent();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.ModificarProv(Convert.ToInt32(textBoxID.Text), textBoxName.Text, textBoxDir.Text, Convert.ToInt32(textBoxTel.Text), textBoxCorreo.Text);
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.EliminarProv(Convert.ToInt32(textBoxID.Text));
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
