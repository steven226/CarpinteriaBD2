namespace CarpinteriaBD
{
    partial class InterfazBD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazBD));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.BtnAñadirC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPedidoInser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnInsertaP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Inventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.registraVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultaC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultaP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelPrincipal.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.PanelIzquierdo.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.PanelContenedor);
            this.PanelPrincipal.Controls.Add(this.PanelInferior);
            this.PanelPrincipal.Controls.Add(this.PanelSuperior);
            this.PanelPrincipal.Controls.Add(this.PanelIzquierdo);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1200, 724);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Controls.Add(this.dataGridView1);
            this.PanelContenedor.Location = new System.Drawing.Point(236, 86);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(952, 532);
            this.PanelContenedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // PanelInferior
            // 
            this.PanelInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.PanelInferior.Location = new System.Drawing.Point(230, 624);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(970, 100);
            this.PanelInferior.TabIndex = 2;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.PanelSuperior.Controls.Add(this.bunifuImageButton5);
            this.PanelSuperior.Controls.Add(this.BtnMinimizar);
            this.PanelSuperior.Controls.Add(this.BtnRestaurar);
            this.PanelSuperior.Controls.Add(this.BtnMaximizar);
            this.PanelSuperior.Controls.Add(this.BtnCerrar);
            this.PanelSuperior.Location = new System.Drawing.Point(230, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(970, 80);
            this.PanelSuperior.TabIndex = 1;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(6, 12);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(54, 51);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 4;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageActive = null;
            this.BtnMinimizar.Location = new System.Drawing.Point(874, 24);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Zoom = 10;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.ImageActive = null;
            this.BtnRestaurar.Location = new System.Drawing.Point(904, 24);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(24, 24);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 2;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Zoom = 10;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.ImageActive = null;
            this.BtnMaximizar.Location = new System.Drawing.Point(904, 24);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(24, 24);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Zoom = 10;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageActive = null;
            this.BtnCerrar.Location = new System.Drawing.Point(934, 24);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(24, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Zoom = 10;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.PanelIzquierdo.Controls.Add(this.BtnUsers);
            this.PanelIzquierdo.Controls.Add(this.groupBoxAdmin);
            this.PanelIzquierdo.Controls.Add(this.Inventario);
            this.PanelIzquierdo.Controls.Add(this.registraVenta);
            this.PanelIzquierdo.Controls.Add(this.btnConsultaC);
            this.PanelIzquierdo.Controls.Add(this.bunifuFlatButton3);
            this.PanelIzquierdo.Controls.Add(this.BtnConsultaP);
            this.PanelIzquierdo.Controls.Add(this.btnCompra);
            this.PanelIzquierdo.Controls.Add(this.bunifuSeparator1);
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(230, 724);
            this.PanelIzquierdo.TabIndex = 0;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.BtnAñadirC);
            this.groupBoxAdmin.Controls.Add(this.btnPedidoInser);
            this.groupBoxAdmin.Controls.Add(this.BtnInsertaP);
            this.groupBoxAdmin.Controls.Add(this.bunifuFlatButton2);
            this.groupBoxAdmin.Controls.Add(this.bunifuFlatButton1);
            this.groupBoxAdmin.Location = new System.Drawing.Point(-29, 309);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(286, 299);
            this.groupBoxAdmin.TabIndex = 15;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Visible = false;
            // 
            // BtnAñadirC
            // 
            this.BtnAñadirC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnAñadirC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnAñadirC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirC.BorderRadius = 0;
            this.BtnAñadirC.ButtonText = "AÑADIR CLIENTES";
            this.BtnAñadirC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAñadirC.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAñadirC.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAñadirC.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirC.Iconimage")));
            this.BtnAñadirC.Iconimage_right = null;
            this.BtnAñadirC.Iconimage_right_Selected = null;
            this.BtnAñadirC.Iconimage_Selected = null;
            this.BtnAñadirC.IconMarginLeft = 0;
            this.BtnAñadirC.IconMarginRight = 0;
            this.BtnAñadirC.IconRightVisible = true;
            this.BtnAñadirC.IconRightZoom = 0D;
            this.BtnAñadirC.IconVisible = true;
            this.BtnAñadirC.IconZoom = 90D;
            this.BtnAñadirC.IsTab = false;
            this.BtnAñadirC.Location = new System.Drawing.Point(29, 21);
            this.BtnAñadirC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAñadirC.Name = "BtnAñadirC";
            this.BtnAñadirC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnAñadirC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnAñadirC.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAñadirC.selected = false;
            this.BtnAñadirC.Size = new System.Drawing.Size(222, 45);
            this.BtnAñadirC.TabIndex = 3;
            this.BtnAñadirC.Text = "AÑADIR CLIENTES";
            this.BtnAñadirC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAñadirC.Textcolor = System.Drawing.Color.White;
            this.BtnAñadirC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadirC.Click += new System.EventHandler(this.BtnAñadirC_Click);
            // 
            // btnPedidoInser
            // 
            this.btnPedidoInser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPedidoInser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPedidoInser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidoInser.BorderRadius = 0;
            this.btnPedidoInser.ButtonText = "AÑADIR TRABAJOS";
            this.btnPedidoInser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidoInser.DisabledColor = System.Drawing.Color.Gray;
            this.btnPedidoInser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPedidoInser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPedidoInser.Iconimage")));
            this.btnPedidoInser.Iconimage_right = null;
            this.btnPedidoInser.Iconimage_right_Selected = null;
            this.btnPedidoInser.Iconimage_Selected = null;
            this.btnPedidoInser.IconMarginLeft = 0;
            this.btnPedidoInser.IconMarginRight = 0;
            this.btnPedidoInser.IconRightVisible = true;
            this.btnPedidoInser.IconRightZoom = 0D;
            this.btnPedidoInser.IconVisible = true;
            this.btnPedidoInser.IconZoom = 90D;
            this.btnPedidoInser.IsTab = false;
            this.btnPedidoInser.Location = new System.Drawing.Point(29, 76);
            this.btnPedidoInser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPedidoInser.Name = "btnPedidoInser";
            this.btnPedidoInser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPedidoInser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPedidoInser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPedidoInser.selected = false;
            this.btnPedidoInser.Size = new System.Drawing.Size(222, 45);
            this.btnPedidoInser.TabIndex = 9;
            this.btnPedidoInser.Text = "AÑADIR TRABAJOS";
            this.btnPedidoInser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedidoInser.Textcolor = System.Drawing.Color.White;
            this.btnPedidoInser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoInser.Click += new System.EventHandler(this.btnPedidoInser_Click);
            // 
            // BtnInsertaP
            // 
            this.BtnInsertaP.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnInsertaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnInsertaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInsertaP.BorderRadius = 0;
            this.BtnInsertaP.ButtonText = "AÑADIR PROVEEDORES";
            this.BtnInsertaP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertaP.DisabledColor = System.Drawing.Color.Gray;
            this.BtnInsertaP.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInsertaP.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnInsertaP.Iconimage")));
            this.BtnInsertaP.Iconimage_right = null;
            this.BtnInsertaP.Iconimage_right_Selected = null;
            this.BtnInsertaP.Iconimage_Selected = null;
            this.BtnInsertaP.IconMarginLeft = 0;
            this.BtnInsertaP.IconMarginRight = 0;
            this.BtnInsertaP.IconRightVisible = true;
            this.BtnInsertaP.IconRightZoom = 0D;
            this.BtnInsertaP.IconVisible = true;
            this.BtnInsertaP.IconZoom = 90D;
            this.BtnInsertaP.IsTab = false;
            this.BtnInsertaP.Location = new System.Drawing.Point(32, 131);
            this.BtnInsertaP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInsertaP.Name = "BtnInsertaP";
            this.BtnInsertaP.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnInsertaP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnInsertaP.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnInsertaP.selected = false;
            this.BtnInsertaP.Size = new System.Drawing.Size(219, 45);
            this.BtnInsertaP.TabIndex = 5;
            this.BtnInsertaP.Text = "AÑADIR PROVEEDORES";
            this.BtnInsertaP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsertaP.Textcolor = System.Drawing.Color.White;
            this.BtnInsertaP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertaP.Click += new System.EventHandler(this.BtnInsertaP_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "MODIFICAR O ELIMINAR CLIENTES";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-6, 186);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(261, 45);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "MODIFICAR O ELIMINAR CLIENTES";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "MODIFICAR O ELIMINAR PROVEEDORES";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-6, 246);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(261, 45);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "MODIFICAR O ELIMINAR PROVEEDORES";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Inventario
            // 
            this.Inventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventario.BorderRadius = 0;
            this.Inventario.ButtonText = "INVENTARIO";
            this.Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventario.DisabledColor = System.Drawing.Color.Gray;
            this.Inventario.Iconcolor = System.Drawing.Color.Transparent;
            this.Inventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("Inventario.Iconimage")));
            this.Inventario.Iconimage_right = null;
            this.Inventario.Iconimage_right_Selected = null;
            this.Inventario.Iconimage_Selected = null;
            this.Inventario.IconMarginLeft = 0;
            this.Inventario.IconMarginRight = 0;
            this.Inventario.IconRightVisible = true;
            this.Inventario.IconRightZoom = 0D;
            this.Inventario.IconVisible = true;
            this.Inventario.IconZoom = 90D;
            this.Inventario.IsTab = false;
            this.Inventario.Location = new System.Drawing.Point(0, 91);
            this.Inventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inventario.Name = "Inventario";
            this.Inventario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Inventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inventario.OnHoverTextColor = System.Drawing.Color.White;
            this.Inventario.selected = false;
            this.Inventario.Size = new System.Drawing.Size(222, 45);
            this.Inventario.TabIndex = 14;
            this.Inventario.Text = "INVENTARIO";
            this.Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inventario.Textcolor = System.Drawing.Color.White;
            this.Inventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // registraVenta
            // 
            this.registraVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.registraVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.registraVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registraVenta.BorderRadius = 0;
            this.registraVenta.ButtonText = "VENTAS";
            this.registraVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registraVenta.DisabledColor = System.Drawing.Color.Gray;
            this.registraVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.registraVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("registraVenta.Iconimage")));
            this.registraVenta.Iconimage_right = null;
            this.registraVenta.Iconimage_right_Selected = null;
            this.registraVenta.Iconimage_Selected = null;
            this.registraVenta.IconMarginLeft = 0;
            this.registraVenta.IconMarginRight = 0;
            this.registraVenta.IconRightVisible = true;
            this.registraVenta.IconRightZoom = 0D;
            this.registraVenta.IconVisible = true;
            this.registraVenta.IconZoom = 90D;
            this.registraVenta.IsTab = false;
            this.registraVenta.Location = new System.Drawing.Point(4, 616);
            this.registraVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registraVenta.Name = "registraVenta";
            this.registraVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.registraVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.registraVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.registraVenta.selected = false;
            this.registraVenta.Size = new System.Drawing.Size(222, 45);
            this.registraVenta.TabIndex = 13;
            this.registraVenta.Text = "VENTAS";
            this.registraVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registraVenta.Textcolor = System.Drawing.Color.White;
            this.registraVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registraVenta.Click += new System.EventHandler(this.registraVenta_Click);
            // 
            // btnConsultaC
            // 
            this.btnConsultaC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnConsultaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnConsultaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultaC.BorderRadius = 0;
            this.btnConsultaC.ButtonText = "CONSULTAR CLIENTES";
            this.btnConsultaC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaC.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultaC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultaC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultaC.Iconimage")));
            this.btnConsultaC.Iconimage_right = null;
            this.btnConsultaC.Iconimage_right_Selected = null;
            this.btnConsultaC.Iconimage_Selected = null;
            this.btnConsultaC.IconMarginLeft = 0;
            this.btnConsultaC.IconMarginRight = 0;
            this.btnConsultaC.IconRightVisible = true;
            this.btnConsultaC.IconRightZoom = 0D;
            this.btnConsultaC.IconVisible = true;
            this.btnConsultaC.IconZoom = 90D;
            this.btnConsultaC.IsTab = false;
            this.btnConsultaC.Location = new System.Drawing.Point(4, 201);
            this.btnConsultaC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultaC.Name = "btnConsultaC";
            this.btnConsultaC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnConsultaC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnConsultaC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultaC.selected = false;
            this.btnConsultaC.Size = new System.Drawing.Size(222, 45);
            this.btnConsultaC.TabIndex = 6;
            this.btnConsultaC.Text = "CONSULTAR CLIENTES";
            this.btnConsultaC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaC.Textcolor = System.Drawing.Color.White;
            this.btnConsultaC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaC.Click += new System.EventHandler(this.btnConsultaC_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "CONSULTAR TRABAJOS";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(4, 256);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(222, 45);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Text = "CONSULTAR TRABAJOS";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // BtnConsultaP
            // 
            this.BtnConsultaP.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnConsultaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultaP.BorderRadius = 0;
            this.BtnConsultaP.ButtonText = "CONSULTAR PROVEEDORES";
            this.BtnConsultaP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultaP.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultaP.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultaP.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsultaP.Iconimage")));
            this.BtnConsultaP.Iconimage_right = null;
            this.BtnConsultaP.Iconimage_right_Selected = null;
            this.BtnConsultaP.Iconimage_Selected = null;
            this.BtnConsultaP.IconMarginLeft = 0;
            this.BtnConsultaP.IconMarginRight = 0;
            this.BtnConsultaP.IconRightVisible = true;
            this.BtnConsultaP.IconRightZoom = 0D;
            this.BtnConsultaP.IconVisible = true;
            this.BtnConsultaP.IconZoom = 90D;
            this.BtnConsultaP.IsTab = false;
            this.BtnConsultaP.Location = new System.Drawing.Point(4, 146);
            this.BtnConsultaP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConsultaP.Name = "BtnConsultaP";
            this.BtnConsultaP.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnConsultaP.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnConsultaP.selected = false;
            this.BtnConsultaP.Size = new System.Drawing.Size(222, 45);
            this.BtnConsultaP.TabIndex = 2;
            this.BtnConsultaP.Text = "CONSULTAR PROVEEDORES";
            this.BtnConsultaP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultaP.Textcolor = System.Drawing.Color.White;
            this.BtnConsultaP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaP.Click += new System.EventHandler(this.BtnConsultaP_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompra.BorderRadius = 0;
            this.btnCompra.ButtonText = "COMPRAS";
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompra.Iconimage")));
            this.btnCompra.Iconimage_right = null;
            this.btnCompra.Iconimage_right_Selected = null;
            this.btnCompra.Iconimage_Selected = null;
            this.btnCompra.IconMarginLeft = 0;
            this.btnCompra.IconMarginRight = 0;
            this.btnCompra.IconRightVisible = true;
            this.btnCompra.IconRightZoom = 0D;
            this.btnCompra.IconVisible = true;
            this.btnCompra.IconZoom = 90D;
            this.btnCompra.IsTab = false;
            this.btnCompra.Location = new System.Drawing.Point(4, 671);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnCompra.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCompra.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompra.selected = false;
            this.btnCompra.Size = new System.Drawing.Size(222, 45);
            this.btnCompra.TabIndex = 11;
            this.btnCompra.Text = "COMPRAS";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompra.Textcolor = System.Drawing.Color.White;
            this.btnCompra.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 68);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(230, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelSuperior;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.PanelContenedor;
            // 
            // BtnUsers
            // 
            this.BtnUsers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUsers.BorderRadius = 0;
            this.BtnUsers.ButtonText = "Gestionar usuarios";
            this.BtnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsers.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUsers.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnUsers.Iconimage")));
            this.BtnUsers.Iconimage_right = null;
            this.BtnUsers.Iconimage_right_Selected = null;
            this.BtnUsers.Iconimage_Selected = null;
            this.BtnUsers.IconMarginLeft = 0;
            this.BtnUsers.IconMarginRight = 0;
            this.BtnUsers.IconRightVisible = true;
            this.BtnUsers.IconRightZoom = 0D;
            this.BtnUsers.IconVisible = true;
            this.BtnUsers.IconZoom = 90D;
            this.BtnUsers.IsTab = false;
            this.BtnUsers.Location = new System.Drawing.Point(1, 24);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnUsers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUsers.selected = false;
            this.BtnUsers.Size = new System.Drawing.Size(222, 45);
            this.BtnUsers.TabIndex = 16;
            this.BtnUsers.Text = "Gestionar usuarios";
            this.BtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsers.Textcolor = System.Drawing.Color.White;
            this.BtnUsers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsers.Visible = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // InterfazBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 724);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "InterfazBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazBD";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.PanelIzquierdo.ResumeLayout(false);
            this.groupBoxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton BtnRestaurar;
        private Bunifu.Framework.UI.BunifuImageButton BtnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton BtnCerrar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInsertaP;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAñadirC;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultaP;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultaC;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPedidoInser;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton registraVenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompra;
        private Bunifu.Framework.UI.BunifuFlatButton Inventario;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUsers;
    }
}

