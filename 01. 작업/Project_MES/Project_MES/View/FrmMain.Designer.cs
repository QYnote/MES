
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("종합코드관리");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("거래처관리");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("자재관리");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("공정관리");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("기초정보관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("수주관리");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("출하관리");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("영업관리", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("생산계획");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("작업지시");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("생산관리", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("실적등록");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("현장시스템", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.PnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Tree_Menu = new System.Windows.Forms.TreeView();
            this.PnlContents = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_StatusMain = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.PnlMenu.Size = new System.Drawing.Size(250, 656);
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
            treeNode1.Name = "Node_InfoCategoryItem";
            treeNode1.Text = "종합코드관리";
            treeNode2.Name = "Node_InfoCustomer";
            treeNode2.Text = "거래처관리";
            treeNode3.Name = "Node_InfoMaterial";
            treeNode3.Text = "자재관리";
            treeNode4.Name = "Node_InfoProcess";
            treeNode4.Text = "공정관리";
            treeNode5.Name = "Node_Basic";
            treeNode5.Text = "기초정보관리";
            treeNode6.Name = "Node_SalesOrder";
            treeNode6.Text = "수주관리";
            treeNode7.Name = "Node_SalesOut";
            treeNode7.Text = "출하관리";
            treeNode8.Name = "Node_Sales";
            treeNode8.Text = "영업관리";
            treeNode9.Name = "Node_WorkPlan";
            treeNode9.Text = "생산계획";
            treeNode10.Name = "Node_WorkOrder";
            treeNode10.Text = "작업지시";
            treeNode11.Name = "Node_Product";
            treeNode11.Text = "생산관리";
            treeNode12.Name = "Node_Product";
            treeNode12.Text = "실적등록";
            treeNode13.Name = "Node_POP";
            treeNode13.Text = "현장시스템";
            this.Tree_Menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode11,
            treeNode13});
            this.Tree_Menu.Size = new System.Drawing.Size(247, 606);
            this.Tree_Menu.TabIndex = 2;
            this.Tree_Menu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_Menu_NodeMouseDoubleClick);
            // 
            // PnlContents
            // 
            this.PnlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContents.Location = new System.Drawing.Point(250, 0);
            this.PnlContents.Name = "PnlContents";
            this.PnlContents.Size = new System.Drawing.Size(1014, 656);
            this.PnlContents.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_StatusMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 25);
            this.panel1.TabIndex = 2;
            // 
            // Lbl_StatusMain
            // 
            this.Lbl_StatusMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_StatusMain.Location = new System.Drawing.Point(0, 0);
            this.Lbl_StatusMain.Name = "Lbl_StatusMain";
            this.Lbl_StatusMain.Size = new System.Drawing.Size(942, 25);
            this.Lbl_StatusMain.TabIndex = 0;
            this.Lbl_StatusMain.Text = "상태바";
            this.Lbl_StatusMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PnlContents);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "메인화면";
            this.PnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView Tree_Menu;
        private System.Windows.Forms.Panel PnlContents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_StatusMain;
    }
}

