namespace Kutuphane_EF_Core.Forms
{
    partial class Yazar_Kategori_KayitForm
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
            System.Windows.Forms.Button btnYayineviEkle;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.lstViewYayinevi = new System.Windows.Forms.ListView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKategoriListele = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.lstViewKategori = new System.Windows.Forms.ListView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnYayineviGüncelle = new System.Windows.Forms.Button();
            this.btnYayineviListele = new System.Windows.Forms.Button();
            this.btnYayineviSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            btnYayineviEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYayineviEkle
            // 
            btnYayineviEkle.BackColor = System.Drawing.SystemColors.HotTrack;
            btnYayineviEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnYayineviEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnYayineviEkle.ForeColor = System.Drawing.SystemColors.Window;
            btnYayineviEkle.Location = new System.Drawing.Point(3, 3);
            btnYayineviEkle.Name = "btnYayineviEkle";
            btnYayineviEkle.Size = new System.Drawing.Size(81, 23);
            btnYayineviEkle.TabIndex = 3;
            btnYayineviEkle.Text = "EKLE";
            btnYayineviEkle.UseVisualStyleBackColor = false;
            btnYayineviEkle.Click += new System.EventHandler(this.btnYayineviEkle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lstYazarlar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(435, 149);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtYazarSoyad, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtYazarAd, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(298, 143);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 14, 25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yazar Soyadı:";
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazarSoyad.Location = new System.Drawing.Point(136, 96);
            this.txtYazarSoyad.Margin = new System.Windows.Forms.Padding(15, 25, 15, 14);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(147, 23);
            this.txtYazarSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 25, 25, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar Adı :";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazarAd.Location = new System.Drawing.Point(136, 25);
            this.txtYazarAd.Margin = new System.Windows.Forms.Padding(15, 25, 15, 14);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(147, 23);
            this.txtYazarAd.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnListele, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnGuncelle, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnSil, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnEkle, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(307, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(125, 143);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListele.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListele.Location = new System.Drawing.Point(3, 108);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(119, 32);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuncelle.Location = new System.Drawing.Point(3, 73);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 29);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(3, 38);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 29);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEkle.Location = new System.Drawing.Point(3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(119, 29);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.ItemHeight = 15;
            this.lstYazarlar.Location = new System.Drawing.Point(3, 202);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(435, 239);
            this.lstYazarlar.TabIndex = 2;
            this.lstYazarlar.SelectedIndexChanged += new System.EventHandler(this.lstYazarlar_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yazar Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lstViewYayinevi, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lstViewKategori, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(450, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(361, 444);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(3, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Yayınevi Kayıt";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lstViewYayinevi
            // 
            this.lstViewYayinevi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewYayinevi.Location = new System.Drawing.Point(3, 348);
            this.lstViewYayinevi.Name = "lstViewYayinevi";
            this.lstViewYayinevi.Size = new System.Drawing.Size(355, 93);
            this.lstViewYayinevi.TabIndex = 6;
            this.lstViewYayinevi.UseCompatibleStateImageBehavior = false;
            this.lstViewYayinevi.SelectedIndexChanged += new System.EventHandler(this.lstViewYayinevi_SelectedIndexChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(355, 87);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtKategoriAd, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(349, 45);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(4, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 14, 25, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kategori Adı :";
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKategoriAd.Location = new System.Drawing.Point(132, 14);
            this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(10, 14, 25, 14);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(192, 23);
            this.txtKategoriAd.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Controls.Add(this.btnKategoriListele, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnKategoriGuncelle, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnKategoriSil, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnKategoriEkle, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(349, 30);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // btnKategoriListele
            // 
            this.btnKategoriListele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKategoriListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKategoriListele.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriListele.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKategoriListele.Location = new System.Drawing.Point(264, 3);
            this.btnKategoriListele.Name = "btnKategoriListele";
            this.btnKategoriListele.Size = new System.Drawing.Size(82, 24);
            this.btnKategoriListele.TabIndex = 3;
            this.btnKategoriListele.Text = "LİSTELE";
            this.btnKategoriListele.UseVisualStyleBackColor = false;
            this.btnKategoriListele.Click += new System.EventHandler(this.btnKategoriListele_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKategoriGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriGuncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(170, 3);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(88, 24);
            this.btnKategoriGuncelle.TabIndex = 2;
            this.btnKategoriGuncelle.Text = "GÜNCELLE";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKategoriSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKategoriSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKategoriSil.Location = new System.Drawing.Point(90, 3);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(74, 24);
            this.btnKategoriSil.TabIndex = 1;
            this.btnKategoriSil.Text = "SİL";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKategoriEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKategoriEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKategoriEkle.Location = new System.Drawing.Point(3, 3);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(81, 24);
            this.btnKategoriEkle.TabIndex = 0;
            this.btnKategoriEkle.Text = "EKLE";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // lstViewKategori
            // 
            this.lstViewKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewKategori.Location = new System.Drawing.Point(3, 127);
            this.lstViewKategori.Name = "lstViewKategori";
            this.lstViewKategori.Size = new System.Drawing.Size(355, 91);
            this.lstViewKategori.TabIndex = 3;
            this.lstViewKategori.UseCompatibleStateImageBehavior = false;
            this.lstViewKategori.SelectedIndexChanged += new System.EventHandler(this.lstViewKategori_SelectedIndexChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 255);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(355, 87);
            this.tableLayoutPanel10.TabIndex = 5;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel11.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.txtYayinevi, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(349, 46);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(4, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 14, 25, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yayınevi Adı:";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYayinevi.Location = new System.Drawing.Point(132, 14);
            this.txtYayinevi.Margin = new System.Windows.Forms.Padding(10, 14, 25, 14);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(192, 23);
            this.txtYayinevi.TabIndex = 4;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 4;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.Controls.Add(this.btnYayineviGüncelle, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnYayineviListele, 0, 0);
            this.tableLayoutPanel12.Controls.Add(btnYayineviEkle, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnYayineviSil, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(349, 29);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // btnYayineviGüncelle
            // 
            this.btnYayineviGüncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnYayineviGüncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYayineviGüncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYayineviGüncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYayineviGüncelle.Location = new System.Drawing.Point(177, 3);
            this.btnYayineviGüncelle.Name = "btnYayineviGüncelle";
            this.btnYayineviGüncelle.Size = new System.Drawing.Size(81, 23);
            this.btnYayineviGüncelle.TabIndex = 5;
            this.btnYayineviGüncelle.Text = "GÜNCELLE";
            this.btnYayineviGüncelle.UseVisualStyleBackColor = false;
            this.btnYayineviGüncelle.Click += new System.EventHandler(this.btnYayineviGüncelle_Click);
            // 
            // btnYayineviListele
            // 
            this.btnYayineviListele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnYayineviListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYayineviListele.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYayineviListele.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYayineviListele.Location = new System.Drawing.Point(264, 3);
            this.btnYayineviListele.Name = "btnYayineviListele";
            this.btnYayineviListele.Size = new System.Drawing.Size(82, 23);
            this.btnYayineviListele.TabIndex = 4;
            this.btnYayineviListele.Text = "LİSTELE";
            this.btnYayineviListele.UseVisualStyleBackColor = false;
            // 
            // btnYayineviSil
            // 
            this.btnYayineviSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnYayineviSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYayineviSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYayineviSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYayineviSil.Location = new System.Drawing.Point(90, 3);
            this.btnYayineviSil.Name = "btnYayineviSil";
            this.btnYayineviSil.Size = new System.Drawing.Size(81, 23);
            this.btnYayineviSil.TabIndex = 1;
            this.btnYayineviSil.Text = "SİL";
            this.btnYayineviSil.UseVisualStyleBackColor = false;
            this.btnYayineviSil.Click += new System.EventHandler(this.btnYayineviSil_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kategori Kayıt";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Yazar_Kategori_KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Yazar_Kategori_KayitForm";
            this.Text = "Yazar_Kategori_KayitForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtYazarSoyad;
        private Label label2;
        private TextBox txtYazarAd;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnListele;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private ListBox lstYazarlar;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox txtKategoriAd;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnKategoriListele;
        private Button btnKategoriGuncelle;
        private Button btnKategoriSil;
        private Button btnKategoriEkle;
        private ListView lstViewKategori;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private ListView lstViewYayinevi;
        private Label label7;
        private TextBox txtYayinevi;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnYayineviGüncelle;
        private Button btnYayineviListele;
        private Button btnYayineviEkle;
        private Button btnYayineviSil;
        private Button button1;
        private Button button3;
        private Label label5;
        private Button button2;
        private Label label1;
    }
}