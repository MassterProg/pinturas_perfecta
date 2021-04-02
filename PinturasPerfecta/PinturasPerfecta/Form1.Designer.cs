namespace PinturasPerfecta
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.ButtonVentas = new FontAwesome.Sharp.IconButton();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.ButtonCompras = new FontAwesome.Sharp.IconButton();
            this.ButtonProductos = new FontAwesome.Sharp.IconButton();
            this.ButtonClientes = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonMin = new FontAwesome.Sharp.IconButton();
            this.buttonMax = new FontAwesome.Sharp.IconButton();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.HomeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.PanelDeEscritorio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.PanelDeEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.LabelFecha);
            this.panelMenu.Controls.Add(this.ButtonVentas);
            this.panelMenu.Controls.Add(this.labelTiempo);
            this.panelMenu.Controls.Add(this.ButtonCompras);
            this.panelMenu.Controls.Add(this.ButtonProductos);
            this.panelMenu.Controls.Add(this.ButtonClientes);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 596);
            this.panelMenu.TabIndex = 0;
            // 
            // LabelFecha
            // 
            this.LabelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFecha.ForeColor = System.Drawing.Color.White;
            this.LabelFecha.Location = new System.Drawing.Point(84, 566);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(42, 16);
            this.LabelFecha.TabIndex = 10;
            this.LabelFecha.Text = "Fecha";
            this.LabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFecha.Visible = false;
            // 
            // ButtonVentas
            // 
            this.ButtonVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonVentas.FlatAppearance.BorderSize = 0;
            this.ButtonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVentas.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ButtonVentas.IconColor = System.Drawing.Color.White;
            this.ButtonVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonVentas.IconSize = 40;
            this.ButtonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonVentas.Location = new System.Drawing.Point(0, 280);
            this.ButtonVentas.Name = "ButtonVentas";
            this.ButtonVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonVentas.Size = new System.Drawing.Size(221, 60);
            this.ButtonVentas.TabIndex = 9;
            this.ButtonVentas.Text = "Ventas";
            this.ButtonVentas.UseVisualStyleBackColor = true;
            this.ButtonVentas.Click += new System.EventHandler(this.ButtonVentas_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.ForeColor = System.Drawing.Color.White;
            this.labelTiempo.Location = new System.Drawing.Point(8, 566);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(70, 21);
            this.labelTiempo.TabIndex = 2;
            this.labelTiempo.Text = "2:09:26";
            this.labelTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCompras
            // 
            this.ButtonCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCompras.FlatAppearance.BorderSize = 0;
            this.ButtonCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCompras.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCompras.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.ButtonCompras.IconColor = System.Drawing.Color.White;
            this.ButtonCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCompras.IconSize = 40;
            this.ButtonCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCompras.Location = new System.Drawing.Point(0, 220);
            this.ButtonCompras.Name = "ButtonCompras";
            this.ButtonCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonCompras.Size = new System.Drawing.Size(221, 60);
            this.ButtonCompras.TabIndex = 8;
            this.ButtonCompras.Text = "Compras";
            this.ButtonCompras.UseVisualStyleBackColor = true;
            this.ButtonCompras.Click += new System.EventHandler(this.ButtonCompras_Click);
            // 
            // ButtonProductos
            // 
            this.ButtonProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonProductos.FlatAppearance.BorderSize = 0;
            this.ButtonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProductos.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonProductos.IconChar = FontAwesome.Sharp.IconChar.SprayCan;
            this.ButtonProductos.IconColor = System.Drawing.Color.White;
            this.ButtonProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonProductos.IconSize = 40;
            this.ButtonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProductos.Location = new System.Drawing.Point(0, 160);
            this.ButtonProductos.Name = "ButtonProductos";
            this.ButtonProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonProductos.Size = new System.Drawing.Size(221, 60);
            this.ButtonProductos.TabIndex = 7;
            this.ButtonProductos.Text = "Productos";
            this.ButtonProductos.UseVisualStyleBackColor = true;
            this.ButtonProductos.Click += new System.EventHandler(this.ButtonProductos_Click);
            // 
            // ButtonClientes
            // 
            this.ButtonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonClientes.FlatAppearance.BorderSize = 0;
            this.ButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClientes.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ButtonClientes.IconColor = System.Drawing.Color.White;
            this.ButtonClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonClientes.IconSize = 40;
            this.ButtonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClientes.Location = new System.Drawing.Point(0, 100);
            this.ButtonClientes.Name = "ButtonClientes";
            this.ButtonClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonClientes.Size = new System.Drawing.Size(221, 60);
            this.ButtonClientes.TabIndex = 6;
            this.ButtonClientes.Text = "Clientes";
            this.ButtonClientes.UseVisualStyleBackColor = true;
            this.ButtonClientes.Click += new System.EventHandler(this.ButtonClientes_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 100);
            this.panel3.TabIndex = 2;
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Image = global::PinturasPerfecta.Properties.Resources.logo_arón;
            this.buttonHome.Location = new System.Drawing.Point(12, 28);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(186, 57);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 0;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelNav.Controls.Add(this.buttonMin);
            this.panelNav.Controls.Add(this.buttonMax);
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Controls.Add(this.currentPositionLabel);
            this.panelNav.Controls.Add(this.HomeIcon);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(221, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(986, 44);
            this.panelNav.TabIndex = 1;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMin.IconColor = System.Drawing.Color.White;
            this.buttonMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMin.IconSize = 25;
            this.buttonMin.Location = new System.Drawing.Point(898, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(26, 22);
            this.buttonMin.TabIndex = 5;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonMax.IconColor = System.Drawing.Color.White;
            this.buttonMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMax.IconSize = 25;
            this.buttonMax.Location = new System.Drawing.Point(930, 0);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(24, 25);
            this.buttonMax.TabIndex = 4;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.buttonClose.Location = new System.Drawing.Point(960, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 25);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.AutoSize = true;
            this.currentPositionLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPositionLabel.ForeColor = System.Drawing.Color.White;
            this.currentPositionLabel.Location = new System.Drawing.Point(51, 9);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(56, 21);
            this.currentPositionLabel.TabIndex = 2;
            this.currentPositionLabel.Text = "Inicio";
            // 
            // HomeIcon
            // 
            this.HomeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.HomeIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeIcon.IconColor = System.Drawing.Color.White;
            this.HomeIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeIcon.IconSize = 38;
            this.HomeIcon.Location = new System.Drawing.Point(3, 3);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(42, 38);
            this.HomeIcon.TabIndex = 1;
            this.HomeIcon.TabStop = false;
            // 
            // PanelDeEscritorio
            // 
            this.PanelDeEscritorio.Controls.Add(this.pictureBox1);
            this.PanelDeEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeEscritorio.Location = new System.Drawing.Point(221, 44);
            this.PanelDeEscritorio.Name = "PanelDeEscritorio";
            this.PanelDeEscritorio.Size = new System.Drawing.Size(986, 552);
            this.PanelDeEscritorio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PinturasPerfecta.Properties.Resources.logo_arón__2;
            this.pictureBox1.Location = new System.Drawing.Point(345, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1207, 596);
            this.Controls.Add(this.PanelDeEscritorio);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.PanelDeEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox buttonHome;
        private FontAwesome.Sharp.IconButton ButtonVentas;
        private FontAwesome.Sharp.IconButton ButtonCompras;
        private FontAwesome.Sharp.IconButton ButtonProductos;
        private FontAwesome.Sharp.IconButton ButtonClientes;
        private FontAwesome.Sharp.IconPictureBox HomeIcon;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Panel PanelDeEscritorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton buttonMin;
        private FontAwesome.Sharp.IconButton buttonMax;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label LabelFecha;
    }
}

