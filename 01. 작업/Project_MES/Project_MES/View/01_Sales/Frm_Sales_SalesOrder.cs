using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.View._01_Sales
{
    public partial class Frm_Sales_SalesOrder : Form
    {
        public Frm_Sales_SalesOrder()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "납품관리";

            //조회영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Btn_Order.Text = "납품";
            Btn_Delete.Text = "삭제";
            Lbl_Contents0.Text = "납품내역";

        }


        #endregion UI 디자인 Setting End
    }
}
