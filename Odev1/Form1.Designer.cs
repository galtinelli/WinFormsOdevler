
namespace Odev1
{
    partial class Form1
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
            this.txtSayiGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.btnEkranaYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayiGiris
            // 
            this.txtSayiGiris.Location = new System.Drawing.Point(26, 32);
            this.txtSayiGiris.Name = "txtSayiGiris";
            this.txtSayiGiris.Size = new System.Drawing.Size(253, 20);
            this.txtSayiGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Sayı Girişi Yapınız";
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(85, 58);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(135, 43);
            this.btnElemanEkle.TabIndex = 2;
            this.btnElemanEkle.Text = "Eleman Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // btnEkranaYaz
            // 
            this.btnEkranaYaz.Location = new System.Drawing.Point(85, 118);
            this.btnEkranaYaz.Name = "btnEkranaYaz";
            this.btnEkranaYaz.Size = new System.Drawing.Size(135, 36);
            this.btnEkranaYaz.TabIndex = 4;
            this.btnEkranaYaz.Text = "Ekrana Yazdır";
            this.btnEkranaYaz.UseVisualStyleBackColor = true;
            this.btnEkranaYaz.Click += new System.EventHandler(this.btnEkranaYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 163);
            this.Controls.Add(this.btnEkranaYaz);
            this.Controls.Add(this.btnElemanEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayiGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayiGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.Button btnEkranaYaz;
    }
}

