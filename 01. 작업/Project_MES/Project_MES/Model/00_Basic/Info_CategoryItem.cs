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

        //조회용
        public string GroupCode { get; set; }

        #endregion Properties End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_CategoryItem()
        {
            query = $@"SELECT CateCode AS '카테고리 코드',
                              CateValue AS '카테고리 값',
                              Remark AS '비고'
                         FROM Info_CategoryItem
                        WHERE GroupCode = '{GroupCode}'";

            return db.GetDataTable_MySQL(query);
        }
    }
}
