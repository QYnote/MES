
namespace Project_MES.View._00_Basic
{
    partial class Frm_Info_Process
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
            this.GvLine = new System.Windows.Forms.DataGridView();
            this.Col_LineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark_Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save_Process = new System.Windows.Forms.Button();
            this.Btn_Delete_Process = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_Search = new System.Windows.Forms.Panel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Pnl_Contents1 = new System.Windows.Forms.Panel();
            this.Btn_Delete_Line = new System.Windows.Forms.Button();
            this.Btn_Save_Line = new System.Windows.Forms.Button();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.GvProcess = new System.Windows.Forms.DataGridView();
            this.Col_ProcessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProcessType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProcessRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pnl_Search.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            this.Pnl_Contents1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 2;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.19239F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.80761F));
            this.TableLayoutMain.Controls.Add(this.GvLine, 1, 3);
            this.TableLayoutMain.Controls.Add(this.panel1, 0, 2);
            this.TableLayoutMain.Controls.Add(this.Pnl_Search, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.Pnl_Contents1, 1, 2);
            this.TableLayoutMain.Controls.Add(this.GvProcess, 0, 3);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 4;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Size = new System.Drawing.Size(998, 642);
            this.TableLayoutMain.TabIndex = 6;
            // 
            // GvLine
            // 
            this.GvLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_LineCode,
            this.Col_LineName,
            this.Col_Remark_Line});
            this.GvLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvLine.Location = new System.Drawing.Point(464, 126);
            this.GvLine.Name = "GvLine";
            this.GvLine.ReadOnly = true;
            this.GvLine.RowTemplate.Height = 23;
            this.GvLine.Size = new System.Drawing.Size(531, 513);
            this.GvLine.TabIndex = 9;
            // 
            // Col_LineCode
            // 
            this.Col_LineCode.HeaderText = "라인코드";
            this.Col_LineCode.Name = "Col_LineCode";
            this.Col_LineCode.ReadOnly = true;
            // 
            // Col_LineName
            // 
            this.Col_LineName.HeaderText = "라인명";
            this.Col_LineName.Name = "Col_LineName";
            this.Col_LineName.ReadOnly = true;
            // 
            // Col_Remark_Line
            // 
            this.Col_Remark_Line.HeaderText = "비고";
            this.Col_Remark_Line.Name = "Col_Remark_Line";
            this.Col_Remark_Line.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Save_Process);
            this.panel1.Controls.Add(this.Btn_Delete_Process);
            this.panel1.Controls.Add(this.Lbl_Contents0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 44);
            this.panel1.TabIndex = 8;
            // 
            // Btn_Save_Process
            // 
            this.Btn_Save_Process.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save_Process.Location = new System.Drawing.Point(311, 0);
            this.Btn_Save_Process.Name = "Btn_Save_Process";
            this.Btn_Save_Process.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save_Process.TabIndex = 3;
            this.Btn_Save_Process.Text = "Btn_Save_Process";
            this.Btn_Save_Process.UseVisualStyleBackColor = true;
            this.Btn_Save_Process.Click += new System.EventHandler(this.Btn_Save_Process_Click);
            // 
            // Btn_Delete_Process
            // 
            this.Btn_Delete_Process.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete_Process.Location = new System.Drawing.Point(386, 0);
            this.Btn_Delete_Process.Name = "Btn_Delete_Process";
            this.Btn_Delete_Process.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete_Process.TabIndex = 2;
            this.Btn_Delete_Process.Text = "Btn_Delete_Process";
            this.Btn_Delete_Process.UseVisualStyleBackColor = true;
            this.Btn_Delete_Process.Click += new System.EventHandler(this.Btn_Delete_Process_Click);
            // 
            // Lbl_Contents0
            // 
            this.Lbl_Contents0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents0.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents0.Name = "Lbl_Contents0";
            this.Lbl_Contents0.Size = new System.Drawing.Size(461, 44);
            this.Lbl_Contents0.TabIndex = 1;
            this.Lbl_Contents0.Text = "Lbl_CustInfo";
            this.Lbl_Contents0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl_Search
            // 
            this.TableLayoutMain.SetColumnSpan(this.Pnl_Search, 2);
            this.Pnl_Search.Controls.Add(this.Btn_Search);
            this.Pnl_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Search.Location = new System.Drawing.Point(0, 50);
            this.Pnl_Search.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_Search.Name = "Pnl_Search";
            this.Pnl_Search.Size = new System.Drawing.Size(998, 29);
            this.Pnl_Search.TabIndex = 7;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Search.Location = new System.Drawing.Point(923, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 29);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Btn_Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
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
            // Pnl_Contents1
            // 
            this.Pnl_Contents1.Controls.Add(this.Btn_Delete_Line);
            this.Pnl_Contents1.Controls.Add(this.Btn_Save_Line);
            this.Pnl_Contents1.Controls.Add(this.Lbl_Contents1);
            this.Pnl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents1.Location = new System.Drawing.Point(461, 79);
            this.Pnl_Contents1.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_Contents1.Name = "Pnl_Contents1";
            this.Pnl_Contents1.Size = new System.Drawing.Size(537, 44);
            this.Pnl_Contents1.TabIndex = 6;
            // 
            // Btn_Delete_Line
            // 
            this.Btn_Delete_Line.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete_Line.Location = new System.Drawing.Point(387, 0);
            this.Btn_Delete_Line.Name = "Btn_Delete_Line";
            this.Btn_Delete_Line.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete_Line.TabIndex = 4;
            this.Btn_Delete_Line.Text = "Btn_Delete_Line";
            this.Btn_Delete_Line.UseVisualStyleBackColor = true;
            // 
            // Btn_Save_Line
            // 
            this.Btn_Save_Line.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save_Line.Location = new System.Drawing.Point(462, 0);
            this.Btn_Save_Line.Name = "Btn_Save_Line";
            this.Btn_Save_Line.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save_Line.TabIndex = 3;
            this.Btn_Save_Line.Text = "Btn_Save_Line";
            this.Btn_Save_Line.UseVisualStyleBackColor = true;
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(537, 44);
            this.Lbl_Contents1.TabIndex = 1;
            this.Lbl_Contents1.Text = "Lbl_CustDetail";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GvProcess
            // 
            this.GvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ProcessCode,
            this.Col_ProcessType,
            this.Col_ProcessName,
            this.Col_ProcessRemark});
            this.GvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvProcess.Location = new System.Drawing.Point(3, 126);
            this.GvProcess.Name = "GvProcess";
            this.GvProcess.RowTemplate.Height = 23;
            this.GvProcess.Size = new System.Drawing.Size(455, 513);
            this.GvProcess.TabIndex = 5;
            this.GvProcess.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvProcess_CellValueChanged);
            this.GvProcess.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvProcess_RowEnter);
            // 
            // Col_ProcessCode
            // 
            this.Col_ProcessCode.HeaderText = "공정코드";
            this.Col_ProcessCode.Name = "Col_ProcessCode";
            this.Col_ProcessCode.ReadOnly = true;
            // 
            // Col_ProcessType
            // 
            this.Col_ProcessType.HeaderText = "공정타입";
            this.Col_ProcessType.Name = "Col_ProcessType";
            this.Col_ProcessType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_ProcessType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_ProcessName
            // 
            this.Col_ProcessName.HeaderText = "공정명";
            this.Col_ProcessName.Name = "Col_ProcessName";
            // 
            // Col_ProcessRemark
            // 
            this.Col_ProcessRemark.HeaderText = "비고";
            this.Col_ProcessRemark.Name = "Col_ProcessRemark";
            // 
            // Frm_Info_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Info_Process";
            this.Text = "Frm_Info_Process";
            this.Load += new System.EventHandler(this.Frm_Info_Process_Load);
            this.TableLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvLine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Pnl_Search.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            this.Pnl_Contents1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Save_Process;
        private System.Windows.Forms.Button Btn_Delete_Process;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Button Btn_Save_Line;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.DataGridView GvProcess;
        private System.Windows.Forms.DataGridView GvLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark_Line;
        private System.Windows.Forms.Button Btn_Delete_Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProcessCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_ProcessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProcessRemark;
    }
}