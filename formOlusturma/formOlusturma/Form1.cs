using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formOlusturma
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private bool MukemmelSayilarKontrol(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }
            if (toplam == sayi)
                return true;
            else
                return false;
        }

        private bool AsalSayilarKontrol(int sayi)
        {
            if (sayi == 1) return false;
            else
            {
                int kontrol = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                        kontrol = 1;
                }
                if (kontrol == 0)
                    return true;
                else
                    return false;
            }
        }

        private void EkranTemizle()
        {
            baslangicSayisi.Text = bitisSayisi.Text = "";
            baslangicSayisi.Focus();
            listTek.Items.Clear();
            listCift.Items.Clear();
            listAsal.Items.Clear();
            listMukemmel.Items.Clear();
        }


        private bool SayiKontrol()
        {
            if(Convert.ToInt32(baslangicSayisi.Text) > Convert.ToInt32 (bitisSayisi.Text))
            {
                MessageBox.Show("Hata! Bitiş sayısı, başlangıç sayısından küçük olamaz.");
                return false;
            }

            if (Convert.ToInt32(baslangicSayisi.Text) <= 0 || Convert.ToInt32(bitisSayisi.Text) <= 0)
            {
                MessageBox.Show("Hata! Girdiğiniz sayı değerlerini kontrol ediniz.");
                return false;
            }
            else
                return true;
        }

        void TekListele(int tekToplam, double tekCarpim)
        {
            listTek.Items.Add("Tek Sayıların Toplamı:" + tekToplam);
            listTek.Items.Add("Tek Sayıların Çarpımı:" + tekCarpim);
        }

        void CiftListele(int ciftToplam, double ciftCarpim)
        {
            listCift.Items.Add("Çift Sayıların Toplamı:" + ciftToplam);
            listCift.Items.Add("Çift Sayıların Çarpımı:" + ciftCarpim);
        }

        void AsalListele(int asalToplam, double asalCarpim)
        {
            listAsal.Items.Add("Asal Sayıların Toplamı:" + asalToplam);
            listAsal.Items.Add("Asal Sayıların Çarpımı:" + asalCarpim);
        }

        void MukemmelListele(int mukemmelToplam, double mukemmelCarpim)
        {
            listMukemmel.Items.Add("Mükemmel Sayıların Toplamı:" + mukemmelToplam);
            listMukemmel.Items.Add("Mükemmel sayıların Çarpımı:" + mukemmelCarpim);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            EkranTemizle();
        }

        private void form_Load(object sender, EventArgs e)
        {
            notification.BalloonTipIcon = ToolTipIcon.Info;
            notification.BalloonTipTitle = "Hesap Makinesi";
            notification.BalloonTipText = "Programa Hoşgeldiniz!";
            notification.ShowBalloonTip(2000);
        }
        
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            int tekToplam = 0, ciftToplam = 0, asalToplam = 0, mukemmelToplam = 0;
            double tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1, mukemmelCarpim = 1;
            int baslangic, bitis;
            baslangic = Convert.ToInt32(baslangicSayisi.Text);
            bitis = Convert.ToInt32(bitisSayisi.Text);
            if(SayiKontrol())
            {

                for (int i = baslangic; i <= bitis; i++)
                {

                    if (i % 2 == 1)
                    {
                        tekToplam += i;
                        tekCarpim *= i;
                        listTek.Items.Add(i.ToString());
                    }
                    if(i % 2 == 0)
                    {
                        ciftToplam += i;
                        ciftCarpim *= i;
                        listCift.Items.Add(i.ToString());
                    }

                    if (AsalSayilarKontrol(i))
                    {
                        asalToplam += i;
                        asalCarpim *= i;
                        listAsal.Items.Add(i.ToString());
                    }

                    if (MukemmelSayilarKontrol(i))
                    {
                        mukemmelToplam += i;
                        mukemmelCarpim *= i;
                        listMukemmel.Items.Add(i.ToString());
                    }

                }

                 TekListele(tekToplam, tekCarpim);

                 CiftListele(ciftToplam, ciftCarpim);

                 if (asalToplam != 0)
                 {
                     AsalListele(asalToplam, asalCarpim);
                 }

                 if (mukemmelToplam != 0)
                 {
                     MukemmelListele(mukemmelToplam, mukemmelCarpim);
                 }

            }

        }

    }
}
