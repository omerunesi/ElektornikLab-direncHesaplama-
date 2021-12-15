namespace ElektornikLab_direncHesaplama_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DB_txtBoxSonuc2 = new System.Windows.Forms.TextBox();
            this.DB_txtBoxSonuc1 = new System.Windows.Forms.TextBox();
            this.DB_cmbBoxBirinciBand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DB_btnHesapla = new System.Windows.Forms.Button();
            this.DB_cmbBoxTolerans = new System.Windows.Forms.ComboBox();
            this.DB_cmbBoxCarpan = new System.Windows.Forms.ComboBox();
            this.DB_cmbBoxIkinciBant = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BB_txtBoxSonuc2 = new System.Windows.Forms.TextBox();
            this.BB_txtBoxSonuc1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BB_cmbBoxUcuncuBand = new System.Windows.Forms.ComboBox();
            this.BB_cmbBoxBirinciBand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BB_btnHesapla = new System.Windows.Forms.Button();
            this.BB_cmbBoxTolerans = new System.Windows.Forms.ComboBox();
            this.BB_cmbBoxCarpan = new System.Windows.Forms.ComboBox();
            this.BB_cmbBoxIkınciBand = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DB_txtBoxSonuc2);
            this.groupBox1.Controls.Add(this.DB_txtBoxSonuc1);
            this.groupBox1.Controls.Add(this.DB_cmbBoxBirinciBand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DB_btnHesapla);
            this.groupBox1.Controls.Add(this.DB_cmbBoxTolerans);
            this.groupBox1.Controls.Add(this.DB_cmbBoxCarpan);
            this.groupBox1.Controls.Add(this.DB_cmbBoxIkinciBant);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(57, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4 Band Direnç";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(708, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ω";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "-";
            // 
            // DB_txtBoxSonuc2
            // 
            this.DB_txtBoxSonuc2.BackColor = System.Drawing.Color.SteelBlue;
            this.DB_txtBoxSonuc2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_txtBoxSonuc2.ForeColor = System.Drawing.Color.Cornsilk;
            this.DB_txtBoxSonuc2.Location = new System.Drawing.Point(602, 101);
            this.DB_txtBoxSonuc2.Name = "DB_txtBoxSonuc2";
            this.DB_txtBoxSonuc2.ReadOnly = true;
            this.DB_txtBoxSonuc2.Size = new System.Drawing.Size(100, 27);
            this.DB_txtBoxSonuc2.TabIndex = 12;
            this.DB_txtBoxSonuc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DB_txtBoxSonuc1
            // 
            this.DB_txtBoxSonuc1.BackColor = System.Drawing.Color.SteelBlue;
            this.DB_txtBoxSonuc1.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_txtBoxSonuc1.ForeColor = System.Drawing.Color.Cornsilk;
            this.DB_txtBoxSonuc1.Location = new System.Drawing.Point(475, 101);
            this.DB_txtBoxSonuc1.Name = "DB_txtBoxSonuc1";
            this.DB_txtBoxSonuc1.ReadOnly = true;
            this.DB_txtBoxSonuc1.Size = new System.Drawing.Size(100, 27);
            this.DB_txtBoxSonuc1.TabIndex = 11;
            this.DB_txtBoxSonuc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DB_cmbBoxBirinciBand
            // 
            this.DB_cmbBoxBirinciBand.BackColor = System.Drawing.Color.SteelBlue;
            this.DB_cmbBoxBirinciBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DB_cmbBoxBirinciBand.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_cmbBoxBirinciBand.ForeColor = System.Drawing.Color.Cornsilk;
            this.DB_cmbBoxBirinciBand.FormattingEnabled = true;
            this.DB_cmbBoxBirinciBand.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.DB_cmbBoxBirinciBand.Location = new System.Drawing.Point(17, 54);
            this.DB_cmbBoxBirinciBand.Name = "DB_cmbBoxBirinciBand";
            this.DB_cmbBoxBirinciBand.Size = new System.Drawing.Size(96, 26);
            this.DB_cmbBoxBirinciBand.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(366, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tolerans";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çarpan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(135, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Band";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. Band";
            // 
            // DB_btnHesapla
            // 
            this.DB_btnHesapla.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_btnHesapla.ForeColor = System.Drawing.Color.SteelBlue;
            this.DB_btnHesapla.Location = new System.Drawing.Point(358, 101);
            this.DB_btnHesapla.Name = "DB_btnHesapla";
            this.DB_btnHesapla.Size = new System.Drawing.Size(96, 29);
            this.DB_btnHesapla.TabIndex = 4;
            this.DB_btnHesapla.Text = "HESAPLA";
            this.DB_btnHesapla.UseVisualStyleBackColor = true;
            this.DB_btnHesapla.Click += new System.EventHandler(this.DB_btnHesapla_Click);
            // 
            // DB_cmbBoxTolerans
            // 
            this.DB_cmbBoxTolerans.BackColor = System.Drawing.Color.SteelBlue;
            this.DB_cmbBoxTolerans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DB_cmbBoxTolerans.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_cmbBoxTolerans.ForeColor = System.Drawing.Color.Cornsilk;
            this.DB_cmbBoxTolerans.FormattingEnabled = true;
            this.DB_cmbBoxTolerans.Items.AddRange(new object[] {
            "Kahve",
            "Kırmızı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Altın",
            "Gümüş"});
            this.DB_cmbBoxTolerans.Location = new System.Drawing.Point(358, 54);
            this.DB_cmbBoxTolerans.Name = "DB_cmbBoxTolerans";
            this.DB_cmbBoxTolerans.Size = new System.Drawing.Size(96, 26);
            this.DB_cmbBoxTolerans.TabIndex = 3;
            // 
            // DB_cmbBoxCarpan
            // 
            this.DB_cmbBoxCarpan.BackColor = System.Drawing.Color.SteelBlue;
            this.DB_cmbBoxCarpan.DisplayMember = "1";
            this.DB_cmbBoxCarpan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DB_cmbBoxCarpan.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_cmbBoxCarpan.ForeColor = System.Drawing.Color.Cornsilk;
            this.DB_cmbBoxCarpan.FormattingEnabled = true;
            this.DB_cmbBoxCarpan.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Altın",
            "Gümüş"});
            this.DB_cmbBoxCarpan.Location = new System.Drawing.Point(241, 54);
            this.DB_cmbBoxCarpan.Name = "DB_cmbBoxCarpan";
            this.DB_cmbBoxCarpan.Size = new System.Drawing.Size(96, 26);
            this.DB_cmbBoxCarpan.TabIndex = 2;
            // 
            // DB_cmbBoxIkinciBant
            // 
            this.DB_cmbBoxIkinciBant.BackColor = System.Drawing.Color.SteelBlue;
            this.DB_cmbBoxIkinciBant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DB_cmbBoxIkinciBant.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DB_cmbBoxIkinciBant.ForeColor = System.Drawing.Color.Cornsilk;
            this.DB_cmbBoxIkinciBant.FormattingEnabled = true;
            this.DB_cmbBoxIkinciBant.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.DB_cmbBoxIkinciBant.Location = new System.Drawing.Point(128, 54);
            this.DB_cmbBoxIkinciBant.Name = "DB_cmbBoxIkinciBant";
            this.DB_cmbBoxIkinciBant.Size = new System.Drawing.Size(96, 26);
            this.DB_cmbBoxIkinciBant.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.BB_txtBoxSonuc2);
            this.groupBox2.Controls.Add(this.BB_txtBoxSonuc1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BB_cmbBoxUcuncuBand);
            this.groupBox2.Controls.Add(this.BB_cmbBoxBirinciBand);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.BB_btnHesapla);
            this.groupBox2.Controls.Add(this.BB_cmbBoxTolerans);
            this.groupBox2.Controls.Add(this.BB_cmbBoxCarpan);
            this.groupBox2.Controls.Add(this.BB_cmbBoxIkınciBand);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(57, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "5 Band Direnç";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(708, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ω";
            // 
            // BB_txtBoxSonuc2
            // 
            this.BB_txtBoxSonuc2.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_txtBoxSonuc2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_txtBoxSonuc2.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_txtBoxSonuc2.Location = new System.Drawing.Point(602, 101);
            this.BB_txtBoxSonuc2.Name = "BB_txtBoxSonuc2";
            this.BB_txtBoxSonuc2.ReadOnly = true;
            this.BB_txtBoxSonuc2.Size = new System.Drawing.Size(100, 27);
            this.BB_txtBoxSonuc2.TabIndex = 14;
            this.BB_txtBoxSonuc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BB_txtBoxSonuc1
            // 
            this.BB_txtBoxSonuc1.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_txtBoxSonuc1.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_txtBoxSonuc1.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_txtBoxSonuc1.Location = new System.Drawing.Point(475, 101);
            this.BB_txtBoxSonuc1.Name = "BB_txtBoxSonuc1";
            this.BB_txtBoxSonuc1.ReadOnly = true;
            this.BB_txtBoxSonuc1.Size = new System.Drawing.Size(100, 27);
            this.BB_txtBoxSonuc1.TabIndex = 13;
            this.BB_txtBoxSonuc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(251, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "3. Band";
            // 
            // BB_cmbBoxUcuncuBand
            // 
            this.BB_cmbBoxUcuncuBand.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_cmbBoxUcuncuBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BB_cmbBoxUcuncuBand.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_cmbBoxUcuncuBand.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_cmbBoxUcuncuBand.FormattingEnabled = true;
            this.BB_cmbBoxUcuncuBand.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.BB_cmbBoxUcuncuBand.Location = new System.Drawing.Point(241, 54);
            this.BB_cmbBoxUcuncuBand.Name = "BB_cmbBoxUcuncuBand";
            this.BB_cmbBoxUcuncuBand.Size = new System.Drawing.Size(96, 26);
            this.BB_cmbBoxUcuncuBand.TabIndex = 11;
            // 
            // BB_cmbBoxBirinciBand
            // 
            this.BB_cmbBoxBirinciBand.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_cmbBoxBirinciBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BB_cmbBoxBirinciBand.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_cmbBoxBirinciBand.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_cmbBoxBirinciBand.FormattingEnabled = true;
            this.BB_cmbBoxBirinciBand.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.BB_cmbBoxBirinciBand.Location = new System.Drawing.Point(17, 54);
            this.BB_cmbBoxBirinciBand.Name = "BB_cmbBoxBirinciBand";
            this.BB_cmbBoxBirinciBand.Size = new System.Drawing.Size(96, 26);
            this.BB_cmbBoxBirinciBand.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(483, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tolerans";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(368, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Çarpan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(135, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "2. Band";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(24, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "1. Band";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Cornsilk;
            this.label12.Location = new System.Drawing.Point(581, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "-";
            // 
            // BB_btnHesapla
            // 
            this.BB_btnHesapla.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_btnHesapla.ForeColor = System.Drawing.Color.SteelBlue;
            this.BB_btnHesapla.Location = new System.Drawing.Point(358, 101);
            this.BB_btnHesapla.Name = "BB_btnHesapla";
            this.BB_btnHesapla.Size = new System.Drawing.Size(96, 29);
            this.BB_btnHesapla.TabIndex = 4;
            this.BB_btnHesapla.Text = "HESAPLA";
            this.BB_btnHesapla.UseVisualStyleBackColor = true;
            this.BB_btnHesapla.Click += new System.EventHandler(this.BB_btnHesapla_Click);
            // 
            // BB_cmbBoxTolerans
            // 
            this.BB_cmbBoxTolerans.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_cmbBoxTolerans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BB_cmbBoxTolerans.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_cmbBoxTolerans.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_cmbBoxTolerans.FormattingEnabled = true;
            this.BB_cmbBoxTolerans.Items.AddRange(new object[] {
            "Kahve",
            "Kırmızı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Altın",
            "Gümüş"});
            this.BB_cmbBoxTolerans.Location = new System.Drawing.Point(475, 54);
            this.BB_cmbBoxTolerans.Name = "BB_cmbBoxTolerans";
            this.BB_cmbBoxTolerans.Size = new System.Drawing.Size(96, 26);
            this.BB_cmbBoxTolerans.TabIndex = 3;
            // 
            // BB_cmbBoxCarpan
            // 
            this.BB_cmbBoxCarpan.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_cmbBoxCarpan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BB_cmbBoxCarpan.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_cmbBoxCarpan.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_cmbBoxCarpan.FormattingEnabled = true;
            this.BB_cmbBoxCarpan.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Altın",
            "Gümüş"});
            this.BB_cmbBoxCarpan.Location = new System.Drawing.Point(358, 54);
            this.BB_cmbBoxCarpan.Name = "BB_cmbBoxCarpan";
            this.BB_cmbBoxCarpan.Size = new System.Drawing.Size(96, 26);
            this.BB_cmbBoxCarpan.TabIndex = 2;
            // 
            // BB_cmbBoxIkınciBand
            // 
            this.BB_cmbBoxIkınciBand.BackColor = System.Drawing.Color.SteelBlue;
            this.BB_cmbBoxIkınciBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BB_cmbBoxIkınciBand.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BB_cmbBoxIkınciBand.ForeColor = System.Drawing.Color.Cornsilk;
            this.BB_cmbBoxIkınciBand.FormattingEnabled = true;
            this.BB_cmbBoxIkınciBand.Items.AddRange(new object[] {
            "Siyah",
            "Kahve",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.BB_cmbBoxIkınciBand.Location = new System.Drawing.Point(128, 54);
            this.BB_cmbBoxIkınciBand.Name = "BB_cmbBoxIkınciBand";
            this.BB_cmbBoxIkınciBand.Size = new System.Drawing.Size(96, 26);
            this.BB_cmbBoxIkınciBand.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Direnç Renk Hesaplama v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DB_btnHesapla;
        private System.Windows.Forms.ComboBox DB_cmbBoxTolerans;
        private System.Windows.Forms.ComboBox DB_cmbBoxCarpan;
        private System.Windows.Forms.ComboBox DB_cmbBoxIkinciBant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox BB_cmbBoxUcuncuBand;
        private System.Windows.Forms.ComboBox BB_cmbBoxBirinciBand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BB_btnHesapla;
        private System.Windows.Forms.ComboBox BB_cmbBoxTolerans;
        private System.Windows.Forms.ComboBox BB_cmbBoxCarpan;
        private System.Windows.Forms.ComboBox BB_cmbBoxIkınciBand;
        private System.Windows.Forms.TextBox DB_txtBoxSonuc1;
        private System.Windows.Forms.ComboBox DB_cmbBoxBirinciBand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DB_txtBoxSonuc2;
        private System.Windows.Forms.TextBox BB_txtBoxSonuc2;
        private System.Windows.Forms.TextBox BB_txtBoxSonuc1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}

