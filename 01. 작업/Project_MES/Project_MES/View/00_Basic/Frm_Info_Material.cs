using Project_MES.Control.CustomUc.Common;
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

namespace Project_MES.View._00_Basic
{
    public partial class Frm_Info_Material : Form
    {
        public Frm_Info_Material()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "자재정보 관리";

            //조회 영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Lbl_Contents0.Text = "자재 정보";
            Btn_Create.Text = "신규등록";
            Btn_Delete.Text = "삭제";

            Lbl_Contents1.Text = "자재 상세정보";
            Btn_Save.Text = "저장";

            GvSet();
            InitCbo();
            LimitTxtLength();
        }

        private void GvSet()
        {
            //DataGridView 셋팅
            gvMaterial.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_MaterialCode.DataPropertyName = "MaterialCode";
            Col_MaterialType.DataPropertyName = "MaterialType";
            Col_Cust.DataPropertyName = "CustCode";
            Col_MaterialName.DataPropertyName = "MaterialName";
            Col_Alias.DataPropertyName = "Alias";
            Col_Unit.DataPropertyName = "UnitCode";
        }

        private void InitCbo()
        {
            Info_Customer cust = new Info_Customer();
            DataTable source = cust.Select_Cbo();

            InitCboBase(source, "거래처코드", "거래처명", Col_Cust, uc_LblCbo_Cust);



            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = "CG000401";
            cateItem.Code_FieldName = "자재코드";
            cateItem.Value_FieldName = "자재타입";

            source = cateItem.Select_Cbo();

            InitCboBase(source, "자재코드", "자재타입", Col_MaterialType, uc_LblCbo_MaterialType);



            cateItem.GroupCode = "CG000402";
            cateItem.Code_FieldName = "단위코드";
            cateItem.Value_FieldName = "단위명";

            source = cateItem.Select_Cbo();

            InitCboBase(source, "단위코드", "단위명", Col_Unit, uc_LblCbo_Unit);
        }

        private void InitCboBase(DataTable source, string valueStr, string displayStr, DataGridViewComboBoxColumn col, Uc_LblCbo ucCbo)
        {
            //DataGridView 입력
            col.DataSource = source;
            col.ValueMember = valueStr;
            col.DisplayMember = displayStr;

            //상세정보 입력
            ucCbo.CboContents.DataSource = source;
            ucCbo.CboContents.ValueMember = valueStr;
            ucCbo.CboContents.DisplayMember = displayStr;
        }

        private void LimitTxtLength()
        {
            //글자길이 제한 지정
            uc_LblTxt_MaterialName.TxtContents.MaxLength = 100; //자재명
            uc_LblTxt_Alias.TxtContents.MaxLength = 100;        //자재번호
            uc_LblTxt_Spec.TxtContents.MaxLength = 100;         //스팩
            uc_LblTxt_Remark.TxtContents.MaxLength = 500;       //비고
        }

        #endregion UI 디자인 Setting

        private void Frm_Info_Material_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        //반제품 거래처코드 어떻게 처리할지 추가작업 필요

        #region 조회

        private void DisplayData()
        {
            Info_Material cust = new Info_Material();

            gvMaterial.DataSource = cust.Select_Frm_Info_Material();
        }


        private void gvMaterial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvMaterial.Rows[e.RowIndex].DataBoundItem == null) return;

            DataRow dr = (gvMaterial.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;   //선택된Row 거래처 코드

            uc_LblTxt_MaterialCode.TxtContents.Text = dr["MaterialCode"].ToString();    //자재코드
            uc_LblTxt_MaterialName.TxtContents.Text = dr["MaterialName"].ToString();    //자재명
            uc_LblTxt_Alias.TxtContents.Text = dr["Alias"].ToString();                  //자재번호
            uc_LblTxt_Spec.TxtContents.Text = dr["Spec"].ToString();                    //스펙
            uc_LblTxt_Remark.TxtContents.Text = dr["Remark"].ToString();                //비고

            uc_LblCbo_MaterialType.CboContents.SelectedValue = dr["MaterialType"];      //자재타입
            uc_LblCbo_Cust.CboContents.SelectedValue = dr["CustCode"];                  //거래처
            uc_LblCbo_Unit.CboContents.SelectedValue = dr["UnitCode"];                  //단위
        }

        #endregion 조회 End

        #region Insert/Update

        //신규 생성
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            //상세정보 초기화
            uc_LblTxt_MaterialCode.TxtContents.Clear(); //자재코드
            uc_LblTxt_MaterialName.TxtContents.Clear(); //자재명
            uc_LblTxt_Alias.TxtContents.Clear();        //자재번호
            uc_LblTxt_Spec.TxtContents.Clear();         //스펙
            uc_LblTxt_Remark.TxtContents.Clear();       //비고

            uc_LblCbo_MaterialType.CboContents.SelectedIndex = 0;   //자재타입
            uc_LblCbo_Cust.CboContents.SelectedIndex = 0;           //거래처
            uc_LblCbo_Unit.CboContents.SelectedIndex = 0;           //단위
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Info_Material material = new Info_Material();
            material.MaterialCode = uc_LblTxt_MaterialCode.TxtContents.Text;                    //자재코드
            material.MaterialName = uc_LblTxt_MaterialName.TxtContents.Text;                    //자재명
            material.MaterialType = uc_LblCbo_MaterialType.CboContents.SelectedValue.ToString();//자재타입
            material.Alias = uc_LblTxt_Alias.TxtContents.Text;                                  //자재번호
            material.Spec = uc_LblTxt_Spec.TxtContents.Text;                                    //스펙

            material.UnitCode = uc_LblCbo_Unit.CboContents.SelectedValue.ToString();            //단위
            material.CustCode = uc_LblCbo_Cust.CboContents.SelectedValue.ToString();            //거래처
            material.Remark = uc_LblTxt_Remark.TxtContents.Text;                                //비고

            material.InsertUpdate_Frm_Info_Material();

            DisplayData();
        }

        #endregion Insert/Update End

        #region 삭제

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Info_Material material = new Info_Material();
            material.MaterialCode = uc_LblTxt_MaterialCode.TxtContents.Text;    //자재코드

            material.Delete_Frm_Info_Material();

            DisplayData();
        }

        #endregion 삭제 End
    }
}
