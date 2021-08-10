
namespace PinturasPerfecta
{
    partial class FormularioVentas
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
            this.boxFecha = new System.Windows.Forms.TextBox();
            this.boxMT = new System.Windows.Forms.TextBox();
            this.boxIDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpar = new FontAwesome.Sharp.IconButton();
            this.buttonAgregar = new FontAwesome.Sharp.IconButton();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.btnDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxFecha
            // 
            this.boxFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFecha.ForeColor = System.Drawing.Color.White;
            this.boxFecha.Location = new System.Drawing.Point(200, 199);
            this.boxFecha.Multiline = true;
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(175, 30);
            this.boxFecha.TabIndex = 46;
            // 
            // boxMT
            // 
            this.boxMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxMT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMT.ForeColor = System.Drawing.Color.White;
            this.boxMT.Location = new System.Drawing.Point(200, 161);
            this.boxMT.Multiline = true;
            this.boxMT.Name = "boxMT";
            this.boxMT.Size = new System.Drawing.Size(175, 30);
            this.boxMT.TabIndex = 44;
            // 
            // boxIDV
            // 
            this.boxIDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxIDV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIDV.ForeColor = System.Drawing.Color.White;
            this.boxIDV.Location = new System.Drawing.Point(200, 47);
            this.boxIDV.Multiline = true;
            this.boxIDV.Name = "boxIDV";
            this.boxIDV.Size = new System.Drawing.Size(175, 30);
            this.boxIDV.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Monto Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "idEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "idCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "idVenta";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.Orange;
            this.buttonLimpar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.buttonLimpar.IconColor = System.Drawing.Color.Orange;
            this.buttonLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLimpar.IconSize = 30;
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(30, 262);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(113, 34);
            this.buttonLimpar.TabIndex = 48;
            this.buttonLimpar.Text = "Limpiar";
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.Cyan;
            this.buttonAgregar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonAgregar.IconColor = System.Drawing.Color.Cyan;
            this.buttonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAgregar.IconSize = 32;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregar.Location = new System.Drawing.Point(296, 262);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(134, 34);
            this.buttonAgregar.TabIndex = 47;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            this.buttonAgregar.MouseEnter += new System.EventHandler(this.buttonAgregar_MouseEnter);
            this.buttonAgregar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(456, 31);
            this.panelNav.TabIndex = 49;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonClose.IconColor = System.Drawing.Color.White;
            this.buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClose.IconSize = 25;
            this.buttonClose.Location = new System.Drawing.Point(429, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 25);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxCliente.ForeColor = System.Drawing.Color.White;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(200, 85);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(175, 28);
            this.comboBoxCliente.TabIndex = 47;
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.comboBoxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxEmpleado.ForeColor = System.Drawing.Color.White;
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(200, 122);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(175, 28);
            this.comboBoxEmpleado.TabIndex = 50;
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnDetalleVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleVenta.ForeColor = System.Drawing.Color.Orange;
            this.btnDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnDetalleVenta.IconColor = System.Drawing.Color.Orange;
            this.btnDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalleVenta.IconSize = 30;
            this.btnDetalleVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleVenta.Location = new System.Drawing.Point(149, 262);
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(141, 34);
            this.btnDetalleVenta.TabIndex = 51;
            this.btnDetalleVenta.Text = "Productos";
            this.btnDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 207);
            this.dataGridView1.TabIndex = 52;
            // 
            // FormularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(456, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDetalleVenta);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.boxFecha);
            this.Controls.Add(this.boxMT);
            this.Controls.Add(this.boxIDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioVentas";
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox boxFecha;
        public System.Windows.Forms.TextBox boxMT;
        public System.Windows.Forms.TextBox boxIDV;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton buttonLimpar;
        public FontAwesome.Sharp.IconButton buttonAgregar;
        public System.Windows.Forms.Panel panelNav;
        private FontAwesome.Sharp.IconButton buttonClose;
        public System.Windows.Forms.ComboBox comboBoxCliente;
        public System.Windows.Forms.ComboBox comboBoxEmpleado;
        private FontAwesome.Sharp.IconButton btnDetalleVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}