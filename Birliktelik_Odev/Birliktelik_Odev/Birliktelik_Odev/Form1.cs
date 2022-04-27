using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birliktelik_Odev
{
    public partial class Form1 : Form
    {
        int fisSayisi;
        double esikDestekSonuc;
        int ekmekAdet;
        int sutAdet;
        int icecekAdet;
        int kolaAdet;
        int yumurtaAdet;
        int bezAdet;

        int ekmekSutAdet;
        int ekmekİcecekAdet;
        int ekmekKolaAdet;
        int ekmekYumurtaAdet;
        int ekmekBezAdet;

        int sutİcecekAdet;
        int sutKolaAdet;
        int sutYumurtaAdet;
        int sutBezAdet;

        int icecekKolaAdet;
        int icecekYumurtaAdet;
        int icecekBezAdet;

        int kolaYumurtaAdet;
        int kolaBezAdet;

        int yumurtaBezAdet;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsikDestek_Click(object sender, EventArgs e)
        {
            fisSayisi = dataGridView1.Rows.Count;
            esikDestekSonuc = Convert.ToDouble(0.60 * fisSayisi);
            lblEsikDestekSonuc.Text = esikDestekSonuc.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFrekans_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                ekmekAdet += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            lstDestekDegerler.Items.Add("Ürün Ekmek Toplam : " + ekmekAdet.ToString());


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sutAdet += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            lstDestekDegerler.Items.Add("Ürün Süt Toplam : "+sutAdet.ToString());


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                icecekAdet += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lstDestekDegerler.Items.Add("Ürün İçecek Toplam : " + icecekAdet.ToString());


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                kolaAdet += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lstDestekDegerler.Items.Add("Ürün Kola Toplam : " + kolaAdet.ToString());


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                yumurtaAdet += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lstDestekDegerler.Items.Add("Ürün Yumurta Toplam : " + yumurtaAdet.ToString());


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                bezAdet += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            lstDestekDegerler.Items.Add("Ürün Bez Toplam : " + bezAdet.ToString());
        }

        private void btnYeniTablo_Click(object sender, EventArgs e)
        {
            if(ekmekAdet >= esikDestekSonuc)
            {
                lstEsikYeniTablo.Items.Add("Ekmek Yeni Adet :" + ekmekAdet);
            }


            if (sutAdet >= esikDestekSonuc)
            {
                lstEsikYeniTablo.Items.Add("Süt Yeni Adet :" + sutAdet);
            }

            if (icecekAdet >= esikDestekSonuc)
            {
                lstEsikYeniTablo.Items.Add("İçecek Yeni Adet :" + icecekAdet);
            }

            if (kolaAdet >= esikDestekSonuc)
            {
                lstEsikYeniTablo.Items.Add("Kola Yeni Adet :" + kolaAdet);
            }

            if (yumurtaAdet >= esikDestekSonuc)
            {
                lstEsikYeniTablo.Items.Add("Yumurta Yeni Adet :" + yumurtaAdet);
            }

            if (bezAdet >= esikDestekSonuc)
            {
                lstEsikYeniTablo.Items.Add("Bez Yeni Adet :" + bezAdet);
            }
        }

        private void btnIkiliGrup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) ==1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)==1)
                {

                    ekmekSutAdet++;
                }

            }
            lstIkiliGrup.Items.Add("(Ekmek,Süt) :" + ekmekSutAdet.ToString());

            if (ekmekSutAdet >= esikDestekSonuc)
            {
                lstYeniTablo2.Items.Add("(Ekmek,Süt) :" + ekmekSutAdet.ToString());
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == 1)
                {
                    ekmekİcecekAdet++;
                    

                    if (ekmekİcecekAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Ekmek,İçecek) :" + ekmekİcecekAdet.ToString());
                    }
                }
               
            }
             lstIkiliGrup.Items.Add("(Ekmek,İçecek) :" + ekmekİcecekAdet.ToString());
            
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == 1)
                {
                    ekmekKolaAdet++;
                    

                    if (ekmekKolaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Ekmek,Kola) :" + ekmekKolaAdet.ToString());
                    }
                }
            }
            lstIkiliGrup.Items.Add("(Ekmek,Kola) :" + ekmekKolaAdet.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) == 1)
                {
                    ekmekYumurtaAdet++;
                    

                    if (ekmekYumurtaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Ekmek,Yumurta) :" + ekmekYumurtaAdet.ToString());
                    }
                }
            }
            lstIkiliGrup.Items.Add("(Ekmek,Yumurta) :" + ekmekYumurtaAdet.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) == 1)
                {
                    ekmekBezAdet++;
                    

                    if (ekmekBezAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Ekmek,Bez) :" + ekmekBezAdet.ToString());
                    }
                }
            }

             lstIkiliGrup.Items.Add("(Ekmek,Bez) :" + ekmekBezAdet.ToString());
             lstIkiliGrup.Items.Add("**************************************************");


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == 1)
                {

                    sutİcecekAdet++;
                    

                    if (sutİcecekAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Süt,İçecek) :" + sutİcecekAdet.ToString());
                    }
                }

            }
            lstIkiliGrup.Items.Add("(Süt,İçecek) :" + sutİcecekAdet.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == 1)
                {
                    sutKolaAdet++;
                   

                    if (sutKolaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Süt,Kola) :" + sutKolaAdet.ToString());
                    }
                }
            }
             lstIkiliGrup.Items.Add("(Süt,Kola) :" + sutKolaAdet.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) == 1)
                {
                    sutYumurtaAdet++;
                    

                    if (sutYumurtaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Süt,Yumurta) :" + sutYumurtaAdet.ToString());
                    }
                }
            }
            lstIkiliGrup.Items.Add("(Süt,Yumurta) :" + sutYumurtaAdet.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) == 1)
                {
                    sutBezAdet++;
                    

                    if (sutBezAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Süt,Bez) :" + sutBezAdet.ToString());
                    }
                }
            }
            lstIkiliGrup.Items.Add("(Süt,Bez) :" + sutBezAdet.ToString());

            lstIkiliGrup.Items.Add("**************************************************");


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == 1)
                {

                    icecekKolaAdet++;
                    

                    if (icecekKolaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(İçecek,Kola) :" + icecekKolaAdet.ToString());
                    }
                }

            }
            lstIkiliGrup.Items.Add("(İçecek,Kola) :" + icecekKolaAdet.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) == 1)
                {
                    icecekYumurtaAdet++;
                    

                    if (icecekYumurtaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(İçecek,Yumurta) :" + icecekYumurtaAdet.ToString());
                    }
                }
            }
             lstIkiliGrup.Items.Add("(İçecek,Yumurta) :" + icecekYumurtaAdet.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) == 1)
                {
                    icecekBezAdet++;
                    

                    if (icecekBezAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(İçecek,Bez) :" + icecekBezAdet.ToString());
                    }
                }
            }
            lstIkiliGrup.Items.Add("(İçecek,Bez) :" + icecekBezAdet.ToString());
            lstIkiliGrup.Items.Add("**************************************************");


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) == 1)
                {

                    kolaYumurtaAdet++;
                    

                    if (kolaYumurtaAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Kola,Yumurta) :" + kolaYumurtaAdet.ToString());
                    }
                }

            }
             lstIkiliGrup.Items.Add("(Kola,Yumurta) :" + kolaYumurtaAdet.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) == 1)
                {
                    kolaBezAdet++;
                    

                    if (kolaBezAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Kola,Bez) :" + kolaBezAdet.ToString());
                    }
                }
            }
            lstIkiliGrup.Items.Add("(Kola,Bez) :" + kolaBezAdet.ToString());
            lstIkiliGrup.Items.Add("**************************************************");


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) == 1 && Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) == 1)
                {

                    yumurtaBezAdet++;
                    

                    if (yumurtaBezAdet >= esikDestekSonuc)
                    {
                        lstYeniTablo2.Items.Add("(Yumurta,Bez) :" + yumurtaBezAdet.ToString());
                    }
                }

            }

            lstIkiliGrup.Items.Add("(Yumurta,Bez) :" + yumurtaBezAdet.ToString());

        }

        private void btnYeniTablo2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
