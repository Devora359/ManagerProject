
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=srv2\\pupils;Initial Catalog=9147_shop;Integrated Security=True;Trust Server Certificate=True";
            DataAccess ds = new DataAccess();
            ds.InsertCategories(connectionString);
            ds.InsertProduct(connectionString);
        }
    }
}