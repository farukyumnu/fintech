using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageResizer;

namespace @case
{
    public partial class Form1 : Form
    {
        public int el=0;
        public int renk=0;
        public int karesil = 0;
        public int dairesil = 0;
        public int ucgensil = 0;
        public int altıgensil = 0;
        public int karekayit=0;
        public int ucgenkayit = 0;
        public int dairekayit = 0;
        public int altıgenkayit = 0;
        public string kayit1;
        public string kayit2;
        public string kayit3;
        public string kayit4;
        public Form1()
        {
            InitializeComponent();
            karepicture.MouseWheel += Karepicture_MouseWheel;
            ucgenpicture.MouseWheel += Ucgenpicture_MouseWheel;
            dairepicture.MouseWheel += Dairepicture_MouseWheel;
            altıgenpicture.MouseWheel += Altıgenpicture_MouseWheel;
        }

        private void Altıgenpicture_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                altıgenpicture.Width = altıgenpicture.Width + 50;
                altıgenpicture.Height = altıgenpicture.Height + 50;
            }
            if (e.Delta < 0 && altıgenpicture.Width>50 && altıgenpicture.Height> 50)  
            {
                altıgenpicture.Width = altıgenpicture.Width - 50;
                altıgenpicture.Height = altıgenpicture.Height - 50;
            }
        }

        private void Dairepicture_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                dairepicture.Width = dairepicture.Width + 50;
                dairepicture.Height = dairepicture.Height + 50;
            }
            if(e.Delta < 0 && dairepicture.Width > 50 && dairepicture.Height > 50)
            {
                dairepicture.Width = dairepicture.Width - 50;
                dairepicture.Height = dairepicture.Height - 50;
            }
        }

        private void Ucgenpicture_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ucgenpicture.Width = ucgenpicture.Width + 50;
                ucgenpicture.Height = ucgenpicture.Height + 50;
            }
            if(e.Delta < 0 && ucgenpicture.Width > 50 && ucgenpicture.Height > 50)
            {
                ucgenpicture.Width = ucgenpicture.Width - 50;
                ucgenpicture.Height = ucgenpicture.Height - 50;
            }
        }

        private void Karepicture_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                karepicture.Width = karepicture.Width + 50;
                karepicture.Height = karepicture.Height + 50;
            }
            if(e.Delta < 0 && karepicture.Width > 50 && karepicture.Height > 50)
            {
                karepicture.Width = karepicture.Width - 50;
                karepicture.Height = karepicture.Height - 50;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            el = 0;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            timer1.Enabled = true;
            timer1.Interval = 500;
            kayit1 = "";
            kayit2 = "";
            kayit3 = "";
            kayit4 = "";


        }
        private void button1_Click(object sender, EventArgs e)
        {

            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            saveFileDialog1.Title = "Kaydetmek için bir ad girin";
            saveFileDialog1.Filter = "Metin dosyaları|*.txt|" + "Bütün dosyalar|*.*";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya_adı;
                dosya_adı = saveFileDialog1.FileName;
                System.IO.TextWriter dosya = System.IO.File.CreateText(dosya_adı);
                dosya.Write(kayit1.ToString()+"\n"+kayit2.ToString()+"\n"+kayit3.ToString()+"\n"+kayit4.ToString());
                dosya.Close();
                kayit1 = "";
                kayit2 = "";
                kayit3 = "";
                kayit4 = "";
            }
            el = 0;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            label5.Visible = true;
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            panel1.Controls.Clear();
            openFileDialog1.Filter = "Metin dosyaları|*.txt|" + "Bütün dosyalar|*.*";
            openFileDialog1.Title = "Açılacak dosyayı seçiniz";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya_adi;
                dosya_adi = openFileDialog1.FileName;
                System.IO.TextReader dosya = System.IO.File.OpenText(dosya_adi);
                string x;
                x = dosya.ReadToEnd();
                dosya.Close();
                label5.Text = x;
                kayit1 = "";
                kayit2 = "";
                kayit3 = "";
                kayit4 = "";
            }
            
        }

        private void kare_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            karekayit = 1;
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            karepicture.Visible = true;
            if (renk == 0) 
            {
                label1.Text = "Beyaz Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/beyazkare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
                
            }
            if (renk == 1)
            {
                label1.Text = "Kırmızı Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/kırmızıkare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 2)
            {
                label1.Text = "Mavi Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/mavikare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 3)
            {
                label1.Text = "Yeşil Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/yeşilkare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 4)
            {
                label1.Text = "Turuncu Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/turuncukare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 5)
            {
                label1.Text = "Siyah Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/siyahkare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 6)
            {
                label1.Text = "Sarı Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/sarıkare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 7)
            {
                label1.Text = "Mor Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/morkare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
            if (renk == 8)
            {
                label1.Text = "Kahverengi Kare";
                karepicture.Image = Image.FromFile(@"şekil/kare/kahverengikare.png");
                karepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                karepicture.Location = panel1.Location;
                panel1.Controls.Add(karepicture);
                ControlExtension.Draggable(karepicture, true);
                renk = 0;
            }
        }

        private void daire_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            dairekayit = 1;
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            dairepicture.Visible = true;
            if (renk == 0)
            {
                label3.Text = "Beyaz Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/beyazdaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 1)
            {
                label3.Text = "Kırmızı Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/kırmızıdaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 2)
            {
                label3.Text = "Mavi Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/mavidaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 3)
            {
                label3.Text = "Yeşil Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/yeşildaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 4)
            {
                label3.Text = "Turuncu Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/turuncudaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 5)
            {
                label3.Text = "Siyah Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/siyahdaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 6)
            {
                label3.Text = "Sarı Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/sarıdaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 7)
            {
                label3.Text = "Mor Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/mordaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
            if (renk == 8)
            {
                label3.Text = "Kahverengi Daire";
                dairepicture.Image = Image.FromFile(@"şekil/daire/kahverengidaire.png");
                dairepicture.SizeMode = PictureBoxSizeMode.StretchImage;
                dairepicture.Location = panel1.Location;
                panel1.Controls.Add(dairepicture);
                ControlExtension.Draggable(dairepicture, true);
                renk = 0;
            }
        }
        private void altigen_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            altıgenkayit = 1;
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            altıgenpicture.Visible = true;
            if (renk == 0)
            {
                label2.Text = "Beyaz Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/beyazaltıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 1)
            {
                label2.Text = "Kırmızı Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/kırmızıaltıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 2)
            {
                label2.Text = "Mavi Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/mavialtıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 3)
            {
                label2.Text = "Yeşil Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/yeşilaltıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 4)
            {
                label2.Text = "Turuncu Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/turuncualtıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 5)
            {
                label2.Text = "Siyah Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/siyahaltıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 6)
            {
                label2.Text = "Sarı Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/sarıaltıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 7)
            {
                label2.Text = "Mor Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/moraltıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
            if (renk == 8)
            {
                label2.Text = "Kahverengi Altıgen";
                altıgenpicture.Image = Image.FromFile(@"şekil/altıgen/kahverengialtıgen.png");
                altıgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                altıgenpicture.Location = panel1.Location;
                panel1.Controls.Add(altıgenpicture);
                ControlExtension.Draggable(altıgenpicture, true);
                renk = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk =0;
            label5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 1;
            label5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 2;
            label5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 3;
            label5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 4;
            label5.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 5;
            label5.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 6;
            label5.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 7;
            label5.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            renk = 8;
            label5.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            karepicture.Visible=false;
            ucgenpicture.Visible=false;
            dairepicture.Visible=false;
            altıgenpicture.Visible=false;
            altıgenpicture.BorderStyle = BorderStyle.None;
            dairepicture.BorderStyle = BorderStyle.None;
            ucgenpicture.BorderStyle = BorderStyle.None;
            karepicture.BorderStyle = BorderStyle.None;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            kayit1 = "";
            kayit2 = "";
            kayit3 = "";
            kayit4 = "";
            label5.Visible=false;
            el = 0;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            ucgenkayit = 1;
            el = 0;
            ucgensil = 0;
            dairesil = 0;
            altıgensil = 0;
            karesil = 0;
            ucgenpicture.Visible = true;
            if (renk == 0)
            {
                label4.Text = "Beyaz Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/beyazüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 1)
            {
                label4.Text = "Kırmızı Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/kırmızıüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 2)
            {
                label4.Text = "Mavi Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/maviüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 3)
            {
                label4.Text = "Yeşil Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/yeşilüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 4)
            {
                label4.Text = "Turuncu Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/turuncuüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 5)
            {
                label4.Text = "Siyah Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/siyahüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 6)
            {
                label4.Text = "Sarı Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/sarıüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 7)
            {
                label4.Text = "Mor Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/morüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
            if (renk == 8)
            {
                label4.Text = "Kahverengi Üçgen";
                ucgenpicture.Image = Image.FromFile(@"şekil/ucgen/kahverengiüçgen.png");
                ucgenpicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ucgenpicture.Location = panel1.Location;
                panel1.Controls.Add(ucgenpicture);
                ControlExtension.Draggable(ucgenpicture, true);
                renk = 0;
            }
        }

        private void EL_Click(object sender, EventArgs e)
        {
            if (el==0) 
            {
                el = 1;
            }
            
        }

        private void karepicture_Click(object sender, EventArgs e)
        {
            
            if (el==1) 
            {
                label1.Location=karepicture.Location;
                label1.Visible = true;
                karesil = 1;
                karepicture.BorderStyle = BorderStyle.FixedSingle;
            } 
        }

        private void ucgenpicture_Click(object sender, EventArgs e)
        {
            
            if (el == 1)
            {
                label4.Location= ucgenpicture.Location;
                label4.Visible = true;
                ucgensil = 1;
                ucgenpicture.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void dairepicture_Click(object sender, EventArgs e)
        {
            
            if (el == 1)
            {
                label3.Location = dairepicture.Location;
                label3.Visible = true;
                dairesil = 1;
                dairepicture.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void altıgenpicture_Click(object sender, EventArgs e)
        {
            
            if (el == 1)
            {
                label2.Location = altıgenpicture.Location;
                label2.Visible=true;
                altıgensil = 1;
                altıgenpicture.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            el = 0;
            if (karesil==1) 
            {
                karepicture.Visible= false;
                karesil = 0;
                karekayit = 0;
                kayit1 = "";
            }
            if (dairesil==1)
            {
                dairepicture.Visible = false;
                dairesil = 0;
                dairekayit = 0;
                kayit2 = "";
            }
            if (ucgensil==1)
            {
                ucgenpicture.Visible = false;
                ucgensil = 0;
                ucgenkayit = 0;
                kayit4 = "";
            }
            if (altıgensil==1)
            {
                altıgenpicture.Visible = false;
                altıgensil = 0;
                altıgenkayit=0;
                kayit3 = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (el == 0) 
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                altıgenpicture.BorderStyle = BorderStyle.None;
                dairepicture.BorderStyle = BorderStyle.None;
                ucgenpicture.BorderStyle = BorderStyle.None;
                karepicture.BorderStyle = BorderStyle.None;
                
            }
            if (karekayit==1) 
            {
                kayit1= "Boyut: "+karepicture.Size.ToString()+" Konum: " + karepicture.Location.ToString()+ " Cisim: " + label1.Text;
                
            }
            if (dairekayit==1)
            {
                kayit2= "Boyut: "+dairepicture.Size.ToString() + " Konum: " + dairepicture.Location.ToString() + " Cisim: " + label3.Text;
              
            }
            if (altıgenkayit==1)
            {
                kayit3= "Boyut: "+ altıgenpicture.Size.ToString() + " Konum: " + altıgenpicture.Location.ToString() + " Cisim: " + label2.Text;
                
            }
            if (ucgenkayit==1)
            {
                kayit4= "Boyut: "+ ucgenpicture.Size.ToString() + " Konum: " + ucgenpicture.Location.ToString() + " Cisim: " + label4.Text;
               
            }
        }
    }
}
