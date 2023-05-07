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

        public List<ProductModel> getStoreProduscts(int SID)
        { 
            List<ProductModel> products = new List<ProductModel>();
            try
            {
                String query = "SELECT Stok.amount, Product.* FROM Stok JOIN Product ON Stok.PID = Product.id " +
                    "WHERE Stok.SID = '"+ SID +"'";
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
            }catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean productOrderFromStore(int PID, int FID, int SID, int amount) 
        {
            try
            {
                String query = "SELECT s.amount FROM Stok s WHERE s.PID = '"+ PID +"' AND s.SID = '"+ SID +"';";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();

                int DBamount;
                if (int.TryParse(command.ExecuteScalar().ToString(), out DBamount))
                {
                    if (DBamount >= amount)
                    {
                        try
                        {
                            DateTime date = GetDate(3);
                            String query2 = "INSERT INTO supplies(SID,FID,PID,amount,Direction,date_of_arrival, Status) " +
                                "VALUES('" + SID + "','" + FID + "','" + PID + "','" + amount + "', 'f' ,'" + date + "', 's'); " +
                                "UPDATE Stok SET amount = amount - '" + amount + "' WHERE Stok.SID = '" + SID + "' AND Stok.PID ='" + PID + "';";
                            SqlCommand command2 = new SqlCommand(query2, conn);
                            command2.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error " + ex);
                            return false;
                        }
                    }
                    else
                    {
                        String message = "you order '" + amount + "' and the max existing amount is '" + DBamount + "'" +
                            ", Do you want to take the amount in storge and wate for the rest to arrive from factory?";
                        DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (DBamount != 0)
                            {
                                try
                                {
                                    DateTime date = GetDate(3);
                                    DateTime date2 = GetDate(33);
                                    int newAmount = amount - DBamount;
                                    String query3 = "INSERT INTO supplies(SID,FID,PID,amount,Direction,date_of_arrival, Status) " +
                                        "VALUES('" + SID + "', '" + FID + "' ,'" + PID + "','" + DBamount + "',f,'" + date + "',s), " +
                                        "('" + SID + "', '" + FID + "' ,'" + PID + "', '" + newAmount + "', f, '" + date2 + "', o);" +
                                        " UPDATE Stok SET amount = amount- '" + DBamount + "' WHERE Stok.SID = '" + SID + "' AND Stok.PID ='" + PID + "';";
                                    SqlCommand command3 = new SqlCommand(query3, conn);
                                    command3.ExecuteNonQuery();
                                    return true;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("error " + ex);
                                    return false;
                                }
                            }
                            else
                            {
                                try
                                {
                                    DateTime date = GetDate(33);
                                    String query4 = "INSERT INTO supplies(SID,FID,PID,amount,Direction,date_of_arrival, Status)" +
                                        "VALUES('" + SID + "', '" + FID + "' ,'" + PID + "','" + amount + "',f,'" + date + "',o) ";
                                    SqlCommand command4 = new SqlCommand(query4, conn);
                                    command.ExecuteNonQuery();
                                    return true;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("error " + ex);
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("error can not execute the order");
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("error "+ ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        private DateTime GetDate(int days)
        {
            DateTime currentDate = DateTime.Now;
            DateTime futureDate = currentDate.AddDays(days);
            return futureDate;
        }
    }
}
