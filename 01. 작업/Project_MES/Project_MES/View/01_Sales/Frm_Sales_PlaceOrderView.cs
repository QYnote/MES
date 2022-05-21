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
    public partial class Frm_Sales_PlaceOrderView : Form
    {
        public Frm_Sales_PlaceOrderView()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

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

            GvSet();
        }

        private void GvSet()
        {
            GvSet_OrderMaster();
            GvSet_OrderDetail();
        }

        private void GvSet_OrderMaster()
        {
            //DataGridView 셋팅
            gvOrderMaster.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_OrderNo.DataPropertyName = "OrderNo";
            Col_CustName.DataPropertyName = "OrderCustName";
            Col_OutCustName.DataPropertyName = "OutCustName";
            Col_OrderDate.DataPropertyName = "OrderDate";
            Col_OrderEndDate.DataPropertyName = "EndDate";
            Col_Remark_OM.DataPropertyName = "Remark";
        }

        private void GvSet_OrderDetail()
        {
            //DataGridView 셋팅
            gvOrderDetail.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_Seq.DataPropertyName = "LotSeq";
            Col_ProductCode.DataPropertyName = "ProductCode";
            Col_ProductName.DataPropertyName = "MaterialName";
            Col_ProductAlias.DataPropertyName = "Alias";
            Col_ProductSpec.DataPropertyName = "Spec";
            Col_Qty.DataPropertyName = "OrderQty";
            Col_Unit.DataPropertyName = "ItemValue";
            Col_Remark_OD.DataPropertyName = "Remark";
            Col_PlanStatus.DataPropertyName = "PlanStatus";
        }

        #endregion UI 디자인 Setting End

        private void Frm_Sales_Order_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            Frm_Sales_PlaceOrder frmCreate = new Frm_Sales_PlaceOrder();
            
            if(frmCreate.ShowDialog() == DialogResult.OK)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            //OrderMaster
            Sales_PlaceOrderMaster om = new Sales_PlaceOrderMaster();
            om.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value.ToString("yyyyMMdd");   //조회시작일
            om.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss");  //조회 종료일
            om.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;   //수주처명

            gvOrderMaster.DataSource = om.Select_FrmSalesOrder();

            //OrderDetail
        }

        private void gvOrderMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvOrderMaster.Rows[e.RowIndex].DataBoundItem == null) return;

            string orderNo = (gvOrderMaster.Rows[e.RowIndex].DataBoundItem as DataRowView).Row["OrderNo"].ToString();   //선택된Row LotNo

            DisplayOrderDetail(orderNo);
        }

        private void DisplayOrderDetail(string lotNo)
        {
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.HighLotNo = lotNo;

            od.Select_FrmSalesOrder();
        }
    }
}
