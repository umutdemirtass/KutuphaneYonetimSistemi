namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(306, 201);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(160, 37);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(306, 131);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(160, 23);
            this.textBoxSifre.TabIndex = 1;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // textBoxKullanıcıAdi
            // 
            this.textBoxKullanıcıAdi.Location = new System.Drawing.Point(306, 67);
            this.textBoxKullanıcıAdi.Name = "textBoxKullanıcıAdi";
            this.textBoxKullanıcıAdi.Size = new System.Drawing.Size(160, 23);
            this.textBoxKullanıcıAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(120, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(592, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKullanıcıAdi);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.buttonGiris);
            this.Name = "FormGiris";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxSifre;
        private TextBox textBoxKullanıcıAdi;
        private Label label1;
        private Label label2;
    }
}