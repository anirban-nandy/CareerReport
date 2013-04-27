using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CareerReportData;

namespace CareerReportDb
{
    public class DbInteraction
    {
        static string passwordCurrent = "technicise";
        static string dbmsCurrent = "careerdb";

        private static MySql.Data.MySqlClient.MySqlConnection OpenDbConnection()
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=" + passwordCurrent + ";database=" + dbmsCurrent + ";persist security info=False");

            //open the connection
            if (msqlConnection.State != System.Data.ConnectionState.Open)
                msqlConnection.Open();

            return msqlConnection;
        }

        #region Insert Details
        public static int EnterNewDetails(DetailsInfo NewDetails)
        {
            return EnterNewDetailsindb(NewDetails);
        }

        private static int EnterNewDetailsindb(DetailsInfo NewDetails)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "INSERT INTO details(id,presentdate,name,address,adresscont,city,state,zip,phone,fax,website,emailconvention,datasource,status,facility,uniquecntctid,firstmame,lastname,position) "
                                    + "VALUES(@id,@presentdate,@name,@address,@adresscont,@city,@state,@zip,@phone,@fax,@website,@emailconvention,@datasource,@status,@facility,@uniquecntctid,@firstmame,@lastname,@position)";

                msqlCommand.Parameters.AddWithValue("@id", NewDetails.id);
                msqlCommand.Parameters.AddWithValue("@presentdate", NewDetails.presentdate);
                msqlCommand.Parameters.AddWithValue("@name", NewDetails.name);
                msqlCommand.Parameters.AddWithValue("@address", NewDetails.address);
                msqlCommand.Parameters.AddWithValue("@adresscont", NewDetails.adresscont);
                msqlCommand.Parameters.AddWithValue("@city", NewDetails.city);
                msqlCommand.Parameters.AddWithValue("@state", NewDetails.state);
                msqlCommand.Parameters.AddWithValue("@zip", NewDetails.zip);
                msqlCommand.Parameters.AddWithValue("@phone", NewDetails.phone);
                msqlCommand.Parameters.AddWithValue("@fax", NewDetails.fax);
                msqlCommand.Parameters.AddWithValue("@website", NewDetails.website);
                msqlCommand.Parameters.AddWithValue("@emailconvention", NewDetails.emailconvention);
                msqlCommand.Parameters.AddWithValue("@datasource", NewDetails.datasource);
                msqlCommand.Parameters.AddWithValue("@status", NewDetails.status);
                msqlCommand.Parameters.AddWithValue("@facility", NewDetails.facility);
                msqlCommand.Parameters.AddWithValue("@uniquecntctid", NewDetails.uniquecntctid);
                msqlCommand.Parameters.AddWithValue("@firstmame", NewDetails.firstmame);
                msqlCommand.Parameters.AddWithValue("@lastname", NewDetails.lastname);
                msqlCommand.Parameters.AddWithValue("@position", NewDetails.position);
                msqlCommand.ExecuteNonQuery();

                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }
        #endregion
    }
}
