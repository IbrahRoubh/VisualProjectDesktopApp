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

        public Boolean isUser(String email, String password, CookieManager cookieManager)
        {
            try
            {
                String query = "SELECT password from Customer where email = '" + email + "'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                var excutedResult = command.ExecuteScalar();
                if (excutedResult != null)
                {
                    string DBpassword = excutedResult.ToString();
                    if (password == DBpassword)
                    {
                        cookieManager.setCooike(email);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
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

    }
}
