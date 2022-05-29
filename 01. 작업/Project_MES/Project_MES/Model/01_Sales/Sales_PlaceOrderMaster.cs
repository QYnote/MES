using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._01_Sales
{
    internal class Sales_PlaceOrderMaster
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
        public DateTime Search_StartDate { get; set; }
        public DateTime Search_EndDate { get; set; }
        public string Search_CustName { get; set; }

        #endregion Property End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable R_PlaceOrderMaster()
        {
            query = $@"CALL Sales_PlaceOrderMaster_R('{Search_StartDate.ToString("yyyyMMdd")}',
                                                     '{Search_EndDate.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss")}',
                                                     '{Search_CustName}')";

            return db.GetDataTable_MySQL(query);
        }

        public bool CU_PlaceOrderMaster()
        {
            query = $@"CALL Sales_PlaceOrderMaster_CU('{OrderNo}',
                                                      '{OrderCustCode}',
                                                      '{OutCustCode}',
                                                      '{OrderDate.ToString("yyyyMMdd")}',
                                                      '{EndDate.ToString("yyyyMMdd")}',

                                                      '{Remark}',
                                                      
                                                      '{Global_DataStorage.ClientName}',
                                                      '{Global_DataStorage.ClientIP}')";
            return db.ExcuteQuery_MySQL(query);
        }

        public void D_PlaceOrderMaster_ByCreateError()
        {
            //저장중 에러시 삭제용
            query = "";

            db.ExcuteQuery_MySQL(query);
        }

        public bool D_PlaceOrderMaster()
        {
            query = $@"CALL Sales_PlaceOrderMaster_D('{OrderNo}')";

            return db.ExcuteQuery_MySQL(query);
        }
    }
}
