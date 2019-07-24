using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_Demo
{
    class DataHandler
    {

        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection conn;
        public DataHandler()
        {
            connection.DataSource = "";
            connection.InitialCatalog = "MilitaryDB";
            connection.IntegratedSecurity = true;
            conn = new SqlConnection(connection.ToString());
        }

        public DataSet ReadData(string tblName)
        {
            DataSet rawData = new DataSet();

            SqlConnection conn = new SqlConnection(connection.ToString());
            string qry = string.Format("SELECT * FROM {0}", tblName);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tblName);
                adapter.Fill(rawData, tblName);
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }


        // After the jet completes its mission to scout we save the data of the trip using this querry 
        public int InsertCompleteTrip(string newJetModel, int newfuelTankCapacity, double newheight, double newmaxWeight)
        {
            int changed = 0;
            
            try
            {
                SqlCommand command = new SqlCommand("SPInsertCompleteTrip", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TitleToAdd", newJetModel);
                command.Parameters.AddWithValue("@GenreToAdd", newfuelTankCapacity);
                command.Parameters.AddWithValue("@AgeRestrictionToAdd", newheight);
                command.Parameters.AddWithValue("@RentalPriceToAdd", newmaxWeight);
               
                conn.Open();
                changed = command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return changed;
        }


        //this will allow the user to top up fuel befor the jet takes off, we will update only the fuel on that ID
        public int UpdateFuelStoredProc(int fuelLevelToUpdate)
        {
            int changed = 0;
            
            try
            {
                SqlCommand command = new SqlCommand("SPUpdateFuel", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fuelLevelToUpdate", fuelLevelToUpdate);
                
                conn.Open();
                changed = command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }


            return changed;
        }


        //This method will be used to insert a new obsticle that is added 
        public int InsertObstacleSproc(int newObstacleID, string newDescription, string newRange)
        {
            int changed = 0;
            
            try
            {
                SqlCommand command = new SqlCommand("SPInsertObstacle", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ObstacleIDToAdd", newObstacleID);
                command.Parameters.AddWithValue("@DescriptionToAdd", newDescription);
                command.Parameters.AddWithValue("@RangeToAdd", newRange);
                
               
                conn.Open();
                changed = command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return changed;
        }

             
    }
}
