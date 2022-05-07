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
    public partial class Frm_Info_Customer : Form
    {
        public Frm_Info_Customer()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "거래처정보 관리";

            //조회 영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Lbl_Contents0.Text = "거래처 정보";
            Btn_Create.Text = "신규등록";
            Btn_Delete.Text = "삭제";

            Lbl_Contents1.Text = "거래처 상세정보";
            Btn_Save.Text = "저장";

            GvSet();            //DataGridView Setting
            InitCbo();          //Cbo 데이터 입력
            LimitTxtLength();   //Txt길이제한 설정
        }

        private void GvSet()
        {
            //DataGridView 셋팅
            gvCustomer.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_CustType.DataPropertyName = "CustType";
            Col_CustName.DataPropertyName = "CustName";
            Col_CustNo.DataPropertyName = "CustNo";
            Col_Address.DataPropertyName = "Address";
        }

        private void InitCbo()
        {
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = "CG0002";
            cateItem.Code_FieldName = "거래처코드";
            cateItem.Value_FieldName = "거래처타입";

            DataTable source = cateItem.Select_Cbo();

            InitCboBase(source, "거래처코드", "거래처타입", Col_CustType, uc_LblCbo_CustType);
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
            uc_LblTxt_CustName.TxtContents.MaxLength = 100;     //거래처명
            uc_LblTxt_CustNo.TxtContents.MaxLength = 20;        //사업자번호
            uc_LblTxt_Adress.TxtContents.MaxLength = 100;       //주소
            uc_LblTxt_Presi.TxtContents.MaxLength = 100;        //대표자
            uc_LblTxt_Post.TxtContents.MaxLength = 20;          //우편번호

            uc_LblTxt_Email.TxtContents.MaxLength = 100;        //이메일
            uc_LblTxt_Tel.TxtContents.MaxLength = 20;           //담당자번호
            uc_LblTxt_Fax.TxtContents.MaxLength = 20;           //팩스
            uc_LblTxt_Cate.TxtContents.MaxLength = 100;         //업종
            uc_LblTxt_Condition.TxtContents.MaxLength = 100;    //업태

            uc_LblTxt_Remark.TxtContents.MaxLength = 500;       //비고
        }

        #endregion UI 디자인 Setting

        private void Frm_Info_Customer_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        #region 조회

        private void DisplayData()
        {
            Info_Customer cust = new Info_Customer();

            gvCustomer.DataSource = cust.Select_Frm_Info_Customer();
        }

        
        private void gvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {   //Row선택시 상세정보 입력
            if (gvCustomer.Rows[e.RowIndex].DataBoundItem == null) return;

            DataRow dr = (gvCustomer.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;   //선택된Row 거래처 코드

            uc_LblCbo_CustType.CboContents.SelectedValue = dr["CustType"];          //거래처타입
            uc_LblTxt_CustCode.TxtContents.Text = dr["CustCode"].ToString();        //거래처코드
            uc_LblTxt_CustName.TxtContents.Text = dr["CustName"].ToString();        //거래처명
            uc_LblTxt_CustNo.TxtContents.Text = dr["CustNo"].ToString();            //사업자번호
            uc_LblTxt_Adress.TxtContents.Text = dr["Address"].ToString();           //주소

            uc_LblTxt_Presi.TxtContents.Text = dr["Presi"].ToString();              //대표자
            uc_LblTxt_Post.TxtContents.Text = dr["Post"].ToString();                //우편번호
            uc_LblTxt_Email.TxtContents.Text = dr["Mail"].ToString();               //이메일
            uc_LblTxt_Tel.TxtContents.Text = dr["Tel"].ToString();                  //담당자번호
            uc_LblTxt_Fax.TxtContents.Text = dr["Fax"].ToString();                  //팩스

            uc_LblTxt_Cate.TxtContents.Text = dr["Category"].ToString();            //업종
            uc_LblTxt_Condition.TxtContents.Text = dr["ConditionName"].ToString();  //업태
            uc_LblTxt_Remark.TxtContents.Text = dr["Remark"].ToString();            //비고
        }

        #endregion 조회 End

        #region Insert/Update

        //신규 생성
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            //상세정보 초기화
            uc_LblTxt_CustCode.TxtContents.Clear();             //거래처코드
            uc_LblCbo_CustType.CboContents.SelectedIndex = 0;   //거래처 타입
            uc_LblTxt_CustName.TxtContents.Clear();             //거래처명
            uc_LblTxt_Presi.TxtContents.Clear();                //대표자
            uc_LblTxt_CustNo.TxtContents.Clear();               //사업자번호

            uc_LblTxt_Adress.TxtContents.Clear();               //주소
            uc_LblTxt_Post.TxtContents.Clear();                 //우편번호
            uc_LblTxt_Email.TxtContents.Clear();                //이메일
            uc_LblTxt_Tel.TxtContents.Clear();                  //담당자번호
            uc_LblTxt_Fax.TxtContents.Clear();                  //팩스

            uc_LblTxt_Cate.TxtContents.Clear();                 //업종
            uc_LblTxt_Condition.TxtContents.Clear();            //업태
            uc_LblTxt_Remark.TxtContents.Clear();               //비고
        }

        //신규등록, 저장
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Info_Customer cust = new Info_Customer();
            cust.CustCode = uc_LblTxt_CustCode.TxtContents.Text;                        //거래처코드
            cust.CustType = uc_LblCbo_CustType.CboContents.SelectedValue.ToString();    //거래처 타입
            cust.CustName = uc_LblTxt_CustName.TxtContents.Text;                        //거래처명
            cust.Presi = uc_LblTxt_Presi.TxtContents.Text;                              //대표자
            cust.CustNo = uc_LblTxt_CustNo.TxtContents.Text;                            //사업자번호

            cust.Address = uc_LblTxt_Adress.TxtContents.Text;                           //주소
            cust.Post = uc_LblTxt_Post.TxtContents.Text;                                //우편번호
            cust.Mail = uc_LblTxt_Email.TxtContents.Text;                               //이메일
            cust.Tel = uc_LblTxt_Tel.TxtContents.Text;                                  //담당자번호
            cust.Fax = uc_LblTxt_Fax.TxtContents.Text;                                  //팩스

            cust.Category = uc_LblTxt_Cate.TxtContents.Text;                            //업종
            cust.Condition = uc_LblTxt_Condition.TxtContents.Text;                      //업태
            cust.Remark = uc_LblTxt_Remark.TxtContents.Text;                            //비고

            cust.InsertUpdate_Frm_Info_Customer();

            DisplayData();
        }

        #endregion Insert/Update End

        #region Delete

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Info_Customer cust = new Info_Customer();
            cust.CustCode = uc_LblTxt_CustCode.TxtContents.Text;    //거래처코드

            cust.Delete_Frm_Info_Customer();

            DisplayData();
        }

        #endregion Delete End
    }
}
