
namespace PinturasPerfecta
{
    partial class FormularioCompras
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
            this.panelNavCompras = new System.Windows.Forms.Panel();
            this.buttonCloseCompras = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFolio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxCant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new FontAwesome.Sharp.IconButton();
            this.buttonAgregar = new FontAwesome.Sharp.IconButton();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.comboBoxProveedores = new System.Windows.Forms.ComboBox();
            this.panelNavCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavCompras
            // 
            this.panelNavCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelNavCompras.Controls.Add(this.buttonCloseCompras);
            this.panelNavCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavCompras.Location = new System.Drawing.Point(0, 0);
            this.panelNavCompras.Name = "panelNavCompras";
            this.panelNavCompras.Size = new System.Drawing.Size(375, 31);
            this.panelNavCompras.TabIndex = 26;
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
            this.buttonCloseCompras.Location = new System.Drawing.Point(348, 0);
            this.buttonCloseCompras.Name = "buttonCloseCompras";
            this.buttonCloseCompras.Size = new System.Drawing.Size(26, 25);
            this.buttonCloseCompras.TabIndex = 3;
            this.buttonCloseCompras.UseVisualStyleBackColor = true;
            this.buttonCloseCompras.Click += new System.EventHandler(this.buttonCloseCompras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Folio";
            // 
            // boxFolio
            // 
            this.boxFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxFolio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFolio.ForeColor = System.Drawing.Color.White;
            this.boxFolio.Location = new System.Drawing.Point(147, 43);
            this.boxFolio.Multiline = true;
            this.boxFolio.Name = "boxFolio";
            this.boxFolio.Size = new System.Drawing.Size(205, 30);
            this.boxFolio.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cantidad";
            // 
            // boxCant
            // 
            this.boxCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxCant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCant.ForeColor = System.Drawing.Color.White;
            this.boxCant.Location = new System.Drawing.Point(147, 194);
            this.boxCant.Multiline = true;
            this.boxCant.Name = "boxCant";
            this.boxCant.Size = new System.Drawing.Size(205, 30);
            this.boxCant.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha";
            // 
            // boxFecha
            // 
            this.boxFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFecha.ForeColor = System.Drawing.Color.White;
            this.boxFecha.Location = new System.Drawing.Point(147, 245);
            this.boxFecha.Multiline = true;
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(205, 30);
            this.boxFecha.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Precio";
            // 
            // BoxPrecio
            // 
            this.BoxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.BoxPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPrecio.ForeColor = System.Drawing.Color.White;
            this.BoxPrecio.Location = new System.Drawing.Point(147, 299);
            this.BoxPrecio.Multiline = true;
            this.BoxPrecio.Name = "BoxPrecio";
            this.BoxPrecio.Size = new System.Drawing.Size(205, 30);
            this.BoxPrecio.TabIndex = 40;
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
            this.buttonLimpar.Location = new System.Drawing.Point(19, 375);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(113, 34);
            this.buttonLimpar.TabIndex = 41;
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
            this.buttonAgregar.Location = new System.Drawing.Point(218, 375);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(134, 34);
            this.buttonAgregar.TabIndex = 42;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            this.buttonAgregar.MouseEnter += new System.EventHandler(this.buttonAgregar_MouseEnter);
            this.buttonAgregar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.comboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxProducto.ForeColor = System.Drawing.Color.White;
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(147, 147);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(205, 28);
            this.comboBoxProducto.TabIndex = 45;
            this.comboBoxProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // comboBoxProveedores
            // 
            this.comboBoxProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.comboBoxProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxProveedores.ForeColor = System.Drawing.Color.White;
            this.comboBoxProveedores.FormattingEnabled = true;
            this.comboBoxProveedores.Location = new System.Drawing.Point(147, 96);
            this.comboBoxProveedores.Name = "comboBoxProveedores";
            this.comboBoxProveedores.Size = new System.Drawing.Size(205, 28);
            this.comboBoxProveedores.TabIndex = 46;
            // 
            // FormularioCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(375, 429);
            this.Controls.Add(this.comboBoxProveedores);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.BoxPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFolio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNavCompras);
            this.Name = "FormularioCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCompras";
            this.panelNavCompras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelNavCompras;
        private FontAwesome.Sharp.IconButton buttonCloseCompras;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox boxFolio;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox boxCant;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox boxFecha;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox BoxPrecio;
        private FontAwesome.Sharp.IconButton buttonLimpar;
        public FontAwesome.Sharp.IconButton buttonAgregar;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.ComboBox comboBoxProveedores;
    }
}