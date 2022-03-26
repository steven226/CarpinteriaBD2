namespace CarpinteriaBD
{
    partial class FormPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBnombreC = new System.Windows.Forms.TextBox();
            this.TBfechaS = new System.Windows.Forms.TextBox();
            this.TBfechaE = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBdescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBcantidad = new System.Windows.Forms.TextBox();
            this.TBcosto = new System.Windows.Forms.TextBox();
            this.TBstatus = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Cancelar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 431);
            this.panel2.TabIndex = 1;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(12, 384);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de entrega:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decha de solicitud:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // TBnombreC
            // 
            this.TBnombreC.Location = new System.Drawing.Point(186, 82);
            this.TBnombreC.Name = "TBnombreC";
            this.TBnombreC.Size = new System.Drawing.Size(275, 20);
            this.TBnombreC.TabIndex = 2;
            // 
            // TBfechaS
            // 
            this.TBfechaS.Location = new System.Drawing.Point(186, 121);
            this.TBfechaS.Name = "TBfechaS";
            this.TBfechaS.Size = new System.Drawing.Size(275, 20);
            this.TBfechaS.TabIndex = 3;
            // 
            // TBfechaE
            // 
            this.TBfechaE.Location = new System.Drawing.Point(186, 158);
            this.TBfechaE.Name = "TBfechaE";
            this.TBfechaE.Size = new System.Drawing.Size(275, 20);
            this.TBfechaE.TabIndex = 4;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(264, 442);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 5;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción:";
            // 
            // TBdescripcion
            // 
            this.TBdescripcion.Location = new System.Drawing.Point(186, 193);
            this.TBdescripcion.Multiline = true;
            this.TBdescripcion.Name = "TBdescripcion";
            this.TBdescripcion.Size = new System.Drawing.Size(275, 84);
            this.TBdescripcion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Costo:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(3, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status:";
            // 
            // TBcantidad
            // 
            this.TBcantidad.Location = new System.Drawing.Point(186, 297);
            this.TBcantidad.Name = "TBcantidad";
            this.TBcantidad.Size = new System.Drawing.Size(275, 20);
            this.TBcantidad.TabIndex = 7;
            // 
            // TBcosto
            // 
            this.TBcosto.Location = new System.Drawing.Point(186, 328);
            this.TBcosto.Name = "TBcosto";
            this.TBcosto.Size = new System.Drawing.Size(275, 20);
            this.TBcosto.TabIndex = 8;
            // 
            // TBstatus
            // 
            this.TBstatus.FormattingEnabled = true;
            this.TBstatus.Items.AddRange(new object[] {
            "Solicitado",
            "En curso",
            "Entregado",
            "Cancelado"});
            this.TBstatus.Location = new System.Drawing.Point(186, 358);
            this.TBstatus.Name = "TBstatus";
            this.TBstatus.Size = new System.Drawing.Size(275, 21);
            this.TBstatus.TabIndex = 9;
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(473, 489);
            this.Controls.Add(this.TBstatus);
            this.Controls.Add(this.TBcosto);
            this.Controls.Add(this.TBcantidad);
            this.Controls.Add(this.TBdescripcion);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.TBfechaE);
            this.Controls.Add(this.TBfechaS);
            this.Controls.Add(this.TBnombreC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBnombreC;
        private System.Windows.Forms.TextBox TBfechaS;
        private System.Windows.Forms.TextBox TBfechaE;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBdescripcion;
        private System.Windows.Forms.TextBox TBcantidad;
        private System.Windows.Forms.TextBox TBcosto;
        private System.Windows.Forms.ComboBox TBstatus;
    }
}