namespace Project_MES.View._00_Basic
{
    partial class Frm_Info_CategoryItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_Contents0_Base = new System.Windows.Forms.Panel();
            this.Tree_CateGroup = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_GroupName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save_Group = new System.Windows.Forms.Button();
            this.Btn_Delete_Group = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.gv_CateItem = new System.Windows.Forms.DataGridView();
            this.Pnl_Contents1 = new System.Windows.Forms.Panel();
            this.Btn_Save_Item = new System.Windows.Forms.Button();
            this.Btn_Delete_Item = new System.Windows.Forms.Button();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.TableLayoutMain.SuspendLayout();
            this.Pnl_Contents0_Base.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CateItem)).BeginInit();
            this.Pnl_Contents1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 2;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.TableLayoutMain.Controls.Add(this.Pnl_Contents0_Base, 0, 2);
            this.TableLayoutMain.Controls.Add(this.panel1, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.gv_CateItem, 1, 2);
            this.TableLayoutMain.Controls.Add(this.Pnl_Contents1, 1, 1);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 3;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutMain.Size = new System.Drawing.Size(998, 642);
            this.TableLayoutMain.TabIndex = 3;
            // 
            // Pnl_Contents0_Base
            // 
            this.Pnl_Contents0_Base.Controls.Add(this.Tree_CateGroup);
            this.Pnl_Contents0_Base.Controls.Add(this.panel2);
            this.Pnl_Contents0_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents0_Base.Location = new System.Drawing.Point(3, 97);
            this.Pnl_Contents0_Base.Name = "Pnl_Contents0_Base";
            this.Pnl_Contents0_Base.Size = new System.Drawing.Size(326, 542);
            this.Pnl_Contents0_Base.TabIndex = 4;
            // 
            // Tree_CateGroup
            // 
            this.Tree_CateGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree_CateGroup.Location = new System.Drawing.Point(0, 29);
            this.Tree_CateGroup.Name = "Tree_CateGroup";
            this.Tree_CateGroup.Size = new System.Drawing.Size(326, 513);
            this.Tree_CateGroup.TabIndex = 7;
            this.Tree_CateGroup.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_CateGroup_NodeMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_LblTxt_GroupName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 29);
            this.panel2.TabIndex = 8;
            // 
            // uc_LblTxt_GroupName
            // 
            this.uc_LblTxt_GroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_GroupName.DisplayText = "Default Text";
            this.uc_LblTxt_GroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_LblTxt_GroupName.LblText = "추가이름";
            this.uc_LblTxt_GroupName.LblWidth = 100;
            this.uc_LblTxt_GroupName.Location = new System.Drawing.Point(0, 0);
            this.uc_LblTxt_GroupName.Name = "uc_LblTxt_GroupName";
            this.uc_LblTxt_GroupName.Size = new System.Drawing.Size(326, 29);
            this.uc_LblTxt_GroupName.TabIndex = 0;
            this.uc_LblTxt_GroupName.TxtWdith = 218;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Save_Group);
            this.panel1.Controls.Add(this.Btn_Delete_Group);
            this.panel1.Controls.Add(this.Lbl_Contents0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 44);
            this.panel1.TabIndex = 7;
            // 
            // Btn_Save_Group
            // 
            this.Btn_Save_Group.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save_Group.Location = new System.Drawing.Point(182, 0);
            this.Btn_Save_Group.Name = "Btn_Save_Group";
            this.Btn_Save_Group.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save_Group.TabIndex = 3;
            this.Btn_Save_Group.Text = "Btn_Save_Group";
            this.Btn_Save_Group.UseVisualStyleBackColor = true;
            this.Btn_Save_Group.Click += new System.EventHandler(this.Btn_Save_Group_Click);
            // 
            // Btn_Delete_Group
            // 
            this.Btn_Delete_Group.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete_Group.Location = new System.Drawing.Point(257, 0);
            this.Btn_Delete_Group.Name = "Btn_Delete_Group";
            this.Btn_Delete_Group.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete_Group.TabIndex = 2;
            this.Btn_Delete_Group.Text = "Btn_Delete_Group";
            this.Btn_Delete_Group.UseVisualStyleBackColor = true;
            this.Btn_Delete_Group.Click += new System.EventHandler(this.Btn_Delete_Group_Click);
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(332, 44);
            this.Lbl_Contents0.TabIndex = 1;
            this.Lbl_Contents0.Text = "Lbl_CateGroup";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl_MailTitle
            // 
            this.TableLayoutMain.SetColumnSpan(this.Pnl_MailTitle, 2);
            this.Pnl_MailTitle.Controls.Add(this.Lbl_MailTitle);
            this.Pnl_MailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_MailTitle.Location = new System.Drawing.Point(0, 0);
            this.Pnl_MailTitle.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_MailTitle.Name = "Pnl_MailTitle";
            this.Pnl_MailTitle.Size = new System.Drawing.Size(998, 50);
            this.Pnl_MailTitle.TabIndex = 2;
            // 
            // Lbl_MailTitle
            // 
            this.Lbl_MailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_MailTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_MailTitle.Location = new System.Drawing.Point(0, 0);
            this.Lbl_MailTitle.Name = "Lbl_MailTitle";
            this.Lbl_MailTitle.Size = new System.Drawing.Size(998, 50);
            this.Lbl_MailTitle.TabIndex = 0;
            this.Lbl_MailTitle.Text = "Lbl_MainTitle";
            this.Lbl_MailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gv_CateItem
            // 
            this.gv_CateItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CateItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_CateItem.Location = new System.Drawing.Point(335, 97);
            this.gv_CateItem.Name = "gv_CateItem";
            this.gv_CateItem.RowTemplate.Height = 23;
            this.gv_CateItem.Size = new System.Drawing.Size(660, 542);
            this.gv_CateItem.TabIndex = 5;
            this.gv_CateItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CateItem_CellValueChanged);
            // 
            // Pnl_Contents1
            // 
            this.Pnl_Contents1.Controls.Add(this.Btn_Save_Item);
            this.Pnl_Contents1.Controls.Add(this.Btn_Delete_Item);
            this.Pnl_Contents1.Controls.Add(this.Lbl_Contents1);
            this.Pnl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents1.Location = new System.Drawing.Point(332, 50);
            this.Pnl_Contents1.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_Contents1.Name = "Pnl_Contents1";
            this.Pnl_Contents1.Size = new System.Drawing.Size(666, 44);
            this.Pnl_Contents1.TabIndex = 6;
            // 
            // Btn_Save_Item
            // 
            this.Btn_Save_Item.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save_Item.Location = new System.Drawing.Point(516, 0);
            this.Btn_Save_Item.Name = "Btn_Save_Item";
            this.Btn_Save_Item.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save_Item.TabIndex = 3;
            this.Btn_Save_Item.Text = "Btn_Save_Item";
            this.Btn_Save_Item.UseVisualStyleBackColor = true;
            this.Btn_Save_Item.Click += new System.EventHandler(this.Btn_Save_Item_Click);
            // 
            // Btn_Delete_Item
            // 
            this.Btn_Delete_Item.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete_Item.Location = new System.Drawing.Point(591, 0);
            this.Btn_Delete_Item.Name = "Btn_Delete_Item";
            this.Btn_Delete_Item.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete_Item.TabIndex = 2;
            this.Btn_Delete_Item.Text = "Btn_Delete_Item";
            this.Btn_Delete_Item.UseVisualStyleBackColor = true;
            this.Btn_Delete_Item.Click += new System.EventHandler(this.Btn_Delete_Item_Click);
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(666, 44);
            this.Lbl_Contents1.TabIndex = 1;
            this.Lbl_Contents1.Text = "Lbl_CateItem";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Info_CategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Info_CategoryItem";
            this.Text = "종합코드 관리";
            this.Load += new System.EventHandler(this.Frm_Info_CategoryItem_Load);
            this.TableLayoutMain.ResumeLayout(false);
            this.Pnl_Contents0_Base.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CateItem)).EndInit();
            this.Pnl_Contents1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.DataGridView gv_CateItem;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Button Btn_Save_Item;
        private System.Windows.Forms.Button Btn_Delete_Item;
        private System.Windows.Forms.TreeView Tree_CateGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Save_Group;
        private System.Windows.Forms.Button Btn_Delete_Group;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_Contents0_Base;
        private System.Windows.Forms.Panel panel2;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_GroupName;
    }
}