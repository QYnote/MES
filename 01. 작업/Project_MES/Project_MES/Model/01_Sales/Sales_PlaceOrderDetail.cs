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
        public string WorkStatus { get; set; }
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

        public DataTable R_PlaceOrderDetail_ByOrderNo()
        {
            query = $@"CALL Sales_PlaceOrderDetail_R('{OrderNo}')";

            return db.GetDataTable_MySQL(query);
        }

        public DataTable R_PlaceOrderDetail_BySearch()
        {
            query = $@"CALL Sales_PlaceOrderDetail_R_BySearch('{Search_StartDate.ToString("yyyyMMdd")}',
                                                              '{Search_EndDate.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss")}',
                                                              '{Search_CustName}',
                                                              '{Search_ProductName}',
                                                              '{Search_Alias}')";

            return db.GetDataTable_MySQL(query);
        }

        public DataTable R_PlaceOrderDetail_InDeliveryOrder()
        {
            query = $@"CALL Sales_PlaceOrderDetail_R_InDeliverOrder('{Search_StartDate.ToString("yyyyMMdd")}',
                                                                    '{Search_EndDate.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss")}',
                                                                    '{Search_CustName}',
                                                                    '{Search_ProductName}',
                                                                    '{Search_Alias}')";

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

        public bool U_PlaceOrderDetail_ByWorkPlanSave()
        {
            query = $@"CALL Sales_PlaceOrderDetail_U_ByWorkPlanSave('{OrderNo}',
                                                                     {Seq},
                                                                    '{WorkStatus}',

                                                                    '{Global_DataStorage.ClientName}',
                                                                    '{Global_DataStorage.ClientIP}' )";

            return db.ExcuteQuery_MySQL(query);
        }
    }
}
