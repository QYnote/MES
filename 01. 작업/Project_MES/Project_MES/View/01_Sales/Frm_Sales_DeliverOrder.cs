using Project_MES.Control.CustomUc.Gv;
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
    public partial class Frm_Sales_DeliverOrder : Form
    {
        public Frm_Sales_DeliverOrder()
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
            uc_LblDtp_OrderDate.DtpStartDate.Value = DateTime.Now.AddDays(-7);
            uc_LblDtp_OrderDate.DtpEndDate.Value = DateTime.Now;

            //컨텐츠 영역
            Btn_Order.Text = "납품";
            Lbl_Contents0.Text = "납품내역";

            GvSet();
            InitCbo();
        }

        private void GvSet()
        {
            GvSet_RemainDeliver();
        }

        private void GvSet_RemainDeliver()
        {
            //Grid Set
            GvDeliverOrder.AutoGenerateColumns = false; //DataSource Column생성 방지
            GvDeliverOrder.AllowUserToAddRows = false;  //새 행 입력 권한

            //ColumnSet
            Col_OrderNo.DataPropertyName = "OrderNo";                       //수주번호
            Col_OrderSeq.DataPropertyName = "Seq";                          //수주순번
            Col_OrderCustCode.DataPropertyName = "OrderCustCode";           //수주처코드
            Col_ProductCode.DataPropertyName = "ProductCode";               //제품코드
            Col_OrderQty.DataPropertyName = "OrderQty";                     //수주수량
            Col_WorkGoodQty.DataPropertyName = "GoodQty";               //양품생산량
            Col_DeliverOrderQtySum.DataPropertyName = "DeliveryOrderQty";    //납품진행량
            Col_DeliverRemainQty.DataPropertyName = "DeliveryRemainQty";     //미납품량
            Col_OutCustCode.DataPropertyName = "OutCustCode";               //납품처코드
            Col_OrderDate.DataPropertyName = "OrderDate";                   //수주일
            Col_OrderEndDate.DataPropertyName = "EndDate";                  //마감일

            //납품지시일자
            _ = new DtpCell(GvDeliverOrder, Col_DeliverDate);               
            Col_DeliverDate.DefaultCellStyle.Format = "d";  //날짜 표기 형식 설정

            //일부 Column 작성 가능하도록 수정
            Col_Check.ReadOnly = false;             //체크박스
            Col_DeliverOrderQty.ReadOnly = false;   //출하지시 할 수량
            Col_DeliverDate.ReadOnly = false;       //출하지시 일자

            Col_OrderNo.ReadOnly = true;            //수주번호
            Col_OrderSeq.ReadOnly = true;           //수주순번
            Col_OrderCustCode.ReadOnly = true;      //수주처
            Col_OrderQty.ReadOnly = true;           //수주수량
            Col_WorkGoodQty.ReadOnly = true;        //양품수량
            Col_DeliverRemainQty.ReadOnly = true;   //남은 출하수량
            Col_DeliverOrderQtySum.ReadOnly = true; //출하지시 한 수량
            Col_OrderDate.ReadOnly = true;          //수주일자
            Col_OrderEndDate.ReadOnly = true;       //마감일자
            Col_OutCustCode.ReadOnly = true;        //납품처
        }

        private void InitCbo()
        {
            //추후 코드 정보 Column 추가시 활성화
            /*
            DataTable source;

            Info_Customer cust = new Info_Customer();
            //수주처
            source = cust.Select_InItCbo_OrderCust().Select("CustType = 'CI02'").CopyToDataTable();
            Col_OrderCustName.DataSource = source;
            Col_OrderCustName.ValueMember = "CustCode";
            Col_OrderCustName.DisplayMember = "CustName";

            //납품처
            source = cust.Select_InItCbo_OrderCust().Select("CustType = 'CI04'").CopyToDataTable();
            Col_OutCustName.DataSource = source;
            Col_OutCustName.ValueMember = "CustCode";
            Col_OutCustName.DisplayMember = "CustName";

            Info_Material material = new Info_Material();
            source = material.Select_InitCbo_Product();
            //제품명
            Col_ProductName.DataSource = source;
            Col_ProductName.ValueMember = "MaterialCode";
            Col_ProductName.DisplayMember = "MaterialName";

            //제품번호
            Col_ProductAlias.DataSource = source;
            Col_ProductAlias.ValueMember = "MaterialCode";
            Col_ProductAlias.DisplayMember = "Alias";
            */
        }

        #endregion UI 디자인 Setting End

        #region 입력보조

        #region WorkOrder 체크박스

        private void GvDeliverOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //체크박스 선택시 진행
            if (GvDeliverOrder.Columns[e.ColumnIndex].Name == Col_Check.Name)
            {
                DataGridViewRow row = GvDeliverOrder.Rows[e.RowIndex];

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

                if (datarow.Cells[Col_DeliverOrderQty.Name].Value != null || Convert.ToDouble(datarow.Cells[Col_DeliverOrderQty.Name].Value) != 0)
                {
                    //불량수량을 입력한 상태일시 전체양품처리로 초기화
                    datarow.Cells[Col_DeliverOrderQty.Name].Value = 0;                                   //불량수량
                }
            }
            else
            {
                //체크해제상태 -> 체크상태 변환
                datarow.Cells[Col_Check.Name].Value = true;
            }
        }

        #endregion WorkOrder 체크박스 End

        #region 지시수량 입력 검사

        private void GvDeliverOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //지시 수량 입력인지 확인
            if (GvDeliverOrder.Columns[e.ColumnIndex].Name != Col_DeliverOrderQty.Name) return;

            if (!CheckInsertOrderQty())
            {
                //진행 오류시
                GvDeliverOrder.CurrentCell.Value = 0;

                return;
            }

            GvDeliverOrder.Rows[e.RowIndex].Cells[Col_Check.Name].Value = true;
        }

        private bool CheckInsertOrderQty()
        {
            //숫자 입력 확인
            if (!CheckDouble()) return false;

            //남은 지시수량
            double remainQty = GvDeliverOrder.Rows[GvDeliverOrder.CurrentCell.RowIndex].Cells[Col_DeliverRemainQty.Name].Value == null
                              ? 0 : Convert.ToDouble(GvDeliverOrder.Rows[GvDeliverOrder.CurrentCell.RowIndex].Cells[Col_DeliverRemainQty.Name].Value);
            //지시수량
            double orderQty = Convert.ToDouble(GvDeliverOrder.CurrentCell.Value);

            if (remainQty < orderQty)
            {
                MessageBox.Show("지시수량이 남은 지시수량보다 클 수 없습니다.");
                return false;
            }

            return true;
        }

        private bool CheckDouble()
        {
            //Double Type으로 변환 가능한지 체크
            try
            {
                Convert.ToDouble(GvDeliverOrder.CurrentCell.Value);

                return true;
            }
            catch
            {
                MessageBox.Show("0 또는 잘못된 값을 입력하였습니다.");
                return false;
            }
        }

        #endregion 지시수량 입력 End

        #endregion 입력보조 End

        #region 조회

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            Sales_PlaceOrderDetail od = new Sales_PlaceOrderDetail();
            od.Search_StartDate = uc_LblDtp_OrderDate.DtpStartDate.Value;
            od.Search_EndDate = uc_LblDtp_OrderDate.DtpEndDate.Value;
            od.Search_CustName = uc_LblTxt_CustName.TxtContents.Text;
            od.Search_ProductName = uc_LblTxt_ProductName.TxtContents.Text;
            od.Search_Alias = uc_LblTxt_ProductAlias.TxtContents.Text;

            GvDeliverOrder.DataSource = od.R_PlaceOrderDetail_InDeliveryOrder();
        }

        #endregion 조회 End

        #region 납품지시

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            if (OrderProcess_DeliveryOrder())
            {
                DisplayData();
            }
        }

        private bool OrderProcess_DeliveryOrder()
        {
            foreach (DataGridViewRow dataRow in GvDeliverOrder.Rows)
            {
                if (Check_DeliveryOrder(dataRow))
                {
                    continue;
                }

                if (!Save_DeliveryOrder(dataRow))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Check_DeliveryOrder(DataGridViewRow dataRow)
        {
            //체크박스 체크상태 검사
            bool chk = Convert.ToBoolean(dataRow.Cells[Col_Check.Name].Value);
            if (chk == false) return true;

            //지시수량 입력 검사
            if(dataRow.Cells[Col_DeliverOrderQty.Name].Value == null || 
                Convert.ToDouble(dataRow.Cells[Col_DeliverOrderQty.Name].Value) == 0)
            {
                return true;
            }

            //지시일자 검사
            if (dataRow.Cells[Col_DeliverDate.Name].Value == null) return true;

            return false;
        }


        private bool Save_DeliveryOrder(DataGridViewRow dataRow)
        {
            Sales_DeliveryOrder sdo = new Sales_DeliveryOrder();
            sdo.OrderNo = dataRow.Cells[Col_OrderNo.Name].Value.ToString();
            sdo.OrderSeq = Convert.ToInt32(dataRow.Cells[Col_OrderSeq.Name].Value);
            sdo.ProductCode = dataRow.Cells[Col_ProductCode.Name].Value.ToString();
            sdo.DeliveryOrderQty = Convert.ToDouble(dataRow.Cells[Col_DeliverOrderQty.Name].Value.ToString());
            sdo.DeliveryOrderDate = Convert.ToDateTime(dataRow.Cells[Col_DeliverDate.Name].Value);

            return sdo.C_DeliveryOrder();
        }

        #endregion

        private void Frm_Sales_DeliverOrder_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

    }
}
