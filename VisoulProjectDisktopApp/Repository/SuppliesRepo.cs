﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisoulProjectDisktopApp.Repository
{
    internal class SuppliesRepo
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NEQA9MK;Initial Catalog=VisoulProjectDB;Persist Security Info=True;User ID=ibrahim;Password=1133");

        public Boolean isStateChange(int id,String newState)
        {
            try
            {
                String query = "UPDATE supplies SET Status = '"+newState+"' WHERE ID='"+id+"'";
                SqlCommand command= new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();

                return true;
            }catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
