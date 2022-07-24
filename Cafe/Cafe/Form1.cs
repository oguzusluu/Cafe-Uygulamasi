using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    
    public partial class Form1 : Form
    {   
        const int LATTE = 0;
        const int AMERICANO = 1;
        const int ESPRESSO = 2;
        public Form1()
        {
            InitializeComponent();
        }
        int[] icecekadetleri = new int[3];
        string[] isim = { "Latte", "Americano", "Espresso" };
        int fiyat;
       
        private void UpdateLabel() 
        { 
           
            lbl_amrcn.Text = icecekadetleri[AMERICANO].ToString();
            lbl_latte.Text = icecekadetleri[LATTE].ToString();
            lbl_esprss.Text = icecekadetleri[ESPRESSO].ToString();
            lbl_fiyat.Text = fiyat.ToString();
        }

        private void btn_amcarti_Click(object sender, EventArgs e)
        {
          
            icecekadetleri[AMERICANO]++;
            fiyat += 28;
            UpdateLabel();
        }

        private void btn_amceksi_Click(object sender, EventArgs e)
        {
      
            if (icecekadetleri[AMERICANO] > 0)
            {
                icecekadetleri[AMERICANO]--;
                fiyat -= 28;
                UpdateLabel();
            }
        }

        private void btn_lattearti_Click(object sender, EventArgs e)
        {

            icecekadetleri[LATTE]++;
            fiyat += 24;
            UpdateLabel();

        }

        private void btn_latteeksi_Click(object sender, EventArgs e)
        {
           
            if (icecekadetleri[LATTE] > 0)
            {
                icecekadetleri[LATTE]--;
                fiyat -= 24;
                UpdateLabel();
            }

        }

        private void btn_espssarti_Click(object sender, EventArgs e)
        {

            icecekadetleri[ESPRESSO]++;
            fiyat += 20;
            UpdateLabel();

        }

        private void btn_espsseksi_Click(object sender, EventArgs e)
        {
           
            if (icecekadetleri[ESPRESSO] > 0)
            {
                icecekadetleri[ESPRESSO]--;
                fiyat -= 20;
                UpdateLabel();
            }

        }

        private void btn_stm_Click(object sender, EventArgs e)
        {
            string cikti = "";
            for (int i = 0; i < icecekadetleri.Length; i++)
            {
                if (icecekadetleri[i] == 0)
                {
                    continue;
                }
                cikti +=icecekadetleri[i] + " adet " + isim[i] +"\n";
            }   
            MessageBox.Show(cikti+fiyat+ "₺");

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < icecekadetleri.Length; i++)
            {
                icecekadetleri[i] = 0;
            }

            fiyat = 0;
            UpdateLabel();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
