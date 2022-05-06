using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._00_Basic
{
    internal class Info_CategoryGroup
    {
        #region Property

        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public int Level { get; set; }
        public string HighGroup { get; set; }
        public char UseYn { get; set; }

        #endregion Property End


        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_CategoryItem()
        {
            query = @"select GroupCode, GroupName, Level, HighGroup 
                        from Info_CategoryGroup";

            return db.GetDataTable_MySQL(query);
        }

        public void Insert_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryGroup_C('{GroupName}',
                                                   {Level},
                                                  '{HighGroup}',
                                                  '{Global_DataStorage.ClientName}',
                                                  '{Global_DataStorage.ClientIP}')";

            db.ExcuteQuery_MySQL(query);
        }

        public void Delete_Frm_Info_CategoryItem()
        {
            query = $@"CALL Info_CategoryGroup_D('{GroupCode}')";

            db.ExcuteQuery_MySQL(query);
        }
    }
}
