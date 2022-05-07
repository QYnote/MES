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

        public string GroupCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemValue { get; set; }
        public string Remark { get; set; }

        //조회용
        public string Code_FieldName { get; set; }    //코드 Column 명
        public string Value_FieldName { get; set; }    //Value Column명

        #endregion Properties End

        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_CategoryItem()
        {
            query = $@"SELECT ItemCode, ItemValue, Remark
                         FROM Info_CategoryItem
                        WHERE GroupCode = '{GroupCode}'";

            return db.GetDataTable_MySQL(query);
        }

        public void Insert_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryItem_CU('{GroupCode}',
                                                 '{ItemCode}',
                                                 '{ItemValue}',
                                                 '{Remark}',
                                                 '{Global_DataStorage.ClientName}',
                                                 '{Global_DataStorage.ClientIP}')";

            db.ExcuteQuery_MySQL(query);
        }

        public void Delete_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryItem_D('{GroupCode}',
                                                '{ItemCode}')";

            db.ExcuteQuery_MySQL(query);
        }

        public DataTable Select_Cbo()
        {
            query = $@"SELECT ItemCode AS {Code_FieldName},
                              ItemValue AS {Value_FieldName} 
                         FROM Info_CategoryItem
                        WHERE GroupCode = '{GroupCode}'";
            /*  
                기초정보
                CG00001 : 자재 타입
                CG00002 : 거래처 타입
                CG00003 : 공정 타입

                생산관리
                CG02001 : 계획 상태
                CG02002 : 지시 상태
             */

            return db.GetDataTable_MySQL(query);
        }
    }
}
