using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._00_Basic
{
    internal class Info_Material
    {
        #region Property

        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialType { get; set; }
        public string Alias { get; set; }
        public string Spec { get; set; }
        public string UnitCode { get; set; }
        public string CustCode { get; set; }
        public string Remark { get; set; }
        public string UseYn { get; set; }

        #endregion Property End


        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_Material()
        {
            query = @"SELECT MaterialType, MaterialCode, MaterialName, Alias, Spec, 
                        	 UnitCode, CustCode, Remark
                        FROM Info_Material
                       WHERE UseYn = 'Y'";

            return db.GetDataTable_MySQL(query);
        }

        public bool InsertUpdate_Frm_Info_Material()
        {
            query = $@"CALL Info_Material_CU('{MaterialCode}',
                                             '{MaterialName}',
                                             '{MaterialType}',
                                             '{Alias}',
                                             '{Spec}',

                                             '{UnitCode}',
                                             '{CustCode}',
                                             '{Remark}',

                                             '{Global_DataStorage.ClientName}',
                                             '{Global_DataStorage.ClientIP}')";

            return db.ExcuteQuery_MySQL(query);
        }

        public bool Delete_Frm_Info_Material()
        {
            query = $@"CALL Info_Material_D('{MaterialCode}',
                                            '{Global_DataStorage.ClientName}',
                                            '{Global_DataStorage.ClientIP}')";

            return db.ExcuteQuery_MySQL(query);
        }

        public DataTable Select_Cbo()
        {
            query = $@"SELECT MaterialCode AS '자재코드',
                              MaterialName AS '자재명'
                         FROM Info_Material
                        WHERE UseYn = 'Y'";

            return db.GetDataTable_MySQL(query);
        }

        public DataTable Select_InitCbo_Product()
        {
            //조건 : 거래사용중, 완제품
            query = @"SELECT ma.MaterialCode, ma.MaterialName, ma.Alias, ma.Spec, ma.CustCode,
                             ci.ItemValue AS UnitName
                        FROM Info_Material ma
                  INNER JOIN Info_CategoryItem ci ON ci.ItemCode = ma.UnitCode
                                                 AND ci.GroupCode = 'CG000402'
                       WHERE ma.UseYn = 'Y'
                         AND ma.MaterialType = 'CI01'";

            return db.GetDataTable_MySQL(query);
        }
    }
}
