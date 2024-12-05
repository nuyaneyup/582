namespace StokTakipProgramı582
{
    partial class frmSatısDetayaları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatısDetayaları));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdSatislar = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSatisToplam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSatisIptal);
            this.groupBox2.Controls.Add(this.grdSatilanUrunler);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(531, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 357);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış Detayları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "₺";
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Location = new System.Drawing.Point(256, 266);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSatisToplam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Satış Toplam Fiyatı : ";
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisIptal.Image")));
            this.btnSatisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisIptal.Location = new System.Drawing.Point(-1, 259);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(141, 32);
            this.btnSatisIptal.TabIndex = 2;
            this.btnSatisIptal.Text = "SATIŞI İPTAL ET";
            this.btnSatisIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.Location = new System.Drawing.Point(6, 88);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(367, 92);
            this.grdSatilanUrunler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATILAN ÜRÜNLER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdSatislar);
            this.groupBox1.Location = new System.Drawing.Point(68, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Listesi";
            // 
            // grdSatislar
            // 
            this.grdSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatislar.Location = new System.Drawing.Point(7, 20);
            this.grdSatislar.MultiSelect = false;
            this.grdSatislar.Name = "grdSatislar";
            this.grdSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSatislar.Size = new System.Drawing.Size(444, 331);
            this.grdSatislar.TabIndex = 0;
            // 
            // frmSatısDetayaları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSatısDetayaları";
            this.Text = "Satış Detayaları";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdSatislar;
    }
}