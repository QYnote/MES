using Project_MES.Model._00_Basic;
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
            uc_LblDtp_OrderDate.DtpStartDate.Value = DateTime.Now.AddDays(-7);
            uc_LblDtp_OrderDate.DtpEndDate.Value = DateTime.Now;

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주내역";
            Lbl_Contents1.Text = "수주 상세내역";

            GvSet();
            InitCbo();
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
            Col_CustCode.DataPropertyName = "OrderCustCode";
            Col_OutCustCode.DataPropertyName = "OutCustCode";
            Col_OrderDate.DataPropertyName = "OrderDate";
            Col_OrderEndDate.DataPropertyName = "EndDate";
            Col_Remark_OM.DataPropertyName = "Remark";
        }

        private void GvSet_OrderDetail()
        {
            //DataGridView 셋팅
            gvOrderDetail.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_Seq.DataPropertyName = "Seq";
            Col_ProductCode.DataPropertyName = "ProductCode";
            Col_ProductName.DataPropertyName = "MaterialName";
            Col_ProductAlias.DataPropertyName = "Alias";
            Col_ProductSpec.DataPropertyName = "Spec";
            Col_Qty.DataPropertyName = "OrderQty";
            Col_Unit.DataPropertyName = "ItemValue";
            Col_Remark_OD.DataPropertyName = "Remark";
            Col_PlanStatus.DataPropertyName = "PlanStatus";
        }

        private void InitCbo()
        {
            Info_Customer cust = new Info_Customer();
            DataTable source = cust.Select_InItCbo_OrderCust();

            //수주처
            Col_CustCode.DataSource = source.Select("CustType = 'CI02'").CopyToDataTable();
            Col_CustCode.ValueMember = "CustCode";
            Col_CustCode.DisplayMember = "CustName";

            //납품처
            Col_OutCustCode.DataSource = source.Copy();
            Col_OutCustCode.ValueMember = "CustCode";
            Col_OutCustCode.DisplayMember = "CustName";

            //계획상태
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.Value_FieldName = "계획상태";
            cateItem.Code_FieldName = "상태코드";
            cateItem.GroupCode = "CG0101";

            Col_PlanStatus.DataSource = cateItem.Select_Cbo();
            Col_PlanStatus.ValueMember = "상태코드";
            Col_PlanStatus.DisplayMember = "계획상태";
        }

        #endregion UI 디자인 Setting End

        private void Frm_Sales_Order_Load(object sender, EventArgs e)
        {
            DisplayData();
        }


        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        #region 조회

        private void DisplayData()
        {
            //OrderMaster
            Sales_PlaceOrderMaster om = new Sales_PlaceOrderMaster();
            om.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value.ToString("yyyyMMdd");   //조회시작일
            om.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss");  //조회 종료일
            om.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;   //수주처명

            gvOrderMaster.DataSource = om.R_PlaceOrderMaster();
        }

        private void gvOrderMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvOrderMaster.SelectedRows.Count == 0) return;

            string orderNo = gvOrderMaster.SelectedRows[0].Cells[Col_OrderNo.Name].Value.ToString(); //선택된Row LotNo

            DisplayOrderDetail(orderNo);
        }

        private void DisplayOrderDetail(string lotNo)
        {
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.OrderNo = lotNo;

            gvOrderDetail.DataSource = od.R_PlaceOrderDetail();
        }


        #endregion 조회 End

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            Frm_Sales_PlaceOrder frmCreate = new Frm_Sales_PlaceOrder("Create");
            
            if(frmCreate.ShowDialog() == DialogResult.OK)
            {
                DisplayData();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow masterRow = gvOrderMaster.SelectedRows[0];

            Frm_Sales_PlaceOrder frmCreate = new Frm_Sales_PlaceOrder("Update");
            frmCreate.MasterRow = masterRow;    //Master정보

            if (frmCreate.ShowDialog() == DialogResult.OK)
            {
                DisplayData();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DeleteProcess_PlaceOrder())
            {
                MessageBox.Show("수주정보가 삭제되었습니다.");
            }
        }

        #region 삭제

        private bool DeleteProcess_PlaceOrder()
        {
            //선택한 행 가져오기
            DataGridViewRow masterRow = gvOrderMaster.CurrentRow;

            //에러목록 체크
            if (!Check_DeleteError(masterRow)) return false;

            //수주번호 가져오기
            string orderNo = masterRow.Cells[Col_OrderNo.Name].Value.ToString();

            //데이터 삭제
            return DeletePlaceOrder(orderNo);
        }

        private bool Check_DeleteError(DataGridViewRow masterRow)
        {
            //선택된 행이 없으면 종료
            if (masterRow == null) return false;

            //상세내역 중 계획 상태가 CI01(계획대기) 상태가 아닌게 있으면 삭제불가
            foreach (DataGridViewRow row in gvOrderDetail.Rows)
            {
                if(row.Cells[Col_PlanStatus.Name].Value.ToString() != "CI01") return false;
            }

            return true;
        }

        private bool DeletePlaceOrder(string orderNo)
        {
            Sales_PlaceOrderMaster om = new Sales_PlaceOrderMaster();
            om.OrderNo = orderNo;

            return om.D_PlaceOrderMaster();
        }

        #endregion 삭제 End
    }
}
