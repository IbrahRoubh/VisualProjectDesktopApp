using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using VisoulProjectDisktopApp.model;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace VisoulProjectDisktopApp
{
    internal class FactoryRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=123");
        
        public FactoryModel getFactoryById(int id)
        {
            try
            {
                string query = "SELECT * FROM Factory WHERE ID = '" + id + "'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                FactoryModel factory = new FactoryModel();
                if (reader.Read())
                {
                    factory.id = (int)reader["ID"];
                    factory.name = (String)reader["name"];
                    factory.password = (String)reader["password"];
                    factory.location = (String)reader["location"];
                    factory.phoneNum = (String)reader["phone"];
                    factory.email = (String)reader["email"];
                }
                return factory;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
                return null;
            }
            finally { conn.Close(); }



        }
        
        public FactoryModel getUser(String email,String password)
        {
            try
            {
                String query = "SELECT * from Factory where email = '" + email + "';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                FactoryModel factory = new FactoryModel();
                if (reader.Read())
                {
                    factory.id = (int)reader["ID"];
                    factory.name = (String)reader["name"];
                    factory.password = (String)reader["password"];
                    factory.location = (String)reader["location"];
                    factory.phoneNum = (String)reader["phone"];
                    factory.email = (String)reader["email"];
                }
                if (reader != null)
                {
                    string DBpassword = factory.password;
                    if (password == DBpassword)
                    {
                        return factory;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch {
                
                return null;
            }
            finally
            {
                conn.Close();
            }
        }   

        public void updateFactory(int ID,String name,String location,String phone, String password)
        {
            try
            {
                String query = "UPDATE Factory SET name = '" + name + "',location = '" + location + "', phone = '" + phone + "', password = '" + password + "' WHERE ID= '" + ID + "'";
                conn.Open();
                SqlCommand command = new SqlCommand(query,conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Update completed successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " +ex);
            }
            finally
            {
                conn.Close();
            }           
        }

        public List<SuppliesModel> getRequest(int FID)
        {
            try
            {
                String query = "SELECT * FROM supplies WHERE FID ='"+FID+ "' AND Direction ='factory' " +
                    "AND Status ='ordered';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<SuppliesModel> supplies = new List<SuppliesModel>();

                while (reader.Read())
                {
                    SuppliesModel supplie = new SuppliesModel();
                    supplie.id = (int)reader["ID"];
                    supplie.FID = (int)reader["FID"];
                    supplie.SID = (int)reader["SID"];
                    supplie.PID = (int)reader["PID"];
                    supplie.amount = (int)reader["amount"];
                    supplie.Direction = ((String)reader["Direction"]).Trim();
                    supplie.date_of_arrival = (DateTime)reader["date_of_arrival"];
                    supplie.status = ((String)reader["Status"]).Trim();

                    supplies.Add(supplie);
                }
                return supplies;
            }catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int getReustAmount(int FID)
        {
            try
            {
                int amount=0;
                string query = "SELECT COUNT(*) FROM supplies WHERE FID ='" + FID+"'" +
                    " AND Direction ='factory' AND Status ='ordered';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    amount = Convert.ToInt32(result);
                    
                }

                return amount;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("error " + ex);
                return 0;
            }
            finally
            {
                conn.Close() ;
            }

        }

        public List<ProductModel> getFactoryProducts(int FID)
        {
            try
            {
                string query = "SELECT * FROM Product WHERE FID = '"+FID+"';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<ProductModel> products = new List<ProductModel>{ };

                while (reader.Read())
                {
                    ProductModel product = new ProductModel();
                    product.id = (int)reader["ID"];
                    product.name = (string)reader["name"];
                    product.description = (string)reader["description"];
                    product.code = (string)reader["code"];
                    product.FID = (int)reader["FID"];
                    product.price = reader.GetSqlMoney(reader.GetOrdinal("price"));

                    products.Add(product);
                }

                return products;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " +ex);
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int getProductAmount(int PID, int FID)
        {
            try
            {
                int amount = 0;
                string query = "SELECT amount FROM report WHERE FID = '"+FID+"' AND PID='"+PID+"'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    amount = Convert.ToInt32(result);
                }
                return amount;
            }
            catch(Exception ex )
            {
                MessageBox.Show("error " + ex);
                return 0;
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
