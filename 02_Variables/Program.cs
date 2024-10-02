using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.55;

            //Console.WriteLine(number);


            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " \u20BA");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " \u20BA");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " \u20BA");


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Elmanın Toplam Fiyatı: " + appleTotalPrice + " ₺");
            //Console.WriteLine("Alınan Portakalın Toplam Fiyatı: " + orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Çileğin Toplam Fiyatı: " + strawberryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Patetesin Toplam Fiyatı: " + potatoTotalPrice + " ₺");
            //Console.WriteLine("Alınan Domatesin Toplam Fiyatı: " + tomatoTotalPrice + " ₺");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice;

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "₺");
            #endregion

            #region Char Değişkenler

            //char symbol;

            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçesi: ");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------");

            //Console.WriteLine("Yolcu TC Kimlik No: "+ passangerIdentityNumber + "Yolcu Adı Soyadı : " + passangerName + " " + passangerSurname + " " + passangerDistrict + " " + passangerCity + " " + passangerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");

            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");

            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
             
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");

            //tvPrice = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav Notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav Notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);  


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            #endregion


            Console.Read();
        }
    }
}
