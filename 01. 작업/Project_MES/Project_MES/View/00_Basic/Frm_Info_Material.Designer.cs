
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
            this.Lbl_Contents0 = new System.Windows.Forms.Label();
            this.Pnl_Search = new System.Windows.Forms.Panel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Pnl_MailTitle = new System.Windows.Forms.Panel();
            this.Lbl_MailTitle = new System.Windows.Forms.Label();
            this.Pnl_Contents1 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_Contents1 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.gvMaterial = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uc_LblCbo_Unit = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblTxt_Alias = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_MaterialCode = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblCbo_Cust = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblCbo_MaterialType = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblTxt_MaterialName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Spec = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Remark = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Col_MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaterialType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cust = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TableLayoutMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Search.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            this.Pnl_Contents1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
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
            this.TableLayoutMain.Controls.Add(this.gvMaterial, 0, 3);
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
            this.Btn_Create.Location = new System.Drawing.Point(386, 0);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 44);
            this.Btn_Create.TabIndex = 3;
            this.Btn_Create.Text = "Btn_Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
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
            this.Pnl_Contents1.Controls.Add(this.Btn_Delete);
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
            this.Btn_Save.Location = new System.Drawing.Point(387, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 44);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Contents1
            // 
            this.Lbl_Contents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Contents1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contents1.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Contents1.Name = "Lbl_Contents1";
            this.Lbl_Contents1.Size = new System.Drawing.Size(462, 44);
            this.Lbl_Contents1.TabIndex = 1;
            this.Lbl_Contents1.Text = "Lbl_CustDetail";
            this.Lbl_Contents1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Location = new System.Drawing.Point(462, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 44);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Btn_Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // gvMaterial
            // 
            this.gvMaterial.AllowUserToAddRows = false;
            this.gvMaterial.AllowUserToDeleteRows = false;
            this.gvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaterialCode,
            this.Col_MaterialType,
            this.Col_MaterialName,
            this.Col_Alias,
            this.Col_Cust,
            this.Col_Unit});
            this.gvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMaterial.Location = new System.Drawing.Point(3, 126);
            this.gvMaterial.MultiSelect = false;
            this.gvMaterial.Name = "gvMaterial";
            this.gvMaterial.ReadOnly = true;
            this.gvMaterial.RowTemplate.Height = 23;
            this.gvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMaterial.Size = new System.Drawing.Size(455, 513);
            this.gvMaterial.TabIndex = 5;
            this.gvMaterial.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMaterial_RowEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo_Unit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Alias, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_MaterialCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo_Cust, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo_MaterialType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_MaterialName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Spec, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Remark, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(461, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 175);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // uc_LblCbo_Unit
            // 
            this.uc_LblCbo_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo_Unit.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_Unit.CboWdith = 150;
            this.uc_LblCbo_Unit.LblText = "단위";
            this.uc_LblCbo_Unit.LblWidth = 100;
            this.uc_LblCbo_Unit.Location = new System.Drawing.Point(271, 108);
            this.uc_LblCbo_Unit.Name = "uc_LblCbo_Unit";
            this.uc_LblCbo_Unit.Size = new System.Drawing.Size(263, 29);
            this.uc_LblCbo_Unit.TabIndex = 11;
            // 
            // uc_LblTxt_Alias
            // 
            this.uc_LblTxt_Alias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Alias.DisplayText = "Default Text";
            this.uc_LblTxt_Alias.LblText = "자재번호";
            this.uc_LblTxt_Alias.LblWidth = 100;
            this.uc_LblTxt_Alias.Location = new System.Drawing.Point(3, 73);
            this.uc_LblTxt_Alias.Name = "uc_LblTxt_Alias";
            this.uc_LblTxt_Alias.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_Alias.TabIndex = 5;
            this.uc_LblTxt_Alias.TxtWdith = 150;
            // 
            // uc_LblTxt_MaterialCode
            // 
            this.uc_LblTxt_MaterialCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_MaterialCode.DisplayText = "Default Text";
            this.uc_LblTxt_MaterialCode.Enabled = false;
            this.uc_LblTxt_MaterialCode.LblText = "자재코드";
            this.uc_LblTxt_MaterialCode.LblWidth = 100;
            this.uc_LblTxt_MaterialCode.Location = new System.Drawing.Point(3, 3);
            this.uc_LblTxt_MaterialCode.Name = "uc_LblTxt_MaterialCode";
            this.uc_LblTxt_MaterialCode.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_MaterialCode.TabIndex = 0;
            this.uc_LblTxt_MaterialCode.TxtWdith = 150;
            // 
            // uc_LblCbo_Cust
            // 
            this.uc_LblCbo_Cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo_Cust.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_Cust.CboWdith = 150;
            this.uc_LblCbo_Cust.LblText = "거래처";
            this.uc_LblCbo_Cust.LblWidth = 100;
            this.uc_LblCbo_Cust.Location = new System.Drawing.Point(271, 38);
            this.uc_LblCbo_Cust.Name = "uc_LblCbo_Cust";
            this.uc_LblCbo_Cust.Size = new System.Drawing.Size(263, 29);
            this.uc_LblCbo_Cust.TabIndex = 13;
            // 
            // uc_LblCbo_MaterialType
            // 
            this.uc_LblCbo_MaterialType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblCbo_MaterialType.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_MaterialType.CboWdith = 150;
            this.uc_LblCbo_MaterialType.LblText = "자재타입";
            this.uc_LblCbo_MaterialType.LblWidth = 100;
            this.uc_LblCbo_MaterialType.Location = new System.Drawing.Point(271, 3);
            this.uc_LblCbo_MaterialType.Name = "uc_LblCbo_MaterialType";
            this.uc_LblCbo_MaterialType.Size = new System.Drawing.Size(263, 29);
            this.uc_LblCbo_MaterialType.TabIndex = 1;
            // 
            // uc_LblTxt_MaterialName
            // 
            this.uc_LblTxt_MaterialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_MaterialName.DisplayText = "Default Text";
            this.uc_LblTxt_MaterialName.LblText = "자재명";
            this.uc_LblTxt_MaterialName.LblWidth = 100;
            this.uc_LblTxt_MaterialName.Location = new System.Drawing.Point(3, 38);
            this.uc_LblTxt_MaterialName.Name = "uc_LblTxt_MaterialName";
            this.uc_LblTxt_MaterialName.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_MaterialName.TabIndex = 2;
            this.uc_LblTxt_MaterialName.TxtWdith = 150;
            // 
            // uc_LblTxt_Spec
            // 
            this.uc_LblTxt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Spec.DisplayText = "Default Text";
            this.uc_LblTxt_Spec.LblText = "스펙";
            this.uc_LblTxt_Spec.LblWidth = 100;
            this.uc_LblTxt_Spec.Location = new System.Drawing.Point(3, 108);
            this.uc_LblTxt_Spec.Name = "uc_LblTxt_Spec";
            this.uc_LblTxt_Spec.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_Spec.TabIndex = 5;
            this.uc_LblTxt_Spec.TxtWdith = 150;
            // 
            // uc_LblTxt_Remark
            // 
            this.uc_LblTxt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_LblTxt_Remark, 2);
            this.uc_LblTxt_Remark.DisplayText = "Default Text";
            this.uc_LblTxt_Remark.LblText = "비고";
            this.uc_LblTxt_Remark.LblWidth = 100;
            this.uc_LblTxt_Remark.Location = new System.Drawing.Point(3, 143);
            this.uc_LblTxt_Remark.Name = "uc_LblTxt_Remark";
            this.uc_LblTxt_Remark.Size = new System.Drawing.Size(531, 29);
            this.uc_LblTxt_Remark.TabIndex = 8;
            this.uc_LblTxt_Remark.TxtWdith = 417;
            // 
            // Col_MaterialCode
            // 
            this.Col_MaterialCode.HeaderText = "자재 코드";
            this.Col_MaterialCode.Name = "Col_MaterialCode";
            this.Col_MaterialCode.ReadOnly = true;
            // 
            // Col_MaterialType
            // 
            this.Col_MaterialType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_MaterialType.HeaderText = "자재타입";
            this.Col_MaterialType.Name = "Col_MaterialType";
            this.Col_MaterialType.ReadOnly = true;
            this.Col_MaterialType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_MaterialType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_MaterialName
            // 
            this.Col_MaterialName.HeaderText = "자재명";
            this.Col_MaterialName.Name = "Col_MaterialName";
            this.Col_MaterialName.ReadOnly = true;
            // 
            // Col_Alias
            // 
            this.Col_Alias.HeaderText = "자재번호";
            this.Col_Alias.Name = "Col_Alias";
            this.Col_Alias.ReadOnly = true;
            // 
            // Col_Cust
            // 
            this.Col_Cust.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_Cust.HeaderText = "거래처";
            this.Col_Cust.Name = "Col_Cust";
            this.Col_Cust.ReadOnly = true;
            this.Col_Cust.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Cust.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // Frm_Info_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Info_Material";
            this.Text = "자재정보 관리";
            this.Load += new System.EventHandler(this.Frm_Info_Material_Load);
            this.TableLayoutMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Pnl_Search.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            this.Pnl_Contents1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.DataGridView gvMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_MaterialCode;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_MaterialType;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_MaterialName;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Spec;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Remark;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_Unit;
        private System.Windows.Forms.Button Btn_Delete;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Alias;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_MaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Alias;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Cust;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Unit;
    }
}