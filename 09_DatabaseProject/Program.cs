﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET

            Console.WriteLine("**** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi");

            Console.WriteLine();
            Console.WriteLine();

            string tabloNumber;

            Console.Write("---------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tabloNumber = Console.ReadLine();
            Console.Write("---------------------------");

            SqlConnection connection = new SqlConnection("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=EgitimKampiDB;Integrated Security=True;");


            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();// Verileri geçici(RAM) belleğe almak için

            adapter.Fill(dataTable);

            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
