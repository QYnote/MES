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
            Btn_Delete_Group.Text = "수정";

            Lbl_Contents1.Text = "카테고리 내용";
            Btn_Save_Item.Text = "저장";
            Btn_Delete_Item.Text = "수정";
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

        #region 카테고리 그룹 그리기

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

        #endregion 카테고리그룹 그리기 End

        #region 카테고리 그룹 기능

        private void Btn_Save_Group_Click(object sender, EventArgs e)
        {
            //선택된 노드 없을시 취소
            if (Tree_CateGroup.SelectedNode == null) return;
            if (Tree_CateGroup.SelectedNode.Level > 3) return;

            Info_CategoryGroup cateGroup = new Info_CategoryGroup();
            cateGroup.GroupName = uc_LblTxt_GroupName.TxtContents.Text;
            cateGroup.Level = Tree_CateGroup.SelectedNode.Level + 1;
            cateGroup.HighGroup = Tree_CateGroup.SelectedNode.Name;

            cateGroup.Insert_Frm_Info_CategoryItem();

            DisplayData();
        }

        #endregion 카테고리 그룹 기능 End


        private void Tree_CateGroup_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string groupCode = e.Node.Name;

            SetCateItem(gv_CateItem, groupCode);
        }

        private void SetCateItem(DataGridView gv, string groupCode)
        {
            Info_CategoryItem cateItem = new Info_CategoryItem();
            cateItem.GroupCode = groupCode;

            gv.DataSource = cateItem.Select_Frm_Info_CategoryItem();
        }

    }
}
