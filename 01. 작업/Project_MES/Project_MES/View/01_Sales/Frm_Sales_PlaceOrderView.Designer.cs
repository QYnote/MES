
namespace Project_MES.View._01_Sales
{
    partial class Frm_Sales_PlaceOrderView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvOrderDetail = new System.Windows.Forms.DataGridView();
            this.Col_Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_OD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.gvOrderMaster = new System.Windows.Forms.DataGridView();
            this.Col_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OutCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_OM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gvOrderDetail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Contents0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Contents1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvOrderMaster, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.AllowUserToAddRows = false;
            this.gvOrderDetail.AllowUserToDeleteRows = false;
            this.gvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Seq,
            this.Col_ProductCode,
            this.Col_ProductName,
            this.Col_ProductAlias,
            this.Col_ProductSpec,
            this.Col_Qty,
            this.Col_Unit,
            this.Col_Remark_OD,
            this.Col_PlanStatus});
            this.gvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrderDetail.Location = new System.Drawing.Point(3, 413);
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.ReadOnly = true;
            this.gvOrderDetail.RowTemplate.Height = 23;
            this.gvOrderDetail.Size = new System.Drawing.Size(992, 226);
            this.gvOrderDetail.TabIndex = 5;
            // 
            // Col_Seq
            // 
            this.Col_Seq.Frozen = true;
            this.Col_Seq.HeaderText = "순번";
            this.Col_Seq.Name = "Col_Seq";
            this.Col_Seq.ReadOnly = true;
            // 
            // Col_ProductCode
            // 
            this.Col_ProductCode.Frozen = true;
            this.Col_ProductCode.HeaderText = "제품코드";
            this.Col_ProductCode.Name = "Col_ProductCode";
            this.Col_ProductCode.ReadOnly = true;
            // 
            // Col_ProductName
            // 
            this.Col_ProductName.Frozen = true;
            this.Col_ProductName.HeaderText = "제품명";
            this.Col_ProductName.Name = "Col_ProductName";
            this.Col_ProductName.ReadOnly = true;
            // 
            // Col_ProductAlias
            // 
            this.Col_ProductAlias.Frozen = true;
            this.Col_ProductAlias.HeaderText = "제품번호";
            this.Col_ProductAlias.Name = "Col_ProductAlias";
            this.Col_ProductAlias.ReadOnly = true;
            // 
            // Col_ProductSpec
            // 
            this.Col_ProductSpec.Frozen = true;
            this.Col_ProductSpec.HeaderText = "Spec";
            this.Col_ProductSpec.Name = "Col_ProductSpec";
            this.Col_ProductSpec.ReadOnly = true;
            // 
            // Col_Qty
            // 
            this.Col_Qty.Frozen = true;
            this.Col_Qty.HeaderText = "수량";
            this.Col_Qty.Name = "Col_Qty";
            this.Col_Qty.ReadOnly = true;
            // 
            // Col_Unit
            // 
            this.Col_Unit.Frozen = true;
            this.Col_Unit.HeaderText = "단위";
            this.Col_Unit.Name = "Col_Unit";
            this.Col_Unit.ReadOnly = true;
            // 
            // Col_Remark_OD
            // 
            this.Col_Remark_OD.Frozen = true;
            this.Col_Remark_OD.HeaderText = "비고";
            this.Col_Remark_OD.Name = "Col_Remark_OD";
            this.Col_Remark_OD.ReadOnly = true;
            // 
            // Col_PlanStatus
            // 
            this.Col_PlanStatus.Frozen = true;
            this.Col_PlanStatus.HeaderText = "계획상태";
            this.Col_PlanStatus.Name = "Col_PlanStatus";
            this.Col_PlanStatus.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uc_LblTxt_CustName);
            this.panel1.Controls.Add(this.uc_LblDtp_OrderDate);
            this.panel1.Controls.Add(this.Btn_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 35);
            this.panel1.TabIndex = 3;
            // 
            // uc_LblTxt_CustName
            // 
            this.uc_LblTxt_CustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_CustName.DisplayText = "";
            this.uc_LblTxt_CustName.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_CustName.LblText = "수주처";
            this.uc_LblTxt_CustName.LblWidth = 100;
            this.uc_LblTxt_CustName.Location = new System.Drawing.Point(338, 0);
            this.uc_LblTxt_CustName.Name = "uc_LblTxt_CustName";
            this.uc_LblTxt_CustName.Size = new System.Drawing.Size(264, 35);
            this.uc_LblTxt_CustName.TabIndex = 9;
            this.uc_LblTxt_CustName.TxtWdith = 150;
            // 
            // uc_LblDtp_OrderDate
            // 
            this.uc_LblDtp_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblDtp_OrderDate.DisplayFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uc_LblDtp_OrderDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblDtp_OrderDate.DtpRange = true;
            this.uc_LblDtp_OrderDate.LblText = "수주일자";
            this.uc_LblDtp_OrderDate.LblWidth = 100;
            this.uc_LblDtp_OrderDate.Location = new System.Drawing.Point(0, 0);
            this.uc_LblDtp_OrderDate.Name = "uc_LblDtp_OrderDate";
            this.uc_LblDtp_OrderDate.Size = new System.Drawing.Size(338, 35);
            this.uc_LblDtp_OrderDate.TabIndex = 8;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Search.Location = new System.Drawing.Point(923, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 35);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Btn_Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.AutoSize = true;
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(3, 85);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(992, 44);
            this.Lbl_Contents0.TabIndex = 0;
            this.Lbl_Contents0.Text = "Lbl_OrderMaster";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.AutoSize = true;
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(3, 360);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(992, 50);
            this.Lbl_Contents1.TabIndex = 1;
            this.Lbl_Contents1.Text = "Lbl_OrderDetail";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl_MailTitle
            // 
            this.Pnl_MailTitle.Controls.Add(this.Lbl_MailTitle);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Create);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Update);
            this.Pnl_MailTitle.Controls.Add(this.Btn_Delete);
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
            this.Lbl_MailTitle.Size = new System.Drawing.Size(773, 50);
            this.Lbl_MailTitle.TabIndex = 0;
            this.Lbl_MailTitle.Text = "Lbl_MainTitle";
            this.Lbl_MailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Create.Location = new System.Drawing.Point(773, 0);
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
            this.Btn_Update.Location = new System.Drawing.Point(848, 0);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 50);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Btn_Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Location = new System.Drawing.Point(923, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 50);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Btn_Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // gvOrderMaster
            // 
            this.gvOrderMaster.AllowUserToAddRows = false;
            this.gvOrderMaster.AllowUserToDeleteRows = false;
            this.gvOrderMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_OrderNo,
            this.Col_CustName,
            this.Col_OutCustName,
            this.Col_OrderDate,
            this.Col_OrderEndDate,
            this.Col_Remark_OM});
            this.gvOrderMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrderMaster.Location = new System.Drawing.Point(3, 132);
            this.gvOrderMaster.MultiSelect = false;
            this.gvOrderMaster.Name = "gvOrderMaster";
            this.gvOrderMaster.ReadOnly = true;
            this.gvOrderMaster.RowTemplate.Height = 23;
            this.gvOrderMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrderMaster.Size = new System.Drawing.Size(992, 225);
            this.gvOrderMaster.TabIndex = 4;
            this.gvOrderMaster.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrderMaster_RowEnter);
            // 
            // Col_OrderNo
            // 
            this.Col_OrderNo.HeaderText = "수주번호";
            this.Col_OrderNo.Name = "Col_OrderNo";
            this.Col_OrderNo.ReadOnly = true;
            // 
            // Col_CustName
            // 
            this.Col_CustName.HeaderText = "수주처";
            this.Col_CustName.Name = "Col_CustName";
            this.Col_CustName.ReadOnly = true;
            // 
            // Col_OutCustName
            // 
            this.Col_OutCustName.HeaderText = "납품처";
            this.Col_OutCustName.Name = "Col_OutCustName";
            this.Col_OutCustName.ReadOnly = true;
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
            // Col_Remark_OM
            // 
            this.Col_Remark_OM.HeaderText = "비고";
            this.Col_Remark_OM.Name = "Col_Remark_OM";
            this.Col_Remark_OM.ReadOnly = true;
            // 
            // Frm_Sales_PlaceOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Sales_PlaceOrderView";
            this.Text = "Frm_SalesOrder";
            this.Load += new System.EventHandler(this.Frm_Sales_Order_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.DataGridView gvOrderMaster;
        private System.Windows.Forms.DataGridView gvOrderDetail;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_OrderDate;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OutCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_OM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_OD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanStatus;
    }
}