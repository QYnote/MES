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
    public partial class Frm_Info_CategoryItem : Form
    {
        public Frm_Info_CategoryItem()
        {
            InitializeComponent();
            SetDesign();
        }

        #region UI 디자인 Setting

        private void SetDesign()
        {
            //타이틀영역
            Lbl_MailTitle.Text = "종합코드관리";

            //컨텐츠 영역
            Lbl_Contents0.Text = "카테고리 그룹";
            Btn_Save_Group.Text = "하위 추가";
            Btn_Delete_Group.Text = "수정";

            Lbl_Contents1.Text = "카테고리 내용";
            Btn_Save_Item.Text = "저장";
            Btn_Delete_Item.Text = "수정";
        }

        #endregion UI 디자인 Setting
    }
}
