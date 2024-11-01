using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud

            // Create Update Read Delete

            
            Console.WriteLine("***** Menü Sipariş İşlem Sayfası *****");

            Console.WriteLine();
            #region Yeni Kategori Ekleme İşlemi

            //Console.WriteLine("--------------------------");
            //Console.Write("Lütfen Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=EgitimKampiDB;Integrated Security=True;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz bir şekilde sorguyu çalıştırır.
            //connection.Close();

            //Console.WriteLine("Kategori Başarılı bir şekilde eklendi");
            #endregion

            #region Yeni Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı:");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı:");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=EgitimKampiDB;Integrated Security=True;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Ekleme Başarılı");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=EgitimKampiDB;Integrated Security=True;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command); // SQL den verileri C# tarafına çekme görevi görecek.

            //DataTable dataTable = new DataTable(); // bellekte istenilen bütün verileri tutabilmek için

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) // Her bir Satırı okumak için
            //{
            //    foreach (var rowItem in row.ItemArray) //okunan satırın sütünlarına bakmak için
            //    {
            //        Console.WriteLine(rowItem.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}



            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=EgitimKampiDB;Integrated Security=True;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);

            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProcutName=@productName = @productName, ProductPrice=@productPrice where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı!");
            #endregion

            Console.Read();

        }
    }
}
