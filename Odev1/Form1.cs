using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Odev 1:
        //Ekranda bulunan bir textBox'ta alınan sayıları (ondalıklı da girilebilir) hata kontrolü yaparak Eleman Ekle butonuna tıklandığında bir listeye ekleyiniz. Daha sonra, Ekrana Yazdır btonunu tıklandığında bu listenin içerisinde bulunan sayıların en küçüğünü ve en büyüğünü MessageBox ile ekrana yazdır.

        //Not 1:
        //metinsel ifade veya boş girildiğinde listeye ekleme yapmayacak ve kullanıcıya MessageBox ile uyarı verilecek

        //Not 2:Eleman ekle butonun a tıklandığında eleman eklendi uyarısı verecek ve textbox temizlenecek

        List<double> sayilar = new List<double>();
        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
                bool sayiMi = double.TryParse(txtSayiGiris.Text,out double sayi);
                if (sayiMi==true)
                {
                    sayilar.Add(sayi);
                    MessageBox.Show("Eleman eklendi");
                    
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Değer Listeye Eklenmedi");
                }
                txtSayiGiris.Clear();
                //txtSayiGirisi.Text="";
        }

        private void btnEkranaYaz_Click(object sender, EventArgs e)
        {

            //Daha sonra, Ekrana Yazdır btonunu tıklandığında bu listenin içerisinde bulunan sayıların en küçüğünü ve en büyüğünü MessageBox ile ekrana yazdır.

            sayilar.Sort();
            MessageBox.Show("Girilen sayıladan en küçüğü: " + sayilar[0] + "\n Girilen sayıların en büyüğü: " + sayilar[sayilar.Count - 1]);
        }

    }
}
