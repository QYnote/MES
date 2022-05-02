using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._01_Sales
{
    internal class Sales_OrderMaster
    {
        #region Property

        //입력용
        public string OrderNo { get; set; }
        public string OrderCustCode { get; set; }
        public string OutCustCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remark { get; set; }
        public char UseYN { get; set; }

        //조회용
        public string Search_StartDate { get; set; }
        public string Search_EndDate { get; set; }
        public string Search_CustName { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_FrmSalesOrder()
        {
            query = @"SELECT OrderNo, OrderCustCode, OutCustCode, OrderDate, EndDate, 
                             Remark
                        FROM Sales_OrderMaster";

            return db.GetDataTable_MySQL(query);
        }
    }
}
