using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;

namespace VisoulProjectDisktopApp.Repository
{
    internal class ProductRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=123");

        public void addProduct(String name,String description,String code,int amount, decimal price, int FID)
        {
            try
            {
                // add the product
                String query = "INSERT INTO Product(name,description,code, price,FID)" +
                    " VALUES('" + name + "','" + description + "','" + code + "'" +
                    ",'"+price+"','" + FID + "')";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("You should change the name!! "+ FID);
                return ;
            }
            try { 
                // have the new product id
                String query2 = "SELECT ID FROM Product WHERE name = '"+name+"'";
                SqlCommand command = new SqlCommand(query2,conn);
                int PID = (int)command.ExecuteScalar();
                
                // set the amount 
                String query3 = "INSERT INTO report(amount,FID,PID) VALUES('" + amount + "','" + FID + "','"+PID+"')";
                command = new SqlCommand(query3,conn);
                command.ExecuteNonQuery();

                MessageBox.Show("The product has been added successfully");
            }
            catch(Exception ex )
            {
                MessageBox.Show("error "+ ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public ProductModel getProduct(int PID)
        {
            try
            {
                String query = "SELECT * FROM Product WHERE ID ='"+ PID +"';";
                SqlCommand command = new SqlCommand(query,conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                ProductModel product = new ProductModel();
                if (reader.Read())
                {
                    product.id = (int)reader["ID"];
                    product.name = (String)reader["name"];
                    product.description = (String)reader["description"];
                    product.code = (String)reader["code"];
                    product.FID = (int)reader["FID"];
                }

                return product;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error for= "+PID+"  " + ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
