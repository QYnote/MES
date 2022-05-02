using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.Control.CustomUc.Common
{
    public partial class Uc_LblTxt : UserControl
    {
        #region Property

        public int LblWidth { get; set; } = 100;
        public int TxtWdith { get; set; } = 150;
        public string LblText { get; set; } = "Label명";
        public string DisplayText { get; set; } = "Default Text";

        #endregion Property End

        public TextBox TxtContents = new TextBox();

        public Uc_LblTxt()
        {
            InitializeComponent();
        }

        private void Uc_LblTxt_Load(object sender, EventArgs e)
        {
            SetBackGroud();
            CreateLabel();
            CreateText();
        }

        private void SetBackGroud()
        {
            this.Size = new Size(LblWidth + TxtWdith + 14, 29);
        }

        private void CreateLabel()
        {
            Label lbl = new Label();

            lbl.Size = new Size(LblWidth, 23);
            lbl.Text = LblText;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Parent = this;

            //위치 셋팅
            int locationX, locationY;

            locationX = 3;
            locationY = (this.Size.Height - lbl.Size.Height) / 2;

            lbl.Location = new Point(locationX, locationY);
        }

        private void CreateText()
        {
            TxtContents.Size = new Size(TxtWdith, 23);
            TxtContents.Text = DisplayText;
            TxtContents.Parent = this;

            //위치 셋팅
            int locationX, locationY;

            locationX = 9 + LblWidth;
            locationY = (this.Size.Height - TxtContents.Size.Height) / 2 - 1;

            TxtContents.Location = new Point(locationX, locationY);
        }

    }
}
