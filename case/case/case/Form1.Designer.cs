namespace @case
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.altıgenpicture = new System.Windows.Forms.PictureBox();
            this.dairepicture = new System.Windows.Forms.PictureBox();
            this.ucgenpicture = new System.Windows.Forms.PictureBox();
            this.karepicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucgen = new System.Windows.Forms.Button();
            this.altigen = new System.Windows.Forms.Button();
            this.daire = new System.Windows.Forms.Button();
            this.kare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.EL = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altıgenpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dairepicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucgenpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karepicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.altıgenpicture);
            this.panel1.Controls.Add(this.dairepicture);
            this.panel1.Controls.Add(this.ucgenpicture);
            this.panel1.Controls.Add(this.karepicture);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 413);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // altıgenpicture
            // 
            this.altıgenpicture.Location = new System.Drawing.Point(332, 227);
            this.altıgenpicture.Name = "altıgenpicture";
            this.altıgenpicture.Size = new System.Drawing.Size(100, 50);
            this.altıgenpicture.TabIndex = 3;
            this.altıgenpicture.TabStop = false;
            this.altıgenpicture.Visible = false;
            this.altıgenpicture.Click += new System.EventHandler(this.altıgenpicture_Click);
            // 
            // dairepicture
            // 
            this.dairepicture.Location = new System.Drawing.Point(189, 247);
            this.dairepicture.Name = "dairepicture";
            this.dairepicture.Size = new System.Drawing.Size(100, 50);
            this.dairepicture.TabIndex = 2;
            this.dairepicture.TabStop = false;
            this.dairepicture.Visible = false;
            this.dairepicture.Click += new System.EventHandler(this.dairepicture_Click);
            // 
            // ucgenpicture
            // 
            this.ucgenpicture.Location = new System.Drawing.Point(85, 158);
            this.ucgenpicture.Name = "ucgenpicture";
            this.ucgenpicture.Size = new System.Drawing.Size(100, 50);
            this.ucgenpicture.TabIndex = 1;
            this.ucgenpicture.TabStop = false;
            this.ucgenpicture.Visible = false;
            this.ucgenpicture.Click += new System.EventHandler(this.ucgenpicture_Click);
            // 
            // karepicture
            // 
            this.karepicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.karepicture.Location = new System.Drawing.Point(231, 138);
            this.karepicture.Name = "karepicture";
            this.karepicture.Size = new System.Drawing.Size(100, 50);
            this.karepicture.TabIndex = 0;
            this.karepicture.TabStop = false;
            this.karepicture.Visible = false;
            this.karepicture.Click += new System.EventHandler(this.karepicture_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(83, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 52);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(6, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 52);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucgen);
            this.groupBox1.Controls.Add(this.altigen);
            this.groupBox1.Controls.Add(this.daire);
            this.groupBox1.Controls.Add(this.kare);
            this.groupBox1.Location = new System.Drawing.Point(640, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çizim Şekli";
            // 
            // ucgen
            // 
            this.ucgen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucgen.BackgroundImage")));
            this.ucgen.Location = new System.Drawing.Point(18, 54);
            this.ucgen.Name = "ucgen";
            this.ucgen.Size = new System.Drawing.Size(32, 29);
            this.ucgen.TabIndex = 4;
            this.ucgen.UseVisualStyleBackColor = true;
            this.ucgen.Click += new System.EventHandler(this.button13_Click);
            // 
            // altigen
            // 
            this.altigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("altigen.BackgroundImage")));
            this.altigen.Location = new System.Drawing.Point(89, 54);
            this.altigen.Name = "altigen";
            this.altigen.Size = new System.Drawing.Size(30, 29);
            this.altigen.TabIndex = 3;
            this.altigen.UseVisualStyleBackColor = true;
            this.altigen.Click += new System.EventHandler(this.altigen_Click);
            // 
            // daire
            // 
            this.daire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("daire.BackgroundImage")));
            this.daire.Location = new System.Drawing.Point(89, 19);
            this.daire.Name = "daire";
            this.daire.Size = new System.Drawing.Size(32, 29);
            this.daire.TabIndex = 2;
            this.daire.UseVisualStyleBackColor = true;
            this.daire.Click += new System.EventHandler(this.daire_Click);
            // 
            // kare
            // 
            this.kare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kare.BackgroundImage")));
            this.kare.Location = new System.Drawing.Point(18, 19);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(32, 29);
            this.kare.TabIndex = 1;
            this.kare.UseVisualStyleBackColor = true;
            this.kare.Click += new System.EventHandler(this.kare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(640, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Seçimi";
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.Location = new System.Drawing.Point(101, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 26);
            this.button11.TabIndex = 8;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.Location = new System.Drawing.Point(53, 81);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 26);
            this.button10.TabIndex = 7;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.Location = new System.Drawing.Point(9, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 26);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Location = new System.Drawing.Point(101, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 26);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Location = new System.Drawing.Point(54, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 26);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(9, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 26);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(101, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 26);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(54, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 26);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(9, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 26);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.Location = new System.Drawing.Point(101, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(41, 46);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // EL
            // 
            this.EL.Image = ((System.Drawing.Image)(resources.GetObject("EL.Image")));
            this.EL.Location = new System.Drawing.Point(6, 19);
            this.EL.Name = "EL";
            this.EL.Size = new System.Drawing.Size(41, 46);
            this.EL.TabIndex = 6;
            this.EL.UseVisualStyleBackColor = true;
            this.EL.Click += new System.EventHandler(this.EL_Click);
            // 
            // button13
            // 
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(54, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(41, 46);
            this.button13.TabIndex = 7;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(55, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EL);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Location = new System.Drawing.Point(640, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 71);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şekil İşlemleri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(640, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 453);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altıgenpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dairepicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucgenpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karepicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button altigen;
        private System.Windows.Forms.Button daire;
        private System.Windows.Forms.Button kare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button ucgen;
        private System.Windows.Forms.Button EL;
        private System.Windows.Forms.PictureBox altıgenpicture;
        private System.Windows.Forms.PictureBox dairepicture;
        private System.Windows.Forms.PictureBox ucgenpicture;
        private System.Windows.Forms.PictureBox karepicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

