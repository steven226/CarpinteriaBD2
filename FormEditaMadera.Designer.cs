namespace CarpinteriaBD
{
    partial class FormEditaMadera
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.TBcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBprecioVenta = new System.Windows.Forms.TextBox();
            this.TBprecioCompra = new System.Windows.Forms.TextBox();
            this.TBtamano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBtipoMadera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(173, 275);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(75, 23);
            this.btnListo.TabIndex = 22;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // TBcantidad
            // 
            this.TBcantidad.Location = new System.Drawing.Point(173, 224);
            this.TBcantidad.Name = "TBcantidad";
            this.TBcantidad.Size = new System.Drawing.Size(100, 20);
            this.TBcantidad.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cantidad:";
            // 
            // TBprecioVenta
            // 
            this.TBprecioVenta.Location = new System.Drawing.Point(173, 175);
            this.TBprecioVenta.Name = "TBprecioVenta";
            this.TBprecioVenta.Size = new System.Drawing.Size(100, 20);
            this.TBprecioVenta.TabIndex = 19;
            // 
            // TBprecioCompra
            // 
            this.TBprecioCompra.Location = new System.Drawing.Point(173, 129);
            this.TBprecioCompra.Name = "TBprecioCompra";
            this.TBprecioCompra.Size = new System.Drawing.Size(100, 20);
            this.TBprecioCompra.TabIndex = 18;
            // 
            // TBtamano
            // 
            this.TBtamano.Location = new System.Drawing.Point(173, 80);
            this.TBtamano.Name = "TBtamano";
            this.TBtamano.Size = new System.Drawing.Size(100, 20);
            this.TBtamano.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio de Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tamaño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Madera: ";
            // 
            // TBtipoMadera
            // 
            this.TBtipoMadera.Location = new System.Drawing.Point(173, 28);
            this.TBtipoMadera.Name = "TBtipoMadera";
            this.TBtipoMadera.Size = new System.Drawing.Size(100, 20);
            this.TBtipoMadera.TabIndex = 12;
            // 
            // FormEditaMadera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(359, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.TBcantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBprecioVenta);
            this.Controls.Add(this.TBprecioCompra);
            this.Controls.Add(this.TBtamano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBtipoMadera);
            this.Name = "FormEditaMadera";
            this.Text = "FormEditaMadera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.TextBox TBcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBprecioVenta;
        private System.Windows.Forms.TextBox TBprecioCompra;
        private System.Windows.Forms.TextBox TBtamano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBtipoMadera;
    }
}