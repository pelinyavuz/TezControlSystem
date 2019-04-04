using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Math.Geometry;
using System.Drawing.Imaging;
namespace TezControlSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Blob[] blobs;
        int sayac;
        int toplamSekilSayisi;
        Bitmap kaynakResim;
        Bitmap siyahBeyazResim;

        private void socketadd_Click(object sender, EventArgs e)
        {
            OpenFileDialog rs = new OpenFileDialog();
            rs.Title = "Resim Seç";
            rs.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";

            if (rs.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(rs.OpenFile());
            }

            sayac = 1;
            Bitmap kaynakResim = new Bitmap(pictureBox1.Image);

            //Otsu Threshold uygulandı
            OtsuThreshold otsuFiltre = new OtsuThreshold();
            //resim eğer renkliyse önce griye çeviriyor sonra filtre uyguluyor
            //resim zaten griyse direk filtreyi uyguluyor
            siyahBeyazResim = otsuFiltre.Apply(kaynakResim.PixelFormat != PixelFormat.Format8bppIndexed ? Grayscale.CommonAlgorithms.BT709.Apply(kaynakResim) : kaynakResim);

            BlobCounterBase bc = new BlobCounter();
            bc.FilterBlobs = true;
            bc.MinHeight = 5;
            bc.MinWidth = 5;

            bc.ProcessImage(siyahBeyazResim);
            blobs = bc.GetObjectsInformation();

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                if (blobs.Length > 0)
                {

                    bc.ExtractBlobsImage(siyahBeyazResim, blobs[i], true);
                    pictureBox1.Image = siyahBeyazResim;
                    pictureBox1.Refresh();
                }

            }
        }

        private void deleteedges_Click(object sender, EventArgs e)
        {
            //filtre oluşturuldu
            ExtractBiggestBlob filtre = new ExtractBiggestBlob();
            //filtre uygulandı
            Bitmap temizResim = filtre.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = temizResim;
        }

        private void colorize_Click(object sender, EventArgs e)
        {
            //filtre oluşturuldu
            ConnectedComponentsLabeling filtre = new ConnectedComponentsLabeling();
            Bitmap boyaliResim = filtre.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = boyaliResim;
        }

        private void nextstep_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = blobs[sayac - 1].Image.ToManagedImage();

            if (sayac == toplamSekilSayisi)
            {
                sayac = 0;
            }
            sayac++;
        }
    }

}
    
