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

        public bool Insert_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryItem_CU('{GroupCode}',
                                                 '{ItemCode}',
                                                 '{ItemValue}',
                                                 '{Remark}',
                                                 '{Global_DataStorage.ClientName}',
                                                 '{Global_DataStorage.ClientIP}')";
            return db.ExcuteQuery_MySQL(query);
        }

        public bool Delete_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryItem_D('{GroupCode}',
                                                '{ItemCode}')";
            return db.ExcuteQuery_MySQL(query);
        }

        public DataTable Select_Cbo()
        {
            query = $@"SELECT ItemCode AS {Code_FieldName},
                              ItemValue AS {Value_FieldName} 
                         FROM Info_CategoryItem
                        WHERE GroupCode = '{GroupCode}'";

            return db.GetDataTable_MySQL(query);
            /*  
                기초정보
                CG0002 : 거래처 타입
                CG0003 : 공정 타입
                CG000401 : 자재 타입
                CG000402 : 자재 단위

                생산관리
                CG0201 : 계획 상태
                CG0202 : 지시 상태
             */

        }
    }
}
