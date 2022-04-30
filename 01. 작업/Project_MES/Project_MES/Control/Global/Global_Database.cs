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
        MySqlConnection connection = null;

        public void ConnectDatabase_MySQL()
        {
            //비연결 확인상태에서 연결 시작
            //연동string 지정
            string conn = $@"Server = {connect_Server};
                                 Database = {connect_dbName};
                                 UID = {connect_id};
                                 password = {connect_pw};";

            try
            {
                //DB 연동
                connection = new MySqlConnection(conn);
                connection.Open();
            }
            catch (Exception ex)
            {
                //연결 오류, 실패시 메시지 출력
                MessageBox.Show($"MySQL 연결 오류\n{ex.Message}");
            }
        }

        public void DisConnectDatabase_MySQL()
        {
            //연결 상태시 열결 해제
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable GetDataTable_MySQL(string query)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                //table에 데이터 채우기
                adapter.SelectCommand = new MySqlCommand(query, connection);
                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetDataTable_MySQL 오류\n{ex.Message}");
                throw;
            }
        }

        public void ExcuteQuery_MySQL(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                //query문 실행
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ExcuteQuery_MySQL 오류\n{ex.Message}");
                throw;
            }
        }

        #endregion MySQL 연결방식 End
    }
}
