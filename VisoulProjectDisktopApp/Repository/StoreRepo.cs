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
    }
}
