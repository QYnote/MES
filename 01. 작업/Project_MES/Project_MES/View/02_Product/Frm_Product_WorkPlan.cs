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

            //컨텐츠 영역
            Lbl_Contents0.Text = "수주내역";
            gvPlaceOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //열선택
            gvPlaceOrderDetail.MultiSelect = false; //다중행 선택 불가
            gvPlaceOrderDetail.ReadOnly = true; //읽기전용
            gvPlaceOrderDetail.AllowUserToAddRows = false; ;    //열 생성 불가처리

            Lbl_Contents1.Text = "생산 계획내역";
            Btn_Save.Text = "저장";
            Btn_Delete.Text = "삭제";
            uc_LblTxt_OrderQty.TxtContents.ReadOnly = true;     //수량입력 방지
            uc_LblTxt_PlanQty.TxtContents.ReadOnly = true;      //수량입력 방지
            uc_LblTxt_RemainQty.TxtContents.ReadOnly = true;    //수량입력 방지
            gvWorkPlan.MultiSelect = false; //다중행 선택 불가
            Col_PlanQty.DefaultCellStyle.Format = "N";  //수량 입력 단위(,)표기
            Col_PlanStartDate.DefaultCellStyle.Format = "d"; //날짜 표기 형식 설정

        }

        #endregion UI 디자인 Setting
    }
}
