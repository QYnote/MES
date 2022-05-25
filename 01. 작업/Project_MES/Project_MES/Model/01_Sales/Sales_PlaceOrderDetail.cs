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

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable R_PlaceOrderDetail()
        {
            query = $@"CALL Sales_PlaceOrderDetail_R('{OrderNo}')";

            return db.GetDataTable_MySQL(query);
        }

        public bool CU_PlaceOrderDetail()
        {
            query = $@"CALL Sales_PlaceOrderDetail_CU('{OrderNo}',
                                                       {Seq},
                                                      '{ProductCode}',
                                                       {OrderQty},
                                                      '{Remark}',
                                                      '{Global_DataStorage.ClientName}',
                                                      '{Global_DataStorage.ClientIP}' )";

            return db.ExcuteQuery_MySQL(query);
        }

        public bool D_PlaceOrderDetail()
        {
            query = $@"";

            return db.ExcuteQuery_MySQL(query);
        }
    }
}
