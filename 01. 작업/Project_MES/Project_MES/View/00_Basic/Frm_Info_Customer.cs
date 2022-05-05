﻿using System;
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
        }

        #endregion UI 디자인 Setting
    }
}
