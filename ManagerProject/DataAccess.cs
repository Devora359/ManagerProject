
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;

namespace ManagerProject
{
    internal class DataAccess
    {

        //string connectionString = "Data Source=srv2\\pupils;Initial Catalog=Ex1;Integrated Security=True;Trust Server Certificate=True";
        //public DataAccess(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}
        public int InsertCategories(string connectionString)
        {
            string category_name;
            Console.WriteLine("insert category_name ");
            category_name = Console.ReadLine();

            string query = "INSERT INTO categories(category_name)" +
            "VALUES (@category_name) ";

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@category_name", SqlDbType.VarChar, 50).Value = category_name;

                // open connection, execute INSERT, close connection
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();

                return rowsAffected;
            }
        }
        public int InsertProduct(string connectionString)
        {
            string procuct_name, description, image_name;
            int category_id, price;
            Console.WriteLine("insert product_name ");
            procuct_name = Console.ReadLine();
            Console.WriteLine("insert description");
            description = Console.ReadLine();
            Console.WriteLine("insert image_url");
            image_name = Console.ReadLine();
            Console.WriteLine("insert category_id");
            category_id = int.Parse(Console.ReadLine());
            Console.WriteLine("insert price");
            price = int.Parse(Console.ReadLine());

            string query = "INSERT INTO products(product_name, description, image_url, category_id, price) " +
            "VALUES (@product_name, @description, @image_url, @category_id, @price) ";

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {

                // define parameters and their values
                cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = procuct_name;
                cmd.Parameters.Add("@description", SqlDbType.VarChar, 50).Value = description;
                cmd.Parameters.Add("@image_url", SqlDbType.VarChar, 50).Value = image_name;
                cmd.Parameters.Add("@category_id", SqlDbType.VarChar, 50).Value = category_id;
                cmd.Parameters.Add("@price", SqlDbType.VarChar, 200).Value = price;
                // open connection, execute INSERT, close connection
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();

                return rowsAffected;
            }
}
