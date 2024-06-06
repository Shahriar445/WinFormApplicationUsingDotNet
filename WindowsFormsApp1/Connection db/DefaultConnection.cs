using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Connection_db
{
    public  class DefaultConnection
    {
        private string connectionString = "Data Source=DESKTOP-PM9DUD3;Initial Catalog=ProductDetails;Integrated Security=True;";
         private SqlConnection _SqlConnection;
        public DefaultConnection()
        {
            _SqlConnection = new SqlConnection(connectionString);
           
        }
        public DataTable GetDataWithDb(string data)
        {
            try
            {
                _SqlConnection.Open();
                DataTable dts = new DataTable();
                SqlCommand cmd = new SqlCommand(data, _SqlConnection);
                SqlDataAdapter adapter =new SqlDataAdapter(cmd);
                adapter.Fill(dts);
                return dts;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally {       
                _SqlConnection.Close();
            }
            

        }
        public bool InsertData(string sqlCommand)
        {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, _SqlConnection);
                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }
    }
}
