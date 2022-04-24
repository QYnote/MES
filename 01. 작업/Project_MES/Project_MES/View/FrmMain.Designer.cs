
namespace Project_MES.View
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("자재관리");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("거래처관리");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("공정관리");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("기초정보관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("수주관리");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("출하관리");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("영업관리", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("생산계획");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("작업지시");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("생산관리", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("현장_First");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("현장0");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("현장Last");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("현장시스템", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.PnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Tree_Menu = new System.Windows.Forms.TreeView();
            this.PnlContents = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.ColumnCount = 1;
            this.PnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.PnlMenu.Controls.Add(this.button1, 0, 0);
            this.PnlMenu.Controls.Add(this.Tree_Menu, 0, 1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.RowCount = 2;
            this.PnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMenu.Size = new System.Drawing.Size(250, 546);
            this.PnlMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tree_Menu
            // 
            this.Tree_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree_Menu.ItemHeight = 20;
            this.Tree_Menu.Location = new System.Drawing.Point(0, 50);
            this.Tree_Menu.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Tree_Menu.Name = "Tree_Menu";
            treeNode1.Name = "Node_InfoMaterial";
            treeNode1.Text = "자재관리";
            treeNode2.Name = "Node_InfoCustomer";
            treeNode2.Text = "거래처관리";
            treeNode3.Name = "Node_InfoProcess";
            treeNode3.Text = "공정관리";
            treeNode4.Name = "Node_Basic";
            treeNode4.Text = "기초정보관리";
            treeNode5.Name = "Node_SalesOrder";
            treeNode5.Text = "수주관리";
            treeNode6.Name = "Node_SalesOut";
            treeNode6.Text = "출하관리";
            treeNode7.Name = "Node_Sales";
            treeNode7.Text = "영업관리";
            treeNode8.Name = "Node_Plan";
            treeNode8.Text = "생산계획";
            treeNode9.Name = "Node_WorkOrder";
            treeNode9.Text = "작업지시";
            treeNode10.Name = "Node_Product";
            treeNode10.Text = "생산관리";
            treeNode11.Name = "Node_Product0";
            treeNode11.Text = "현장_First";
            treeNode12.Name = "Node_Product1";
            treeNode12.Text = "현장0";
            treeNode13.Name = "Node_Product2";
            treeNode13.Text = "현장Last";
            treeNode14.Name = "Node_POP";
            treeNode14.Text = "현장시스템";
            this.Tree_Menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode14});
            this.Tree_Menu.Size = new System.Drawing.Size(247, 496);
            this.Tree_Menu.TabIndex = 2;
            this.Tree_Menu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_Menu_NodeMouseDoubleClick);
            // 
            // PnlContents
            // 
            this.PnlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContents.Location = new System.Drawing.Point(250, 0);
            this.PnlContents.Name = "PnlContents";
            this.PnlContents.Size = new System.Drawing.Size(802, 546);
            this.PnlContents.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 546);
            this.Controls.Add(this.PnlContents);
            this.Controls.Add(this.PnlMenu);
            this.Name = "FrmMain";
            this.Text = "메인화면";
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView Tree_Menu;
        private System.Windows.Forms.Panel PnlContents;
    }
}

