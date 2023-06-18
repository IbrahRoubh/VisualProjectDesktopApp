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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=123");
        public FactoryModel getUser(String email,String password)
        {
            try
            {
                String query = "SELECT * from Factory where email = '" + email + "';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                FactoryModel factory = new FactoryModel();
                while (reader.Read())
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

        public void loadFactory(FactoryModel factrory,String username)
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
                    factrory.email = (String)reader["email"];
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

        public List<SuppliesModel> getOrders(int FID)
        {
            try
            {
                String query = "SELECT * FROM supplies WHERE FID ='"+ FID +"' AND Direction ='f' AND Status !='d'; ";
                SqlCommand command = new SqlCommand(query,conn);
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
                    supplie.date_of_arrival = (DateTime)reader["date_of_arrival"];
                    supplie.Direction = ((String)reader["Direction"]).Trim();
                    supplie.status = ((String)reader["Status"]).Trim();

                    supplies.Add(supplie);
                }
                return supplies;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error "+ ex);
                return null;
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
                String query = "SELECT * FROM supplies WHERE FID ='"+FID+"' AND Direction ='s' AND Status ='o'";
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

    }
}
