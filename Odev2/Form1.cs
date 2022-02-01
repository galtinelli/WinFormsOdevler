using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Kullanıcıdan vize ve final notunu alıp vizenin %40'ı finalin %60'ını hesaplayarak ortalamayı bulan ve ortalamaya göre harf notunu ve geçme durumunu labellarda yazan form uygulaması,
        //NOT: Hata kontrolü yaparak ,metinsel ifade veya boş girildiğinde listeye ekleme yapmayacak ve kullanıcıya MessageBox ile uyarı verilecek

        //Not: 0-25:F 25-45:D,45-70:C,70-85:B,85-100:A
        //harf notu olmalı ve Fiçin kaldı d için koşullu geçti c,b,a için geçti ifadesi yer almalıdır.
        //notlar 0-100 aralığında girilmelidir.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double vize, final, ortalama;
        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            //TODO
            //vize ve final notlarının boş ve string girilmesini kontrol et


            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);
            if ((vize < 0 || vize > 100) || (final < 0 || final > 100))
            {
                MessageBox.Show("Hatalı veri girişi yapılmıştır.");
            }
            else
            {
                ortalama = (vize * 0.4) + (final * 0.6);
                if (ortalama >= 0 && ortalama < 25)
                {
                    MessageBox.Show($"Ortalamanız: {ortalama}  F ile KALDINIZ. ");
                }
                else if (ortalama >= 25 && ortalama < 45)
                {
                    MessageBox.Show($"Ortalamanız: {ortalama}  D ile Koşullu Geçtiniz. ");
                }
                else if (ortalama >= 45 && ortalama < 70)
                {
                    MessageBox.Show($"Ortalamanız: {ortalama} C ile Geçtiniz. ");
                }
                else if (ortalama >= 70 && ortalama < 85)
                {
                    MessageBox.Show($"Ortalamanız: {ortalama} B ile Geçtiniz. ");
                }
                else if (ortalama >= 85 && ortalama <= 100)
                {
                    MessageBox.Show($"Ortalamanız: {ortalama} A ile Geçtiniz. ");
                }
                else
                {
                    MessageBox.Show("Hatalı not girişi yapılmıştır.");
                }

            }

            //if ()
            //{
            //    MessageBox.Show("Hatalı veri girişi yapılmıştır.");
            //}



        }
    }
}