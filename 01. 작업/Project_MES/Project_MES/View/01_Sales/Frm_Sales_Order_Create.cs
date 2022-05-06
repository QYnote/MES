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
    public partial class Frm_Sales_Order_Create : Form
    {
        public Frm_Sales_Order_Create()
        {
            InitializeComponent();
            SetDesign();
        }

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "수주등록";
            Btn_Save.Text = "저장";
            Btn_Close.Text = "닫기";

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주사항";

            Lbl_Contents1.Text = "수주내역";
            Btn_Delete.Text = "삭제";
        }
    }
}
