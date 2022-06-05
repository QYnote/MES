using Project_MES.Model._00_Basic;
using Project_MES.Model._01_Sales;
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
    public partial class Frm_Product_WorkOrderPerformance : Form
    {
        public Frm_Product_WorkOrderPerformance()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "생산실적관리";

            //조회영역
            Btn_Search.Text = "조회";
            uc_LblDtp_OrderDate.DtpStartDate.Value = DateTime.Now.AddDays(-7);
            uc_LblDtp_OrderDate.DtpEndDate.Value = DateTime.Now;

            //컨텐츠 영역 - 생산실적
            Lbl_Contents0.Text = "작업지시 내역";
            Btn_Save.Text = "저장";

            GvSet();
            InitCbo();
        }

        private void GvSet()
        {
            GvSet_WorkOrder();
        }

        private void GvSet_WorkOrder()
        {
            //DataGridView 셋팅
            GvWorkOrder.AutoGenerateColumns = false; //DataSource Column생성 방지
            GvWorkOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //열선택
            GvWorkOrder.MultiSelect = false; //다중행 선택 불가
            GvWorkOrder.AllowUserToAddRows = false; ;    //열 생성 불가처리

            //Grid Field명 지정
            Col_WorkOrderNo.DataPropertyName = "WorkOrderNo";
            Col_CustCode.DataPropertyName = "CustCode";
            Col_CustName.DataPropertyName = "CustCode";
            Col_ProductCode.DataPropertyName = "ProductCode";
            Col_ProductName.DataPropertyName = "ProductCode";
            Col_ProductAlias.DataPropertyName = "ProductCode";
            Col_Unit.DataPropertyName = "ProductCode";
            Col_WorkQty.DataPropertyName = "WorkQty";
            Col_GoodQty.DataPropertyName = "GoodQty";
            Col_BadQty.DataPropertyName = "BadQty";
            Col_WorkOrderDate.DataPropertyName = "WorkOrderDate";
            Col_Remark.DataPropertyName = "Remark";

            //수정 불가 셋팅
            Col_WorkOrderNo.ReadOnly = true;
            Col_CustCode.ReadOnly = true;
            Col_CustName.ReadOnly = true;
            Col_ProductCode.ReadOnly = true;
            Col_ProductName.ReadOnly = true;
            Col_ProductAlias.ReadOnly = true;
            Col_WorkQty.ReadOnly = true;
            Col_GoodQty.ReadOnly = true;
            Col_BadQty.ReadOnly = false;        //불량수량
            Col_WorkOrderDate.ReadOnly = true;
            Col_Remark.ReadOnly = true;
        }

        private void InitCbo()
        {
            DataTable source;

            //거래처 관련
            Info_Customer cust = new Info_Customer();
            source = cust.Select_InItCbo_OrderCust();

            //수주처
            Col_CustName.DataSource = source.Select("CustType = 'CI02'").CopyToDataTable();
            Col_CustName.ValueMember = "CustCode";
            Col_CustName.DisplayMember = "CustName";


            //제품관련
            Info_Material material = new Info_Material();
            source = material.Select_Cbo_All();

            //제품명
            Col_ProductName.DataSource = source;
            Col_ProductName.ValueMember = "MaterialCode";
            Col_ProductName.DisplayMember = "MaterialName";

            //제품번호
            Col_ProductAlias.DataSource = source;
            Col_ProductAlias.ValueMember = "MaterialCode";
            Col_ProductAlias.DisplayMember = "Alias";

            //수량단위
            Col_Unit.DataSource = source;
            Col_Unit.ValueMember = "MaterialCode";
            Col_Unit.DisplayMember = "UnitName";
        }

        #endregion UI 디자인 Setting

        #region 조회

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            DisplayData_WorkOrder();
        }

        private void DisplayData_WorkOrder()
        {
            Product_WorkOrder wo = new Product_WorkOrder();
            wo.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value;
            wo.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value;
            wo.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;
            wo.Search_ProductName = uc_LblTxt_ProductName.TxtContents.Text;
            wo.Search_ProductAlias = uc_LblTxt_ProductAlias.TxtContents.Text;

            GvWorkOrder.DataSource = wo.R_WorkOrder_ByPerformance();
        }

        #endregion 조회 End

        #region 입력보조

        #region WorkOrder 체크박스

        private void GvWorkOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //체크박스 선택시 진행
            if (GvWorkOrder.Columns[e.ColumnIndex].Name == Col_Check.Name)
            {
                DataGridViewRow row = GvWorkOrder.Rows[e.RowIndex];

                ChkBoxClick_GvWorkOrder(row);

                return;
            }
        }

        private void ChkBoxClick_GvWorkOrder(DataGridViewRow datarow)
        {
            bool chk = Convert.ToBoolean(datarow.Cells[Col_Check.Name].Value);

            if (chk)
            {
                //체크상태 -> 체크해제상태 변환
                datarow.Cells[Col_Check.Name].Value = false;

                if (datarow.Cells[Col_BadQty.Name].Value != null || Convert.ToDouble(datarow.Cells[Col_BadQty.Name].Value) != 0)
                {
                    //불량수량을 입력한 상태일시 전체양품처리로 초기화
                    datarow.Cells[Col_GoodQty.Name].Value = datarow.Cells[Col_WorkQty.Name].Value;  //양품수량
                    datarow.Cells[Col_BadQty.Name].Value = 0;                                   //불량수량
                }
            }
            else
            {
                //체크해제상태 -> 체크상태 변환
                datarow.Cells[Col_Check.Name].Value = true;
            }
        }

        #endregion WorkOrder 체크박스 End

        #region 불량수량 입력 검사

        private void GvWorkPlan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //지시 수량 입력인지 확인
            if (GvWorkOrder.Columns[e.ColumnIndex].Name != Col_BadQty.Name) return;

            if (!CheckInsertOrderQty())
            {
                //진행 오류시
                GvWorkOrder.CurrentCell.Value = 0;

                return;
            }

            GvWorkOrder.Rows[e.RowIndex].Cells[Col_Check.Name].Value = true;
        }

        private bool CheckInsertOrderQty()
        {
            //숫자 입력 확인
            if (!CheckDouble()) return false;

            //작업수량
            double workQty = GvWorkOrder.Rows[GvWorkOrder.CurrentCell.RowIndex].Cells[Col_WorkQty.Name].Value == null
                              ? 0 : Convert.ToDouble(GvWorkOrder.Rows[GvWorkOrder.CurrentCell.RowIndex].Cells[Col_WorkQty.Name].Value);
            //불량수량
            double badQty = Convert.ToDouble(GvWorkOrder.CurrentCell.Value);

            if (workQty < badQty)
            {
                MessageBox.Show("불량수량이 작업수량보다 클 수 없습니다.");
                return false;
            }

            //양품수량 = 작업수량 - 불량수량
            GvWorkOrder.Rows[GvWorkOrder.CurrentCell.RowIndex].Cells[Col_GoodQty.Name].Value = workQty - badQty;

            return true;
        }

        private bool CheckDouble()
        {
            //Double Type으로 변환 가능한지 체크
            try
            {
                Convert.ToDouble(GvWorkOrder.CurrentCell.Value);

                return true;
            }
            catch
            {
                MessageBox.Show("0 또는 잘못된 값을 입력하였습니다.");
                return false;
            }
        }

        #endregion 불량수량 입력 End

        #endregion 입력보조 End

        #region 저장

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (SaveProcess_WorkOrder())
            {

            }
        }

        private bool SaveProcess_WorkOrder()
        {
            foreach (DataGridViewRow dataRow in GvWorkOrder.Rows)
            {
                //마지막행인 새입력 열일경우 스킵
                if (dataRow.IsNewRow == true) continue;
                //체크박스가 체크가 안되있으면 스킵
                if (Convert.ToBoolean(dataRow.Cells[Col_Check.Name].Value) != true) continue;

                //저장중 에러 발생시 저장 중단
                if (!Update_WorkOrder(dataRow))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Update_WorkOrder(DataGridViewRow dataRow)
        {
            Product_WorkOrder wo = new Product_WorkOrder();
            wo.WorkOrderNo = dataRow.Cells[Col_WorkOrderNo.Name].Value.ToString();
            wo.GoodQty = Convert.ToDouble(dataRow.Cells[Col_GoodQty.Name].Value);
            wo.BadQty = Convert.ToDouble(dataRow.Cells[Col_BadQty.Name].Value);

            return wo.U_WorkOrder_ByBadQty();
        }

        #endregion 저장 End

        private void Frm_Product_WorkOrderPerformance_FormClosed(object sender, FormClosedEventArgs e)
        {
            //종료시 찌꺼기 코드 제거
            Dispose();
        }

        private void Frm_Product_WorkPlan_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

    }
}
