
namespace WeAreTheChampion.UI
{
    partial class AnaForm
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTakimlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenkler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            this.dgvAnaform = new System.Windows.Forms.DataGridView();
            this.takim1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takim2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaform)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTakimlar,
            this.tsmiRenkler,
            this.tsmiOyuncular});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTakimlar
            // 
            this.tsmiTakimlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmiTakimlar.ForeColor = System.Drawing.Color.Red;
            this.tsmiTakimlar.Name = "tsmiTakimlar";
            this.tsmiTakimlar.Size = new System.Drawing.Size(114, 24);
            this.tsmiTakimlar.Text = "Takımlar    |";
            this.tsmiTakimlar.Click += new System.EventHandler(this.tsmiTakimlar_Click);
            // 
            // tsmiRenkler
            // 
            this.tsmiRenkler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmiRenkler.ForeColor = System.Drawing.Color.Red;
            this.tsmiRenkler.Name = "tsmiRenkler";
            this.tsmiRenkler.Size = new System.Drawing.Size(109, 24);
            this.tsmiRenkler.Text = "Renkler    |";
            this.tsmiRenkler.Click += new System.EventHandler(this.tsmiRenkler_Click);
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmiOyuncular.ForeColor = System.Drawing.Color.Red;
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(101, 24);
            this.tsmiOyuncular.Text = "Oyuncular";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniKarsilasma);
            this.groupBox1.Controls.Add(this.dgvAnaform);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karşılaşmalar";
            // 
            // btnYeniKarsilasma
            // 
            this.btnYeniKarsilasma.Location = new System.Drawing.Point(467, 0);
            this.btnYeniKarsilasma.Name = "btnYeniKarsilasma";
            this.btnYeniKarsilasma.Size = new System.Drawing.Size(237, 39);
            this.btnYeniKarsilasma.TabIndex = 1;
            this.btnYeniKarsilasma.Text = "+ Yeni Karşılaşma";
            this.btnYeniKarsilasma.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasma.Click += new System.EventHandler(this.btnYeniKarsilasma_Click);
            // 
            // dgvAnaform
            // 
            this.dgvAnaform.AllowUserToOrderColumns = true;
            this.dgvAnaform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnaform.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takim1,
            this.takim2,
            this.tarih,
            this.saat,
            this.sonuc});
            this.dgvAnaform.Location = new System.Drawing.Point(6, 45);
            this.dgvAnaform.Name = "dgvAnaform";
            this.dgvAnaform.RowHeadersWidth = 50;
            this.dgvAnaform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAnaform.Size = new System.Drawing.Size(696, 334);
            this.dgvAnaform.TabIndex = 0;
            // 
            // takim1
            // 
            this.takim1.FillWeight = 150F;
            this.takim1.HeaderText = "Takım 1";
            this.takim1.Name = "takim1";
            this.takim1.Width = 150;
            // 
            // takim2
            // 
            this.takim2.FillWeight = 150F;
            this.takim2.HeaderText = "Takım 2";
            this.takim2.Name = "takim2";
            this.takim2.Width = 150;
            // 
            // tarih
            // 
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            // 
            // saat
            // 
            this.saat.FillWeight = 50F;
            this.saat.HeaderText = "Saat";
            this.saat.Name = "saat";
            this.saat.Width = 50;
            // 
            // sonuc
            // 
            this.sonuc.FillWeight = 20F;
            this.sonuc.HeaderText = "Sonuc";
            this.sonuc.Name = "sonuc";
            this.sonuc.Width = 20;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(27, 422);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(237, 39);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Seçiliyi Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(332, 422);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(237, 39);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Seçiliyi Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 480);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaForm";
            this.Text = "We Ara the Champions 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakimlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenkler;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYeniKarsilasma;
        private System.Windows.Forms.DataGridView dgvAnaform;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn takim1;
        private System.Windows.Forms.DataGridViewTextBoxColumn takim2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuc;
    }
}