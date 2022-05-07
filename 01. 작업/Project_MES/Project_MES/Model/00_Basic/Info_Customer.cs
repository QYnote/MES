using Project_MES.Control.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MES.Model._00_Basic
{
    internal class Info_Customer
    {
        #region Property

        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string CustType { get; set; }
        public string CustNo { get; set; }
        public string Presi { get; set; }
        public string Address { get; set; }
        public string Post { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Remark { get; set; }
        public string UseYn { get; set; }

        #endregion Property End


        string query = "";
        Global_Database db = new Global_Database();

        public DataTable Select_Frm_Info_Customer()
        {
            query = @"select GroupCode, GroupName, Level, HighGroup 
                        from Info_CategoryGroup";

            return db.GetDataTable_MySQL(query);
        }

        public void InsertUpdate_Frm_Info_Customer()
        {
            query = $@"CALL Info_Cusomer_CU('{CustCode   }',
                                            '{CustName   }',
                                            '{CustType   }',
                                            '{CustNo     }',
                                            '{Presi      }',

                                            '{Address    }',
                                            '{Post       }',
                                            '{Tel        }',
                                            '{Fax        }',
                                            '{Mail       }',

                                            '{Category   }',
                                            '{Condition  }',
                                            '{Remark     }',
                                                        
                                            '{UseYn      }',
                                            '{Global_DataStorage.ClientName}',
                                            '{Global_DataStorage.ClientIP}')";

            db.ExcuteQuery_MySQL(query);
        }
    }
}
