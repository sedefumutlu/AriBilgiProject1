using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //Console.Write("Kullanici Adı=");
            //string kullaniciAdi = Console.ReadLine();
            //Console.Write("Sifre = ");
            //string Sifre = Console.ReadLine();
            //Rol rolu = default(Rol);

            //if (kullaniciAdi == "cem" && Sifre == "1234")
            //    rolu = Rol.Admin;
            //else if (kullaniciAdi == "A" && Sifre == "1234")
            //    rolu = Rol.Musteri;
            //else if (kullaniciAdi == "B" && Sifre == "1234")
            //    rolu = Rol.Danisman;
            //else
            //    rolu = default(Rol);

            //switch (rolu)
            //{
            //    case Rol.Admin:
            //        Console.WriteLine("Admin Paneline hoşgeldiniz");
            //        break;
            //    case Rol.Musteri:
            //        Console.WriteLine("Musteri Paneline hoşgeldiniz");
            //        break;
            //    case Rol.Danisman:
            //        Console.WriteLine("Danısman Paneline hoşgeldiniz");
            //        break;
            //    default:
            //        Console.WriteLine("Yetkisiz Giris");
            //        break;
            //}
            #endregion

            #region ÖRnek 2
            //for (int sayi = 0; sayi <= 10; sayi++)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion

            #region Örnek 3
            //Sonsuz Döngü
            //for(;true; )
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}
            #endregion

            #region d den r ye  kadar olan harfleri yazan prg.
            //for (char harf = 'd'; harf <= 'r'; harf++)
            //{
            //    Console.Write("{0} ",harf);
            //}
            #endregion

            #region 10 dan 0 a kadar olan sayıları yazan prg.
            //for (sbyte i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region i ve j degiskeni birbirine esit olana kadar ekrana yazan prg.
            //for (int i = 0, j = 10; i <= j ; i++, j--)
            //{
            //    Console.WriteLine("i:{0} , j:{1}", i, j);
            //}
            #endregion

            #region Klavyeden 0 girilene kadar olan sayıların toplamını yazan prg.
            //int toplamSayac = 0;
            //int sayi = 1;
            //for (; sayi != 0; )
            //{
            //    Console.Write("Sayı Giriniz = ");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplamSayac += sayi;
            //}
            //Console.WriteLine("Sonuc : {0}",toplamSayac);

            #endregion

            #region While Döngüsü
            //int sayi = 1, toplamSayac = 0;
            //while (sayi != 0)
            //{
            //    Console.Write("Sayı Giriniz =");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplamSayac += sayi;
            //}
            //Console.WriteLine("Sonuc: {0}", toplamSayac);
            #endregion

            #region 0 dan 20 ye kadar cift olan sayıları ekrana yazan prg.
            //int sayi = 0;
            //while (sayi<=20)
            //{
            //    int kalan = sayi % 2;
            //    if(kalan == 0) // Cifttir
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi++;
            //}
            #endregion

            #region Sayi tahmin oyunu
            //while (true)
            //{
            //    Random rnd = new Random();
            //    int rastSayi = rnd.Next(0, 10);
            //    byte tahminSayisi = 1;
            //    while (tahminSayisi <= 5)
            //    {
            //        Console.Write("{0}. Tahmin =", tahminSayisi);
            //        int tahmin = int.Parse(Console.ReadLine());
            //        if (tahmin == rastSayi)
            //        {
            //            Console.WriteLine("Tebrikler {0} tahminde bildiniz..", tahminSayisi);
            //            break;
            //        }
            //        tahminSayisi++;
            //    }
            //    if (tahminSayisi > 5)
            //    {
            //        Console.WriteLine("Oyunu Kaybettiniz..");
            //        Console.WriteLine("Rastgele Sayı : {0}", rastSayi);
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}
            #endregion

            #region 1 den 21 ye kadar olan tek sayıları ekrana yazan prg.
            //int sayi = 1;
            //do
            //{
            //    if (sayi % 2 == 1)
            //        Console.WriteLine(sayi);
            //    sayi++;
            //} while (sayi <= 21);
            #endregion

            #region Continue Deyimi
            //for (char harf = 'A'; harf <= 'F'; harf++)
            //{
            //    Console.WriteLine(harf);
            //    if (harf == 'D')
            //        continue;
            //    Console.WriteLine("Merhaba");
            //}
            #endregion

            #region Asal Sayı Bulma
            //bool Asaldir = true;
            //Console.Write("Sayı Giriniz=");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 2; i < sayi; i++) //Bolenleri bulduk
            //{
            //    if (sayi % i == 0)
            //    {
            //        Asaldir = false;
            //        break;
            //    }

            //}
            //if (Asaldir)
            //    Console.WriteLine("sayi Asaldir");
            //else
            //    Console.WriteLine("Sayı asal degildir.");
            #endregion

            #region Min max arasındaki asal sayiları bulan prg.
            //Console.Write("Min Sayi = ");
            //int min = int.Parse(Console.ReadLine());
            //Console.Write("Max Sayi = ");
            //int max = int.Parse(Console.ReadLine());

            //for (int i = min; i <= max; i++) //Aralık icindeki sayı döner
            //{
            //    bool Asaldir = true;
            //    for (int bolen = 2; bolen < i; bolen++) // Bolenleri tutar
            //    {
            //        if (i % bolen == 0)
            //        {
            //            Asaldir = false;
            //            break;
            //        }
            //    }
            //    if (Asaldir)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region Üçgen fornatında * karakteri pattern'i olusturan prog.
            //Console.Write("Sayi = ");
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++) // Satirlar icin döner
            //{
            //    for (int j = 1; j <= i; j++) //Yıldız karakterinin sayisi kullanılacak
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Üçgen fornatında * karakter pattern'i tersten olusturan prog.
            //Console.Write("Sayi = ");
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = sayi; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Bir metni istebilen sayıda ekrana yazan prg.
            //Console.Write("Metin yazınız= ");
            //string metin = Console.ReadLine();
            //Console.Write("Kac kere tekrar edecek = ");
            //int tekrarSayisi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= tekrarSayisi; i++)
            //    Console.WriteLine("{0}. {1}",i,metin);
            #endregion

            #region Faktoriyel hesabı yapan prog.
            //Console.Write("Sayi giriniz =");
            //int sayi = int.Parse(Console.ReadLine());
            //int carpim = 1;

            //for (int i = 2; i <= sayi; i++)
            //{
            //    carpim *= i;
            //}
            //Console.WriteLine("Sonuc : {0}", carpim);
            #endregion

            #region Tek sayıların karesi cift sayıların küpünü alan prg.
            //for (int i = 1; i <= 50; i++)
            //{
            //    int sonuc;
            //    sonuc = i % 2 == 1 ? i * i : i * i * i;
            //    Console.WriteLine("{0} = {1}",i,sonuc);
            //}
            #endregion

            #region Örnek
            //int yuz200arasiAdet = 0, toplamSayac = 0, toplamSayac2=0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0}. Sayi = ", i);
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi >= 100 && sayi < 200)
            //        yuz200arasiAdet++;
            //    else if (sayi < 100)
            //    {
            //        toplamSayac += sayi;
            //    }
            //    else if (sayi > 200 && sayi % 4 == 0)
            //    {
            //        toplamSayac2 += sayi;
            //    }
            //}

            //Console.WriteLine("100 ile 200 arasındaki sayıların Adedi: {0}", yuz200arasiAdet);
            //Console.WriteLine("100 den kucuk olanlarının toplami : {0}", toplamSayac);
            //Console.WriteLine("200 den buyuk ve 4 e tam bolunen sayiların toplami : {0}", toplamSayac2);
            #endregion

            #region 1+2+4+8+16+32+64+128+256+512+1024 cıktı veren prg.
            #region 1.Yol
            //for (int i = 0; i <= 10; i++)
            //{
            //    int carpim = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        carpim *= 2;
            //    }
            //    Console.Write("{0}+", carpim);
            //}
            #endregion
            #region 2.Yol
            for (int i = 0; i <= 10; i++)
                Console.Write("{0}+", Math.Pow(2,i));
            #endregion
            #endregion
        }
    }
}
