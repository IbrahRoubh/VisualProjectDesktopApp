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
    internal class CustomerRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=123");

        public CustomerModel getCustomerById(int id) 
        {
            try
            {
                string query = "SELECT * FROM Customer WHERE id='"+id+"'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                CustomerModel customer = new CustomerModel();
                
                if(reader.Read())
                {
                    customer.Id = (int)reader["id"];
                    customer.Name = (string)reader["name"];
                    customer.Email = (string)reader["email"];
                    customer.Phone = (string)reader["phone"];
                    customer.Location = (string)reader["location"];
                    customer.Password = (string)reader["password"];
                }

                return customer;
            }catch 
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        
        
        }

        public CustomerModel isUser(String email, String password)
        {
            try
            {
                String query = "SELECT * from Customer where email = '" + email + "'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CustomerModel customer = new CustomerModel();

                    customer.Id = (int)reader["id"];
                    customer.Name = (string)reader["name"];
                    customer.Email = (string)reader["email"];
                    customer.Phone = (string)reader["phone"];
                    customer.Location = (string)reader["location"];
                    customer.Password = (string)reader["password"];

                    if (password == customer.Password)
                    {
                        return customer;
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
            catch(Exception ex)
            {
                MessageBox.Show("error "+ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean isValidEmail(String email)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Customer WHERE Customer.email='" + email + "';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)command.ExecuteScalar();

                if(count == 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean addCustomer(CustomerModel customer)
        {
            try
            {
                string query = "INSERT INTO Customer(name,email," +
                    "location,phone,password) values(" +
                    "'"+customer.Name+"','"+customer.Email+"'," +
                    "'"+customer.Location+"','"+customer.Phone+"'," +
                    "'"+customer.Password+"')";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("error "+ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateCustomer(int ID, String name, String location, String phone, String password)
        {
            try
            {
                String query = "UPDATE Customer SET name = '" + name + "',location = '" + location + "', phone = '" + phone + "', password = '" + password + "' WHERE ID= '" + ID + "'";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Update completed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
