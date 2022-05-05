using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._01_Sales
{
    internal class Sales_OrderDetail
    {
        #region Property

        //입력용
        public string HighLotNo { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_FrmSalesOrder()
        {
            query = $@"CALL Sales_Get_OrderDetail('{HighLotNo}')";

            return db.GetDataTable_MySQL(query);
        }
    }
}
