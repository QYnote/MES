using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.View._02_Product
{
    public partial class Frm_Product_WorkPlan_Write : Form
    {
        private string openStatus = ""; //신규 : Create, 수정 : Update

        public Frm_Product_WorkPlan_Write(string status)
        {
            openStatus = status;

            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "생산계획 등록";
            Btn_Save.Text = "저장";
            Btn_Close.Text = "취소";

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주내역";
            Lbl_Contents1.Text = "생산계획 정보";
            Btn_Delete.Text = "삭제";

            //신규, 수정 구분 셋팅
            if(openStatus == "Create")
            {
                Btn_Delete.Visible = false;
                Col_PlanStatus.Visible = false;
            }
        }

        #endregion UI 디자인 Setting
    }
}
