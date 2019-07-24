<<<<<<< Updated upstream
﻿using System;
=======
using System;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            connection.DataSource = "";
            connection.InitialCatalog = "MilitaryDB";
=======
            connection.DataSource = @"";//dependantn on server running on
            connection.InitialCatalog = "dbMilitary";
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
                DataTable table = new DataTable();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        public int InsertCompleteTrip(string newJetModel, int newfuelTankCapacity, double newheight, double newmaxWeight)
=======
        public int InsertNewJet(string newJetModel, int newfuelTankCapacity, double newHeight, double newMaxWeight, double newSpeed, int newInventory)
>>>>>>> Stashed changes
        {
            int changed = 0;
            
            try
            {
<<<<<<< Updated upstream
                SqlCommand command = new SqlCommand("SPInsertCompleteTrip", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TitleToAdd", newJetModel);
                command.Parameters.AddWithValue("@GenreToAdd", newfuelTankCapacity);
                command.Parameters.AddWithValue("@AgeRestrictionToAdd", newheight);
                command.Parameters.AddWithValue("@RentalPriceToAdd", newmaxWeight);
               
=======
                SqlCommand command = new SqlCommand("SPInsertNewJet", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@newJet", newJetModel);
                command.Parameters.AddWithValue("@newFuelTankcapacity", newfuelTankCapacity);
                command.Parameters.AddWithValue("@newHeight", newHeight);
                command.Parameters.AddWithValue("@newMaxWeight", newMaxWeight);
               command.Parameters.AddWithValue("@newSpeed",newSpeed);
               command.Parameters.AddWithValue("@newInventory",newInventory);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        public int UpdateFuelStoredProc(int fuelLevelToUpdate)
=======
        public int UpdateFuelStoredProc(int idToUpdate, int fuelLevelToUpdate)
>>>>>>> Stashed changes
        {
            int changed = 0;
            
            try
            {
                SqlCommand command = new SqlCommand("SPUpdateFuel", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fuelLevelToUpdate", fuelLevelToUpdate);
<<<<<<< Updated upstream
                
=======
                command.Parameters.AddWithValue("@idToUpdate",idToUpdate);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        public int InsertObstacleSproc(int newObstacleID, string newDescription, string newRange)
=======
        public int InsertObstacleSproc(string newDescription, int  newRange)
>>>>>>> Stashed changes
        {
            int changed = 0;
            
            try
            {
                SqlCommand command = new SqlCommand("SPInsertObstacle", conn);
                command.CommandType = CommandType.StoredProcedure;
<<<<<<< Updated upstream
                command.Parameters.AddWithValue("@ObstacleIDToAdd", newObstacleID);
=======
>>>>>>> Stashed changes
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
