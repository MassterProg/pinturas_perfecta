﻿namespace PinturasPerfecta
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCargar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonModificar = new FontAwesome.Sharp.IconButton();
            this.buttonElimnar = new FontAwesome.Sharp.IconButton();
            this.buttonAgregar = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 22);
            this.panel2.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCargar.FlatAppearance.BorderSize = 0;
            this.buttonCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.buttonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.ForeColor = System.Drawing.Color.White;
            this.buttonCargar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.buttonCargar.IconColor = System.Drawing.Color.White;
            this.buttonCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCargar.IconSize = 40;
            this.buttonCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCargar.Location = new System.Drawing.Point(0, 368);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(204, 60);
            this.buttonCargar.TabIndex = 5;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Controls.Add(this.buttonElimnar);
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonCargar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(796, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 428);
            this.panel1.TabIndex = 3;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.buttonModificar.IconColor = System.Drawing.Color.White;
            this.buttonModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonModificar.IconSize = 40;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(0, 153);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(204, 60);
            this.buttonModificar.TabIndex = 19;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonElimnar
            // 
            this.buttonElimnar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonElimnar.FlatAppearance.BorderSize = 0;
            this.buttonElimnar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.buttonElimnar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimnar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElimnar.ForeColor = System.Drawing.Color.White;
            this.buttonElimnar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.buttonElimnar.IconColor = System.Drawing.Color.White;
            this.buttonElimnar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonElimnar.IconSize = 40;
            this.buttonElimnar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonElimnar.Location = new System.Drawing.Point(0, 93);
            this.buttonElimnar.Name = "buttonElimnar";
            this.buttonElimnar.Size = new System.Drawing.Size(204, 60);
            this.buttonElimnar.TabIndex = 18;
            this.buttonElimnar.Text = "Eliminar";
            this.buttonElimnar.UseVisualStyleBackColor = true;
            this.buttonElimnar.Click += new System.EventHandler(this.buttonElimnar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAgregar.IconColor = System.Drawing.Color.White;
            this.buttonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAgregar.IconSize = 40;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.Location = new System.Drawing.Point(0, 33);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(204, 60);
            this.buttonAgregar.TabIndex = 17;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 33);
            this.panel5.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxBuscar);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 35);
            this.panel3.TabIndex = 15;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.ForeColor = System.Drawing.Color.Cyan;
            this.textBoxBuscar.Location = new System.Drawing.Point(43, 0);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(161, 30);
            this.textBoxBuscar.TabIndex = 28;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(43, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 5);
            this.panel6.TabIndex = 27;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Cyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 35);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(796, 10);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.OrangeRed;
            this.dataGridView1.Location = new System.Drawing.Point(0, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(796, 418);
            this.dataGridView1.TabIndex = 5;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton buttonModificar;
        private FontAwesome.Sharp.IconButton buttonElimnar;
        private FontAwesome.Sharp.IconButton buttonAgregar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}