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
    public partial class Frm_Sales_PlaceOrder : Form
    {

        //등록화면 호출시 완제품리스트 보관용
        private string FrmStatus;
        private DataTable dtMaterialCbo;

        //수정시 마스터정보
        public DataGridViewRow MasterRow;

        /// <summary>
        /// PlaceOrder 등록화면
        /// </summary>
        /// <param name="status">오픈 형태 신규생성 : Create, 수정 : Update</param>
        public Frm_Sales_PlaceOrder(string status)
        {
            InitializeComponent();
            SetDefaultDesign();
            FrmStatus = status;
        }

        #region UI 디자인 Setting

        private void SetDefaultDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "수주등록";
            Btn_Save.Text = "저장";
            Btn_Close.Text = "닫기";

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주사항";
            uc_LblTxt_OrderNo.TxtContents.ReadOnly = true;
            uc_LblCbo_OrderCust.CboContents.SelectedIndexChanged += new EventHandler(CboOrderCust_SelectedIndexChanged);
            uc_LblDtp_OrderDate.DtpStartDate.Value = DateTime.Now;
            uc_LblDtp_EndDate.DtpEndDate.Value = DateTime.Now;

            Lbl_Contents1.Text = "수주내역";
            Btn_Delete.Text = "삭제";

            InitCbo();
            GvSet();
        }

        /// <summary>
        /// 콤보박스 입력
        /// </summary>
        private void InitCbo()
        {
            Info_Customer cust = new Info_Customer();
            DataTable source = cust.Select_InItCbo_OrderCust();

            //수주사항 입력
            //수주거래처
            uc_LblCbo_OrderCust.CboContents.DataSource = source.Select("CustType = 'CI02'").CopyToDataTable();
            uc_LblCbo_OrderCust.CboContents.ValueMember = "CustCode";
            uc_LblCbo_OrderCust.CboContents.DisplayMember = "CustName";

            //납품거래처
            uc_LblCbo_OrderOutCust.CboContents.DataSource = source.Copy();
            uc_LblCbo_OrderOutCust.CboContents.ValueMember = "CustCode";
            uc_LblCbo_OrderOutCust.CboContents.DisplayMember = "CustName";

            //완제품
            Info_Material material = new Info_Material();
            dtMaterialCbo = material.Select_InitCbo_Product();

            Col_ProductCode.DataSource = dtMaterialCbo.Copy();
            Col_ProductCode.ValueMember = "MaterialCode";
            Col_ProductCode.DisplayMember = "MaterialCode";
        }

        /// <summary>
        /// GridView Setting
        /// gvPlaceOrderDetail 기본 셋팅
        /// </summary>
        private void GvSet()
        {
            //DataGridView 셋팅
            GvPlaceOrderDetail.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_Seq.DataPropertyName = "Seq";
            Col_ProductCode.DataPropertyName = "ProductCode";
            Col_ProductName.DataPropertyName = "MaterialName";
            Col_Alias.DataPropertyName = "Alias";
            Col_Spec.DataPropertyName = "Spec";
            Col_Qty.DataPropertyName = "OrderQty";
            Col_Unit.DataPropertyName = "ItemValue";
            Col_Remark.DataPropertyName = "Remark";
        }

        #endregion UI 디자인 Setting End

        #region 조회

        private void Frm_Sales_PlaceOrder_Load(object sender, EventArgs e)
        {
            //수정일 시 데이터 입력
            if (FrmStatus == "Update")
            {
                //데이터 입력
                InitPlaceOrder();

                //수정 불가
                uc_LblCbo_OrderCust.CboContents.Enabled = false; //수주처
                Btn_Delete.Visible = false;
            }
        }

        private void InitPlaceOrder()
        {
            //수정일 경우 데이터 입력
            //Master Info
            uc_LblTxt_OrderNo.TxtContents.Text = MasterRow.Cells["Col_OrderNo"].Value.ToString();                               //수주번호
            uc_LblCbo_OrderCust.CboContents.SelectedValue = MasterRow.Cells["Col_CustName"].Value ?? "";                        //수주처
            uc_LblCbo_OrderOutCust.CboContents.SelectedValue = MasterRow.Cells["Col_OutCustName"].Value ?? "";                  //납품처
            uc_LblDtp_OrderDate.DtpStartDate.Value = Convert.ToDateTime(MasterRow.Cells["Col_OrderDate"].Value.ToString());     //수주일
            uc_LblDtp_EndDate.DtpStartDate.Value = Convert.ToDateTime(MasterRow.Cells["Col_OrderEndDate"].Value.ToString());    //마감일
            uc_LblTxt_Remark.TxtContents.Text = MasterRow.Cells["Col_Remark_OM"].Value == null ? "": MasterRow.Cells["Col_Remark_OM"].Value.ToString(); //비고

            //Detail Info
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.OrderNo = MasterRow.Cells["Col_OrderNo"].Value.ToString();

            GvPlaceOrderDetail.DataSource = od.R_PlaceOrderDetail_ByOrderNo();
        }

        #endregion 조회 End

        #region 입력보조
        /// <summary>
        /// 수주처 변경 시 제품코드 ComboBox의 리스트를 수주처에 맞추어 변경
        /// </summary>
        private void CboOrderCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            //해당거래처에 해당하는 제품리스트 찾기
            DataRow[] rows = dtMaterialCbo.Select($"CustCode = '{(sender as ComboBox).SelectedValue}'");

            //선택된 수주처에 해당하는 제품이 없으면 콤보박스 백지화
            if (rows.Length <= 0)
            {
                Col_ProductCode.DataSource = null;

                return;
            }

            //데이터가 입력된 상태에서 수주처 변경 시
            //신규추가행 포함 행수가 1개 보다 많으면 GridVeiw 초기화
            if (GvPlaceOrderDetail.Rows.Count > 1)
            {
                GvPlaceOrderDetail.Rows.Clear();
            }

            //제품코드 ComboBox 리스트 수주처에 맞추어 변경
            Col_ProductCode.DataSource = rows.CopyToDataTable();
            Col_ProductCode.ValueMember = "MaterialCode";
            Col_ProductCode.DisplayMember = "MaterialCode";
        }


        /// <summary>
        /// 제품코드 선택시
        /// 제품명, 제품번호, 스펙, 단위에 해당하는 Value 채우기
        /// </summary>
        private void GvOrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //제품코드를 변경시에만 실행
            if(GvPlaceOrderDetail.Columns[e.ColumnIndex].DataPropertyName == "ProductCode")
            {
                //해당하는 제품코드 행 가져오기
                DataRow[] item = dtMaterialCbo.Select($"MaterialCode = '{GvPlaceOrderDetail.CurrentCell.Value}'");

                //선택창 열고 취소할경우 실행 취소
                if (item.Length <= 0) return;

                //연관데이터 입력
                GvPlaceOrderDetail.CurrentRow.Cells[Col_ProductName.Name].Value = item[0]["MaterialName"].ToString();    //제품명
                GvPlaceOrderDetail.CurrentRow.Cells[Col_Alias.Name].Value       = item[0]["Alias"].ToString();           //제품번호
                GvPlaceOrderDetail.CurrentRow.Cells[Col_Spec.Name].Value        = item[0]["Spec"].ToString();            //스펙
                GvPlaceOrderDetail.CurrentRow.Cells[Col_Unit.Name].Value        = item[0]["UnitName"].ToString();        //단위
            }
        }
        #endregion 입력보조End

        #region 저장

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //저장 프로세스 진행
            if (SaveProcess_PlaceOrder())
            {
                //정상실행시 후속 실행
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool SaveProcess_PlaceOrder()
        {
            //필수사항 입력 체크
            if (Check_SaveError()) return false;

            //Sales_PlaceOrderMaster 저장
            //저장 중 에러 발생시 저장 중단
            if (!Save_PlaceOrderMaster()) return false;

            //Sales_PlaceOrderDetail 저장
            foreach (DataGridViewRow dataRow in GvPlaceOrderDetail.Rows)
            {
                //마지막행인 새입력 열일경우 스킵
                if (dataRow.Index == GvPlaceOrderDetail.Rows.Count - 1) continue;

                //저장중 에러 발생시 저장 중단
                if (!Save_PlaceOrderDetail(dataRow))
                {
                    //신규생성일때 실행 오류 시 정보 삭제
                    if(FrmStatus == "Create")
                    {
                        Delete_PlaceOrder_ByError();
                    }
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 저장 전 에러체크
        /// </summary>
        /// <returns></returns>
        private bool Check_SaveError()
        {
            //수주내역 1줄이상 입력 했는지
            if (GvPlaceOrderDetail.Rows.Count <= 1) return true;

            //입력된 모든행 확인
            foreach (DataGridViewRow dataRow in GvPlaceOrderDetail.Rows)
            {
                //마지막행인 새입력 열일경우 스킵
                if (dataRow.Index == GvPlaceOrderDetail.Rows.Count - 1) continue;

                //제품코드 빈칸인 곳이 있는지
                if (dataRow.Cells[Col_ProductCode.Name].Value == null) return true;

                //수량 입력을 안한곳이 있는지
                if (dataRow.Cells[Col_Qty.Name].Value == null) return true;
            }

            return false;
        }

        /// <summary>
        /// PlaceOrderMaster 저장, 수정
        /// </summary>
        /// <returns>저장 중 정상 작동시 True, 오류시 False</returns>
        private bool Save_PlaceOrderMaster()
        {
            Sales_PlaceOrderMaster om = new Sales_PlaceOrderMaster();
            om.OrderNo = uc_LblTxt_OrderNo.TxtContents.Text;                                //수주번호
            om.OrderCustCode = uc_LblCbo_OrderCust.CboContents.SelectedValue.ToString();    //수주 거래처
            om.OutCustCode = uc_LblCbo_OrderOutCust.CboContents.SelectedValue.ToString();   //납품 거래처
            om.OutCustCode = uc_LblCbo_OrderOutCust.CboContents.SelectedValue.ToString();   //납품 거래처
            om.OrderDate = uc_LblDtp_OrderDate.DtpStartDate.Value;     //수주일자
            om.EndDate = uc_LblDtp_EndDate.DtpStartDate.Value;         //마감일자
            om.Remark = uc_LblTxt_Remark.TxtContents.Text;                                  //비고

            return om.CU_PlaceOrderMaster();
        }

        /// <summary>
        /// PlaceOrderDetail 저장, 수정
        /// </summary>
        /// <param name="dataRow"> 저장할 행</param>
        /// <returns>저장 중 정상 작동시 True, 오류시 False</returns>
        private bool Save_PlaceOrderDetail(DataGridViewRow dataRow)
        {
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.OrderNo = uc_LblTxt_OrderNo.TxtContents.Text;                       //수주번호
            od.Seq = dataRow.Index + 1;                                            //순번
            od.ProductCode = dataRow.Cells[Col_ProductCode.Name].Value.ToString(); //제품코드
            od.OrderQty = Convert.ToDouble(dataRow.Cells[Col_Qty.Name].Value);     //수량
            od.Remark = dataRow.Cells[Col_Remark.Name].Value == null ? "" : dataRow.Cells[Col_Remark.Name].Value.ToString();  //비고

            return od.CU_PlaceOrderDetail();
        }

        private void Delete_PlaceOrder_ByError()
        {
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            Sales_PlaceOrderMaster om = new Sales_PlaceOrderMaster();

        }

        #endregion 저장 End

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //현재행 데이터 가져오기
            DataGridViewRow dataRow = GvPlaceOrderDetail.CurrentRow;

            GvPlaceOrderDetail.Rows.Remove(dataRow);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            //저장하지 않고 종료
            DialogResult = DialogResult.Cancel;
        }

        private void Frm_Sales_PlaceOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //화면 종료시 Heap 찌꺼기 데이터 제거
            Dispose();
        }
    }
}
