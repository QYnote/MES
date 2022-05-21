﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_SearchMain = new System.Windows.Forms.Panel();
            this.Pnl_Search1 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_ProductAlias = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_ProductName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_Search0 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.gvPlaceOrderDetail = new System.Windows.Forms.DataGridView();
            this.gvWorkPlan = new System.Windows.Forms.DataGridView();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.uc_LblTxt_PlanQty = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_RemainQty = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_OrderQty = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Col_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductCode_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_UnitNmae_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Unit_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_WorkStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutMain.SuspendLayout();
            this.Pnl_SearchMain.SuspendLayout();
            this.Pnl_Search1.SuspendLayout();
            this.Pnl_Search0.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlaceOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkPlan)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 2;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Controls.Add(this.Pnl_SearchMain, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Lbl_Contents0, 0, 2);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.gvPlaceOrderDetail, 0, 3);
            this.TableLayoutMain.Controls.Add(this.gvWorkPlan, 1, 5);
            this.TableLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.TableLayoutMain.Controls.Add(this.panel1, 0, 4);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 6;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutMain.Size = new System.Drawing.Size(998, 642);
            this.TableLayoutMain.TabIndex = 2;
            // 
            // Pnl_SearchMain
            // 
            this.TableLayoutMain.SetColumnSpan(this.Pnl_SearchMain, 2);
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
            this.TableLayoutMain.SetColumnSpan(this.Lbl_Contents0, 2);
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(3, 108);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(992, 44);
            this.Lbl_Contents0.TabIndex = 0;
            this.Lbl_Contents0.Text = "Lbl_OrderDetail";
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
            // gvPlaceOrderDetail
            // 
            this.gvPlaceOrderDetail.AllowUserToAddRows = false;
            this.gvPlaceOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlaceOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_OrderNo,
            this.Col_OrderSeq,
            this.Col_CustName,
            this.Col_ProductCode_SO,
            this.Col_ProductName_SO,
            this.Col_ProductAlias_SO,
            this.Col_UnitNmae_Sales,
            this.Col_OrderDate,
            this.Col_OrderEndDate,
            this.Col_Remark_SO,
            this.Col_Status});
            this.TableLayoutMain.SetColumnSpan(this.gvPlaceOrderDetail, 2);
            this.gvPlaceOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPlaceOrderDetail.Location = new System.Drawing.Point(3, 155);
            this.gvPlaceOrderDetail.MultiSelect = false;
            this.gvPlaceOrderDetail.Name = "gvPlaceOrderDetail";
            this.gvPlaceOrderDetail.ReadOnly = true;
            this.gvPlaceOrderDetail.RowTemplate.Height = 23;
            this.gvPlaceOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPlaceOrderDetail.Size = new System.Drawing.Size(992, 217);
            this.gvPlaceOrderDetail.TabIndex = 4;
            // 
            // gvWorkPlan
            // 
            this.gvWorkPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWorkPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_PlanNo,
            this.Col_PlanQty,
            this.Col_Unit_MP,
            this.Col_Remark_MP,
            this.Col_PlanStartDate,
            this.Col_WorkStatus});
            this.gvWorkPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWorkPlan.Location = new System.Drawing.Point(273, 422);
            this.gvWorkPlan.Name = "gvWorkPlan";
            this.gvWorkPlan.RowTemplate.Height = 23;
            this.gvWorkPlan.Size = new System.Drawing.Size(722, 217);
            this.gvWorkPlan.TabIndex = 5;
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(998, 44);
            this.Lbl_Contents1.TabIndex = 1;
            this.Lbl_Contents1.Text = "Lbl_PlanMaster";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uc_LblTxt_PlanQty
            // 
            this.uc_LblTxt_PlanQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_PlanQty.DisplayText = "0";
            this.uc_LblTxt_PlanQty.LblText = "계획 수량";
            this.uc_LblTxt_PlanQty.LblWidth = 100;
            this.uc_LblTxt_PlanQty.Location = new System.Drawing.Point(3, 38);
            this.uc_LblTxt_PlanQty.Name = "uc_LblTxt_PlanQty";
            this.uc_LblTxt_PlanQty.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_PlanQty.TabIndex = 12;
            this.uc_LblTxt_PlanQty.TxtWdith = 150;
            // 
            // uc_LblTxt_RemainQty
            // 
            this.uc_LblTxt_RemainQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_RemainQty.DisplayText = "0";
            this.uc_LblTxt_RemainQty.LblText = "미계획 수량";
            this.uc_LblTxt_RemainQty.LblWidth = 100;
            this.uc_LblTxt_RemainQty.Location = new System.Drawing.Point(3, 73);
            this.uc_LblTxt_RemainQty.Name = "uc_LblTxt_RemainQty";
            this.uc_LblTxt_RemainQty.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_RemainQty.TabIndex = 11;
            this.uc_LblTxt_RemainQty.TxtWdith = 150;
            // 
            // uc_LblTxt_OrderQty
            // 
            this.uc_LblTxt_OrderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_OrderQty.DisplayText = "0";
            this.uc_LblTxt_OrderQty.LblText = "수주수량";
            this.uc_LblTxt_OrderQty.LblWidth = 100;
            this.uc_LblTxt_OrderQty.Location = new System.Drawing.Point(3, 3);
            this.uc_LblTxt_OrderQty.Name = "uc_LblTxt_OrderQty";
            this.uc_LblTxt_OrderQty.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_OrderQty.TabIndex = 10;
            this.uc_LblTxt_OrderQty.TxtWdith = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_PlanQty, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_OrderQty, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_RemainQty, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 419);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 105);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.TableLayoutMain.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Lbl_Contents1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 44);
            this.panel1.TabIndex = 7;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save.Location = new System.Drawing.Point(848, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Btn_Create";
            this.Btn_Save.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Location = new System.Drawing.Point(923, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Btn_Update";
            this.Btn_Delete.UseVisualStyleBackColor = true;
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
            // Col_Status
            // 
            this.Col_Status.HeaderText = "진행상태";
            this.Col_Status.Name = "Col_Status";
            this.Col_Status.ReadOnly = true;
            // 
            // Col_PlanNo
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Col_PlanNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col_PlanNo.HeaderText = "계획번호";
            this.Col_PlanNo.Name = "Col_PlanNo";
            this.Col_PlanNo.ReadOnly = true;
            // 
            // Col_PlanQty
            // 
            dataGridViewCellStyle2.Format = "N";
            dataGridViewCellStyle2.NullValue = "0";
            this.Col_PlanQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_PlanQty.HeaderText = "계획수량";
            this.Col_PlanQty.Name = "Col_PlanQty";
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
            // 
            // Col_PlanStartDate
            // 
            this.Col_PlanStartDate.HeaderText = "생산시작 계획일";
            this.Col_PlanStartDate.Name = "Col_PlanStartDate";
            // 
            // Col_WorkStatus
            // 
            this.Col_WorkStatus.HeaderText = "작업상태";
            this.Col_WorkStatus.Name = "Col_WorkStatus";
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
            this.Pnl_SearchMain.ResumeLayout(false);
            this.Pnl_Search1.ResumeLayout(false);
            this.Pnl_Search0.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlaceOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkPlan)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.DataGridView gvWorkPlan;
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
        private System.Windows.Forms.DataGridView gvPlaceOrderDetail;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_PlanQty;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_RemainQty;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_OrderQty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_UnitNmae_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Unit_MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_WorkStatus;
    }
}