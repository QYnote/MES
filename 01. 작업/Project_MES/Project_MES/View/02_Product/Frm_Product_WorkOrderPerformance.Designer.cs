
namespace Project_MES.View._02_Product
{
    partial class Frm_Product_WorkOrderPerformance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_SearchMain = new System.Windows.Forms.Panel();
            this.Pnl_Search1 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_ProductAlias = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_ProductName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_Search0 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.GvWorkOrder = new System.Windows.Forms.DataGridView();
            this.Col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_WorkOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_ProductAlias = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_WorkQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_GoodQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BadQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_WorkOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutMain.SuspendLayout();
            this.Pnl_SearchMain.SuspendLayout();
            this.Pnl_Search1.SuspendLayout();
            this.Pnl_Search0.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvWorkOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 1;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutMain.Controls.Add(this.Pnl_SearchMain, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.panel1, 0, 2);
            this.TableLayoutMain.Controls.Add(this.GvWorkOrder, 0, 3);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 4;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Size = new System.Drawing.Size(998, 642);
            this.TableLayoutMain.TabIndex = 2;
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
            // uc_LblTxt_ProductAlias
            // 
            this.uc_LblTxt_ProductAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_ProductAlias.DisplayText = "";
            this.uc_LblTxt_ProductAlias.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt_ProductAlias.LblText = "제품번호";
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
            this.uc_LblTxt_ProductName.DisplayText = "";
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
            this.uc_LblTxt_CustName.DisplayText = "";
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
            this.uc_LblDtp_OrderDate.DtpRange = true;
            this.uc_LblDtp_OrderDate.LblText = "지시일자";
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
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Pnl_MailTitle
            // 
            this.Pnl_MailTitle.Controls.Add(this.Btn_Save);
            this.Pnl_MailTitle.Controls.Add(this.Lbl_MailTitle);
            this.Pnl_MailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_MailTitle.Location = new System.Drawing.Point(0, 0);
            this.Pnl_MailTitle.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_MailTitle.Name = "Pnl_MailTitle";
            this.Pnl_MailTitle.Size = new System.Drawing.Size(998, 50);
            this.Pnl_MailTitle.TabIndex = 2;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save.Location = new System.Drawing.Point(923, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 50);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_Contents0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 44);
            this.panel1.TabIndex = 7;
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(998, 44);
            this.Lbl_Contents0.TabIndex = 1;
            this.Lbl_Contents0.Text = "Lbl_WorkOrder";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GvWorkOrder
            // 
            this.GvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvWorkOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Check,
            this.Col_WorkOrderNo,
            this.Col_CustCode,
            this.Col_CustName,
            this.Col_ProductCode,
            this.Col_ProductName,
            this.Col_ProductAlias,
            this.Col_WorkQty,
            this.Col_GoodQty,
            this.Col_BadQty,
            this.Col_WorkOrderDate,
            this.Col_Unit,
            this.Col_Remark});
            this.GvWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvWorkOrder.Location = new System.Drawing.Point(3, 155);
            this.GvWorkOrder.Name = "GvWorkOrder";
            this.GvWorkOrder.RowTemplate.Height = 23;
            this.GvWorkOrder.Size = new System.Drawing.Size(992, 484);
            this.GvWorkOrder.TabIndex = 5;
            this.GvWorkOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvWorkOrder_CellContentClick);
            this.GvWorkOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvWorkPlan_CellEndEdit);
            // 
            // Col_Check
            // 
            this.Col_Check.HeaderText = "";
            this.Col_Check.Name = "Col_Check";
            this.Col_Check.Width = 30;
            // 
            // Col_WorkOrderNo
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Col_WorkOrderNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col_WorkOrderNo.HeaderText = "작업번호";
            this.Col_WorkOrderNo.Name = "Col_WorkOrderNo";
            this.Col_WorkOrderNo.ReadOnly = true;
            // 
            // Col_CustCode
            // 
            this.Col_CustCode.HeaderText = "수주처코드";
            this.Col_CustCode.Name = "Col_CustCode";
            // 
            // Col_CustName
            // 
            this.Col_CustName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_CustName.HeaderText = "수주처명";
            this.Col_CustName.Name = "Col_CustName";
            this.Col_CustName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_CustName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_ProductCode
            // 
            this.Col_ProductCode.HeaderText = "제품코드";
            this.Col_ProductCode.Name = "Col_ProductCode";
            // 
            // Col_ProductName
            // 
            this.Col_ProductName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_ProductName.HeaderText = "제품명";
            this.Col_ProductName.Name = "Col_ProductName";
            this.Col_ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_ProductAlias
            // 
            this.Col_ProductAlias.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_ProductAlias.HeaderText = "제품번호";
            this.Col_ProductAlias.Name = "Col_ProductAlias";
            this.Col_ProductAlias.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_ProductAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_WorkQty
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.Col_WorkQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_WorkQty.HeaderText = "작업수량";
            this.Col_WorkQty.Name = "Col_WorkQty";
            // 
            // Col_GoodQty
            // 
            this.Col_GoodQty.HeaderText = "양품수량";
            this.Col_GoodQty.Name = "Col_GoodQty";
            // 
            // Col_BadQty
            // 
            dataGridViewCellStyle3.Format = "N";
            dataGridViewCellStyle3.NullValue = "0";
            this.Col_BadQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_BadQty.HeaderText = "불량수량";
            this.Col_BadQty.Name = "Col_BadQty";
            // 
            // Col_WorkOrderDate
            // 
            this.Col_WorkOrderDate.HeaderText = "작업지시일";
            this.Col_WorkOrderDate.Name = "Col_WorkOrderDate";
            // 
            // Col_Unit
            // 
            this.Col_Unit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_Unit.HeaderText = "단위";
            this.Col_Unit.Name = "Col_Unit";
            this.Col_Unit.ReadOnly = true;
            this.Col_Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_Remark
            // 
            this.Col_Remark.HeaderText = "비고";
            this.Col_Remark.Name = "Col_Remark";
            // 
            // Frm_Product_WorkOrderPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Product_WorkOrderPerformance";
            this.Text = "생산실적";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Product_WorkOrderPerformance_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Product_WorkPlan_Load);
            this.TableLayoutMain.ResumeLayout(false);
            this.Pnl_SearchMain.ResumeLayout(false);
            this.Pnl_Search1.ResumeLayout(false);
            this.Pnl_Search0.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvWorkOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.DataGridView GvWorkOrder;
        private System.Windows.Forms.Panel Pnl_SearchMain;
        private System.Windows.Forms.Panel Pnl_Search1;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductAlias;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_ProductName;
        private System.Windows.Forms.Panel Pnl_Search0;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustName;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_OrderDate;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_WorkOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_ProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_ProductAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_WorkQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_GoodQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BadQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_WorkOrderDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark;
    }
}