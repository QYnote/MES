using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.Control.CustomUc.Gv
{
    internal class DtpCell
    {
        private DateTimePicker InsertDtpCell;
        private readonly DataGridView InsertGv;
        private readonly DataGridViewTextBoxColumn InsertCol;

        /// <summary>
        /// DataGridView의 Cell에 DateTimePiker 방식 적용하기
        /// </summary>
        /// <param name="gv">들어갈 DataGridView</param>
        /// <param name="col">들어갈 Column</param>
        public DtpCell(DataGridView gv, DataGridViewTextBoxColumn col)
        {
            InsertGv = gv;
            InsertCol = col;
            gv.CellClick += Gv_CellClick;
        }

        private  void Gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택한 셀의 열이 생산시작 계획일일 경우 실행
            if (InsertGv.Columns[e.ColumnIndex].Name == InsertCol.Name)
            {
                InsertDtpCell = new DateTimePicker();

                InsertGv.Controls.Add(InsertDtpCell);

                //Dtp 셋팅
                Rectangle BtnDtp = InsertGv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //달력버튼

                InsertDtpCell.Format = DateTimePickerFormat.Short;                    //표기형식
                InsertDtpCell.Size = new Size(BtnDtp.Width, BtnDtp.Height);           //버튼크기
                InsertDtpCell.Location = new Point(BtnDtp.X, BtnDtp.Y);               //버튼위치
                InsertDtpCell.ValueChanged += new EventHandler(InsertValueDtpToCell); //달력 선택 값 - GvCell 값 연동
                InsertDtpCell.CloseUp += new EventHandler(HideDtp);                   //달력 숨기기
                InsertDtpCell.LostFocus += new EventHandler(HideDtp);
                InsertDtpCell.Value = DateTime.Now;
            }
        }

        private void InsertValueDtpToCell(object sender, EventArgs e)
        {
            //선택된 셀이 날짜 입력 셀일 경우에만 입력
            if (InsertGv.CurrentCell.ColumnIndex == InsertCol.Index)
            {
                //Cell에 달력값 넣기
                InsertGv.CurrentCell.Value = InsertDtpCell.Value;
            }
        }

        private void HideDtp(object sender, EventArgs e)
        {
            //미사용시 버튼 숨기기
            InsertDtpCell.Visible = false;
        }

        //코드 출저 : https://www.aspsnippets.com/questions/188248/Display-DateTimePicker-in-DataGridView-cell-using-C-and-VBNet-in-Windows-Forms-Application/
    }
}
