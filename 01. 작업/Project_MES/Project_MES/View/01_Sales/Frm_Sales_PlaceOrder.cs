using Project_MES.Model._00_Basic;
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
        private DataTable dtMaterialCbo;

        public Frm_Sales_PlaceOrder()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "수주등록";
            Btn_Save.Text = "저장";
            Btn_Close.Text = "닫기";

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주사항";
            uc_LblTxt_OrderNo.Enabled = false;
            uc_LblCbo_OrderCust.CboContents.SelectedIndexChanged += new EventHandler(CboOrderCust_SelectedIndexChanged);

            Lbl_Contents1.Text = "수주내역";
            Btn_Delete.Text = "삭제";

            InitCbo();
            GvSet();
        }

        private void CboOrderCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            //수주처 변경시 제품코드 ComboBox 리스트 수주처에 맞추어 변경

            //선택된 수주처에 해당하는 제품이 없으면 콤보박스 백지화
            if (dtMaterialCbo.Select($"CustCode = '{(sender as ComboBox).SelectedValue}'").Length <= 0)
            {
                Col_ProductCode.DataSource = null;

                return;
            }

            if (GvOrderDetail.Rows.Count > 1)
            {
                //데이터 입력된상태면 Detail 초기화
                GvOrderDetail.Rows.Clear();
            }

            //제품코드 ComboBox 리스트 수주처에 맞추어 변경
            Col_ProductCode.DataSource = dtMaterialCbo.Select($"CustCode = '{(sender as ComboBox).SelectedValue}'").CopyToDataTable();
            Col_ProductCode.ValueMember = "MaterialCode";
            Col_ProductCode.DisplayMember = "MaterialCode";
        }

        private void GvSet()
        {
            //DataGridView 셋팅
            GvOrderDetail.AutoGenerateColumns = false; //DataSource Column생성 방지

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

        private void InitCbo()
        {
            Info_Customer cust = new Info_Customer();
            DataTable source = cust.Select_InItCbo_OrderCust();

            //수주사항 입력
            //배송거래처
            uc_LblCbo_OrderOutCust.CboContents.DataSource = source;
            uc_LblCbo_OrderOutCust.CboContents.ValueMember = "CustCode";
            uc_LblCbo_OrderOutCust.CboContents.DisplayMember = "CustName";


            //수주거래처
            uc_LblCbo_OrderCust.CboContents.DataSource = source.Select("CustType = 'CI02'").CopyToDataTable();
            uc_LblCbo_OrderCust.CboContents.ValueMember = "CustCode";
            uc_LblCbo_OrderCust.CboContents.DisplayMember = "CustName";

            Info_Material material = new Info_Material();
            dtMaterialCbo = material.Select_InitCbo_SalesOrder();

            Col_ProductCode.DataSource = dtMaterialCbo.Copy();
            Col_ProductCode.ValueMember = "MaterialCode";
            Col_ProductCode.DisplayMember = "MaterialCode";
        }
            
        #endregion UI 디자인 Setting End


        private void Btn_Save_Click(object sender, EventArgs e)
        {


            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GvOrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //제품코드 선택시 제품명, 제품번호, 스펙, 단위에 해당하는 Value 채우기
            if(GvOrderDetail.Columns[e.ColumnIndex].DataPropertyName == "ProductCode")
            {
                if (dtMaterialCbo.Select($"MaterialCode = '{GvOrderDetail.CurrentCell.Value}'").Length <= 0) return;
                DataRow item = dtMaterialCbo.Select($"MaterialCode = '{GvOrderDetail.CurrentCell.Value}'")[0];

                GvOrderDetail.CurrentRow.Cells[Col_ProductName.Name].Value = item["MaterialName"].ToString();
                GvOrderDetail.CurrentRow.Cells[Col_Alias.Name].Value = item["Alias"].ToString();
                GvOrderDetail.CurrentRow.Cells[Col_Spec.Name].Value = item["Spec"].ToString();
                GvOrderDetail.CurrentRow.Cells[Col_Unit.Name].Value = item["UnitName"].ToString();
            }
        }

    }
}
