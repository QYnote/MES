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
            Btn_Delete_Group.Text = "삭제";

            Lbl_Contents1.Text = "카테고리 아이템";
            Btn_Save_Item.Text = "저장";
            Btn_Delete_Item.Text = "삭제";

            GvSet();
        }

        private void GvSet()
        {
            //DataGridView 셋팅
            gv_CateItem.AutoGenerateColumns = false; //DataSource Column생성 방지

            //Grid Field명 지정
            Col_ItemCode.DataPropertyName = "ItemCode";
            Col_ItemValue.DataPropertyName = "ItemValue";
            Col_Remark.DataPropertyName = "Remark";
        }

        #endregion UI 디자인 Setting

        private void Frm_Info_CategoryItem_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            SetTreeList(Tree_CateGroup);
        }

        #region 카테고리 그룹 기능

        //조회
        private void SetTreeList(TreeView tree)
        {
            Info_CategoryGroup cateGroup = new Info_CategoryGroup();
            DataTable dt = cateGroup.Select_Frm_Info_CategoryItem();

            //카테고리 그룹 존재 체크
            if (dt.Rows.Count > 0)
            {
                //초기화
                tree.Nodes.Clear();

                //최상위 항목 리스트만 나오도록 필터링
                DataRow[] rootRow = dt.Select("HighGroup = 'Root'");

                foreach (DataRow dr in rootRow)
                {
                    //최상위 노드 생성
                    TreeNode rootNode = new TreeNode();
                    rootNode.Name = dr["GroupCode"].ToString();
                    rootNode.Text = dr["GroupName"].ToString();

                    //하위항목 리스트만 나오도록 필터링
                    DataRow[] childRow = dt.Select($"HighGroup = '{dr["GroupCode"]}'");

                    //하위항목이 없으면 하위항목 생성 건너뛰기
                    if (childRow.Length > 0)
                    {
                        CreateChildNode(dt, childRow, rootNode);
                    }

                    //최상위노드 treeView에 추가
                    tree.Nodes.Add(rootNode);
                }

                tree.ExpandAll();
            }
        }

        private void CreateChildNode(DataTable dt, DataRow[] parentRow, TreeNode parentNode)
        {
            //상위항목 수만큼 진행
            foreach (DataRow dr in parentRow)
            {
                //하위노드 생성
                TreeNode childNode = new TreeNode();
                childNode.Name = dr["GroupCode"].ToString();
                childNode.Text = dr["GroupName"].ToString();

                //하위항목 있는지 검색
                DataRow[] childRow = dt.Select($"HighGroup = '{dr["GroupCode"]}'");

                //하위항목이 있으면 추가 하위항목 생성
                if (childRow.Length > 0)
                {
                    CreateChildNode(dt, childRow, childNode);
                }

                //상위노드에 생성한 하위노드 추가
                parentNode.Nodes.Add(childNode);
            }
        }

        //하위항목 신규 생성
        private void Btn_Save_Group_Click(object sender, EventArgs e)
        {
            //취소 조건
            if (Tree_CateGroup.SelectedNode == null) return;
            if (Tree_CateGroup.SelectedNode.Level >= 3)
            {
                MessageBox.Show("더이상 하위항목을 만들 수 없습니다.");
                return;
            }

            Info_CategoryGroup cateGroup = new Info_CategoryGroup();
            cateGroup.GroupName = uc_LblTxt_GroupName.TxtContents.Text; //그룹명
            cateGroup.Level = Tree_CateGroup.SelectedNode.Level + 1;    //레벨
            cateGroup.HighGroup = Tree_CateGroup.SelectedNode.Name;     //상위그룹

            cateGroup.Insert_Frm_Info_CategoryItem();

            DisplayData();
        }

        //선택항목 삭제
        private void Btn_Delete_Group_Click(object sender, EventArgs e)
        {
            //취소 조건
            if (Tree_CateGroup.SelectedNode == null) return;

            TreeNode parentNode = Tree_CateGroup.SelectedNode;

            Info_CategoryGroup cateGroup = new Info_CategoryGroup();
            cateGroup.GroupCode = parentNode.Name;

            //데이터, 아이템 삭제
            cateGroup.Delete_Frm_Info_CategoryItem();

            DisplayData();
        }

        #endregion 카테고리 그룹 기능 End

        #region 카테고리 아이템 기능
        private string SelectedGroupCode; //저장,삭제시 GroupCode 보관용

        /////////////////////   조회  ///////////////
        private void Tree_CateGroup_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(dicCateItem.Count > 0)
            {
                if (MessageBox.Show("수정내역이 있습니다.\n화면을 변경하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            //Item 입력
            string groupCode = e.Node.Name;

            SetCateItem(gv_CateItem, groupCode);

            //저장 or 삭제용
            dicCateItem.Clear();    //저장용 Dictionary 초기화
            SelectedGroupCode = groupCode;  //신규생성시 그룹코드 보관용
        }

        private void SetCateItem(DataGridView gv, string groupCode)
        {
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = groupCode;

            gv.DataSource = cateItem.Select_Frm_Info_CategoryItem();
        }

        ///////////////     데이터 수정, 신규 Row생성    /////////////////////
        private Dictionary<int, DataRow> dicCateItem = new Dictionary<int, DataRow>();

        private void gv_CateItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //값 변경시 데이터 저장
            CreateDictionary(e.RowIndex);
        }

        private void CreateDictionary(int rowIdx)
        {   //값 변경시 데이터 저장
            DataRow dr = (gv_CateItem.Rows[rowIdx].DataBoundItem as DataRowView).Row;

            //변경된 내용 딕셔너리에 저장
            if (dicCateItem.ContainsKey(rowIdx))
            {
                //같은 행 수정시 기존Dic 삭제
                dicCateItem.Remove(rowIdx);
            }

            dicCateItem.Add(rowIdx, dr);
        }

        private void Btn_Save_Item_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            if (dicCateItem.Count < 0) return;

            //변경되 내용 일괄 DB 전송
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = SelectedGroupCode; //그룹코드

            foreach (DataRow dr in dicCateItem.Values)
            {
                cateItem.ItemCode = dr["ItemCode"].ToString();
                cateItem.ItemValue = dr["ItemValue"].ToString();
                cateItem.Remark = dr["Remark"].ToString();

                cateItem.Insert_Frm_Info_CategoryItem();
            }

            dicCateItem.Clear();    //Dictionary 초기화
            SetCateItem(gv_CateItem, SelectedGroupCode);    //재조회
        }

        ///////////////////////////////     삭제      ////////////////////////
        private void Btn_Delete_Item_Click(object sender, EventArgs e)
        {
            if (gv_CateItem.SelectedCells.Count < 0) return;

            DataGridViewRow selectedRow = gv_CateItem.SelectedCells[0].OwningRow;

            dicCateItem.Remove(selectedRow.Index);  //Dictionay 삭제

            if(selectedRow.Cells[Col_ItemCode.Name].Value != null)
            {
                //코드값이 입력된 행이면 데이터 삭제
                DeleteItem(selectedRow);
            }

            gv_CateItem.Rows.Remove(selectedRow);      //해당Row 삭제
        }
        

        private void DeleteItem(DataGridViewRow row)
        {
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = SelectedGroupCode; //그룹코드
            cateItem.ItemCode = row.Cells[Col_ItemCode.Name].Value.ToString();

            cateItem.Delete_Frm_Info_CategoryItem();
        }

        #endregion 카테고리 아이템 기능 End

    }
}
