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
        private DataTable dtMaterialCbo;

        public Frm_Sales_PlaceOrder()
        {
            InitializeComponent();
            SetDefaultDesign();
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
            Col_Seq.DataPropertyName = "LotSeq";
            Col_ProductCode.DataPropertyName = "ProductCode";
            Col_ProductName.DataPropertyName = "ProductName";
            Col_Alias.DataPropertyName = "Alias";
            Col_Spec.DataPropertyName = "Spec";
            Col_Qty.DataPropertyName = "OrderQty";
            Col_Unit.DataPropertyName = "Unit";
            Col_Remark.DataPropertyName = "Remark";
        }

        #endregion UI 디자인 Setting End

        #region 저장

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

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //필수사항 입력 체크
            if (Check_SaveError()) return;

            //저장 프로세스 진행
            if (SaveProcess_PlaceOrder())
            {
                //정상실행시 후속 실행
                DialogResult = DialogResult.OK;
                Close();
            }
        }

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

        private bool SaveProcess_PlaceOrder()
        {
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
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// PlaceOrderMaster 저장, 수정
        /// </summary>
        /// <returns>저장 중 정상 작동시 True, 오류시 False</returns>
        private bool Save_PlaceOrderMaster()
        {
            Sales_PlaceOrderMaster om = new Sales_PlaceOrderMaster();
            om.OrderCustCode = uc_LblCbo_OrderCust.CboContents.SelectedValue.ToString();    //수주 거래처
            om.OutCustCode = uc_LblCbo_OrderOutCust.CboContents.SelectedValue.ToString();   //납품 거래처
            om.OutCustCode = uc_LblCbo_OrderOutCust.CboContents.SelectedValue.ToString();   //납품 거래처
            om.OrderDate = uc_LblDtp_OrderDate.DtpStartDate.Value.ToString("yyyyMMdd");     //수주일자
            om.EndDate = uc_LblDtp_EndDate.DtpStartDate.Value.ToString("yyyyMMdd");         //마감일자
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
            od.OrderNo = uc_LblTxt_OrderNo.TxtContents.Text;    //수주번호
            od.Seq = dataRow.Cells[Col_ProductCode.Name].Value == null ? 0 : (int)dataRow.Cells[Col_ProductCode.Name].Value;   //순번
            od.ProductCode = dataRow.Cells[Col_ProductCode.Name].Value.ToString();  //제품코드
            od.OrderQty = Convert.ToDouble(dataRow.Cells[Col_Qty.Name].Value);      //수량
            od.Remark = dataRow.Cells[Col_Remark.Name].Value == null ? "" : dataRow.Cells[Col_Remark.Name].Value.ToString();  //비고

            return od.CU_PlaceOrderDetail();
        }

        #endregion 저장 End
    }
}
