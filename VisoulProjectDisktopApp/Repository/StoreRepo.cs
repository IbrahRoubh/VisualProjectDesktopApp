using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;

namespace VisoulProjectDisktopApp.Repository
{
    internal class StoreRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=1133");

        public List<StoreModel> getStores()
        {
            try
            {
                List<StoreModel> stores = new List<StoreModel>();
                String query = "SELECT ID,name,location,phone FROM Store";
                SqlCommand command = new SqlCommand(query,conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    StoreModel store = new StoreModel();

                    store.ID = (int)reader["ID"];
                    store.name = (string)reader["name"];
                    store.location = (string)reader["location"];
                    store.phone = (string)reader["phone"];

                    stores.Add(store);
                }
                return stores;
            }catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
                return null;
            }finally { 
                conn.Close();
            }
        }

        public List<ProductModel> getStoreProduscts(int SID)
        {
            List<ProductModel> products = new List<ProductModel>();
            try
            {
                String query = "SELECT Stok.amount, Product.* FROM Stok JOIN Product ON Stok.PID = Product.id\r\nWHERE Stok.SID = '"+ SID +"'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductModel product = new ProductModel();
                    product.id = (int)reader["ID"];
                    product.name = (string)reader["name"];
                    product.description = (string)reader["description"];
                    product.code = (string)reader["code"];
                    product.amount = (int)reader["amount"];
                    products.Add(product);
                }
                return products;
            }catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
