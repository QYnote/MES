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

            GvSet();
            InitCbo();
        }

        private void GvSet()
        {
            //DataGridView 셋팅
            GvProcess.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_ProcessCode.DataPropertyName = "ProcessCode";
            Col_ProcessName.DataPropertyName = "ProcessName";
            Col_ProcessType.DataPropertyName = "ProcessType";
            Col_ProcessRemark.DataPropertyName = "Remark";
        }

        private void InitCbo()
        {
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = "CG0003";
            cateItem.Code_FieldName = "공정코드";
            cateItem.Value_FieldName = "공정타입";

            Col_ProcessType.DataSource = cateItem.Select_Cbo();
            Col_ProcessType.ValueMember = "공정코드";
            Col_ProcessType.DisplayMember = "공정타입";
        }

        #endregion UI 디자인 Setting

        private void Frm_Info_Process_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        #region 조회

        private void DisplayData()
        {
            Info_Process proc = new Info_Process();

            GvProcess.DataSource = proc.Select_Frm_Info_Process();
        }


        private void GvProcess_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GvProcess.Rows[e.RowIndex].DataBoundItem == null) return;

            DataRow dr = (GvProcess.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;   //선택된Row 거래처 코드
        }

        #endregion 조회 End

        #region Insert/Update

        private Dictionary<int, DataRow> dicProcess = new Dictionary<int, DataRow>();

        private void GvProcess_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //값 변경시 데이터 저장
            CreateDictionary(e.RowIndex);
        }

        private void CreateDictionary(int rowIdx)
        {   //값 변경시 데이터 저장
            DataRow dr = (GvProcess.Rows[rowIdx].DataBoundItem as DataRowView).Row;

            //변경된 내용 딕셔너리에 저장
            if (dicProcess.ContainsKey(rowIdx))
            {
                //같은 행 수정시 기존Dic 삭제
                dicProcess.Remove(rowIdx);
            }

            dicProcess.Add(rowIdx, dr);
        }

        private void Btn_Save_Process_Click(object sender, EventArgs e)
        {
            SaveProcess();
        }

        private void SaveProcess()
        {
            if (dicProcess.Count < 0) return;

            //변경되 내용 일괄 DB 전송
            Info_Process proc = new Info_Process();

            foreach (DataRow dr in dicProcess.Values)
            {
                proc.ProcessCode = dr["ProcessCode"].ToString();    //공정코드
                proc.ProcessType = dr["ProcessType"].ToString();    //공정타입
                proc.ProcessName = dr["ProcessName"].ToString();    //공정명
                proc.Remark = dr["Remark"].ToString();              //비고

                proc.InsertUpdate_Frm_Info_Process();
            }

            dicProcess.Clear();    //Dictionary 초기화
            DisplayData();
        }

        #endregion Insert/Update End

        #region Delete

        private void Btn_Delete_Process_Click(object sender, EventArgs e)
        {
            if (GvProcess.SelectedCells.Count < 0) return;

            //Process 코드가 비어있는 신규row는 삭제
            int rowidx = GvProcess.SelectedCells[0].RowIndex;
            DataRow selectedRow = (GvProcess.Rows[rowidx].DataBoundItem as DataRowView).Row;

            if (selectedRow["ProcessCode"].ToString() == "")
            {
                dicProcess.Remove(rowidx);  //Dictionary 삭제
                return;
            }

            DeleteItem(selectedRow);

            GvProcess.Rows.Remove(GvProcess.Rows[rowidx]);      //해당Row 삭제
        }

        private void DeleteItem(DataRow row)
        {
            Info_Process proc = new Info_Process();
            proc.ProcessCode = row["ProcessCode"].ToString(); //그룹코드

            proc.Delete_Frm_Info_Process();
        }

        #endregion Delete End
    }
}
