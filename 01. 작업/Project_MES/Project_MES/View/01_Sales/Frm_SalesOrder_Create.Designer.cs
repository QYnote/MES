
namespace Project_MES.View._01_Sales
{
    partial class Frm_SalesOrder_Create
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
            this.Pnl_SalesOrderDetail = new System.Windows.Forms.Panel();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_SalesOrderMaster = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uc_LblTxt1 = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblDtp_EndDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.uc_LblDtp_OrderDate = new Project_MES.Control.CustomUc.Common.Uc_LblDtp();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_LblCbo_OrderOutCust = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblCbo_OrderCust = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblTxt_OrderNo = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Pnl_Contents.SuspendLayout();
            this.Pnl_SalesOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Pnl_MailTitle.SuspendLayout();
            this.Pnl_SalesOrderMaster.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Contents
            // 
            this.Pnl_Contents.ColumnCount = 1;
            this.Pnl_Contents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Pnl_Contents.Controls.Add(this.Pnl_SalesOrderDetail, 0, 3);
            this.Pnl_Contents.Controls.Add(this.dataGridView2, 0, 4);
            this.Pnl_Contents.Controls.Add(this.Lbl_Contents0, 0, 1);
            this.Pnl_Contents.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.Pnl_Contents.Controls.Add(this.Pnl_SalesOrderMaster, 0, 2);
            this.Pnl_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Contents.Name = "Pnl_Contents";
            this.Pnl_Contents.RowCount = 5;
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.Pnl_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Pnl_Contents.Size = new System.Drawing.Size(998, 642);
            this.Pnl_Contents.TabIndex = 0;
            // 
            // Pnl_SalesOrderDetail
            // 
            this.Pnl_SalesOrderDetail.Controls.Add(this.Lbl_Contents1);
            this.Pnl_SalesOrderDetail.Controls.Add(this.Btn_Delete);
            this.Pnl_SalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_SalesOrderDetail.Location = new System.Drawing.Point(0, 152);
            this.Pnl_SalesOrderDetail.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_SalesOrderDetail.Name = "Pnl_SalesOrderDetail";
            this.Pnl_SalesOrderDetail.Size = new System.Drawing.Size(998, 44);
            this.Pnl_SalesOrderDetail.TabIndex = 10;
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(923, 44);
            this.Lbl_Contents1.TabIndex = 0;
            this.Lbl_Contents1.Text = "Lbl_SalesOrderDetail";
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 199);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(992, 440);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "순번";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "제품코드";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "제품명";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "제품번호";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Spec";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "수량";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "단위";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "비고";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
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
            this.Lbl_Contents0.Text = "Lbl_SalesOrderMaster";
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
            // Pnl_SalesOrderMaster
            // 
            this.Pnl_SalesOrderMaster.Controls.Add(this.panel3);
            this.Pnl_SalesOrderMaster.Controls.Add(this.panel2);
            this.Pnl_SalesOrderMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_SalesOrderMaster.Location = new System.Drawing.Point(0, 94);
            this.Pnl_SalesOrderMaster.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_SalesOrderMaster.Name = "Pnl_SalesOrderMaster";
            this.Pnl_SalesOrderMaster.Size = new System.Drawing.Size(998, 58);
            this.Pnl_SalesOrderMaster.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uc_LblTxt1);
            this.panel3.Controls.Add(this.uc_LblDtp_EndDate);
            this.panel3.Controls.Add(this.uc_LblDtp_OrderDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 29);
            this.panel3.TabIndex = 4;
            // 
            // uc_LblTxt1
            // 
            this.uc_LblTxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt1.DisplayText = "Txt 기본 Text";
            this.uc_LblTxt1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblTxt1.LblText = "비고";
            this.uc_LblTxt1.LblWidth = 100;
            this.uc_LblTxt1.Location = new System.Drawing.Point(552, 0);
            this.uc_LblTxt1.Name = "uc_LblTxt1";
            this.uc_LblTxt1.Size = new System.Drawing.Size(314, 29);
            this.uc_LblTxt1.TabIndex = 3;
            this.uc_LblTxt1.TxtWdith = 200;
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
            this.uc_LblDtp_EndDate.Location = new System.Drawing.Point(338, 0);
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
            this.uc_LblDtp_OrderDate.DtpRange = true;
            this.uc_LblDtp_OrderDate.LblText = "수주일자";
            this.uc_LblDtp_OrderDate.LblWidth = 100;
            this.uc_LblDtp_OrderDate.Location = new System.Drawing.Point(0, 0);
            this.uc_LblDtp_OrderDate.Name = "uc_LblDtp_OrderDate";
            this.uc_LblDtp_OrderDate.Size = new System.Drawing.Size(338, 29);
            this.uc_LblDtp_OrderDate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_LblCbo_OrderOutCust);
            this.panel2.Controls.Add(this.uc_LblCbo_OrderCust);
            this.panel2.Controls.Add(this.uc_LblTxt_OrderNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 29);
            this.panel2.TabIndex = 3;
            // 
            // uc_LblCbo_OrderOutCust
            // 
            this.uc_LblCbo_OrderOutCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo_OrderOutCust.CboDataSource = null;
            this.uc_LblCbo_OrderOutCust.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_OrderOutCust.CboWdith = 150;
            this.uc_LblCbo_OrderOutCust.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_LblCbo_OrderOutCust.LblText = "납품 거래처";
            this.uc_LblCbo_OrderOutCust.LblWidth = 100;
            this.uc_LblCbo_OrderOutCust.Location = new System.Drawing.Point(528, 0);
            this.uc_LblCbo_OrderOutCust.Name = "uc_LblCbo_OrderOutCust";
            this.uc_LblCbo_OrderOutCust.Size = new System.Drawing.Size(264, 29);
            this.uc_LblCbo_OrderOutCust.TabIndex = 2;
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
            // Frm_SalesOrder_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.Pnl_Contents);
            this.Name = "Frm_SalesOrder_Create";
            this.Text = "Frm_Sales_Order";
            this.Pnl_Contents.ResumeLayout(false);
            this.Pnl_Contents.PerformLayout();
            this.Pnl_SalesOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Pnl_MailTitle.ResumeLayout(false);
            this.Pnl_SalesOrderMaster.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Pnl_Contents;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel Pnl_SalesOrderDetail;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Panel Pnl_SalesOrderMaster;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_OrderNo;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_OrderCust;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_OrderOutCust;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_EndDate;
        private Control.CustomUc.Common.Uc_LblDtp uc_LblDtp_OrderDate;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt1;
    }
}