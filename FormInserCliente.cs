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
    public partial class FormInserCliente : Form
    {
        public FormInserCliente()
        {
            InitializeComponent();
        }

        private void cancelarC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void terminarC_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.InsertarCliente(textBoxnombreC.Text, textBoxDireccionC.Text, textBoxTelefonoC.Text, textBoxCorreoC.Text);
            this.Close();
            conectar.desconectar();
        }
    }
}
