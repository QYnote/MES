
namespace Project_MES.View._02_Product
{
    partial class Frm_Product_WorkOrder
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
            this.gvWorkOrder = new System.Windows.Forms.DataGridView();
            this.Col_Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProcessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductCode_WO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias_WO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Unit_WO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_WO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_SearchMain = new System.Windows.Forms.Panel();
            this.Pnl_Search1 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_ProductAlias = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_ProductName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_Search0 = new System.Windows.Forms.Panel();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Btn_Order = new System.Windows.Forms.Button();
            this.gvWorkPlan = new System.Windows.Forms.DataGridView();
            this.Col_PlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductCode_MPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductName_MPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductAlias_MPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_UnitNmae_MPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PlanStatus_MPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrder)).BeginInit();
            this.Pnl_SearchMain.SuspendLayout();
            this.Pnl_Search1.SuspendLayout();
            this.Pnl_Search0.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 1;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Controls.Add(this.gvWorkOrder, 0, 5);
            this.TableLayoutMain.Controls.Add(this.Pnl_SearchMain, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Lbl_Contents0, 0, 2);
            this.TableLayoutMain.Controls.Add(this.Lbl_Contents1, 0, 4);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.gvWorkPlan, 0, 3);
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
            this.TableLayoutMain.TabIndex = 3;
            // 
            // gvWorkOrder
            // 
            this.gvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWorkOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Seq,
            this.Col_ProcessType,
            this.Col_ProcessName,
            this.Col_Status,
            this.Col_ProductCode_WO,
            this.Col_ProductAlias_WO,
            this.Col_Qty,
            this.Col_Unit_WO,
            this.Col_Remark_WO});
            this.gvWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWorkOrder.Location = new System.Drawing.Point(3, 425);
            this.gvWorkOrder.Name = "gvWorkOrder";
            this.gvWorkOrder.RowTemplate.Height = 23;
            this.gvWorkOrder.Size = new System.Drawing.Size(992, 214);
            this.gvWorkOrder.TabIndex = 5;
            // 
            // Col_Seq
            // 
            this.Col_Seq.HeaderText = "공정순번";
            this.Col_Seq.Name = "Col_Seq";
            this.Col_Seq.ReadOnly = true;
            // 
            // Col_ProcessType
            // 
            this.Col_ProcessType.HeaderText = "공정타입";
            this.Col_ProcessType.Name = "Col_ProcessType";
            this.Col_ProcessType.ReadOnly = true;
            // 
            // Col_ProcessName
            // 
            this.Col_ProcessName.HeaderText = "공정명";
            this.Col_ProcessName.Name = "Col_ProcessName";
            this.Col_ProcessName.ReadOnly = true;
            // 
            // Col_Status
            // 
            this.Col_Status.HeaderText = "진행상황";
            this.Col_Status.Name = "Col_Status";
            this.Col_Status.ReadOnly = true;
            // 
            // Col_ProductCode_WO
            // 
            this.Col_ProductCode_WO.HeaderText = "제품명";
            this.Col_ProductCode_WO.Name = "Col_ProductCode_WO";
            this.Col_ProductCode_WO.ReadOnly = true;
            // 
            // Col_ProductAlias_WO
            // 
            this.Col_ProductAlias_WO.HeaderText = "제품 Spec";
            this.Col_ProductAlias_WO.Name = "Col_ProductAlias_WO";
            this.Col_ProductAlias_WO.ReadOnly = true;
            // 
            // Col_Qty
            // 
            this.Col_Qty.HeaderText = "수량";
            this.Col_Qty.Name = "Col_Qty";
            this.Col_Qty.ReadOnly = true;
            // 
            // Col_Unit_WO
            // 
            this.Col_Unit_WO.HeaderText = "단위";
            this.Col_Unit_WO.Name = "Col_Unit_WO";
            this.Col_Unit_WO.ReadOnly = true;
            // 
            // Col_Remark_WO
            // 
            this.Col_Remark_WO.HeaderText = "비고";
            this.Col_Remark_WO.Name = "Col_Remark_WO";
            this.Col_Remark_WO.ReadOnly = true;
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
            this.Pnl_MailTitle.Controls.Add(this.Btn_Order);
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
            this.Lbl_MailTitle.Size = new System.Drawing.Size(923, 50);
            this.Lbl_MailTitle.TabIndex = 0;
            this.Lbl_MailTitle.Text = "Lbl_MainTitle";
            this.Lbl_MailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Order
            // 
            this.Btn_Order.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Order.Location = new System.Drawing.Point(923, 0);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Size = new System.Drawing.Size(75, 50);
            this.Btn_Order.TabIndex = 1;
            this.Btn_Order.Text = "Btn_Order";
            this.Btn_Order.UseVisualStyleBackColor = true;
            // 
            // gvWorkPlan
            // 
            this.gvWorkPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWorkPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_PlanNo,
            this.Col_CustCode,
            this.Col_CustName,
            this.Col_ProductCode_MPM,
            this.Col_ProductName_MPM,
            this.Col_ProductAlias_MPM,
            this.Col_PlanQty,
            this.Col_UnitNmae_MPM,
            this.Col_PlanStartDate,
            this.Col_Remark_SO,
            this.Col_PlanStatus_MPM});
            this.gvWorkPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWorkPlan.Location = new System.Drawing.Point(3, 155);
            this.gvWorkPlan.Name = "gvWorkPlan";
            this.gvWorkPlan.RowTemplate.Height = 23;
            this.gvWorkPlan.Size = new System.Drawing.Size(992, 214);
            this.gvWorkPlan.TabIndex = 4;
            // 
            // Col_PlanNo
            // 
            this.Col_PlanNo.Frozen = true;
            this.Col_PlanNo.HeaderText = "계획번호";
            this.Col_PlanNo.Name = "Col_PlanNo";
            this.Col_PlanNo.ReadOnly = true;
            // 
            // Col_CustCode
            // 
            this.Col_CustCode.Frozen = true;
            this.Col_CustCode.HeaderText = "수주처 코드";
            this.Col_CustCode.Name = "Col_CustCode";
            this.Col_CustCode.ReadOnly = true;
            // 
            // Col_CustName
            // 
            this.Col_CustName.Frozen = true;
            this.Col_CustName.HeaderText = "수주처";
            this.Col_CustName.Name = "Col_CustName";
            this.Col_CustName.ReadOnly = true;
            // 
            // Col_ProductCode_MPM
            // 
            this.Col_ProductCode_MPM.Frozen = true;
            this.Col_ProductCode_MPM.HeaderText = "제품코드";
            this.Col_ProductCode_MPM.Name = "Col_ProductCode_MPM";
            this.Col_ProductCode_MPM.ReadOnly = true;
            // 
            // Col_ProductName_MPM
            // 
            this.Col_ProductName_MPM.Frozen = true;
            this.Col_ProductName_MPM.HeaderText = "제품명";
            this.Col_ProductName_MPM.Name = "Col_ProductName_MPM";
            this.Col_ProductName_MPM.ReadOnly = true;
            // 
            // Col_ProductAlias_MPM
            // 
            this.Col_ProductAlias_MPM.Frozen = true;
            this.Col_ProductAlias_MPM.HeaderText = "제품번";
            this.Col_ProductAlias_MPM.Name = "Col_ProductAlias_MPM";
            this.Col_ProductAlias_MPM.ReadOnly = true;
            // 
            // Col_PlanQty
            // 
            this.Col_PlanQty.Frozen = true;
            this.Col_PlanQty.HeaderText = "계획수량";
            this.Col_PlanQty.Name = "Col_PlanQty";
            this.Col_PlanQty.ReadOnly = true;
            // 
            // Col_UnitNmae_MPM
            // 
            this.Col_UnitNmae_MPM.Frozen = true;
            this.Col_UnitNmae_MPM.HeaderText = "단위";
            this.Col_UnitNmae_MPM.Name = "Col_UnitNmae_MPM";
            this.Col_UnitNmae_MPM.ReadOnly = true;
            // 
            // Col_PlanStartDate
            // 
            this.Col_PlanStartDate.Frozen = true;
            this.Col_PlanStartDate.HeaderText = "수주일자";
            this.Col_PlanStartDate.Name = "Col_PlanStartDate";
            this.Col_PlanStartDate.ReadOnly = true;
            // 
            // Col_Remark_SO
            // 
            this.Col_Remark_SO.Frozen = true;
            this.Col_Remark_SO.HeaderText = "비고";
            this.Col_Remark_SO.Name = "Col_Remark_SO";
            this.Col_Remark_SO.ReadOnly = true;
            // 
            // Col_PlanStatus_MPM
            // 
            this.Col_PlanStatus_MPM.Frozen = true;
            this.Col_PlanStatus_MPM.HeaderText = "진행상태";
            this.Col_PlanStatus_MPM.Name = "Col_PlanStatus_MPM";
            this.Col_PlanStatus_MPM.ReadOnly = true;
            // 
            // Frm_Product_WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Product_WorkOrder";
            this.Text = "작업지시";
            this.TableLayoutMain.ResumeLayout(false);
            this.TableLayoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrder)).EndInit();
            this.Pnl_SearchMain.ResumeLayout(false);
            this.Pnl_Search1.ResumeLayout(false);
            this.Pnl_Search0.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.DataGridView gvWorkOrder;
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
        private System.Windows.Forms.Button Btn_Order;
        private System.Windows.Forms.DataGridView gvWorkPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProcessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode_WO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias_WO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Unit_WO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_WO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductCode_MPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName_MPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductAlias_MPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_UnitNmae_MPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PlanStatus_MPM;
    }
}