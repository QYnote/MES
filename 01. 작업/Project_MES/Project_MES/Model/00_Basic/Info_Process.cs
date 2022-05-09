using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._00_Basic
{
    internal class Info_Process
    {
        #region Property

        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
        public string ProcessType { get; set; }
        public string Remark { get; set; }

        #endregion Property End


        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_Process()
        {
            query = @"SELECT ProcessCode, ProcessName, ProcessType, Remark
                        FROM info_Process
                       WHERE UseYN = 'Y'";

            return db.GetDataTable_MySQL(query);
        }

        public DataTable Select_Cbo()
        {
            query = $@"SELECT ProcessCode AS '공정코드',
                              ProcessName AS '공정명'
                         FROM Info_Process
                        WHERE UseYn = 'Y'";

            return db.GetDataTable_MySQL(query);
        }

        public void InsertUpdate_Frm_Info_Process()
        {
            query = $@"CALL Info_Process_CU('{ProcessCode}',
                                             '{ProcessName}',
                                             '{ProcessType}',
                                             '{Remark}',

                                             '{Global_DataStorage.ClientName}',
                                             '{Global_DataStorage.ClientIP}')";

            db.ExcuteQuery_MySQL(query);
        }

        public void Delete_Frm_Info_Process()
        {
            query = $@"CALL Info_Process_D('{ProcessCode}',
                                           '{Global_DataStorage.ClientName}',
                                           '{Global_DataStorage.ClientIP}')";

            db.ExcuteQuery_MySQL(query);
        }

    }
}
