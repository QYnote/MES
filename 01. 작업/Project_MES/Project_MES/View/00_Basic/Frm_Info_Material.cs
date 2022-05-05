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
        }

        #endregion UI 디자인 Setting
    }
}
