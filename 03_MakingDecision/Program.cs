using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz");
            //string password;

            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}


            //int sayi;

            //sayi = int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}


            //int exam1, exam2, exam3, avarage;

            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (avarage >50 & avarage < 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if(avarage > 84)
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion


            #region Mod İşlemleri

            //int number;

            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);






            //Console.WriteLine("Lütfen 1.Sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan : " + result);







            //Console.WriteLine("Lütfen sayıyı giriniz");

            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion


            #region Char değişkenler ile Karar

            //char team;
            //Console.WriteLine("lütfen takım sembolünü giriniz: ");

            //team = char.Parse(Console.ReadLine());

            //if(team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine(" **** C# Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");

            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fırında Somon");
            //    Console.WriteLine("4- Patlıcan Musakka");
            //    Console.WriteLine("5- Fasulye Pilav");
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorba");


            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fırında Somon");
            //    Console.WriteLine("4- Patlıcan Musakka");
            //    Console.WriteLine("5- Fasulye Pilav");
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //}  
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fırında Somon");
            //    Console.WriteLine("4- Patlıcan Musakka");
            //    Console.WriteLine("5- Fasulye Pilav");
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fırında Somon");
            //    Console.WriteLine("4- Patlıcan Musakka");
            //    Console.WriteLine("5- Fasulye Pilav");
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //}






            #endregion


            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default:
            //        Console.WriteLine("Hatalı veri girişi");
            //        break;
            //}

            #endregion


            #region Switch Case Hesap Makinesi

            //int number1, number2, result;

            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;

              

            //}

            #endregion

            Console.Read();



        }
    }
}
