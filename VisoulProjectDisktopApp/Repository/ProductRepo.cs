﻿using System;
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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=1133");

        public List<ProductModel> getProductsByFactoryID(int id)
        {
            List<ProductModel> products = new List<ProductModel>();
            try
            {
                String query = "SELECT Product.*,report.amount FROM Product INNER JOIN Report ON Product.ID = Report.PID INNER JOIN Factory ON Report.FID = Factory.ID WHERE Factory.ID = '" + id + "'";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public void productUpdate(int FID,int PID,String name,String description,String code,String amounte)
        {
            try
            {
                String query = "UPDATE Product SET description = '" + description + "', code = '" + code + "' WHERE name = '"+name+"'";
                String query2 = "UPDATE report SET amount = '"+amounte+"' WHERE FID = '"+FID+"' AND PID = '"+PID+"'";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlCommand command2 = new SqlCommand(query2, conn);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error "+ ex);
            }
            finally
            {
                conn.Close();
            }
        }
        /*public ProductModel getProductByName(String naem)
        {
            try
            {
                String query = "SELECT * ";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }*/
    }
}
