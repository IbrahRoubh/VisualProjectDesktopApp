using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace VisoulProjectDisktopApp
{
    internal class FactoryRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=1133");
        public Boolean isUser(String username,String password)
        {
            try
            {
                String query = "SELECT password from Factory where name = '" + username + "'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                string DBpassword = command.ExecuteScalar().ToString();
                conn.Close();

                if (password == DBpassword)
                {
                    create_coockie(username);
                    return true;
                }
                else
                    return false;
            }
            catch {
                conn.Close();
                return false;
            }
        }

        private void create_coockie(String username)
        {
            Cookie cookie = new Cookie("username", username, "/", "localhost");
            cookie.Expires = DateTime.Now.AddDays(1);
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.Add(cookie);
        }
    }
}
