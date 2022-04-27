
namespace Birliktelik_Odev
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekmek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icecek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yumurta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFrekans = new System.Windows.Forms.Button();
            this.btnEsikDestek = new System.Windows.Forms.Button();
            this.lstDestekDegerler = new System.Windows.Forms.ListBox();
            this.lblEsikDestekSonuc = new System.Windows.Forms.Label();
            this.lstEsikYeniTablo = new System.Windows.Forms.ListBox();
            this.btnYeniTablo = new System.Windows.Forms.Button();
            this.lstIkiliGrup = new System.Windows.Forms.ListBox();
            this.btnIkiliGrup = new System.Windows.Forms.Button();
            this.btnUcluGrup = new System.Windows.Forms.Button();
            this.lstUcluGrup = new System.Windows.Forms.ListBox();
            this.lstYeniTablo2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fisNo,
            this.ekmek,
            this.sut,
            this.icecek,
            this.kola,
            this.yumurta,
            this.bez});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // fisNo
            // 
            this.fisNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fisNo.HeaderText = "Fiş No";
            this.fisNo.MinimumWidth = 6;
            this.fisNo.Name = "fisNo";
            this.fisNo.Width = 125;
            // 
            // ekmek
            // 
            this.ekmek.HeaderText = "Ekmek";
            this.ekmek.MinimumWidth = 6;
            this.ekmek.Name = "ekmek";
            this.ekmek.Width = 125;
            // 
            // sut
            // 
            this.sut.HeaderText = "Süt";
            this.sut.MinimumWidth = 6;
            this.sut.Name = "sut";
            this.sut.Width = 125;
            // 
            // icecek
            // 
            this.icecek.HeaderText = "İçecek";
            this.icecek.MinimumWidth = 6;
            this.icecek.Name = "icecek";
            this.icecek.Width = 125;
            // 
            // kola
            // 
            this.kola.HeaderText = "Kola";
            this.kola.MinimumWidth = 6;
            this.kola.Name = "kola";
            this.kola.Width = 125;
            // 
            // yumurta
            // 
            this.yumurta.HeaderText = "Yumurta";
            this.yumurta.MinimumWidth = 6;
            this.yumurta.Name = "yumurta";
            this.yumurta.Width = 125;
            // 
            // bez
            // 
            this.bez.HeaderText = "Bez";
            this.bez.MinimumWidth = 6;
            this.bez.Name = "bez";
            this.bez.Width = 125;
            // 
            // btnFrekans
            // 
            this.btnFrekans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrekans.Location = new System.Drawing.Point(12, 312);
            this.btnFrekans.Name = "btnFrekans";
            this.btnFrekans.Size = new System.Drawing.Size(315, 67);
            this.btnFrekans.TabIndex = 1;
            this.btnFrekans.Text = "1-Ürün Destek Değer (Frekans) Hesapla";
            this.btnFrekans.UseVisualStyleBackColor = true;
            this.btnFrekans.Click += new System.EventHandler(this.btnFrekans_Click);
            // 
            // btnEsikDestek
            // 
            this.btnEsikDestek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsikDestek.Location = new System.Drawing.Point(364, 312);
            this.btnEsikDestek.Name = "btnEsikDestek";
            this.btnEsikDestek.Size = new System.Drawing.Size(234, 67);
            this.btnEsikDestek.TabIndex = 2;
            this.btnEsikDestek.Text = "2-Eşik Destek Sayısı Hesapla";
            this.btnEsikDestek.UseVisualStyleBackColor = true;
            this.btnEsikDestek.Click += new System.EventHandler(this.btnEsikDestek_Click);
            // 
            // lstDestekDegerler
            // 
            this.lstDestekDegerler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDestekDegerler.FormattingEnabled = true;
            this.lstDestekDegerler.ItemHeight = 25;
            this.lstDestekDegerler.Location = new System.Drawing.Point(12, 416);
            this.lstDestekDegerler.Name = "lstDestekDegerler";
            this.lstDestekDegerler.Size = new System.Drawing.Size(315, 154);
            this.lstDestekDegerler.TabIndex = 4;
            this.lstDestekDegerler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblEsikDestekSonuc
            // 
            this.lblEsikDestekSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsikDestekSonuc.Location = new System.Drawing.Point(397, 466);
            this.lblEsikDestekSonuc.Name = "lblEsikDestekSonuc";
            this.lblEsikDestekSonuc.Size = new System.Drawing.Size(164, 49);
            this.lblEsikDestekSonuc.TabIndex = 5;
            this.lblEsikDestekSonuc.Text = "HESAPLA";
            // 
            // lstEsikYeniTablo
            // 
            this.lstEsikYeniTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstEsikYeniTablo.FormattingEnabled = true;
            this.lstEsikYeniTablo.ItemHeight = 25;
            this.lstEsikYeniTablo.Location = new System.Drawing.Point(630, 416);
            this.lstEsikYeniTablo.Name = "lstEsikYeniTablo";
            this.lstEsikYeniTablo.Size = new System.Drawing.Size(328, 154);
            this.lstEsikYeniTablo.TabIndex = 6;
            // 
            // btnYeniTablo
            // 
            this.btnYeniTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniTablo.Location = new System.Drawing.Point(630, 312);
            this.btnYeniTablo.Name = "btnYeniTablo";
            this.btnYeniTablo.Size = new System.Drawing.Size(328, 67);
            this.btnYeniTablo.TabIndex = 7;
            this.btnYeniTablo.Text = "3-Yeni Tablo";
            this.btnYeniTablo.UseVisualStyleBackColor = true;
            this.btnYeniTablo.Click += new System.EventHandler(this.btnYeniTablo_Click);
            // 
            // lstIkiliGrup
            // 
            this.lstIkiliGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstIkiliGrup.FormattingEnabled = true;
            this.lstIkiliGrup.ItemHeight = 25;
            this.lstIkiliGrup.Location = new System.Drawing.Point(991, 416);
            this.lstIkiliGrup.Name = "lstIkiliGrup";
            this.lstIkiliGrup.Size = new System.Drawing.Size(322, 154);
            this.lstIkiliGrup.TabIndex = 8;
            // 
            // btnIkiliGrup
            // 
            this.btnIkiliGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIkiliGrup.Location = new System.Drawing.Point(991, 312);
            this.btnIkiliGrup.Name = "btnIkiliGrup";
            this.btnIkiliGrup.Size = new System.Drawing.Size(322, 67);
            this.btnIkiliGrup.TabIndex = 9;
            this.btnIkiliGrup.Text = "4-İkili Grup Destek Sayısı Hesapla";
            this.btnIkiliGrup.UseVisualStyleBackColor = true;
            this.btnIkiliGrup.Click += new System.EventHandler(this.btnIkiliGrup_Click);
            // 
            // btnUcluGrup
            // 
            this.btnUcluGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcluGrup.Location = new System.Drawing.Point(12, 617);
            this.btnUcluGrup.Name = "btnUcluGrup";
            this.btnUcluGrup.Size = new System.Drawing.Size(322, 67);
            this.btnUcluGrup.TabIndex = 11;
            this.btnUcluGrup.Text = "5-Üçlü Grup Destek Sayısı Hesapla";
            this.btnUcluGrup.UseVisualStyleBackColor = true;
            // 
            // lstUcluGrup
            // 
            this.lstUcluGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUcluGrup.FormattingEnabled = true;
            this.lstUcluGrup.ItemHeight = 25;
            this.lstUcluGrup.Location = new System.Drawing.Point(12, 703);
            this.lstUcluGrup.Name = "lstUcluGrup";
            this.lstUcluGrup.Size = new System.Drawing.Size(322, 154);
            this.lstUcluGrup.TabIndex = 10;
            // 
            // lstYeniTablo2
            // 
            this.lstYeniTablo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstYeniTablo2.FormattingEnabled = true;
            this.lstYeniTablo2.ItemHeight = 25;
            this.lstYeniTablo2.Location = new System.Drawing.Point(997, 683);
            this.lstYeniTablo2.Name = "lstYeniTablo2";
            this.lstYeniTablo2.Size = new System.Drawing.Size(328, 154);
            this.lstYeniTablo2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(991, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "İKİLİ GRUP YENİ TABLO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1344, 1001);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYeniTablo2);
            this.Controls.Add(this.btnUcluGrup);
            this.Controls.Add(this.lstUcluGrup);
            this.Controls.Add(this.btnIkiliGrup);
            this.Controls.Add(this.lstIkiliGrup);
            this.Controls.Add(this.btnYeniTablo);
            this.Controls.Add(this.lstEsikYeniTablo);
            this.Controls.Add(this.lblEsikDestekSonuc);
            this.Controls.Add(this.lstDestekDegerler);
            this.Controls.Add(this.btnEsikDestek);
            this.Controls.Add(this.btnFrekans);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = ">>";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFrekans;
        private System.Windows.Forms.Button btnEsikDestek;
        private System.Windows.Forms.ListBox lstDestekDegerler;
        private System.Windows.Forms.Label lblEsikDestekSonuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekmek;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut;
        private System.Windows.Forms.DataGridViewTextBoxColumn icecek;
        private System.Windows.Forms.DataGridViewTextBoxColumn kola;
        private System.Windows.Forms.DataGridViewTextBoxColumn yumurta;
        private System.Windows.Forms.DataGridViewTextBoxColumn bez;
        private System.Windows.Forms.ListBox lstEsikYeniTablo;
        private System.Windows.Forms.Button btnYeniTablo;
        private System.Windows.Forms.ListBox lstIkiliGrup;
        private System.Windows.Forms.Button btnIkiliGrup;
        private System.Windows.Forms.Button btnUcluGrup;
        private System.Windows.Forms.ListBox lstUcluGrup;
        private System.Windows.Forms.ListBox lstYeniTablo2;
        private System.Windows.Forms.Label label1;
    }
}

