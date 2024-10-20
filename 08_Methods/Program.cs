using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Methotlar
            //()
            //Geriye değer döndürmeyen metotlar (Void)


            //void CustomerList() //Metodu tanımladık
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Merve Öztürk");
            //    Console.WriteLine("Osman Çınar");
            //}

            //CustomerList(); //Metotu çağırdık




            //void Sum()
            //{
            //    int x = 1; int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " +  name + " "+  surName); 
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar
            //void Sum(int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}


            //Sum(3, 6, 7);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kılıç";

            //    return  name + " " + surname;   
            //}

            //StudentCard();

            #endregion

            #region Geriye Değer Döndüren Paremtreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = " Ülke: " + countryName + " - Başkent " + capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.WriteLine("Ülke Adını Giriniz: ");

            //x= Console.ReadLine();

            //Console.WriteLine("Başkenti Giriniz: ");

            //y= Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz: ");

            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Paremtreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,12));
            //Console.WriteLine(Sum(12,166));
            //Console.WriteLine(Sum(41,15));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti" + "Ortalama" + result;
            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi" + "Ortalama" + result;
            //    }
            //}
            //    Console.WriteLine(ExamResult("Ali", 25,41,55));
            //    Console.WriteLine(ExamResult("Ayşe", 41,66,85));

            #endregion
            Console.Read();

        }
    }
}
