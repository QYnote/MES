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
    public partial class Uc_LblCbo : UserControl
    {
        #region Property

        public int LblWidth { get; set; } = 100;
        public int CboWdith { get; set; } = 150;
        public string LblText { get; set; } = "Label명";
        public string CboDefaultText { get; set; } = "Cbo 기본 Text";
        public object CboDataSource { get; set; }

        #endregion Property End

        public Uc_LblCbo()
        {
            InitializeComponent();
        }

        private void Uc_LblCbo_Load(object sender, EventArgs e)
        {
            SetBackGroud();
            CreateLabel();
            CreateCbo();
        }

        private void SetBackGroud()
        {
            this.Size = new Size(LblWidth + CboWdith + 14, 29);
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
            locationY = (this.Size.Height - lbl.Size.Height) / 2 - 1;

            lbl.Location = new Point(locationX, locationY);
        }

        private void CreateCbo()
        {
            ComboBox combo = new ComboBox();

            combo.Size = new Size(CboWdith, 23);
            combo.Text = CboDefaultText;
            combo.DataSource = CboDataSource;
            combo.Parent = this;

            //위치 셋팅
            int locationX, locationY;

            locationX = 9 + LblWidth;
            locationY = (this.Size.Height - combo.Size.Height) / 2 - 1;

            combo.Location = new Point(locationX, locationY);
        }

    }
}
