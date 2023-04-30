﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using VisoulProjectDisktopApp.model;
using System.Windows.Forms;

namespace VisoulProjectDisktopApp
{
    internal class FactoryRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=1133");
        public Boolean isUser(String username,String password,CookieManager cookieManager)
        {
            try
            {
                String query = "SELECT password from Factory where name = '" + username + "'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                string DBpassword = command.ExecuteScalar().ToString();
                if (password == DBpassword)
                {
                    cookieManager.setCooike(username);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch {
                
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public void loadFactory(FactroryModel factrory,String username)
        {
            try
            {
                String query = "SELECT * FROM Factory WHERE name='" + username + "'";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    factrory.id = (int)reader["ID"];
                    factrory.name = (String)reader["name"];
                    factrory.password = (String)reader["password"];
                    factrory.location = (String)reader["location"];
                    factrory.phoneNum = (String)reader["phone"];
                    factrory.type = (String)reader["type"];
                }
            }
            catch 
            {
                Application.Exit();
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
    }
}
