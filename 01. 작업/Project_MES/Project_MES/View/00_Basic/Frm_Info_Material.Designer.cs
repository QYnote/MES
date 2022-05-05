
namespace Project_MES.View._00_Basic
{
    partial class Frm_Info_Material
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_Search = new System.Windows.Forms.Panel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Pnl_Contents1 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.gvPlanMaster = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uc_LblTxt_CustCode = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblCbo_CustType = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Presi = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Post = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Fax = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblCbo1 = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblCbo2 = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.Col_MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Search.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            this.Pnl_Contents1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 2;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.19239F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.80761F));
            this.TableLayoutMain.Controls.Add(this.panel1, 0, 2);
            this.TableLayoutMain.Controls.Add(this.Pnl_Search, 0, 1);
            this.TableLayoutMain.Controls.Add(this.Pnl_MailTitle, 0, 0);
            this.TableLayoutMain.Controls.Add(this.Pnl_Contents1, 1, 2);
            this.TableLayoutMain.Controls.Add(this.gvPlanMaster, 0, 3);
            this.TableLayoutMain.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 4;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Size = new System.Drawing.Size(998, 642);
            this.TableLayoutMain.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Create);
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Lbl_Contents0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 44);
            this.panel1.TabIndex = 8;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Create.Location = new System.Drawing.Point(311, 0);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 44);
            this.Btn_Create.TabIndex = 3;
            this.Btn_Create.Text = "Btn_Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Location = new System.Drawing.Point(386, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "Btn_Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
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
            this.Pnl_Contents1.Controls.Add(this.Btn_Save);
            this.Pnl_Contents1.Controls.Add(this.Lbl_Contents1);
            this.Pnl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contents1.Location = new System.Drawing.Point(461, 79);
            this.Pnl_Contents1.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_Contents1.Name = "Pnl_Contents1";
            this.Pnl_Contents1.Size = new System.Drawing.Size(537, 44);
            this.Pnl_Contents1.TabIndex = 6;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save.Location = new System.Drawing.Point(462, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
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
            // gvPlanMaster
            // 
            this.gvPlanMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlanMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaterialCode,
            this.Col_MaterialType,
            this.Col_Cust,
            this.Col_MaterialName,
            this.Col_Alias,
            this.Col_Unit});
            this.gvPlanMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPlanMaster.Location = new System.Drawing.Point(3, 126);
            this.gvPlanMaster.Name = "gvPlanMaster";
            this.gvPlanMaster.ReadOnly = true;
            this.gvPlanMaster.RowTemplate.Height = 23;
            this.gvPlanMaster.Size = new System.Drawing.Size(455, 513);
            this.gvPlanMaster.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_CustCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo_CustType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_CustName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Presi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Post, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Fax, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(461, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 140);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // uc_LblTxt_CustCode
            // 
            this.uc_LblTxt_CustCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_CustCode.DisplayText = "Default Text";
            this.uc_LblTxt_CustCode.LblText = "자재코드";
            this.uc_LblTxt_CustCode.LblWidth = 100;
            this.uc_LblTxt_CustCode.Location = new System.Drawing.Point(3, 3);
            this.uc_LblTxt_CustCode.Name = "uc_LblTxt_CustCode";
            this.uc_LblTxt_CustCode.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_CustCode.TabIndex = 0;
            this.uc_LblTxt_CustCode.TxtWdith = 150;
            // 
            // uc_LblCbo_CustType
            // 
            this.uc_LblCbo_CustType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo_CustType.CboDataSource = null;
            this.uc_LblCbo_CustType.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_CustType.CboWdith = 150;
            this.uc_LblCbo_CustType.LblText = "자재타입";
            this.uc_LblCbo_CustType.LblWidth = 100;
            this.uc_LblCbo_CustType.Location = new System.Drawing.Point(271, 3);
            this.uc_LblCbo_CustType.Name = "uc_LblCbo_CustType";
            this.uc_LblCbo_CustType.Size = new System.Drawing.Size(263, 29);
            this.uc_LblCbo_CustType.TabIndex = 1;
            // 
            // uc_LblTxt_CustName
            // 
            this.uc_LblTxt_CustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_CustName.DisplayText = "Default Text";
            this.uc_LblTxt_CustName.LblText = "자재명";
            this.uc_LblTxt_CustName.LblWidth = 100;
            this.uc_LblTxt_CustName.Location = new System.Drawing.Point(3, 38);
            this.uc_LblTxt_CustName.Name = "uc_LblTxt_CustName";
            this.uc_LblTxt_CustName.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_CustName.TabIndex = 2;
            this.uc_LblTxt_CustName.TxtWdith = 150;
            // 
            // uc_LblTxt_Presi
            // 
            this.uc_LblTxt_Presi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Presi.DisplayText = "Default Text";
            this.uc_LblTxt_Presi.LblText = "자재번호";
            this.uc_LblTxt_Presi.LblWidth = 100;
            this.uc_LblTxt_Presi.Location = new System.Drawing.Point(271, 38);
            this.uc_LblTxt_Presi.Name = "uc_LblTxt_Presi";
            this.uc_LblTxt_Presi.Size = new System.Drawing.Size(263, 29);
            this.uc_LblTxt_Presi.TabIndex = 3;
            this.uc_LblTxt_Presi.TxtWdith = 150;
            // 
            // uc_LblTxt_Post
            // 
            this.uc_LblTxt_Post.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Post.DisplayText = "Default Text";
            this.uc_LblTxt_Post.LblText = "스펙";
            this.uc_LblTxt_Post.LblWidth = 100;
            this.uc_LblTxt_Post.Location = new System.Drawing.Point(3, 73);
            this.uc_LblTxt_Post.Name = "uc_LblTxt_Post";
            this.uc_LblTxt_Post.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_Post.TabIndex = 5;
            this.uc_LblTxt_Post.TxtWdith = 150;
            // 
            // uc_LblTxt_Fax
            // 
            this.uc_LblTxt_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Fax.DisplayText = "Default Text";
            this.uc_LblTxt_Fax.LblText = "비고";
            this.uc_LblTxt_Fax.LblWidth = 100;
            this.uc_LblTxt_Fax.Location = new System.Drawing.Point(271, 108);
            this.uc_LblTxt_Fax.Name = "uc_LblTxt_Fax";
            this.uc_LblTxt_Fax.Size = new System.Drawing.Size(263, 29);
            this.uc_LblTxt_Fax.TabIndex = 8;
            this.uc_LblTxt_Fax.TxtWdith = 150;
            // 
            // uc_LblCbo1
            // 
            this.uc_LblCbo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo1.CboDataSource = null;
            this.uc_LblCbo1.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo1.CboWdith = 150;
            this.uc_LblCbo1.LblText = "단위";
            this.uc_LblCbo1.LblWidth = 100;
            this.uc_LblCbo1.Location = new System.Drawing.Point(271, 73);
            this.uc_LblCbo1.Name = "uc_LblCbo1";
            this.uc_LblCbo1.Size = new System.Drawing.Size(263, 29);
            this.uc_LblCbo1.TabIndex = 11;
            // 
            // uc_LblCbo2
            // 
            this.uc_LblCbo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo2.CboDataSource = null;
            this.uc_LblCbo2.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo2.CboWdith = 150;
            this.uc_LblCbo2.LblText = "거래처";
            this.uc_LblCbo2.LblWidth = 100;
            this.uc_LblCbo2.Location = new System.Drawing.Point(3, 108);
            this.uc_LblCbo2.Name = "uc_LblCbo2";
            this.uc_LblCbo2.Size = new System.Drawing.Size(262, 29);
            this.uc_LblCbo2.TabIndex = 12;
            // 
            // Col_MaterialCode
            // 
            this.Col_MaterialCode.HeaderText = "자재 코드";
            this.Col_MaterialCode.Name = "Col_MaterialCode";
            // 
            // Col_MaterialType
            // 
            this.Col_MaterialType.HeaderText = "자재타입";
            this.Col_MaterialType.Name = "Col_MaterialType";
            // 
            // Col_Cust
            // 
            this.Col_Cust.HeaderText = "거래처";
            this.Col_Cust.Name = "Col_Cust";
            // 
            // Col_MaterialName
            // 
            this.Col_MaterialName.HeaderText = "자재명";
            this.Col_MaterialName.Name = "Col_MaterialName";
            // 
            // Col_Alias
            // 
            this.Col_Alias.HeaderText = "자재번호";
            this.Col_Alias.Name = "Col_Alias";
            // 
            // Col_Unit
            // 
            this.Col_Unit.HeaderText = "단위";
            this.Col_Unit.Name = "Col_Unit";
            // 
            // Frm_Info_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Info_Material";
            this.Text = "자재정보 관리";
            this.TableLayoutMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Pnl_Search.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            this.Pnl_Contents1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanMaster)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.DataGridView gvPlanMaster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustCode;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_CustType;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustName;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Presi;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Post;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Fax;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo1;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Unit;
    }
}