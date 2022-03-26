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
    
    public partial class FormPedido : Form
    {
        double total;
        public FormPedido()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            total = Convert.ToInt32(TBcantidad.Text) * Convert.ToDouble(TBcosto.Text);
            conectar.IngresarT(TBnombreC.Text, TBfechaS.Text,TBfechaE.Text,TBdescripcion.Text,Convert.ToInt32(TBcantidad.Text),Convert.ToDouble(TBcosto.Text),TBstatus.Text,total);
            this.Close();
            conectar.desconectar();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
