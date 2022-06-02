using Project_MES.Model._00_Basic;
using Project_MES.Model._02_Product;
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
            uc_LblDtp_OrderDate.DtpStartDate.Value = DateTime.Now.AddDays(-7);

            //컨텐츠 영역
            Lbl_Contents0.Text = "생산계획 내역";

            Lbl_Contents1.Text = "작업공정 내역";

            GvSet();
            InitCbo();
        }

        private void GvSet()
        {
            GvSet_WorkPlan();
            Gv_WorkOrder();
        }

        private void GvSet_WorkPlan()
        {
            //Grid Set
            GvWorkPlan.AutoGenerateColumns = false; //DataSource Column생성 방지
            GvWorkPlan.AllowUserToAddRows = false;  //새 행 입력 권한

            //ColumnSet
            Col_PlanNo.DataPropertyName = "PlanNo";
            Col_CustCode.DataPropertyName = "CustCode";
            Col_CustName.DataPropertyName = "CustCode";
            Col_ProductCode_WP.DataPropertyName = "ProductCode";
            Col_ProductName_WP.DataPropertyName = "ProductCode";
            Col_ProductAlias_WP.DataPropertyName = "ProductCode";
            Col_PlanQty.DataPropertyName = "PlanQty";
            Col_RemainOrderQty.DataPropertyName = "RemainOrderQty";
            Col_UnitName_WP.DataPropertyName = "UnitCOde";
            Col_OrderDate.DataPropertyName = "OrderDate";
            Col_EndDate.DataPropertyName = "EndDate";
            Col_WorkStatus_WP.DataPropertyName = "WorkStatus";
            Col_Remark_WP.DataPropertyName = "Remark";

            //일부 Column 작성 가능하도록 수정
            Col_Checked_WP.ReadOnly = false;
            Col_PlanNo.ReadOnly = true;
            Col_CustCode.ReadOnly = true;
            Col_CustName.ReadOnly = true;
            Col_ProductCode_WP.ReadOnly = true;
            Col_ProductName_WP.ReadOnly = true;
            Col_ProductAlias_WP.ReadOnly = true;
            Col_PlanQty.ReadOnly = true;
            Col_RemainOrderQty.ReadOnly = true;
            Col_WorkOrderQty.ReadOnly = false;
            Col_UnitName_WP.ReadOnly = true;
            Col_OrderDate.ReadOnly = true;
            Col_EndDate.ReadOnly = true;
            Col_WorkStatus_WP.ReadOnly = true;
            Col_Remark_WP.ReadOnly = true;
        }

        private void Gv_WorkOrder()
        {
            gvWorkOrder.ReadOnly = true;
            gvWorkOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvWorkOrder.MultiSelect = false;
        }

        private void InitCbo()
        {
            /* custcode, productcode, unitcode, workstatus
             */
            DataTable source;

            Info_Customer cust = new Info_Customer();
            source = cust.Select_Cbo();
            Col_CustName.DataSource = source;
            Col_CustName.ValueMember = "거래처코드";
            Col_CustName.DisplayMember = "거래처명";

            Info_Material material = new Info_Material();
            source = material.Select_InitCbo_Product();
            //제품명
            Col_ProductName_WP.DataSource = source;
            Col_ProductName_WP.ValueMember = "MaterialCode";
            Col_ProductName_WP.DisplayMember = "MaterialName";

            //제품번호
            Col_ProductAlias_WP.DataSource = source;
            Col_ProductAlias_WP.ValueMember = "MaterialCode";
            Col_ProductAlias_WP.DisplayMember = "Alias";

            //단위
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.Code_FieldName = "UnitCode";
            cateItem.Value_FieldName = "UnitName";
            cateItem.GroupCode = "CG000402";

            source = cateItem.Select_Cbo();

            Col_UnitName_WP.DataSource = source;
            Col_UnitName_WP.ValueMember = "UnitCode";
            Col_UnitName_WP.DisplayMember = "UnitName";

            //진행상태
            cateItem.Code_FieldName = "ItemCode";
            cateItem.Value_FieldName = "ItemName";
            cateItem.GroupCode = "CG0202";

            source = cateItem.Select_Cbo();

            Col_WorkStatus_WP.DataSource = source;
            Col_WorkStatus_WP.ValueMember = "ItemCode";
            Col_WorkStatus_WP.DisplayMember = "ItemName";
        }

        #endregion UI 디자인 Setting

        #region 입력보조

        #region WorkPlan 체크박스
        private void GvWorkPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //체크박스 선택시 진행
            if (GvWorkPlan.Columns[e.ColumnIndex].Name == Col_Checked_WP.Name)
            {
                ChkBoxClick_GvWOrkPlan();
            }
        }

        private void ChkBoxClick_GvWOrkPlan()
        {
            bool chk = Convert.ToBoolean(GvWorkPlan.CurrentCell.Value);
            DataGridViewRow row = GvWorkPlan.Rows[GvWorkPlan.CurrentCell.RowIndex];

            if (chk)
            {
                GvWorkPlan.CurrentCell.Value = false;
                if (row.Cells[Col_WorkOrderQty.Name].Value != null)
                {   //지시수량은 안적은 상태일시 0 입력
                    row.Cells[Col_WorkOrderQty.Name].Value = 0;
                }
            }
            else
            {
                GvWorkPlan.CurrentCell.Value = true;    //체크값 변환
                if (row.Cells[Col_WorkOrderQty.Name].Value == null || Convert.ToDouble(row.Cells[Col_WorkOrderQty.Name].Value) == 0)
                {   //지시수량은 안적은 상태일시 계획수량 입력
                    row.Cells[Col_WorkOrderQty.Name].Value = row.Cells[Col_RemainOrderQty.Name].Value;
                } 
            }
        }

        #endregion WorkPlan 체크박스 End

        #region 지시수량 입력 검사

        private void GvWorkPlan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //지시 수량 입력인지 확인
            if (GvWorkPlan.Columns[e.ColumnIndex].Name != Col_WorkOrderQty.Name) return;

            if (!CheckInsertOrderQty())
            {
                //진행 오류시
                GvWorkPlan.CurrentCell.Value = 0;

                return;
            }
            else
            {
                //정상진행시
                GvWorkPlan.Rows[GvWorkPlan.CurrentCell.RowIndex].Cells[Col_Checked_WP.Name].Value = true;
            }
        }

        private bool CheckInsertOrderQty()
        {
            //숫자 입력 확인
            if (!CheckDouble()) return false;

            //계획수량
            double remainQty = GvWorkPlan.Rows[GvWorkPlan.CurrentCell.RowIndex].Cells[Col_RemainOrderQty.Name].Value == null
                              ? 0 : Convert.ToDouble(GvWorkPlan.Rows[GvWorkPlan.CurrentCell.RowIndex].Cells[Col_RemainOrderQty.Name].Value);
            //지시수량
            double orderQty = Convert.ToDouble(GvWorkPlan.CurrentCell.Value);

            if(remainQty < orderQty)
            {
                MessageBox.Show("지시수량이 남은수량보다 클 수 없습니다.");
                return false;
            }

            if(orderQty == 0)
            {
                //지시량 0일시 추가진행 X
                return false;
            }

            return true;
        }

        private bool CheckDouble()
        {
            //Double Type으로 변환 가능한지 체크
            try
            {
                Convert.ToDouble(GvWorkPlan.CurrentCell.Value);

                return true;
            }
            catch
            {
                MessageBox.Show("잘못된 값을 입력하였습니다.");
                return false;
            }
        }

        #endregion 지시수량 입력

        #region 기본 지시수량 입력

        private void GvWorkPlan_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //지시수량 입력시 Default Value = 계획수량
            if (GvWorkPlan.Columns[e.ColumnIndex].Name == Col_WorkOrderQty.Name)
            {
                DataGridViewRow row = GvWorkPlan.Rows[e.RowIndex];

                row.Cells[e.ColumnIndex].Value = row.Cells[Col_RemainOrderQty.Name].Value;
            }
        }

        #endregion 기본 지시수량 입력 End

        #endregion 입력보조 End

        #region 조회

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            DisplayDate_GvWorkPlan();
            DisplayDate_GvProductRouting();
        }

        private void DisplayDate_GvWorkPlan()
        {
            Product_WorkPlan wp = new Product_WorkPlan();
            wp.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value;
            wp.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value;
            wp.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;
            wp.Search_ProductName = uc_LblTxt_ProductName.TxtContents.Text;
            wp.Search_ProductAlias = uc_LblTxt_ProductAlias.TxtContents.Text;

            GvWorkPlan.DataSource = wp.R_WorkPlan_BySearch();
        }

        private void DisplayDate_GvProductRouting()
        {

        }

        #endregion 조회 End

        #region 작업지시

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            //작업지시 진행
            if (OrderProcess_WorkOrder())
            {
                DisplayData();
            }
        }

        private bool OrderProcess_WorkOrder()
        {
            foreach (DataGridViewRow dataRow in GvWorkPlan.Rows)
            {
                //마지막행인 새입력 열일경우 스킵
                if (dataRow.IsNewRow == true) continue;
                //체크박스가 체크가 안되있으면 스킵
                if (Convert.ToBoolean(dataRow.Cells[Col_Checked_WP.Name].Value) != true) continue;
                //지시완료 일경우 스킵
                if (dataRow.Cells[Col_WorkStatus_WP.Name].Value.ToString() == "CI03") continue;

                //저장중 에러 발생시 저장 중단
                if (!Order_WorkOrder(dataRow))
                {
                    return false;
                }

                //WorkPlan 상태 변경
                if (!Update_WorkPlanStatus(dataRow))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Order_WorkOrder(DataGridViewRow dataRow)
        {
            Product_WorkOrder wo = new Product_WorkOrder();
            wo.PlanNo = dataRow.Cells[Col_PlanNo.Name].Value.ToString();
            wo.ProductCode = dataRow.Cells[Col_ProductCode_WP.Name].Value.ToString();
            wo.WorkOrderQty = Convert.ToDouble(dataRow.Cells[Col_WorkOrderQty.Name].Value);
            wo.Remark = dataRow.Cells[Col_Remark_WP.Name].Value == null ? "" : dataRow.Cells[Col_Remark_WP.Name].Value.ToString();

            return wo.CU_WorkOrder();
        }

        private bool Update_WorkPlanStatus(DataGridViewRow dataRow)
        {
            double remainQty = Convert.ToDouble(dataRow.Cells[Col_RemainOrderQty.Name].Value);
            double workOrderQty = Convert.ToDouble(dataRow.Cells[Col_WorkOrderQty.Name].Value);
            string status = "";

            //
            if(workOrderQty == 0)
            {
                status = "CI01";
            }
            else if(remainQty > workOrderQty)
            {
                status = "CI02";
            }
            else if (remainQty == workOrderQty)
            {
                status = "CI03";
            }

            Product_WorkPlan wp = new Product_WorkPlan();
            wp.PlanNo = dataRow.Cells[Col_PlanNo.Name].Value.ToString();
            wp.WorkStatus = status;

            return wp.U_WorkPlan_ByWorkOrderSave();
        }

        #endregion 작업지시 End

        private void Frm_Product_WorkOrder_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

    }
}
