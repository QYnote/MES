using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._01_Sales
{
    internal class Sales_DeliveryOrder
    {
        #region Property

        public string OrderNo { get; set; }
        public int OrderSeq { get; set; }
        public string ProductCode { get; set; }
        public double DeliveryOrderQty { get; set; }
        public DateTime DeliveryOrderDate { get; set; }
        public string Remark { get; set; }

        //조회용
        public DateTime Search_StartDate { get; set; }
        public DateTime Search_EndDate { get; set; }
        public string Search_CustName { get; set; }
        public string Search_ProductName { get; set; }
        public string Search_Alias { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable R_DeliveryOrder_ByOrderNoSeq()
        {
            query = $@"";

            return db.GetDataTable_MySQL(query);
        }

        public bool C_DeliveryOrder()
        {
            query = $@"CALL Sales_DeliveryOrder_C('{OrderNo}',
                                                  '{OrderSeq}',
                                                  '{ProductCode}',
                                                  '{DeliveryOrderQty}',
                                                  '{DeliveryOrderDate:yyyyMMdd}',

                                                  '{Remark}',

                                                  '{Global_DataStorage.ClientName}',
                                                  '{Global_DataStorage.ClientIP}')";

            return db.ExcuteQuery_MySQL(query);
        }

    }
}
