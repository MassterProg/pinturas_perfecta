namespace PinturasPerfecta
{
    partial class FormularioCapuraDeProductos
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
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.boxCant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelNavCompras = new System.Windows.Forms.Panel();
            this.buttonCloseCompras = new FontAwesome.Sharp.IconButton();
            this.buttonAgregar = new FontAwesome.Sharp.IconButton();
            this.buttonLimpar = new FontAwesome.Sharp.IconButton();
            this.boxPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNavCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.comboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxProducto.ForeColor = System.Drawing.Color.White;
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(145, 52);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(205, 28);
            this.comboBoxProducto.TabIndex = 60;
            this.comboBoxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducto_SelectedIndexChanged);
            // 
            // boxCant
            // 
            this.boxCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxCant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCant.ForeColor = System.Drawing.Color.White;
            this.boxCant.Location = new System.Drawing.Point(145, 99);
            this.boxCant.Multiline = true;
            this.boxCant.Name = "boxCant";
            this.boxCant.Size = new System.Drawing.Size(205, 30);
            this.boxCant.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Producto";
            // 
            // panelNavCompras
            // 
            this.panelNavCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelNavCompras.Controls.Add(this.buttonCloseCompras);
            this.panelNavCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavCompras.Location = new System.Drawing.Point(0, 0);
            this.panelNavCompras.Name = "panelNavCompras";
            this.panelNavCompras.Size = new System.Drawing.Size(368, 31);
            this.panelNavCompras.TabIndex = 47;
            this.panelNavCompras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavCompras_MouseDown);
            // 
            // buttonCloseCompras
            // 
            this.buttonCloseCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseCompras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCloseCompras.FlatAppearance.BorderSize = 0;
            this.buttonCloseCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.buttonCloseCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseCompras.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonCloseCompras.IconColor = System.Drawing.Color.White;
            this.buttonCloseCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCloseCompras.IconSize = 25;
            this.buttonCloseCompras.Location = new System.Drawing.Point(341, 0);
            this.buttonCloseCompras.Name = "buttonCloseCompras";
            this.buttonCloseCompras.Size = new System.Drawing.Size(26, 25);
            this.buttonCloseCompras.TabIndex = 3;
            this.buttonCloseCompras.UseVisualStyleBackColor = true;
            this.buttonCloseCompras.Click += new System.EventHandler(this.buttonCloseCompras_Click);
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
            this.buttonAgregar.Location = new System.Drawing.Point(216, 246);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(134, 34);
            this.buttonAgregar.TabIndex = 59;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            this.buttonAgregar.MouseEnter += new System.EventHandler(this.buttonAgregar_MouseEnter);
            this.buttonAgregar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
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
            this.buttonLimpar.Location = new System.Drawing.Point(17, 246);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(113, 34);
            this.buttonLimpar.TabIndex = 58;
            this.buttonLimpar.Text = "Limpiar";
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.MouseEnter += new System.EventHandler(this.buttonAgregar_MouseEnter);
            this.buttonLimpar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
            // 
            // boxPrecio
            // 
            this.boxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPrecio.ForeColor = System.Drawing.Color.White;
            this.boxPrecio.Location = new System.Drawing.Point(145, 185);
            this.boxPrecio.Multiline = true;
            this.boxPrecio.Name = "boxPrecio";
            this.boxPrecio.Size = new System.Drawing.Size(205, 30);
            this.boxPrecio.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Precio";
            // 
            // boxStock
            // 
            this.boxStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStock.ForeColor = System.Drawing.Color.White;
            this.boxStock.Location = new System.Drawing.Point(145, 143);
            this.boxStock.Multiline = true;
            this.boxStock.Name = "boxStock";
            this.boxStock.Size = new System.Drawing.Size(205, 30);
            this.boxStock.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Stock";
            // 
            // FormularioCapuraDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(368, 292);
            this.Controls.Add(this.boxStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.boxCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelNavCompras);
            this.Name = "FormularioCapuraDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCapuraDeProductos";
            this.panelNavCompras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxProducto;
        public FontAwesome.Sharp.IconButton buttonAgregar;
        public System.Windows.Forms.TextBox boxCant;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panelNavCompras;
        private FontAwesome.Sharp.IconButton buttonCloseCompras;
        private FontAwesome.Sharp.IconButton buttonLimpar;
        public System.Windows.Forms.TextBox boxPrecio;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox boxStock;
        public System.Windows.Forms.Label label2;
    }
}