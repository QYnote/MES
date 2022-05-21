using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.View._03_POP
{
    public partial class Frm_POP_Product : Form
    {
        public Frm_POP_Product()
        {
            InitializeComponent();
            SetDesign();
        }


        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "생산공정1";

            //조회영역
            Btn_Search.Text = "조회";
            Dtp_StartDate.Value = DateTime.Now.AddDays(-7);
            Dtp_EndDate.Value = DateTime.Now;

            //컨텐츠 영역

            Btn_Process.Text = "작업시작";
            gvWorkOrderReady.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   //행 선택방식
            gvWorkOrderReady.MultiSelect = false;   //다중선택 불가
            gvWorkOrderReady.ReadOnly = true;       //읽기전용



        }

        #endregion UI 디자인 Setting
    }
}
