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
    public partial class Frm_Product_WorkPlan : Form
    {
        public Frm_Product_WorkPlan()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "생산계획관리";
            Btn_Create.Text = "계획작성";
            Btn_Update.Text = "수정";

            //조회영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주내역";
            Lbl_Contents1.Text = "생산 계획내역";
        }

        #endregion UI 디자인 Setting

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            OpenPlanInfo("Create");
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            OpenPlanInfo("Update");
        }

        private void OpenPlanInfo(string status)
        {
            Frm_Product_WorkPlan_Write frmWrite = new Frm_Product_WorkPlan_Write(status);
            frmWrite.ShowDialog();
        }
    }
}
