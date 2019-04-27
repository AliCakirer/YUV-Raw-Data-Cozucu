using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace yazlab3
{
    public partial class Form1 : Form
    {
        int komut=0,frame_Sayisi,width,height,suanki_frame,cevirme_tipi=0,sayac=0;
        String dosyayolu;
        String[] liste;
        PictureBox[] resimler;
        byte[] array,arrayY;
        Bitmap[] frames;



        public Form1()
        {
            InitializeComponent();
            btnSag.Hide();
            btnSol.Hide();
            btnOynat.Hide();
            btnDurdur.Hide();
            txtBoxCurrentFrame.Hide();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "YUV dosyası|*.yuv";
            openFileDialog1.ShowDialog();
            dosyayolu = openFileDialog1.FileName;
            
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            

            ErrorProvider provider = new ErrorProvider();

            if (txtBoxWidth.Text=="")
            {
                provider.SetError(txtBoxWidth, "Bu alan boş geçilemez");
            }
            if (txtBoxHeight.Text == "")
            {
                provider.SetError(txtBoxHeight, "Bu alan boş geçilemez");
            }

            if (komut==0)
            {
                provider.SetError(radioButton420, "Bu alanlar boş geçilemez");
                provider.SetError(radioButton422, "Bu alanlar boş geçilemez");
                provider.SetError(radioButton444, "Bu alanlar boş geçilemez");
            }

            width = Convert.ToInt32(txtBoxWidth.Text);
            height = Convert.ToInt32(txtBoxHeight.Text);
            if (komut==1) // 4:4:4
            {
                array = File.ReadAllBytes(dosyayolu);
                arrayY = new byte[array.Length  / 3];
                frame_Sayisi = (array.Length /3) / (height * width);

                int k = 0; int a = 0;

                for (int i = 0; i < frame_Sayisi; i++)
                {
                    for (int j = 0; j < arrayY.Length / frame_Sayisi; j++)
                    {
                        arrayY[k] = array[a];
                        k++;
                        a++;
                    }
                    a += (arrayY.Length / frame_Sayisi)*2;
                }
            }
            if (komut==2) //4:2:2
            {
                array = File.ReadAllBytes(dosyayolu);
                arrayY = new byte[array.Length /2];
                frame_Sayisi = (array.Length /2) / (height * width);

                int k = 0; int a = 0;

                for (int i = 0; i < frame_Sayisi; i++)
                {
                    for (int j = 0; j < arrayY.Length / frame_Sayisi; j++)
                    {
                        arrayY[k] = array[a];
                        k++;
                        a++;
                    }
                    a += (arrayY.Length / frame_Sayisi);
                }
            }
            if (komut==3) //4:2:0
            {
                array = File.ReadAllBytes(dosyayolu);
                arrayY = new byte[array.Length * 4 / 6];
                frame_Sayisi = (array.Length * 4 / 6) / (height * width);

                int k = 0; int a = 0;

                for (int i = 0; i < frame_Sayisi; i++)
                {
                    for (int j = 0; j < arrayY.Length / frame_Sayisi; j++)
                    {
                        arrayY[k] = array[a];
                        k++;
                        a++;
                    }
                    a += (arrayY.Length / frame_Sayisi) / 2;
                }
             

            }

            MessageBox.Show("Ayıklama İşlemi Tamamlandı!!!", "Bilgilendirme Penceresi");

        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            txtBoxCurrentFrame.Enabled = false;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            suanki_frame = sayac;
            
            if (sayac == frame_Sayisi)
            {
                timer1.Stop();
                sayac = 0;

            }
            else
            {
                txtBoxCurrentFrame.Text = suanki_frame.ToString();
                pictureBox1.Image = frames[sayac];
                sayac++;
            }
            
            
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            resimler = new PictureBox[frame_Sayisi];
            String kaydet = folderBrowserDialog1.SelectedPath;

            frames[suanki_frame].Save(kaydet + "\\frame" + suanki_frame + ".bmp");

            MessageBox.Show("Dosya tek frame olarak kaydedilmiştir!!!", "Bilgilendirme Penceresi");
        }

        private void txtBoxCurrentFrame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sayac = Convert.ToInt32(txtBoxCurrentFrame.Text);
                txtBoxCurrentFrame.Text = sayac.ToString();
            }
            
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            sayac++;
            suanki_frame = sayac;
            txtBoxCurrentFrame.Text = sayac.ToString();
            pictureBox1.Image = frames[sayac];
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            sayac--;
            suanki_frame = sayac;
            txtBoxCurrentFrame.Text = sayac.ToString();
            pictureBox1.Image = frames[sayac];

        }

        private void cmboxFps_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000/ Convert.ToInt32(cmboxFps.Text); 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            String kaydet = folderBrowserDialog1.SelectedPath;
            Console.Write(kaydet);
            Console.ReadLine();
            int l = 0;

            for (int i = 0; i < frame_Sayisi; i++)
            {
                Bitmap bmp = new Bitmap(width, height);
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, arrayY[l], arrayY[l], arrayY[l]));
                        l++;
                    }
                }
                bmp.Save(kaydet + "\\çerçeve" + i + ".bmp");
            }

            MessageBox.Show(frame_Sayisi+"  adet frame seçtiğiniz klasöre kaydedilmiştir.!!!", "Bilgilendirme Penceresi");
            //liste = Directory.GetFiles(@kaydet, "*.bmp");
            //pictureBox1.Size = new Size(width, height);
            //pictureBox1.ImageLocation = liste[0];
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtBoxCurrentFrame.Enabled = true;
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            
            Console.ReadLine();
            int l = 0;

            frames = new Bitmap[frame_Sayisi];

            for (int i = 0; i < frame_Sayisi; i++)
            {
                Bitmap bmp = new Bitmap(width, height);
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        
                        bmp.SetPixel(x, y, Color.FromArgb(255, arrayY[l], arrayY[l], arrayY[l]));
                        l++;
                    }
                }
                frames[i] = bmp;
            }
            pictureBox1.Size = new Size(width, height);
            try
            {
                pictureBox1.Image = frames[0];

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen doğru ayarları seçtiğinizden emin olun!!!", "Bilgilendirme Penceresi");
            }
            cmboxFps.Text = "2";
            MessageBox.Show("Dönüştürme İşlemi Tamamlandı!!!", "Bilgilendirme Penceresi");
            btnOynat.Location = new Point(pictureBox1.Location.X-btnOynat.Size.Width, pictureBox1.Location.Y + height/2-btnOynat.Size.Height);
            btnDurdur.Location = new Point(btnOynat.Location.X , btnOynat.Location.Y+ btnOynat.Size.Height);
            btnOynat.Show();
            btnDurdur.Show();
            btnSol.Location = new Point((pictureBox1.Location.X+pictureBox1.Size.Width/2)-(btnSol.Size.Width*3/2),pictureBox1.Location.Y+height);
            txtBoxCurrentFrame.Location = new Point(btnSol.Location.X + btnSol.Size.Width, btnSol.Location.Y);
            txtBoxCurrentFrame.Show();
            btnSag.Location = new Point(txtBoxCurrentFrame.Location.X+txtBoxCurrentFrame.Size.Width, txtBoxCurrentFrame.Location.Y);
            btnSag.Show();
            btnSol.Show();
            
        }

        private void radioButton444_CheckedChanged(object sender, EventArgs e)
        {
            komut = 1;
        }

        private void radioButton422_CheckedChanged(object sender, EventArgs e)
        {
            komut = 2;
        }

        private void radioButton420_CheckedChanged(object sender, EventArgs e)
        {
            komut = 3;
        }
    }
}
