using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._02_Product
{
    internal class Product_WorkOrder
    {
        #region Property

        //입력용
        public string WorkOrderNo { get; set; }
        public string PlanNo { get; set; }
        public string ProductCode { get; set; }
        public double WorkOrderQty { get; set; }
        public double WorkQty { get; set; }
        public double GoodQty { get; set; }
        public double BadQty { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public string WorkStatus { get; set; }
        public string Remark { get; set; }
        public char UseYN { get; set; }

        //조회용
        public DateTime Search_StartDate { get; set; }
        public DateTime Search_EndDate { get; set; }
        public string Search_CustName { get; set; }
        public string Search_ProductName { get; set; }
        public string Search_ProductAlias { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable R_WorkPlan_ByOrderNoSeq()
        {
            query = $@"CALL Product_WorkPlan_R_ByOrderNoSeq('{PlanNo}')";

            return db.GetDataTable_MySQL(query);
        }

        public DataTable R_WorkPlan_BySearch()
        {
            query = $@"CALL Product_WorkPlan_R_BySearch('{Search_StartDate.ToString("yyyyMMdd")}',
                                                        '{Search_EndDate.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss")}',
                                                        '{Search_CustName}',
                                                        '{Search_ProductName}',
                                                        '{Search_ProductAlias}' )";

            return db.GetDataTable_MySQL(query);
        }

        public bool CU_WorkOrder()
        {
            query = $@"CALL Product_WorkOrder_CU('{WorkOrderNo}',
                                                 '{PlanNo}',
                                                 '{ProductCode}',
                                                 '{WorkOrderQty}',
                                                 '{Remark}',
                                                 
                                                 '{Global_DataStorage.ClientName}',
                                                 '{Global_DataStorage.ClientIP}')";
            return db.ExcuteQuery_MySQL(query);
        }

        public bool D_WorkPlan()
        {
            query = $@"CALL Product_WorkPlan_D('{WorkOrderNo}')";

            return db.ExcuteQuery_MySQL(query);
        }
    }
}
