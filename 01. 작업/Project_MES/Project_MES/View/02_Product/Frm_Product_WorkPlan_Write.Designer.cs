namespace Project_MES.View._02_Product
{
    partial class Frm_Product_WorkPlan_Write
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
            this.Pnl_Contents = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_Contents1 = new System.Windows.Forms.Panel();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.gvPlanMaster = new System.Windows.Forms.DataGridView();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_SODetail_Base = new System.Windows.Forms.Panel();
            this.Pnl_SODetail2 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_Remark = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_SODetail1 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_PlanQty = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_RemainPlanQty = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_OrderQty = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_ProductName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_SODetail0 = new System.Windows.Forms.Panel();
            this.uc_LblDtp_EndDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.uc_LblCbo_OrderCust = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblTxt_OrderNo = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Col_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Contents.SuspendLayout();
            this.Pnl_Contents1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).BeginInit();
            this.Pnl_MailTitle.SuspendLayout();
            this.Pnl_SODetail_Base.SuspendLayout();
            this.Pnl_SODetail2.SuspendLayout();
            this.Pnl_SODetail1.SuspendLayout();
            this.Pnl_SODetail0.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Contents
            // 
            this.Pnl_Contents.ColumnCount = 1;
            this.Pnl_Contents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Pnl_Contents.Controls.Add(this.Pnl_Contents1, 0, 3);
            this.Pnl_Contents.Controls.Add(this.gvPlanMaster, 0, 4);
            this.Pnl_Contents.Controls.Add(this.Lbl_Contents0, 0, 1);
            this.Pnl_Contents.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.Pnl_Contents.Controls.Add(this.Pnl_SODetail_Base, 0, 2);
            this.Pnl_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Contents.Name = "Pnl_Contents";
            this.Pnl_Contents.RowCount = 5;
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Pnl_Contents.Size = new System.Drawing.Size(998, 642);
            this.Pnl_Contents.TabIndex = 1;
            // 
            // Pnl_Contents1
            // 
            this.Pnl_Contents1.Controls.Add(this.Lbl_Contents1);
            this.Pnl_Contents1.Controls.Add(this.Btn_Delete);
            this.Pnl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents1.Location = new System.Drawing.Point(0, 181);
            this.Pnl_Contents1.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_Contents1.Name = "Pnl_Contents1";
            this.Pnl_Contents1.Size = new System.Drawing.Size(998, 44);
            this.Pnl_Contents1.TabIndex = 10;
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(923, 44);
            this.Lbl_Contents1.TabIndex = 0;
            this.Lbl_Contents1.Text = "Lbl_Product_ManufacturePlanMaster";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Location = new System.Drawing.Point(923, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Btn_Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // gvPlanMaster
            // 
            this.gvPlanMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlanMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ProductCode,
            this.Col_ProductName,
            this.Col_ProductAlias,
            this.Col_ProductSpec,
            this.Col_PlanQty,
            this.Col_PlanStartDate,
            this.Col_PlanStatus,
            this.Col_Remark});
            this.gvPlanMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPlanMaster.Location = new System.Drawing.Point(3, 228);
            this.gvPlanMaster.Name = "gvPlanMaster";
            this.gvPlanMaster.RowTemplate.Height = 23;
            this.gvPlanMaster.Size = new System.Drawing.Size(992, 411);
            this.gvPlanMaster.TabIndex = 5;
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.AutoSize = true;
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(3, 50);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(992, 44);
            this.Lbl_Contents0.TabIndex = 0;
            this.Lbl_Contents0.Text = "Lbl_Sales_OrderDetail";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl_MailTitle
            // 
            this.Pnl_MailTitle.Controls.Add(this.Lbl_MailTitle);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Save);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Close);
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
            // Btn_Save
            // 
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save.Location = new System.Drawing.Point(848, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 50);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Close.Location = new System.Drawing.Point(923, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 50);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "Btn_Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Pnl_SODetail_Base
            // 
            this.Pnl_SODetail_Base.Controls.Add(this.Pnl_SODetail2);
            this.Pnl_SODetail_Base.Controls.Add(this.Pnl_SODetail1);
            this.Pnl_SODetail_Base.Controls.Add(this.Pnl_SODetail0);
            this.Pnl_SODetail_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_SODetail_Base.Enabled = false;
            this.Pnl_SODetail_Base.Location = new System.Drawing.Point(0, 94);
            this.Pnl_SODetail_Base.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_SODetail_Base.Name = "Pnl_SODetail_Base";
            this.Pnl_SODetail_Base.Size = new System.Drawing.Size(998, 87);
            this.Pnl_SODetail_Base.TabIndex = 11;
            // 
            // Pnl_SODetail2
            // 
            this.Pnl_SODetail2.Controls.Add(this.uc_LblTxt_Remark);
            this.Pnl_SODetail2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SODetail2.Location = new System.Drawing.Point(0, 58);
            this.Pnl_SODetail2.Name = "Pnl_SODetail2";
            this.Pnl_SODetail2.Size = new System.Drawing.Size(998, 29);
            this.Pnl_SODetail2.TabIndex = 5;
            // 
            // uc_LblTxt_Remark
            // 
            this.uc_LblTxt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Remark.DisplayText = "Txt 기본 Text";
            this.uc_LblTxt_Remark.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_Remark.LblText = "비고";
            this.uc_LblTxt_Remark.LblWidth = 100;
            this.uc_LblTxt_Remark.Location = new System.Drawing.Point(0, 0);
            this.uc_LblTxt_Remark.Name = "uc_LblTxt_Remark";
            this.uc_LblTxt_Remark.Size = new System.Drawing.Size(314, 29);
            this.uc_LblTxt_Remark.TabIndex = 3;
            this.uc_LblTxt_Remark.TxtWdith = 200;
            // 
            // Pnl_SODetail1
            // 
            this.Pnl_SODetail1.Controls.Add(this.uc_LblTxt_PlanQty);
            this.Pnl_SODetail1.Controls.Add(this.uc_LblTxt_RemainPlanQty);
            this.Pnl_SODetail1.Controls.Add(this.uc_LblTxt_OrderQty);
            this.Pnl_SODetail1.Controls.Add(this.uc_LblTxt_ProductName);
            this.Pnl_SODetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SODetail1.Location = new System.Drawing.Point(0, 29);
            this.Pnl_SODetail1.Name = "Pnl_SODetail1";
            this.Pnl_SODetail1.Size = new System.Drawing.Size(998, 29);
            this.Pnl_SODetail1.TabIndex = 4;
            // 
            // uc_LblTxt_PlanQty
            // 
            this.uc_LblTxt_PlanQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_PlanQty.DisplayText = "Default Text";
            this.uc_LblTxt_PlanQty.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_PlanQty.LblText = "계획수량";
            this.uc_LblTxt_PlanQty.LblWidth = 100;
            this.uc_LblTxt_PlanQty.Location = new System.Drawing.Point(652, 0);
            this.uc_LblTxt_PlanQty.Name = "uc_LblTxt_PlanQty";
            this.uc_LblTxt_PlanQty.Size = new System.Drawing.Size(194, 29);
            this.uc_LblTxt_PlanQty.TabIndex = 3;
            this.uc_LblTxt_PlanQty.TxtWdith = 80;
            // 
            // uc_LblTxt_RemainPlanQty
            // 
            this.uc_LblTxt_RemainPlanQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_RemainPlanQty.DisplayText = "Default Text";
            this.uc_LblTxt_RemainPlanQty.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_RemainPlanQty.LblText = "미계획수량";
            this.uc_LblTxt_RemainPlanQty.LblWidth = 100;
            this.uc_LblTxt_RemainPlanQty.Location = new System.Drawing.Point(458, 0);
            this.uc_LblTxt_RemainPlanQty.Name = "uc_LblTxt_RemainPlanQty";
            this.uc_LblTxt_RemainPlanQty.Size = new System.Drawing.Size(194, 29);
            this.uc_LblTxt_RemainPlanQty.TabIndex = 2;
            this.uc_LblTxt_RemainPlanQty.TxtWdith = 80;
            // 
            // uc_LblTxt_OrderQty
            // 
            this.uc_LblTxt_OrderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_OrderQty.DisplayText = "Default Text";
            this.uc_LblTxt_OrderQty.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_OrderQty.LblText = "수주수량";
            this.uc_LblTxt_OrderQty.LblWidth = 100;
            this.uc_LblTxt_OrderQty.Location = new System.Drawing.Point(264, 0);
            this.uc_LblTxt_OrderQty.Name = "uc_LblTxt_OrderQty";
            this.uc_LblTxt_OrderQty.Size = new System.Drawing.Size(194, 29);
            this.uc_LblTxt_OrderQty.TabIndex = 1;
            this.uc_LblTxt_OrderQty.TxtWdith = 80;
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
            this.uc_LblTxt_ProductName.TabIndex = 0;
            this.uc_LblTxt_ProductName.TxtWdith = 150;
            // 
            // Pnl_SODetail0
            // 
            this.Pnl_SODetail0.Controls.Add(this.uc_LblDtp_EndDate);
            this.Pnl_SODetail0.Controls.Add(this.uc_LblDtp_OrderDate);
            this.Pnl_SODetail0.Controls.Add(this.uc_LblCbo_OrderCust);
            this.Pnl_SODetail0.Controls.Add(this.uc_LblTxt_OrderNo);
            this.Pnl_SODetail0.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SODetail0.Location = new System.Drawing.Point(0, 0);
            this.Pnl_SODetail0.Name = "Pnl_SODetail0";
            this.Pnl_SODetail0.Size = new System.Drawing.Size(998, 29);
            this.Pnl_SODetail0.TabIndex = 3;
            // 
            // uc_LblDtp_EndDate
            // 
            this.uc_LblDtp_EndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblDtp_EndDate.DisplayFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uc_LblDtp_EndDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblDtp_EndDate.DtpDefaultDate = new System.DateTime(2022, 5, 1, 19, 16, 26, 808);
            this.uc_LblDtp_EndDate.DtpRange = false;
            this.uc_LblDtp_EndDate.LblText = "마감일자";
            this.uc_LblDtp_EndDate.LblWidth = 100;
            this.uc_LblDtp_EndDate.Location = new System.Drawing.Point(742, 0);
            this.uc_LblDtp_EndDate.Name = "uc_LblDtp_EndDate";
            this.uc_LblDtp_EndDate.Size = new System.Drawing.Size(214, 29);
            this.uc_LblDtp_EndDate.TabIndex = 1;
            // 
            // uc_LblDtp_OrderDate
            // 
            this.uc_LblDtp_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblDtp_OrderDate.DisplayFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uc_LblDtp_OrderDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblDtp_OrderDate.DtpDefaultDate = new System.DateTime(2022, 5, 1, 19, 16, 26, 808);
            this.uc_LblDtp_OrderDate.DtpRange = false;
            this.uc_LblDtp_OrderDate.LblText = "수주일자";
            this.uc_LblDtp_OrderDate.LblWidth = 100;
            this.uc_LblDtp_OrderDate.Location = new System.Drawing.Point(528, 0);
            this.uc_LblDtp_OrderDate.Name = "uc_LblDtp_OrderDate";
            this.uc_LblDtp_OrderDate.Size = new System.Drawing.Size(214, 29);
            this.uc_LblDtp_OrderDate.TabIndex = 0;
            // 
            // uc_LblCbo_OrderCust
            // 
            this.uc_LblCbo_OrderCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo_OrderCust.CboDataSource = null;
            this.uc_LblCbo_OrderCust.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_OrderCust.CboWdith = 150;
            this.uc_LblCbo_OrderCust.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblCbo_OrderCust.LblText = "수주 거래처";
            this.uc_LblCbo_OrderCust.LblWidth = 100;
            this.uc_LblCbo_OrderCust.Location = new System.Drawing.Point(264, 0);
            this.uc_LblCbo_OrderCust.Name = "uc_LblCbo_OrderCust";
            this.uc_LblCbo_OrderCust.Size = new System.Drawing.Size(264, 29);
            this.uc_LblCbo_OrderCust.TabIndex = 1;
            // 
            // uc_LblTxt_OrderNo
            // 
            this.uc_LblTxt_OrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_OrderNo.DisplayText = "Txt 기본 Text";
            this.uc_LblTxt_OrderNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_OrderNo.Enabled = false;
            this.uc_LblTxt_OrderNo.LblText = "수주번호";
            this.uc_LblTxt_OrderNo.LblWidth = 100;
            this.uc_LblTxt_OrderNo.Location = new System.Drawing.Point(0, 0);
            this.uc_LblTxt_OrderNo.Name = "uc_LblTxt_OrderNo";
            this.uc_LblTxt_OrderNo.Size = new System.Drawing.Size(264, 29);
            this.uc_LblTxt_OrderNo.TabIndex = 0;
            this.uc_LblTxt_OrderNo.TxtWdith = 150;
            // 
            // Col_ProductCode
            // 
            this.Col_ProductCode.HeaderText = "제품코드";
            this.Col_ProductCode.Name = "Col_ProductCode";
            this.Col_ProductCode.ReadOnly = true;
            // 
            // Col_ProductName
            // 
            this.Col_ProductName.HeaderText = "제품명";
            this.Col_ProductName.Name = "Col_ProductName";
            this.Col_ProductName.ReadOnly = true;
            // 
            // Col_ProductAlias
            // 
            this.Col_ProductAlias.HeaderText = "제품번호";
            this.Col_ProductAlias.Name = "Col_ProductAlias";
            this.Col_ProductAlias.ReadOnly = true;
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
            // 
            // Col_PlanStartDate
            // 
            this.Col_PlanStartDate.HeaderText = "생산시작 계획일";
            this.Col_PlanStartDate.Name = "Col_PlanStartDate";
            // 
            // Col_PlanStatus
            // 
            this.Col_PlanStatus.HeaderText = "진행상황";
            this.Col_PlanStatus.Name = "Col_PlanStatus";
            this.Col_PlanStatus.ReadOnly = true;
            // 
            // Col_Remark
            // 
            this.Col_Remark.HeaderText = "비고";
            this.Col_Remark.Name = "Col_Remark";
            this.Col_Remark.ReadOnly = true;
            // 
            // Frm_Product_WorkPlan_Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.Pnl_Contents);
            this.Name = "Frm_Product_WorkPlan_Write";
            this.Text = "생산계획등록";
            this.Pnl_Contents.ResumeLayout(false);
            this.Pnl_Contents.PerformLayout();
            this.Pnl_Contents1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).EndInit();
            this.Pnl_MailTitle.ResumeLayout(false);
            this.Pnl_SODetail_Base.ResumeLayout(false);
            this.Pnl_SODetail2.ResumeLayout(false);
            this.Pnl_SODetail1.ResumeLayout(false);
            this.Pnl_SODetail0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Pnl_Contents;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView gvPlanMaster;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Pnl_SODetail_Base;
        private System.Windows.Forms.Panel Pnl_SODetail1;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_EndDate;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_OrderDate;
        private System.Windows.Forms.Panel Pnl_SODetail0;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_OrderCust;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_OrderNo;
        private System.Windows.Forms.Panel Pnl_SODetail2;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Remark;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_PlanQty;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_RemainPlanQty;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_OrderQty;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark;
    }
}