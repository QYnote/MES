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
    public partial class Frm_Info_Process : Form
    {
        public Frm_Info_Process()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "공정정보 관리";

            //조회 영역
            Btn_Search.Text = "조회";

            //컨텐츠 영역
            Lbl_Contents0.Text = "공정 정보";
            Btn_Save_Process.Text = "저장";
            Btn_Delete_Process.Text = "삭제";

            Lbl_Contents1.Text = "라인 정보";
            Btn_Save_Line.Text = "저장";
            Btn_Delete_Line.Text = "삭제";
        }

        #endregion UI 디자인 Setting
    }
}
