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
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.gvPlanMaster = new System.Windows.Forms.DataGridView();
            this.Col_CateCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Contents1 = new System.Windows.Forms.Panel();
            this.Btn_Save_Item = new System.Windows.Forms.Button();
            this.Btn_Delete_Item = new System.Windows.Forms.Button();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save_Group = new System.Windows.Forms.Button();
            this.Btn_Delete_Group = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_Contents0_Base = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_LblTxt1 = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.TableLayoutMain.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).BeginInit();
            this.Pnl_Contents1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Contents0_Base.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.TableLayoutMain.Controls.Add(this.gvPlanMaster, 1, 2);
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
            // gvPlanMaster
            // 
            this.gvPlanMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlanMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CateCode,
            this.Col_CateValue,
            this.Col_Remark});
            this.gvPlanMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPlanMaster.Location = new System.Drawing.Point(335, 97);
            this.gvPlanMaster.Name = "gvPlanMaster";
            this.gvPlanMaster.RowTemplate.Height = 23;
            this.gvPlanMaster.Size = new System.Drawing.Size(660, 542);
            this.gvPlanMaster.TabIndex = 5;
            // 
            // Col_CateCode
            // 
            this.Col_CateCode.HeaderText = "카테고리 코드";
            this.Col_CateCode.Name = "Col_CateCode";
            this.Col_CateCode.ReadOnly = true;
            // 
            // Col_CateValue
            // 
            this.Col_CateValue.HeaderText = "카테고리 값";
            this.Col_CateValue.Name = "Col_CateValue";
            // 
            // Col_Remark
            // 
            this.Col_Remark.HeaderText = "비고";
            this.Col_Remark.Name = "Col_Remark";
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
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(326, 513);
            this.treeView1.TabIndex = 7;
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
            // Pnl_Contents0_Base
            // 
            this.Pnl_Contents0_Base.Controls.Add(this.treeView1);
            this.Pnl_Contents0_Base.Controls.Add(this.panel2);
            this.Pnl_Contents0_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents0_Base.Location = new System.Drawing.Point(3, 97);
            this.Pnl_Contents0_Base.Name = "Pnl_Contents0_Base";
            this.Pnl_Contents0_Base.Size = new System.Drawing.Size(326, 542);
            this.Pnl_Contents0_Base.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_LblTxt1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 29);
            this.panel2.TabIndex = 8;
            // 
            // uc_LblTxt1
            // 
            this.uc_LblTxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt1.DisplayText = "Default Text";
            this.uc_LblTxt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_LblTxt1.LblText = "추가이름";
            this.uc_LblTxt1.LblWidth = 100;
            this.uc_LblTxt1.Location = new System.Drawing.Point(0, 0);
            this.uc_LblTxt1.Name = "uc_LblTxt1";
            this.uc_LblTxt1.Size = new System.Drawing.Size(326, 29);
            this.uc_LblTxt1.TabIndex = 0;
            this.uc_LblTxt1.TxtWdith = 218;
            // 
            // Frm_Info_CategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Info_CategoryItem";
            this.Text = "종합코드 관리";
            this.TableLayoutMain.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).EndInit();
            this.Pnl_Contents1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Pnl_Contents0_Base.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.DataGridView gvPlanMaster;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CateCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CateValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Button Btn_Save_Item;
        private System.Windows.Forms.Button Btn_Delete_Item;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Save_Group;
        private System.Windows.Forms.Button Btn_Delete_Group;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_Contents0_Base;
        private System.Windows.Forms.Panel panel2;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt1;
    }
}