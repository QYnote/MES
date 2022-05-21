namespace Project_MES.View._01_Sales
{
    partial class Frm_Sales_SalesOrder
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
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvOrderMaster = new System.Windows.Forms.DataGridView();
            this.Col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OutCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SalesQtySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RemainQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SalesQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_OM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Order = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Pnl_SearchMain = new System.Windows.Forms.Panel();
            this.Pnl_Search1 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_ProductAlias = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_ProductName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_Search0 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderMaster)).BeginInit();
            this.panel2.SuspendLayout();
            this.Pnl_SearchMain.SuspendLayout();
            this.Pnl_Search1.SuspendLayout();
            this.Pnl_Search0.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Pnl_SearchMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 642);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Pnl_MailTitle
            // 
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 152);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 490);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvOrderMaster);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "미납품 내역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gvOrderMaster
            // 
            this.gvOrderMaster.AllowUserToAddRows = false;
            this.gvOrderMaster.AllowUserToDeleteRows = false;
            this.gvOrderMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Check,
            this.Col_OrderNo,
            this.Col_OrderSeq,
            this.Col_CustName,
            this.Col_OutCustName,
            this.Col_OrderQty,
            this.Col_ProductQty,
            this.Col_SalesQtySum,
            this.Col_RemainQty,
            this.Col_SalesQty,
            this.Col_OrderDate,
            this.Col_OrderEndDate,
            this.Col_SalesDate,
            this.Col_Status,
            this.Col_Remark_OM});
            this.gvOrderMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrderMaster.Location = new System.Drawing.Point(3, 3);
            this.gvOrderMaster.Name = "gvOrderMaster";
            this.gvOrderMaster.RowTemplate.Height = 23;
            this.gvOrderMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrderMaster.Size = new System.Drawing.Size(984, 458);
            this.gvOrderMaster.TabIndex = 4;
            // 
            // Col_Check
            // 
            this.Col_Check.Frozen = true;
            this.Col_Check.HeaderText = "";
            this.Col_Check.Name = "Col_Check";
            this.Col_Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_Check.Width = 40;
            // 
            // Col_OrderNo
            // 
            this.Col_OrderNo.HeaderText = "수주번호";
            this.Col_OrderNo.Name = "Col_OrderNo";
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
            // Col_OutCustName
            // 
            this.Col_OutCustName.HeaderText = "납품처";
            this.Col_OutCustName.Name = "Col_OutCustName";
            this.Col_OutCustName.ReadOnly = true;
            // 
            // Col_OrderQty
            // 
            this.Col_OrderQty.HeaderText = "수주량";
            this.Col_OrderQty.Name = "Col_OrderQty";
            this.Col_OrderQty.ReadOnly = true;
            // 
            // Col_ProductQty
            // 
            this.Col_ProductQty.HeaderText = "생산량";
            this.Col_ProductQty.Name = "Col_ProductQty";
            this.Col_ProductQty.ReadOnly = true;
            // 
            // Col_SalesQtySum
            // 
            this.Col_SalesQtySum.HeaderText = "납품진행량";
            this.Col_SalesQtySum.Name = "Col_SalesQtySum";
            this.Col_SalesQtySum.ReadOnly = true;
            // 
            // Col_RemainQty
            // 
            this.Col_RemainQty.HeaderText = "미납품량";
            this.Col_RemainQty.Name = "Col_RemainQty";
            this.Col_RemainQty.ReadOnly = true;
            // 
            // Col_SalesQty
            // 
            this.Col_SalesQty.HeaderText = "납품량";
            this.Col_SalesQty.Name = "Col_SalesQty";
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
            // Col_SalesDate
            // 
            this.Col_SalesDate.HeaderText = "납품일자";
            this.Col_SalesDate.Name = "Col_SalesDate";
            // 
            // Col_Status
            // 
            this.Col_Status.HeaderText = "진행상태";
            this.Col_Status.Name = "Col_Status";
            this.Col_Status.ReadOnly = true;
            // 
            // Col_Remark_OM
            // 
            this.Col_Remark_OM.HeaderText = "비고";
            this.Col_Remark_OM.Name = "Col_Remark_OM";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "납품 내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Order);
            this.panel2.Controls.Add(this.Lbl_Contents0);
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 44);
            this.panel2.TabIndex = 6;
            // 
            // Btn_Order
            // 
            this.Btn_Order.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Order.Location = new System.Drawing.Point(848, 0);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Size = new System.Drawing.Size(75, 44);
            this.Btn_Order.TabIndex = 4;
            this.Btn_Order.Text = "Btn_Order";
            this.Btn_Order.UseVisualStyleBackColor = true;
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(923, 44);
            this.Lbl_Contents0.TabIndex = 0;
            this.Lbl_Contents0.Text = "Lbl_OrderMaster";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Location = new System.Drawing.Point(923, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Btn_Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
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
            this.Pnl_SearchMain.TabIndex = 4;
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
            // Frm_Sales_SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Sales_SalesOrder";
            this.Text = "Frm_Sales_SalesOrder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderMaster)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Pnl_SearchMain.ResumeLayout(false);
            this.Pnl_Search1.ResumeLayout(false);
            this.Pnl_Search0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gvOrderMaster;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OutCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SalesQtySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RemainQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SalesQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SalesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_OM;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Order;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Panel Pnl_SearchMain;
        private System.Windows.Forms.Panel Pnl_Search1;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductAlias;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductName;
        private System.Windows.Forms.Panel Pnl_Search0;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustName;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_OrderDate;
        private System.Windows.Forms.Button Btn_Search;
    }
}