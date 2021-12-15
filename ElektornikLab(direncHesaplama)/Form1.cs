using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektornikLab_direncHesaplama_
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

        private void DB_btnHesapla_Click(object sender, EventArgs e)
        {
            
            int DB_birinciBand = DB_cmbBoxBirinciBand.SelectedIndex *10;
            int DB_ikinciBand = DB_cmbBoxIkinciBant.SelectedIndex;

            double[] carpanDegeri = {1, 10, 100, 1000, 10000, 100000, 100000, 10000000, 0.1, 0.01};
            double DB_carpan = carpanDegeri[DB_cmbBoxCarpan.SelectedIndex];

            double[] toleransDegeri = { 1, 2, 0.5, 0.25, 0.10, 0.05, 5, 10 };

            double artılıSonuc = ((DB_birinciBand + DB_ikinciBand) * DB_carpan) + 
                ((DB_birinciBand + DB_ikinciBand) * DB_carpan) * toleransDegeri[DB_cmbBoxTolerans.SelectedIndex] / 100;
            double eksiliSonuc = ((DB_birinciBand + DB_ikinciBand) * DB_carpan) - 
                ((DB_birinciBand + DB_ikinciBand) * DB_carpan) * toleransDegeri[DB_cmbBoxTolerans.SelectedIndex] / 100;

            DB_txtBoxSonuc1.Text = eksiliSonuc.ToString();
            DB_txtBoxSonuc2.Text = artılıSonuc.ToString();

        }

        private void BB_btnHesapla_Click(object sender, EventArgs e)
        {

            int BB_birinciBand = BB_cmbBoxBirinciBand.SelectedIndex*100;
            int BB_ikinciBand = BB_cmbBoxIkınciBand.SelectedIndex*10;
            int BB_ucuncuBand = BB_cmbBoxUcuncuBand.SelectedIndex;

            double[] carpanDegeri = { 1, 10, 100, 1000, 10000, 100000, 100000, 10000000, 0.1, 0.01 };
            double BB_carpan = carpanDegeri[BB_cmbBoxCarpan.SelectedIndex];

            double[] toleransDegeri = { 1, 2, 0.5, 0.25, 0.10, 0.05, 5, 10 };
            double a = ((BB_birinciBand + BB_ikinciBand + BB_ucuncuBand) * BB_carpan);

            double artılıSonuc = ((BB_birinciBand + BB_ikinciBand + BB_ucuncuBand) * BB_carpan) + 
                ((BB_birinciBand + BB_ikinciBand + BB_ucuncuBand) * BB_carpan) * toleransDegeri[BB_cmbBoxTolerans.SelectedIndex] / 100;
            double eksiliSonuc = ((BB_birinciBand + BB_ikinciBand + BB_ucuncuBand) * BB_carpan) -
                ((BB_birinciBand + BB_ikinciBand + BB_ucuncuBand) * BB_carpan) * toleransDegeri[BB_cmbBoxTolerans.SelectedIndex] / 100;

            BB_txtBoxSonuc1.Text = eksiliSonuc.ToString();
            BB_txtBoxSonuc2.Text = artılıSonuc.ToString();

        }
    }
}
