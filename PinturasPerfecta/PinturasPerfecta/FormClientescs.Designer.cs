﻿namespace PinturasPerfecta
{
    partial class FormClientescs
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.buttonLimpar = new FontAwesome.Sharp.IconButton();
            this.buttonAgregar = new FontAwesome.Sharp.IconButton();
            this.boxDireccion = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxApellido = new System.Windows.Forms.TextBox();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(305, 31);
            this.panelNav.TabIndex = 25;
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
            this.buttonClose.Location = new System.Drawing.Point(278, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 25);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
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
            this.buttonLimpar.Location = new System.Drawing.Point(20, 286);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(113, 34);
            this.buttonLimpar.TabIndex = 24;
            this.buttonLimpar.Text = "Limpiar";
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            this.buttonLimpar.MouseEnter += new System.EventHandler(this.buttonAgregar_MouseEnter);
            this.buttonLimpar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
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
            this.buttonAgregar.Location = new System.Drawing.Point(159, 286);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(134, 34);
            this.buttonAgregar.TabIndex = 23;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            this.buttonAgregar.MouseEnter += new System.EventHandler(this.buttonAgregar_MouseEnter);
            this.buttonAgregar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
            // 
            // boxDireccion
            // 
            this.boxDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDireccion.ForeColor = System.Drawing.Color.White;
            this.boxDireccion.Location = new System.Drawing.Point(118, 206);
            this.boxDireccion.Multiline = true;
            this.boxDireccion.Name = "boxDireccion";
            this.boxDireccion.Size = new System.Drawing.Size(175, 30);
            this.boxDireccion.TabIndex = 22;
            // 
            // boxEmail
            // 
            this.boxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEmail.ForeColor = System.Drawing.Color.White;
            this.boxEmail.Location = new System.Drawing.Point(118, 168);
            this.boxEmail.Multiline = true;
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(175, 30);
            this.boxEmail.TabIndex = 20;
            // 
            // boxApellido
            // 
            this.boxApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxApellido.ForeColor = System.Drawing.Color.White;
            this.boxApellido.Location = new System.Drawing.Point(118, 130);
            this.boxApellido.Multiline = true;
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Size = new System.Drawing.Size(175, 30);
            this.boxApellido.TabIndex = 19;
            // 
            // boxNombre
            // 
            this.boxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNombre.ForeColor = System.Drawing.Color.White;
            this.boxNombre.Location = new System.Drawing.Point(118, 92);
            this.boxNombre.Multiline = true;
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(175, 30);
            this.boxNombre.TabIndex = 18;
            // 
            // boxID
            // 
            this.boxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.boxID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxID.ForeColor = System.Drawing.Color.White;
            this.boxID.Location = new System.Drawing.Point(118, 54);
            this.boxID.Multiline = true;
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(175, 30);
            this.boxID.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "idCliente";
            // 
            // FormClientescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(305, 339);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.boxDireccion);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxApellido);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClientescs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientescs";
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelNav;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton buttonLimpar;
        public FontAwesome.Sharp.IconButton buttonAgregar;
        public System.Windows.Forms.TextBox boxDireccion;
        public System.Windows.Forms.TextBox boxEmail;
        public System.Windows.Forms.TextBox boxApellido;
        public System.Windows.Forms.TextBox boxNombre;
        public System.Windows.Forms.TextBox boxID;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}