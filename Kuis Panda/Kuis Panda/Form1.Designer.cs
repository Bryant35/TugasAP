
namespace Kuis_Panda
{
    partial class FormQuizPanda
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
            this.labelKalimat = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.labelHuruf1 = new System.Windows.Forms.Label();
            this.textBoxHuruf1 = new System.Windows.Forms.TextBox();
            this.labelUbah = new System.Windows.Forms.Label();
            this.textBoxUbah = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelHasill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKalimat.Location = new System.Drawing.Point(33, 54);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(138, 20);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxKalimat.Location = new System.Drawing.Point(183, 51);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(511, 26);
            this.textBoxKalimat.TabIndex = 1;
            this.textBoxKalimat.TextChanged += new System.EventHandler(this.textBoxKalimat_TextChanged);
            this.textBoxKalimat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKalimat_KeyDown);
            this.textBoxKalimat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxKalimat_MouseDown);
            // 
            // labelHuruf1
            // 
            this.labelHuruf1.AutoSize = true;
            this.labelHuruf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHuruf1.Location = new System.Drawing.Point(33, 142);
            this.labelHuruf1.Name = "labelHuruf1";
            this.labelHuruf1.Size = new System.Drawing.Size(126, 20);
            this.labelHuruf1.TabIndex = 2;
            this.labelHuruf1.Text = "Masukkan Huruf";
            // 
            // textBoxHuruf1
            // 
            this.textBoxHuruf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxHuruf1.Location = new System.Drawing.Point(183, 139);
            this.textBoxHuruf1.Name = "textBoxHuruf1";
            this.textBoxHuruf1.Size = new System.Drawing.Size(179, 26);
            this.textBoxHuruf1.TabIndex = 3;
            this.textBoxHuruf1.TextChanged += new System.EventHandler(this.textBoxHuruf1_TextChanged);
            this.textBoxHuruf1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHuruf1_KeyDown);
            // 
            // labelUbah
            // 
            this.labelUbah.AutoSize = true;
            this.labelUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUbah.Location = new System.Drawing.Point(407, 142);
            this.labelUbah.Name = "labelUbah";
            this.labelUbah.Size = new System.Drawing.Size(64, 20);
            this.labelUbah.TabIndex = 4;
            this.labelUbah.Text = "Menjadi";
            // 
            // textBoxUbah
            // 
            this.textBoxUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUbah.Location = new System.Drawing.Point(508, 139);
            this.textBoxUbah.Name = "textBoxUbah";
            this.textBoxUbah.Size = new System.Drawing.Size(186, 26);
            this.textBoxUbah.TabIndex = 5;
            this.textBoxUbah.TextChanged += new System.EventHandler(this.textBoxUbah_TextChanged);
            this.textBoxUbah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUbah_KeyDown);
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonKonversi.Location = new System.Drawing.Point(183, 226);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(511, 29);
            this.buttonKonversi.TabIndex = 6;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            this.buttonKonversi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonKonversi_KeyDown);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHasil.Location = new System.Drawing.Point(33, 316);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(52, 20);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil :";
            // 
            // labelHasill
            // 
            this.labelHasill.AutoSize = true;
            this.labelHasill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHasill.Location = new System.Drawing.Point(179, 316);
            this.labelHasill.Name = "labelHasill";
            this.labelHasill.Size = new System.Drawing.Size(44, 20);
            this.labelHasill.TabIndex = 8;
            this.labelHasill.Text = "Hasil";
            this.labelHasill.Click += new System.EventHandler(this.labelHasill_Click);
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHasill);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxUbah);
            this.Controls.Add(this.labelUbah);
            this.Controls.Add(this.textBoxHuruf1);
            this.Controls.Add(this.labelHuruf1);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.labelKalimat);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.Load += new System.EventHandler(this.FormQuizPanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.Label labelHuruf1;
        private System.Windows.Forms.TextBox textBoxHuruf1;
        private System.Windows.Forms.Label labelUbah;
        private System.Windows.Forms.TextBox textBoxUbah;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelHasill;
    }
}

