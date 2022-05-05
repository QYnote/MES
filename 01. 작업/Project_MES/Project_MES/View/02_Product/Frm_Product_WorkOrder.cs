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
    public partial class Frm_Product_WorkOrder : Form
    {
        public Frm_Product_WorkOrder()
        {
            InitializeComponent();
            SetDesign();
        }


        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "작업지시관리";
            Btn_Order.Text = "작업지시";

            //조회영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Lbl_Contents0.Text = "생산계획 내역";
            Lbl_Contents1.Text = "작업공정 내역";
        }

        #endregion UI 디자인 Setting
    }
}
