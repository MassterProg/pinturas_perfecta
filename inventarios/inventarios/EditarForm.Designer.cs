
namespace inventarios
{
    partial class EditarForm
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
            this.Boxid = new System.Windows.Forms.TextBox();
            this.Boxemail = new System.Windows.Forms.TextBox();
            this.Boxpei = new System.Windows.Forms.TextBox();
            this.Boxnom = new System.Windows.Forms.TextBox();
            this.Boxdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boxid
            // 
            this.Boxid.Location = new System.Drawing.Point(257, 12);
            this.Boxid.Name = "Boxid";
            this.Boxid.Size = new System.Drawing.Size(280, 20);
            this.Boxid.TabIndex = 0;
            // 
            // Boxemail
            // 
            this.Boxemail.Location = new System.Drawing.Point(257, 139);
            this.Boxemail.Name = "Boxemail";
            this.Boxemail.Size = new System.Drawing.Size(280, 20);
            this.Boxemail.TabIndex = 1;
            // 
            // Boxpei
            // 
            this.Boxpei.Location = new System.Drawing.Point(257, 97);
            this.Boxpei.Name = "Boxpei";
            this.Boxpei.Size = new System.Drawing.Size(280, 20);
            this.Boxpei.TabIndex = 2;
            // 
            // Boxnom
            // 
            this.Boxnom.Location = new System.Drawing.Point(257, 59);
            this.Boxnom.Name = "Boxnom";
            this.Boxnom.Size = new System.Drawing.Size(280, 20);
            this.Boxnom.TabIndex = 3;
            // 
            // Boxdir
            // 
            this.Boxdir.Location = new System.Drawing.Point(257, 180);
            this.Boxdir.Name = "Boxdir";
            this.Boxdir.Size = new System.Drawing.Size(280, 20);
            this.Boxdir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "apeido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "email";
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boxdir);
            this.Controls.Add(this.Boxnom);
            this.Controls.Add(this.Boxpei);
            this.Controls.Add(this.Boxemail);
            this.Controls.Add(this.Boxid);
            this.Name = "EditarForm";
            this.Text = "EditarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Boxid;
        public System.Windows.Forms.TextBox Boxemail;
        public System.Windows.Forms.TextBox Boxpei;
        public System.Windows.Forms.TextBox Boxnom;
        public System.Windows.Forms.TextBox Boxdir;
    }
}