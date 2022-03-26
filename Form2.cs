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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btninsertarp(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.InsertarProveedor(textBoxnombrep.Text, textBoxdireccionp.Text, textBoxtelp.Text, textBoxcorreop.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
