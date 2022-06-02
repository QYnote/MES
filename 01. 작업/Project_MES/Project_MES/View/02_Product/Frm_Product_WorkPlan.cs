using Project_MES.Control.CustomUc.Gv;
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

            //조회영역
            Btn_Search.Text = "조회";
            uc_LblDtp_OrderDate.DtpStartDate.Value = DateTime.Now.AddDays(-7);
            uc_LblDtp_OrderDate.DtpEndDate.Value = DateTime.Now;

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주내역";

            //컨텐츠 영역 - 생산계획
            Lbl_Contents1.Text = "생산 계획내역";
            Btn_Save.Text = "저장";
            Btn_Delete.Text = "삭제";
            //수량부분
            uc_LblTxt_OrderQty.TxtContents.ReadOnly = true;     //수량입력 방지
            uc_LblTxt_PlanQty.TxtContents.ReadOnly = true;      //수량입력 방지
            uc_LblTxt_RemainQty.TxtContents.ReadOnly = true;    //수량입력 방지

            GvSet();
            InitCbo();
        }

        private void GvSet()
        {
            GvSet_PlaceOrder();
            GvSet_WorkPlan();
        }

        private void GvSet_PlaceOrder()
        {
            //DataGridView 셋팅
            GvPlaceOrderDetail.AutoGenerateColumns = false; //DataSource Column생성 방지
            GvPlaceOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //열선택
            GvPlaceOrderDetail.MultiSelect = false; //다중행 선택 불가
            GvPlaceOrderDetail.ReadOnly = true; //읽기전용
            GvPlaceOrderDetail.AllowUserToAddRows = false; ;    //열 생성 불가처리

            //Grid Field명 지정
            Col_OrderNo.DataPropertyName = "OrderNo";
            Col_OrderSeq.DataPropertyName = "Seq";
            Col_CustName.DataPropertyName = "OrderCustCode";
            Col_ProductCode.DataPropertyName = "ProductCode";
            Col_ProductName.DataPropertyName = "ProductCode";
            Col_ProductAlias.DataPropertyName = "ProductCode";
            Col_OrderDate.DataPropertyName = "OrderDate";
            Col_OrderEndDate.DataPropertyName = "EndDate";
            Col_Remark_SO.DataPropertyName = "Remark";
            Col_PlanStatus.DataPropertyName = "PlanStatus";
            Col_Hide_OrderQty.DataPropertyName = "OrderQty";
        }

        private void GvSet_WorkPlan()
        {
            //DataGridView 셋팅
            GvWorkPlan.AutoGenerateColumns = false; //DataSource Column생성 방지
            GvWorkPlan.MultiSelect = false; //다중행 선택 불가
            
            //DataGridVIew에 DateTimePicker 적용하기
            _ = new DtpCell(GvWorkPlan, Col_PlanStartDate);

            //Grid Column 설정
            Col_PlanNo.DataPropertyName = "PlanNo";
            Col_PlanQty.DataPropertyName = "PlanQty";
            Col_Unit_WP.DataPropertyName = "ProductCode";
            Col_PlanStartDate.DataPropertyName = "PlanDate";
            Col_WorkStatus.DataPropertyName = "WorkStatus";
            Col_Remark_WP.DataPropertyName = "Remark";

            Col_PlanQty.DefaultCellStyle.Format = "N2";  //수량 입력 단위(,)표기
            Col_PlanStartDate.DefaultCellStyle.Format = "d"; //날짜 표기 형식 설정
            Col_PlanNo.ReadOnly = true;     //계획번호
            Col_Unit_WP.ReadOnly = true;    //단위
            Col_WorkStatus.ReadOnly = true; //작업상태
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
            Col_Unit_WP.DataSource = source;
            Col_Unit_WP.ValueMember = "MaterialCode";
            Col_Unit_WP.DisplayMember = "UnitName";


            //계획상태
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.Value_FieldName = "계획상태";
            cateItem.Code_FieldName = "상태코드";
            cateItem.GroupCode = "CG0101";

            Col_PlanStatus.DataSource = cateItem.Select_Cbo();
            Col_PlanStatus.ValueMember = "상태코드";
            Col_PlanStatus.DisplayMember = "계획상태";

            //작업진행상태
            cateItem.Value_FieldName = "계획상태";
            cateItem.Code_FieldName = "상태코드";
            cateItem.GroupCode = "CG0202";

            Col_WorkStatus.DataSource = cateItem.Select_Cbo();
            Col_WorkStatus.ValueMember = "상태코드";
            Col_WorkStatus.DisplayMember = "계획상태";
        }

        #endregion UI 디자인 Setting

        #region 조회

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            DisplayData_OrderDetail();
            DisplayData_WorkPlan();
            DisplayData_Qty();
        }

        private void DisplayData_OrderDetail()
        {
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value;
            od.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value;
            od.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;
            od.Search_ProductName = uc_LblTxt_ProductName.TxtContents.Text;
            od.Search_Alias = uc_LblTxt_ProductAlias.TxtContents.Text;

            GvPlaceOrderDetail.DataSource = od.R_PlaceOrderDetail_BySearch();
        }

        private void GvPlaceOrderDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GvPlaceOrderDetail.SelectedRows.Count < 1) return;

            DisplayData_WorkPlan();
            DisplayData_Qty();
        }

        private void DisplayData_WorkPlan()
        {
            Product_WorkPlan wp = new Product_WorkPlan();
            DataGridViewRow row = GvPlaceOrderDetail.SelectedRows[0];
            wp.OrderNo = row.Cells[Col_OrderNo.Name].Value.ToString(); //선택된Row LotNo;
            wp.OrderSeq = Convert.ToInt32(row.Cells[Col_OrderSeq.Name].Value);

            GvWorkPlan.DataSource = wp.R_WorkPlan_ByOrderNoSeq();
        }

        private void DisplayData_Qty()
        {
            //수주수량 : 수주목록에서 숨겨놓은 Column 에서 데이터 가져오기
            double orderQty = GvPlaceOrderDetail.SelectedRows[0].Cells[Col_Hide_OrderQty.Name].Value == null
                              ? 0 : Convert.ToDouble(GvPlaceOrderDetail.SelectedRows[0].Cells[Col_Hide_OrderQty.Name].Value);

            uc_LblTxt_OrderQty.TxtContents.Text = orderQty.ToString("N0"); ;


            //계획수량 : 계획목록에 작성된 수량 합계 입력
            double totalQty = 0;

            foreach (DataGridViewRow row in GvWorkPlan.Rows)
            {
                totalQty += row.Cells[Col_PlanQty.Name].Value == null
                            ? 0 : Convert.ToDouble(row.Cells[Col_PlanQty.Name].Value);
            }

            uc_LblTxt_PlanQty.TxtContents.Text = totalQty.ToString("N0");


            //남은수량
            double remainQty = orderQty - totalQty;

            uc_LblTxt_RemainQty.TxtContents.Text = remainQty.ToString("N0");
        }

        #endregion 조회 End

        #region 입력보조

        private void GvWorkPlan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //계획 수량 입력인지 확인
            if (GvWorkPlan.Columns[e.ColumnIndex].DataPropertyName != "PlanQty") return;

            if (!CheckInsertPlanQty())
            {
                return;
            }

            //수량입력 후 날짜 빈칸일 시 오늘날짜로 입력
            if(GvWorkPlan.Rows[e.RowIndex].Cells[Col_PlanStartDate.Name].Value == null)
            {
                GvWorkPlan.Rows[e.RowIndex].Cells[Col_PlanStartDate.Name].Value = DateTime.Now;
            }

            DisplayData_Qty();
        }

        /// <summary>
        /// 입력한 수량이 알맞은 형태로 입력했는지 확인
        /// 숫자입력 or 알맞은 수량
        /// </summary>
        /// <returns></returns>
        private bool CheckInsertPlanQty()
        {
            //수량 입력시 좌측 수량 목록 변경
            /*
             * 1. 해당 셀이 숫자 입력인지 확인
             * 2. 수량일 시 진행
             * 3. 계획수량 < 작성된 목록 리스트의 합계 수량(입력한 셀 포함)인지 확인
             * 3-1. 높을때
             * 3-1-1. 현재 셀값 0으로 바꿈
             * 3-1-2. 알림 메시지 전송
             * 3-2. 같거나 낮을때
             * 3-2-1. 정상진행
             */

            //숫자 입력 확인
            if (!CheckDouble()) return false;

            //수량 합계 확인
            //수주수량 : 수주목록에서 숨겨놓은 Column 에서 데이터 가져오기
            double orderQty = GvPlaceOrderDetail.SelectedRows[0].Cells[Col_Hide_OrderQty.Name].Value == null
                              ? 0 : Convert.ToDouble(GvPlaceOrderDetail.SelectedRows[0].Cells[Col_Hide_OrderQty.Name].Value);
            //계획수량 : 계획목록에 작성된 수량 합계 입력
            double totalQty = 0;

            foreach (DataGridViewRow row in GvWorkPlan.Rows)
            {
                totalQty += row.Cells[Col_PlanQty.Name].Value == null
                            ? 0 : Convert.ToDouble(row.Cells[Col_PlanQty.Name].Value);
            }

            if (orderQty < totalQty)
            {
                //수주수량 < 입력수량일시 경고
                if(MessageBox.Show("입력수량이 수주수량보다 많습니다. 계속 하시겠습니까?", "QtyDanger", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    //취소시 입력수량 0으로 초기화
                    GvWorkPlan.CurrentCell.Value = 0;

                    return false;
                }
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
                GvWorkPlan.CurrentCell.Value = 0;
                return false;
            }
        }

        #endregion 입력보조 End

        #region 등록

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //정상 진행시 추가 진행
            if (SaveProcess_WorkOrder())
            {
                DisplayData();
            }
        }

        private bool SaveProcess_WorkOrder()
        {
            //에러항목 사전확인
            if (Check_SaveError()) return false;

            //Product_WorkOrder 저장
            foreach (DataGridViewRow dataRow in GvWorkPlan.Rows)
            {
                //마지막행인 새입력 열일경우 스킵
                if (dataRow.IsNewRow == true) continue;

                //저장중 에러 발생시 저장 중단
                if (!Save_WorkOrder(dataRow))
                {
                    return false;
                }
            }

            //PlaceOrder 상태 변경
            if (!UpdateStatus_PlaceOrder())
            {
                return false;
            }

            return true;
        }

        private bool Check_SaveError()
        {
            foreach (DataGridViewRow dataRow in GvWorkPlan.Rows)
            {
                if(dataRow.IsNewRow) continue;

                //수량을 입력 했는가
                if (dataRow.Cells[Col_PlanQty.Name].Value == null) return true;

                //수량이 0이 아닌가
                if (Convert.ToDouble(dataRow.Cells[Col_PlanQty.Name].Value) == 0) return true;

                //날짜를 입력 했는가
                if (dataRow.Cells[Col_PlanStartDate.Name].Value == null) return true;
            }

            return false;
        }

        private bool Save_WorkOrder(DataGridViewRow dataRow)
        {
            Product_WorkPlan wp = new Product_WorkPlan();
            wp.PlanNo = dataRow.Cells[Col_PlanNo.Name].Value == null ? "" : dataRow.Cells[Col_PlanNo.Name].Value.ToString();    //계획번호
            wp.OrderNo = GvPlaceOrderDetail.SelectedRows[0].Cells[Col_OrderNo.Name].Value.ToString();           //수주번호
            wp.OrderSeq = Convert.ToInt32(GvPlaceOrderDetail.SelectedRows[0].Cells[Col_OrderSeq.Name].Value);   //수주순번
            wp.ProductCode = GvPlaceOrderDetail.SelectedRows[0].Cells[Col_ProductCode.Name].Value.ToString();   //제품코드
            wp.PlanQty = Convert.ToDouble(dataRow.Cells[Col_PlanQty.Name].Value);                               //수량
            wp.PlanDate = Convert.ToDateTime(dataRow.Cells[Col_PlanStartDate.Name].Value);                      //생산시작 계획일
            wp.Remark = dataRow.Cells[Col_Remark_WP.Name].Value == null ? "" : dataRow.Cells[Col_Remark_WP.Name].Value.ToString();  //비고

            return wp.CU_WorkPlan();
        }

        private bool UpdateStatus_PlaceOrder()
        {
            double orderQty = Convert.ToDouble(uc_LblTxt_OrderQty.TxtContents.Text);
            double planQty = Convert.ToDouble(uc_LblTxt_PlanQty.TxtContents.Text);
            string status;

            //CI01 : 계획중, CI02 : 계획대기, CI03 : 계획완료
            if (orderQty <= planQty)
            {
                //계획수량이 수주수량과 같거나 높을경우
                status = "CI03";
            }
            else if (planQty == 0)
            {
                //계획수량이 0일경우
                status = "CI02";
            }
            else
            {
                //계획수량이 수주수량보자 적을경우
                status = "CI01";
            }

            //데이터 입력
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.OrderNo = GvPlaceOrderDetail.SelectedRows[0].Cells[Col_OrderNo.Name].Value.ToString();       //수주번호
            od.Seq = Convert.ToInt32(GvPlaceOrderDetail.SelectedRows[0].Cells[Col_OrderSeq.Name].Value);    //수주순번
            od.WorkStatus = status;

            return od.U_PlaceOrderDetail_ByWorkPlanSave();
        }

        #endregion 등록 End

        #region 삭제

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //선택한 행이 신규입력행일시 초기화
            if (GvWorkPlan.CurrentRow.IsNewRow) return;

            //정상진행 감지
            if (DeleteProcess_WorkPlan())
            {
            }
        }

        private bool DeleteProcess_WorkPlan()
        {
            DataGridViewRow row = GvWorkPlan.CurrentRow;

            //계획번호가 적혀있는지 감지
            if(row.Cells[Col_PlanNo.Name].Value != null)
            {   //계획번호가 있을경우
                //query 오류 감지
                if (!Delete_WorkPlan(row))
                {
                    return false;
                }

                //행 삭제
                GvWorkPlan.Rows.Remove(GvWorkPlan.CurrentRow);

                DisplayData_Qty();          //총계획수량 재계산
                UpdateStatus_PlaceOrder();  //수주내역 상태 수정
                DisplayData_OrderDetail();  //수주내역 재조회
            }
            else
            {   //계획번호가 빈칸일 경우
                //행 삭제
                GvWorkPlan.Rows.Remove(GvWorkPlan.CurrentRow);

                DisplayData_Qty();  //총계획수량 재계산
            }

            return true;
        }

        private bool Delete_WorkPlan(DataGridViewRow row)
        {
            Product_WorkPlan wp = new Product_WorkPlan();
            wp.PlanNo = row.Cells[Col_PlanNo.Name].Value.ToString();

            return wp.D_WorkPlan();
        }

        #endregion 삭제 End

        private void Frm_Product_WorkPlan_FormClosed(object sender, FormClosedEventArgs e)
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
