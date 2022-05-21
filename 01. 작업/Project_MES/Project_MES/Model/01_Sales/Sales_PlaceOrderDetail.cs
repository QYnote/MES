using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._01_Sales
{
    internal class Sales_PlaceOrderDetail
    {
        #region Property

        public string OrderNo { get; set; }
        public int Seq { get; set; }
        public string ProductCode { get; set; }
        public double OrderQty { get; set; }
        public string Remark { get; set; }

        //입력용
        public string HighLotNo { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_FrmSalesOrder()
        {
            query = $@"CALL Sales_OrderDetail_R('{HighLotNo}')";

            return db.GetDataTable_MySQL(query);
        }

        public bool CU_PlaceOrderDetail()
        {
            query = "";

            return db.ExcuteQuery_MySQL(query);
        }
    }
}
