using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._02_Product
{
    internal class Product_WorkPlan
    {
        #region Property

        //입력용
        public string PlanNo { get; set; }
        public string OrderNo { get; set; }
        public int OrderSeq { get; set; }
        public string ProductCode { get; set; }
        public double PlanQty { get; set; }
        public DateTime PlanDate { get; set; }
        public string Remark { get; set; }
        public char UseYN { get; set; }

        //조회용
        public DateTime Search_StartDate { get; set; }
        public DateTime Search_EndDate { get; set; }
        public string Search_CustName { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable R_WorkPlan_ByOrderNoSeq()
        {
            query = $@"CALL Product_WorkPlan_R_ByOrderNoSeq('{OrderNo}',
                                                            '{OrderSeq}')";

            return db.GetDataTable_MySQL(query);
        }

        public bool CU_WorkPlan()
        {
            query = $@"CALL Product_WorkPlan_CU('{PlanNo}',
                                                '{OrderNo}',
                                                 {OrderSeq},
                                                '{ProductCode}',
                                                 {PlanQty},

                                                '{PlanDate:yyyyMMdd}',
                                                '{Remark}',
                                                
                                                '{Global_DataStorage.ClientName}',
                                                '{Global_DataStorage.ClientIP}')";
            return db.ExcuteQuery_MySQL(query);
        }

        public bool D_WorkPlan()
        {
            query = $@"CALL Product_WorkPlan_D('{PlanNo}')";

            return db.ExcuteQuery_MySQL(query);
        }
    }
}
