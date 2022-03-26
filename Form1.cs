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
    public partial class InterfazBD : Form
    {
        int tipoUser;
        public InterfazBD()
        {
            InitializeComponent();

            tipoUser = Conexion.ROL;
            if (tipoUser == 1)
            {
                this.groupBoxAdmin.Visible = true;
                this.BtnUsers.Visible = true;
            }
            else if(tipoUser == 2)
            {
                this.groupBoxAdmin.Visible = true;
            }
        }


        private const int tamanogrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            rectangulogrid = new Rectangle(ClientRectangle.Width - tamanogrid, ClientRectangle.Height - tamanogrid, tamanogrid, tamanogrid);

            region.Exclude(rectangulogrid);

            PanelPrincipal.Region = region;
            Invalidate();
        }

        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);

                    var Refpoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));

                    if(!rectangulogrid.Contains(Refpoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidbrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(solidbrush, rectangulogrid);

            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);
        }

        int lx, ly;



        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }        

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿REALMENTE DESEA CERRAR EL PROGRAMA?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnInsertaP_Click(object sender, EventArgs e)
        {
            
            Form formularioP = new Form2();
            formularioP.Show();
        }

        private void BtnConsultaP_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            dataGridView1.DataSource = conectar.ConsultaP();
        }

        private void btnConsultaC_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            dataGridView1.DataSource = conectar.ConsultaC();
        }

        private void BtnAñadirC_Click(object sender, EventArgs e)
        {
            Form formularioP = new FormInserCliente();
            formularioP.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form formularioModp = new FormModProv();
            formularioModp.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form formularioModC=new FormModClient();
            formularioModC.Show();
        }

        private void btnPedidoInser_Click(object sender, EventArgs e)
        {
            Form formularioPedidoInser = new FormPedido();
            formularioPedidoInser.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            dataGridView1.DataSource = conectar.ConsultaT();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Form formularioRegistraCompra = new FormCompra();
            formularioRegistraCompra.Show();
        }

        private void registraVenta_Click(object sender, EventArgs e)
        {
            Form formularioRegistraVenta = new FormVenta();
            formularioRegistraVenta.Show();
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            Form formularioMadera = new FormMaderas();
            formularioMadera.Show();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            Form formUsers = new GestionUsers();
            formUsers.Show();
        }

        int sw, sh;
    }
}
