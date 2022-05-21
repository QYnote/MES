using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_MES.Control.Global
{
    class Global_Database
    {
        #region MySQL 연결방식
        //DB 연결 정보
        readonly string connect_Server = ConfigurationManager.AppSettings["DBConnection_Address"].ToString();
        readonly string connect_id = ConfigurationManager.AppSettings["DBConnection_ID"].ToString();
        readonly string connect_pw = ConfigurationManager.AppSettings["DBConnection_PW"].ToString();
        readonly string connect_dbName = ConfigurationManager.AppSettings["DBConnection_DBName"].ToString();

        //Connect 정보
        MySqlConnection connection = new MySqlConnection();

        public Global_Database()
        {
            string conn = $@"Server   = {connect_Server};
                             Database = {connect_dbName};
                             UID      = {connect_id};
                             password = {connect_pw};";

            connection.ConnectionString = conn;
        }

        public DataTable GetDataTable_MySQL(string query)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                //table에 데이터 채우기
                adapter.SelectCommand = new MySqlCommand(query, connection);
                adapter.SelectCommand.CommandTimeout = 180;
                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetDataTable_MySQL 오류\n{ex.Message}");
                throw;
            }
        }

        public bool ExcuteQuery_MySQL(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                //query문 실행
                cmd.CommandTimeout = 180;
                cmd.Connection.Open();  //DB 연결
                cmd.ExecuteNonQuery();  //Query 작동
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ExcuteQuery_MySQL 오류\n{ex.Message}");
                return false;
            }
            finally
            {
                cmd.Connection.Close(); //DB 연결 해제

            }

            return true;
        }

        #endregion MySQL 연결방식 End
    }
}
