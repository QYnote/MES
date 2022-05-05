using Project_MES.Model._01_Sales;
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
    public partial class Frm_SalesOrder : Form
    {
        public Frm_SalesOrder()
        {
            InitializeComponent();
            SetDesign();
        }

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "수주관리";
            Btn_Create.Text = "신규등록";
            Btn_Update.Text = "수정";
            Btn_Delete.Text = "삭제";

            //조회영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주내역";
            Lbl_Contents1.Text = "수주 상세내역";
        }

        private void Frm_SalesOrder_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            Frm_SalesOrder_Create frmCreate = new Frm_SalesOrder_Create();
            
            if(frmCreate.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void DisplayData()
        {
            //OrderMaster
            Sales_OrderMaster om = new Sales_OrderMaster();
            om.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value.ToShortDateString();   //조회시작일
            om.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value.ToShortDateString() + DateTime.Now.ToString(" HH:mm:ss");  //조회 종료일
            om.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;   //수주처명

            gvOrderMaster.DataSource = om.Select_FrmSalesOrder();

            //OrderDetail
        }

    }
}
