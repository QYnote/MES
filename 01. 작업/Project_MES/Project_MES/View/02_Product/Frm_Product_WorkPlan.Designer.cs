
namespace Project_MES.View._02_Product
{
    partial class Frm_Product_WorkPlan
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
            this.gvPlanMaster = new System.Windows.Forms.DataGridView();
            this.Col_Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductCode_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Unit_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_SearchMain = new System.Windows.Forms.Panel();
            this.Pnl_Search1 = new System.Windows.Forms.Panel();
            this.Pnl_Search0 = new System.Windows.Forms.Panel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.gvOrderDetail = new System.Windows.Forms.DataGridView();
            this.Col_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductCode_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RemainPlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TotalPlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_UnitNmae_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uc_LblTxt_ProductAlias = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_ProductName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.TableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).BeginInit();
            this.Pnl_SearchMain.SuspendLayout();
            this.Pnl_Search1.SuspendLayout();
            this.Pnl_Search0.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 1;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Controls.Add(this.gvPlanMaster, 0, 5);
            this.TableLayoutMain.Controls.Add(this.Pnl_SearchMain, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Lbl_Contents0, 0, 2);
            this.TableLayoutMain.Controls.Add(this.Lbl_Contents1, 0, 4);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.gvOrderDetail, 0, 3);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 6;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutMain.Size = new System.Drawing.Size(998, 642);
            this.TableLayoutMain.TabIndex = 2;
            // 
            // gvPlanMaster
            // 
            this.gvPlanMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlanMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Seq,
            this.Col_ProductCode_MP,
            this.Col_ProductName_MP,
            this.Col_ProductAlias_MP,
            this.Col_ProductSpec,
            this.Col_PlanQty,
            this.Col_Unit_MP,
            this.Col_Remark_MP});
            this.gvPlanMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPlanMaster.Location = new System.Drawing.Point(3, 425);
            this.gvPlanMaster.Name = "gvPlanMaster";
            this.gvPlanMaster.RowTemplate.Height = 23;
            this.gvPlanMaster.Size = new System.Drawing.Size(992, 214);
            this.gvPlanMaster.TabIndex = 5;
            // 
            // Col_Seq
            // 
            this.Col_Seq.HeaderText = "순번";
            this.Col_Seq.Name = "Col_Seq";
            this.Col_Seq.ReadOnly = true;
            // 
            // Col_ProductCode_MP
            // 
            this.Col_ProductCode_MP.HeaderText = "제품코드";
            this.Col_ProductCode_MP.Name = "Col_ProductCode_MP";
            this.Col_ProductCode_MP.ReadOnly = true;
            // 
            // Col_ProductName_MP
            // 
            this.Col_ProductName_MP.HeaderText = "제품명";
            this.Col_ProductName_MP.Name = "Col_ProductName_MP";
            this.Col_ProductName_MP.ReadOnly = true;
            // 
            // Col_ProductAlias_MP
            // 
            this.Col_ProductAlias_MP.HeaderText = "제품번호";
            this.Col_ProductAlias_MP.Name = "Col_ProductAlias_MP";
            this.Col_ProductAlias_MP.ReadOnly = true;
            // 
            // Col_ProductSpec
            // 
            this.Col_ProductSpec.HeaderText = "Spec";
            this.Col_ProductSpec.Name = "Col_ProductSpec";
            this.Col_ProductSpec.ReadOnly = true;
            // 
            // Col_PlanQty
            // 
            this.Col_PlanQty.HeaderText = "계획수량";
            this.Col_PlanQty.Name = "Col_PlanQty";
            this.Col_PlanQty.ReadOnly = true;
            // 
            // Col_Unit_MP
            // 
            this.Col_Unit_MP.HeaderText = "단위";
            this.Col_Unit_MP.Name = "Col_Unit_MP";
            this.Col_Unit_MP.ReadOnly = true;
            // 
            // Col_Remark_MP
            // 
            this.Col_Remark_MP.HeaderText = "비고";
            this.Col_Remark_MP.Name = "Col_Remark_MP";
            this.Col_Remark_MP.ReadOnly = true;
            // 
            // Pnl_SearchMain
            // 
            this.Pnl_SearchMain.Controls.Add(this.Pnl_Search1);
            this.Pnl_SearchMain.Controls.Add(this.Pnl_Search0);
            this.Pnl_SearchMain.Controls.Add(this.Btn_Search);
            this.Pnl_SearchMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_SearchMain.Location = new System.Drawing.Point(0, 50);
            this.Pnl_SearchMain.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_SearchMain.Name = "Pnl_SearchMain";
            this.Pnl_SearchMain.Size = new System.Drawing.Size(998, 58);
            this.Pnl_SearchMain.TabIndex = 3;
            // 
            // Pnl_Search1
            // 
            this.Pnl_Search1.Controls.Add(this.uc_LblTxt_ProductAlias);
            this.Pnl_Search1.Controls.Add(this.uc_LblTxt_ProductName);
            this.Pnl_Search1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Search1.Location = new System.Drawing.Point(0, 29);
            this.Pnl_Search1.Name = "Pnl_Search1";
            this.Pnl_Search1.Size = new System.Drawing.Size(923, 29);
            this.Pnl_Search1.TabIndex = 10;
            // 
            // Pnl_Search0
            // 
            this.Pnl_Search0.Controls.Add(this.uc_LblTxt_CustName);
            this.Pnl_Search0.Controls.Add(this.uc_LblDtp_OrderDate);
            this.Pnl_Search0.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Search0.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Search0.Name = "Pnl_Search0";
            this.Pnl_Search0.Size = new System.Drawing.Size(923, 29);
            this.Pnl_Search0.TabIndex = 4;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Search.Location = new System.Drawing.Point(923, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 58);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Btn_Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.AutoSize = true;
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(3, 108);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(992, 44);
            this.Lbl_Contents0.TabIndex = 0;
            this.Lbl_Contents0.Text = "Lbl_OrderDetail";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.AutoSize = true;
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(3, 372);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(992, 50);
            this.Lbl_Contents1.TabIndex = 1;
            this.Lbl_Contents1.Text = "Lbl_PlanMaster";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl_MailTitle
            // 
            this.Pnl_MailTitle.Controls.Add(this.Lbl_MailTitle);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Create);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Update);
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
            this.Lbl_MailTitle.Size = new System.Drawing.Size(848, 50);
            this.Lbl_MailTitle.TabIndex = 0;
            this.Lbl_MailTitle.Text = "Lbl_MainTitle";
            this.Lbl_MailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Create.Location = new System.Drawing.Point(848, 0);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 50);
            this.Btn_Create.TabIndex = 3;
            this.Btn_Create.Text = "Btn_Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Update.Location = new System.Drawing.Point(923, 0);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 50);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Btn_Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_OrderNo,
            this.Col_OrderSeq,
            this.Col_CustName,
            this.Col_ProductCode_SO,
            this.Col_ProductName_SO,
            this.Col_ProductAlias_SO,
            this.Col_OrderQty,
            this.Col_RemainPlanQty,
            this.Col_TotalPlanQty,
            this.Col_UnitNmae_Sales,
            this.Col_OrderDate,
            this.Col_OrderEndDate,
            this.Col_Remark_SO});
            this.gvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrderDetail.Location = new System.Drawing.Point(3, 155);
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.RowTemplate.Height = 23;
            this.gvOrderDetail.Size = new System.Drawing.Size(992, 214);
            this.gvOrderDetail.TabIndex = 4;
            // 
            // Col_OrderNo
            // 
            this.Col_OrderNo.HeaderText = "수주번호";
            this.Col_OrderNo.Name = "Col_OrderNo";
            this.Col_OrderNo.ReadOnly = true;
            // 
            // Col_OrderSeq
            // 
            this.Col_OrderSeq.HeaderText = "순번";
            this.Col_OrderSeq.Name = "Col_OrderSeq";
            this.Col_OrderSeq.ReadOnly = true;
            // 
            // Col_CustName
            // 
            this.Col_CustName.HeaderText = "수주처";
            this.Col_CustName.Name = "Col_CustName";
            this.Col_CustName.ReadOnly = true;
            // 
            // Col_ProductCode_SO
            // 
            this.Col_ProductCode_SO.HeaderText = "제품코드";
            this.Col_ProductCode_SO.Name = "Col_ProductCode_SO";
            this.Col_ProductCode_SO.ReadOnly = true;
            // 
            // Col_ProductName_SO
            // 
            this.Col_ProductName_SO.HeaderText = "제품명";
            this.Col_ProductName_SO.Name = "Col_ProductName_SO";
            this.Col_ProductName_SO.ReadOnly = true;
            // 
            // Col_ProductAlias_SO
            // 
            this.Col_ProductAlias_SO.HeaderText = "제품번";
            this.Col_ProductAlias_SO.Name = "Col_ProductAlias_SO";
            this.Col_ProductAlias_SO.ReadOnly = true;
            // 
            // Col_OrderQty
            // 
            this.Col_OrderQty.HeaderText = "수주수량";
            this.Col_OrderQty.Name = "Col_OrderQty";
            this.Col_OrderQty.ReadOnly = true;
            // 
            // Col_RemainPlanQty
            // 
            this.Col_RemainPlanQty.HeaderText = "미계획 수량";
            this.Col_RemainPlanQty.Name = "Col_RemainPlanQty";
            this.Col_RemainPlanQty.ReadOnly = true;
            // 
            // Col_TotalPlanQty
            // 
            this.Col_TotalPlanQty.HeaderText = "계획수량";
            this.Col_TotalPlanQty.Name = "Col_TotalPlanQty";
            this.Col_TotalPlanQty.ReadOnly = true;
            // 
            // Col_UnitNmae_Sales
            // 
            this.Col_UnitNmae_Sales.HeaderText = "단위";
            this.Col_UnitNmae_Sales.Name = "Col_UnitNmae_Sales";
            this.Col_UnitNmae_Sales.ReadOnly = true;
            // 
            // Col_OrderDate
            // 
            this.Col_OrderDate.HeaderText = "수주일자";
            this.Col_OrderDate.Name = "Col_OrderDate";
            this.Col_OrderDate.ReadOnly = true;
            // 
            // Col_OrderEndDate
            // 
            this.Col_OrderEndDate.HeaderText = "마감임자";
            this.Col_OrderEndDate.Name = "Col_OrderEndDate";
            this.Col_OrderEndDate.ReadOnly = true;
            // 
            // Col_Remark_SO
            // 
            this.Col_Remark_SO.HeaderText = "비고";
            this.Col_Remark_SO.Name = "Col_Remark_SO";
            this.Col_Remark_SO.ReadOnly = true;
            // 
            // uc_LblTxt_ProductAlias
            // 
            this.uc_LblTxt_ProductAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_ProductAlias.DisplayText = "Default Text";
            this.uc_LblTxt_ProductAlias.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_ProductAlias.LblText = "제품번";
            this.uc_LblTxt_ProductAlias.LblWidth = 100;
            this.uc_LblTxt_ProductAlias.Location = new System.Drawing.Point(264, 0);
            this.uc_LblTxt_ProductAlias.Name = "uc_LblTxt_ProductAlias";
            this.uc_LblTxt_ProductAlias.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_ProductAlias.TabIndex = 11;
            this.uc_LblTxt_ProductAlias.TxtWdith = 150;
            // 
            // uc_LblTxt_ProductName
            // 
            this.uc_LblTxt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_ProductName.DisplayText = "Default Text";
            this.uc_LblTxt_ProductName.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_ProductName.LblText = "제품명";
            this.uc_LblTxt_ProductName.LblWidth = 100;
            this.uc_LblTxt_ProductName.Location = new System.Drawing.Point(0, 0);
            this.uc_LblTxt_ProductName.Name = "uc_LblTxt_ProductName";
            this.uc_LblTxt_ProductName.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_ProductName.TabIndex = 10;
            this.uc_LblTxt_ProductName.TxtWdith = 150;
            // 
            // uc_LblTxt_CustName
            // 
            this.uc_LblTxt_CustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_CustName.DisplayText = "Default Text";
            this.uc_LblTxt_CustName.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_CustName.LblText = "수주처명";
            this.uc_LblTxt_CustName.LblWidth = 100;
            this.uc_LblTxt_CustName.Location = new System.Drawing.Point(338, 0);
            this.uc_LblTxt_CustName.Name = "uc_LblTxt_CustName";
            this.uc_LblTxt_CustName.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_CustName.TabIndex = 9;
            this.uc_LblTxt_CustName.TxtWdith = 150;
            // 
            // uc_LblDtp_OrderDate
            // 
            this.uc_LblDtp_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblDtp_OrderDate.DisplayFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uc_LblDtp_OrderDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblDtp_OrderDate.DtpDefaultDate = new System.DateTime(2022, 5, 1, 21, 0, 43, 183);
            this.uc_LblDtp_OrderDate.DtpRange = true;
            this.uc_LblDtp_OrderDate.LblText = "수주일자";
            this.uc_LblDtp_OrderDate.LblWidth = 100;
            this.uc_LblDtp_OrderDate.Location = new System.Drawing.Point(0, 0);
            this.uc_LblDtp_OrderDate.Name = "uc_LblDtp_OrderDate";
            this.uc_LblDtp_OrderDate.Size = new System.Drawing.Size(338, 29);
            this.uc_LblDtp_OrderDate.TabIndex = 8;
            // 
            // Frm_Product_WorkPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Product_WorkPlan";
            this.Text = "생산계획";
            this.TableLayoutMain.ResumeLayout(false);
            this.TableLayoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).EndInit();
            this.Pnl_SearchMain.ResumeLayout(false);
            this.Pnl_Search1.ResumeLayout(false);
            this.Pnl_Search0.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.DataGridView gvPlanMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode_MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName_MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias_MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Unit_MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_MP;
        private System.Windows.Forms.Panel Pnl_SearchMain;
        private System.Windows.Forms.Panel Pnl_Search1;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductAlias;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductName;
        private System.Windows.Forms.Panel Pnl_Search0;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustName;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_OrderDate;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.DataGridView gvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RemainPlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TotalPlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_UnitNmae_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_SO;
    }
}