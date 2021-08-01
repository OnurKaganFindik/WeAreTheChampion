
namespace WeAreTheChampion.UI
{
    partial class KarsilasmaForm
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
            this.cbTakim1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTakim2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.cbSonuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbTakim1
            // 
            this.cbTakim1.FormattingEnabled = true;
            this.cbTakim1.Location = new System.Drawing.Point(101, 6);
            this.cbTakim1.Name = "cbTakim1";
            this.cbTakim1.Size = new System.Drawing.Size(242, 28);
            this.cbTakim1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Takım 1 :";
            // 
            // cbTakim2
            // 
            this.cbTakim2.FormattingEnabled = true;
            this.cbTakim2.Location = new System.Drawing.Point(101, 41);
            this.cbTakim2.Name = "cbTakim2";
            this.cbTakim2.Size = new System.Drawing.Size(242, 28);
            this.cbTakim2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Takım 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarihi      :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(101, 77);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(242, 26);
            this.dtpTarih.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Red;
            this.btnEkle.Location = new System.Drawing.Point(16, 184);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(327, 54);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Karşılaşma Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saat       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sonuc    :";
            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(101, 112);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpSaat.Size = new System.Drawing.Size(242, 26);
            this.dtpSaat.TabIndex = 4;
            // 
            // cbSonuc
            // 
            this.cbSonuc.FormattingEnabled = true;
            this.cbSonuc.Location = new System.Drawing.Point(101, 145);
            this.cbSonuc.Name = "cbSonuc";
            this.cbSonuc.Size = new System.Drawing.Size(242, 28);
            this.cbSonuc.TabIndex = 0;
            // 
            // KarsilasmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 253);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSonuc);
            this.Controls.Add(this.cbTakim2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTakim1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KarsilasmaForm";
            this.Text = "Yeni Karşılaşma Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTakim1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTakim2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.ComboBox cbSonuc;
    }
}