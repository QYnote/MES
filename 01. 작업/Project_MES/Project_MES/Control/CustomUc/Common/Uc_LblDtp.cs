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
    public partial class Uc_LblDtp : UserControl
    {
        #region Property

        public int LblWidth { get; set; } = 100;
        private int DtpWidth = 150;
        public string LblText { get; set; } = "Label명";
        public DateTime DtpDefaultDate { get; set; } = DateTime.Now;
        public DateTimePickerFormat DisplayFormat { get; set; } = DateTimePickerFormat.Short;
        public bool DtpRange { get; set; } = false;

        #endregion Property End

        public Uc_LblDtp()
        {
            InitializeComponent();
        }

        private void Uc_LblDtp_Load(object sender, EventArgs e)
        {
            SetBackGroud();
            CreateLabel();
            CreateDtp();
        }

        private void SetBackGroud()
        {
            if (DisplayFormat == DateTimePickerFormat.Short)
            {
                DtpWidth = 100;
            }

            this.Size = new Size(LblWidth + DtpWidth + (2 * 6 + 2), 29);
        }

        private void CreateLabel()
        {
            //제목Label
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

        private void CreateDtp()
        {
            //DatetimePicker StartDate 셋팅
            DateTimePicker dtp = new DateTimePicker();

            //정보 셋팅
            dtp.Size = new Size(DtpWidth, 23);
            dtp.Value = DtpDefaultDate;
            dtp.Format = DisplayFormat;
            dtp.Parent = this;

            //위치 셋팅
            int locationX, locationY;

            locationX = 9 + LblWidth;
            locationY = (this.Size.Height - dtp.Size.Height) / 2 - 1;
            dtp.Location = new Point(locationX, locationY);



            //날짜 범위로 사용시 추가 생성
            if (DtpRange)
            {
                //중간 "~"Label 셋팅
                Label midLbl = new Label();

                //정보셋팅
                midLbl.Size = new Size(12, 23);
                midLbl.Text = "~";
                midLbl.TextAlign = ContentAlignment.MiddleCenter;
                midLbl.Parent = this;

                //위치 셋팅
                locationX = this.Margin.Left + (6 + LblWidth) + (6 + DtpWidth);
                locationY = (this.Size.Height - midLbl.Size.Height) / 2 - 1;
                midLbl.Location = new Point(locationX, locationY);



                //EndDate 셋팅
                DateTimePicker dtpEnd = new DateTimePicker();

                //정보 셋팅
                dtpEnd.Size = new Size(DtpWidth, 23);
                dtpEnd.Value = DtpDefaultDate;
                dtpEnd.Format = DisplayFormat;
                dtpEnd.Parent = this;

                //위치 셋팅
                locationX = this.Margin.Left + (LblWidth + 6) + (DtpWidth + 6) + (midLbl.Size.Width + 6);
                locationY = (this.Size.Height - dtpEnd.Size.Height) / 2 - 1;
                dtpEnd.Location = new Point(locationX, locationY);



                //base 사이즈 변경
                //      Margin               제목             날짜2개            ~
                //메인폼 margin(3) * 2 + (lblWidth + 6)+  (DtpWidth + 6) * 2 + (midLbl + 6)
                this.Size = new Size((LblWidth + 6) + ((DtpWidth + 6) * 2) + (midLbl.Size.Width + 6) + 2, 29);   
            }
        }

    }
}
