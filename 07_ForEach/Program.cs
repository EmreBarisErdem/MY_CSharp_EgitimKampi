﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Döngüsü

            // ForEach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste,Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}




            //int[] numbers = { 1, 2, 23, 515, 122, 3151, 1515, 15, 2 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}




            //int[] numbers = { 1, 2, 23, 515, 122, 3151, 1515, 15, 2 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}





            //int[] numbers = { 1, 2, 23, 515, 122, 3151, 1515, 15, 2 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);




            //List<int> numbers = new List<int>()
            //{
            //    1,2,3, 4,5,6,7,8,9,10,11,12,13,14, 
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion
            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            Console.WriteLine("-------------------------------------------");

            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");

                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value; //notları topluyoruz...
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }


            //Sınav Ortalamaları


            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");

                //öğrencilerin ortalaması ve geçip kalması durumları...

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("-------------------------------------------");
            }






                #endregion




                Console.Read();
            }
        }
    }
