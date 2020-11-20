namespace GradinNo1
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
            this.cblevel = new System.Windows.Forms.ComboBox();
            this.cbgaji = new System.Windows.Forms.ComboBox();
            this.cbnegara = new System.Windows.Forms.ComboBox();
            this.hitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbnama = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gajiakhir = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.alas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tinggi = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lebar = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panjang = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.jari = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.hasil1 = new System.Windows.Forms.Label();
            this.hasil2 = new System.Windows.Forms.Label();
            this.hasil3 = new System.Windows.Forms.Label();
            this.hitung1 = new System.Windows.Forms.Button();
            this.hitung2 = new System.Windows.Forms.Button();
            this.hitung3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cblevel
            // 
            this.cblevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblevel.FormattingEnabled = true;
            this.cblevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cblevel.Location = new System.Drawing.Point(50, 180);
            this.cblevel.Name = "cblevel";
            this.cblevel.Size = new System.Drawing.Size(209, 33);
            this.cblevel.TabIndex = 0;
            this.cblevel.Text = "Pilih Level Anda";
            // 
            // cbgaji
            // 
            this.cbgaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgaji.FormattingEnabled = true;
            this.cbgaji.Items.AddRange(new object[] {
            "2000000",
            "5000000",
            "8000000",
            "10000000",
            "11000000"});
            this.cbgaji.Location = new System.Drawing.Point(50, 141);
            this.cbgaji.Name = "cbgaji";
            this.cbgaji.Size = new System.Drawing.Size(209, 33);
            this.cbgaji.TabIndex = 2;
            this.cbgaji.Text = "Gaji Anda";
            // 
            // cbnegara
            // 
            this.cbnegara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnegara.FormattingEnabled = true;
            this.cbnegara.Items.AddRange(new object[] {
            "Asia",
            "Europe",
            "North America"});
            this.cbnegara.Location = new System.Drawing.Point(50, 221);
            this.cbnegara.Name = "cbnegara";
            this.cbnegara.Size = new System.Drawing.Size(209, 33);
            this.cbnegara.TabIndex = 3;
            this.cbnegara.Text = "Pilih Negara Anda";
            // 
            // hitung
            // 
            this.hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitung.Location = new System.Drawing.Point(110, 260);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(120, 28);
            this.hitung.TabIndex = 4;
            this.hitung.Text = "Hitung Gaji Akhir";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "> 7 Jt (10%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "> 4jt < 7 Jt (20%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "<4 Jt (40%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Keterangan Penambahan Gaji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Keterangan Pajak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Asia (2%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Europe(2.5%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "North America (3%)";
            // 
            // cbnama
            // 
            this.cbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnama.FormattingEnabled = true;
            this.cbnama.Items.AddRange(new object[] {
            "Anto",
            "Andi",
            "Budi",
            "Nita",
            "Bagus"});
            this.cbnama.Location = new System.Drawing.Point(50, 101);
            this.cbnama.Name = "cbnama";
            this.cbnama.Size = new System.Drawing.Size(209, 33);
            this.cbnama.TabIndex = 13;
            this.cbnama.Text = "Nama Anda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Perhitungan Gaji Akhir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gaji Akhir:";
            // 
            // gajiakhir
            // 
            this.gajiakhir.AutoSize = true;
            this.gajiakhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gajiakhir.Location = new System.Drawing.Point(167, 314);
            this.gajiakhir.Name = "gajiakhir";
            this.gajiakhir.Size = new System.Drawing.Size(20, 24);
            this.gajiakhir.TabIndex = 16;
            this.gajiakhir.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Keterangan Bonus";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Level 1 200 rb";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Level 2 500 rb";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Level 3 1 jt";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(489, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 305);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Perhitungan Luas Bangunan";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 416);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 24);
            this.label16.TabIndex = 24;
            this.label16.Text = "Segitiga";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 451);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "1/2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(64, 451);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "x";
            // 
            // alas
            // 
            this.alas.Location = new System.Drawing.Point(87, 448);
            this.alas.Name = "alas";
            this.alas.Size = new System.Drawing.Size(100, 20);
            this.alas.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(97, 473);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Alas Segitiga";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(522, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 16);
            this.label20.TabIndex = 29;
            this.label20.Text = "History dari perhitungan :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(193, 451);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "x";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(227, 473);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "Tinggi Segitiga";
            // 
            // tinggi
            // 
            this.tinggi.Location = new System.Drawing.Point(217, 447);
            this.tinggi.Name = "tinggi";
            this.tinggi.Size = new System.Drawing.Size(100, 20);
            this.tinggi.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(324, 451);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "=";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(324, 532);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(242, 554);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "Lebar";
            // 
            // lebar
            // 
            this.lebar.Location = new System.Drawing.Point(217, 528);
            this.lebar.Name = "lebar";
            this.lebar.Size = new System.Drawing.Size(100, 20);
            this.lebar.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(193, 532);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(12, 13);
            this.label26.TabIndex = 37;
            this.label26.Text = "x";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(97, 554);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Panjang";
            // 
            // panjang
            // 
            this.panjang.Location = new System.Drawing.Point(87, 529);
            this.panjang.Name = "panjang";
            this.panjang.Size = new System.Drawing.Size(100, 20);
            this.panjang.TabIndex = 35;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(33, 497);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(148, 24);
            this.label28.TabIndex = 34;
            this.label28.Text = "Persegi Panjang";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(99, 634);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 13);
            this.label29.TabIndex = 42;
            this.label29.Text = "Jari-jari";
            // 
            // jari
            // 
            this.jari.Location = new System.Drawing.Point(81, 609);
            this.jari.Name = "jari";
            this.jari.Size = new System.Drawing.Size(100, 20);
            this.jari.TabIndex = 41;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(33, 577);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 24);
            this.label30.TabIndex = 43;
            this.label30.Text = "Lingkaran";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(64, 612);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(12, 13);
            this.label31.TabIndex = 45;
            this.label31.Text = "x";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(34, 612);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 13);
            this.label32.TabIndex = 44;
            this.label32.Text = "Phi";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(186, 599);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "^2";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(218, 614);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(13, 13);
            this.label34.TabIndex = 47;
            this.label34.Text = "=";
            // 
            // hasil1
            // 
            this.hasil1.AutoSize = true;
            this.hasil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil1.Location = new System.Drawing.Point(343, 445);
            this.hasil1.Name = "hasil1";
            this.hasil1.Size = new System.Drawing.Size(20, 24);
            this.hasil1.TabIndex = 48;
            this.hasil1.Text = "0";
            // 
            // hasil2
            // 
            this.hasil2.AutoSize = true;
            this.hasil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil2.Location = new System.Drawing.Point(344, 525);
            this.hasil2.Name = "hasil2";
            this.hasil2.Size = new System.Drawing.Size(20, 24);
            this.hasil2.TabIndex = 49;
            this.hasil2.Text = "0";
            // 
            // hasil3
            // 
            this.hasil3.AutoSize = true;
            this.hasil3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil3.Location = new System.Drawing.Point(241, 605);
            this.hasil3.Name = "hasil3";
            this.hasil3.Size = new System.Drawing.Size(20, 24);
            this.hasil3.TabIndex = 50;
            this.hasil3.Text = "0";
            // 
            // hitung1
            // 
            this.hitung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitung1.Location = new System.Drawing.Point(391, 443);
            this.hitung1.Name = "hitung1";
            this.hitung1.Size = new System.Drawing.Size(120, 28);
            this.hitung1.TabIndex = 51;
            this.hitung1.Text = "Hitung";
            this.hitung1.UseVisualStyleBackColor = true;
            this.hitung1.Click += new System.EventHandler(this.hitung1_Click);
            // 
            // hitung2
            // 
            this.hitung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitung2.Location = new System.Drawing.Point(391, 520);
            this.hitung2.Name = "hitung2";
            this.hitung2.Size = new System.Drawing.Size(120, 28);
            this.hitung2.TabIndex = 52;
            this.hitung2.Text = "Hitung";
            this.hitung2.UseVisualStyleBackColor = true;
            this.hitung2.Click += new System.EventHandler(this.hitung2_Click);
            // 
            // hitung3
            // 
            this.hitung3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitung3.Location = new System.Drawing.Point(391, 597);
            this.hitung3.Name = "hitung3";
            this.hitung3.Size = new System.Drawing.Size(120, 28);
            this.hitung3.TabIndex = 53;
            this.hitung3.Text = "Hitung";
            this.hitung3.UseVisualStyleBackColor = true;
            this.hitung3.Click += new System.EventHandler(this.hitung3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 713);
            this.Controls.Add(this.hitung3);
            this.Controls.Add(this.hitung2);
            this.Controls.Add(this.hitung1);
            this.Controls.Add(this.hasil3);
            this.Controls.Add(this.hasil2);
            this.Controls.Add(this.hasil1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.jari);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lebar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.panjang);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tinggi);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.alas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gajiakhir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.cbnegara);
            this.Controls.Add(this.cbgaji);
            this.Controls.Add(this.cblevel);
            this.Name = "Form1";
            this.Text = "Perhitungan Gaji Akhir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cblevel;
        private System.Windows.Forms.ComboBox cbgaji;
        private System.Windows.Forms.ComboBox cbnegara;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbnama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label gajiakhir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox alas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tinggi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox lebar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox panjang;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox jari;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label hasil1;
        private System.Windows.Forms.Label hasil2;
        private System.Windows.Forms.Label hasil3;
        private System.Windows.Forms.Button hitung1;
        private System.Windows.Forms.Button hitung2;
        private System.Windows.Forms.Button hitung3;
    }
}

