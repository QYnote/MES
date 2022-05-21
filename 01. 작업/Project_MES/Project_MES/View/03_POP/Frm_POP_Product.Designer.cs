
namespace Project_MES.View._03_POP
{
    partial class Frm_POP_Product
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Process = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.gvWorkOrderReady = new System.Windows.Forms.DataGridView();
            this.Col_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrderReady)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("굴림", 20F);
            this.tabControl1.Location = new System.Drawing.Point(12, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvWorkOrderReady);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "대기내역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "진행내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(966, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "완료내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "생산계획일";
            // 
            // Dtp_StartDate
            // 
            this.Dtp_StartDate.Font = new System.Drawing.Font("굴림", 20F);
            this.Dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_StartDate.Location = new System.Drawing.Point(156, 8);
            this.Dtp_StartDate.Name = "Dtp_StartDate";
            this.Dtp_StartDate.Size = new System.Drawing.Size(200, 38);
            this.Dtp_StartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(362, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // Dtp_EndDate
            // 
            this.Dtp_EndDate.Font = new System.Drawing.Font("굴림", 20F);
            this.Dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_EndDate.Location = new System.Drawing.Point(401, 8);
            this.Dtp_EndDate.Name = "Dtp_EndDate";
            this.Dtp_EndDate.Size = new System.Drawing.Size(200, 38);
            this.Dtp_EndDate.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Dtp_EndDate);
            this.panel1.Controls.Add(this.Dtp_StartDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 54);
            this.panel1.TabIndex = 5;
            // 
            // Btn_Process
            // 
            this.Btn_Process.Font = new System.Drawing.Font("굴림", 30F);
            this.Btn_Process.Location = new System.Drawing.Point(771, 532);
            this.Btn_Process.Name = "Btn_Process";
            this.Btn_Process.Size = new System.Drawing.Size(211, 98);
            this.Btn_Process.TabIndex = 6;
            this.Btn_Process.Text = "button1";
            this.Btn_Process.UseVisualStyleBackColor = true;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(854, 3);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(116, 48);
            this.Btn_Search.TabIndex = 7;
            this.Btn_Search.Text = "button1";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_MailTitle);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 50);
            this.panel2.TabIndex = 8;
            // 
            // Lbl_MailTitle
            // 
            this.Lbl_MailTitle.AutoSize = true;
            this.Lbl_MailTitle.Font = new System.Drawing.Font("굴림", 30F);
            this.Lbl_MailTitle.Location = new System.Drawing.Point(3, 5);
            this.Lbl_MailTitle.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_MailTitle.Name = "Lbl_MailTitle";
            this.Lbl_MailTitle.Size = new System.Drawing.Size(200, 40);
            this.Lbl_MailTitle.TabIndex = 1;
            this.Lbl_MailTitle.Text = "생산공정1";
            // 
            // gvWorkOrderReady
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWorkOrderReady.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvWorkOrderReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWorkOrderReady.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_OrderNo,
            this.Col_Customer,
            this.Col_MaterialCode,
            this.Col_MaterialName,
            this.Col_OrderQty,
            this.Col_Remark});
            this.gvWorkOrderReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWorkOrderReady.Location = new System.Drawing.Point(3, 3);
            this.gvWorkOrderReady.Name = "gvWorkOrderReady";
            this.gvWorkOrderReady.RowTemplate.Height = 23;
            this.gvWorkOrderReady.Size = new System.Drawing.Size(960, 351);
            this.gvWorkOrderReady.TabIndex = 0;
            // 
            // Col_OrderNo
            // 
            this.Col_OrderNo.HeaderText = "작업지시번호";
            this.Col_OrderNo.Name = "Col_OrderNo";
            // 
            // Col_Customer
            // 
            this.Col_Customer.HeaderText = "거래처";
            this.Col_Customer.Name = "Col_Customer";
            // 
            // Col_MaterialCode
            // 
            this.Col_MaterialCode.HeaderText = "자재코드";
            this.Col_MaterialCode.Name = "Col_MaterialCode";
            // 
            // Col_MaterialName
            // 
            this.Col_MaterialName.HeaderText = "자재명";
            this.Col_MaterialName.Name = "Col_MaterialName";
            // 
            // Col_OrderQty
            // 
            this.Col_OrderQty.HeaderText = "지시수량";
            this.Col_OrderQty.Name = "Col_OrderQty";
            // 
            // Col_Remark
            // 
            this.Col_Remark.HeaderText = "비고";
            this.Col_Remark.Name = "Col_Remark";
            // 
            // Frm_POP_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Process);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_POP_Product";
            this.Text = "Frm_POP_Product0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrderReady)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_EndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Process;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.DataGridView gvWorkOrderReady;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark;
    }
}