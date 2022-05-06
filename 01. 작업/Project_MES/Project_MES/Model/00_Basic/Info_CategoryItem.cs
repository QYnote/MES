using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._00_Basic
{
    internal class Info_CategoryItem
    {
        #region Properties

        public string GroupCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemValue { get; set; }
        public string Remark { get; set; }

        #endregion Properties End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_CategoryItem()
        {
            query = $@"SELECT ItemCode AS '아이템 코드',
                              ItemValue AS '아이템 값',
                              Remark AS '비고'
                         FROM Info_CategoryItem
                        WHERE GroupCode = '{GroupCode}'";

            return db.GetDataTable_MySQL(query);
        }

        public void Insert_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryItem_CU('{GroupCode}',
                                                 '{ItemCode}',
                                                 '{ItemValue}',
                                                 '{Remark}',
                                                 '{Global_DataStorage.ClientName}',
                                                 '{Global_DataStorage.ClientIP}')";

            db.ExcuteQuery_MySQL(query);
        }

        public void Delete_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryItem_D('{GroupCode}',
                                                '{ItemCode}')";

            db.ExcuteQuery_MySQL(query);
        }
    }
}
