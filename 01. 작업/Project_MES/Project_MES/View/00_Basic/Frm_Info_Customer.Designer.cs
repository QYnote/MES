
namespace Project_MES.View._00_Basic
{
    partial class Frm_Info_Customer
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
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uc_LblTxt_Remark = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_CustNo = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_CustCode = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblCbo_CustType = new Project_MES.Control.CustomUc.Common.Uc_LblCbo();
            this.uc_LblTxt_CustName = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Presi = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Cate = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Condition = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Tel = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Fax = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Post = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Email = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.uc_LblTxt_Adress = new Project_MES.Control.CustomUc.Common.Uc_LblTxt();
            this.Col_CustType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.TableLayoutMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Search.SuspendLayout();
            this.Pnl_MailTitle.SuspendLayout();
            this.Pnl_Contents1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
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
            this.TableLayoutMain.Controls.Add(this.gvCustomer, 0, 3);
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
            this.TableLayoutMain.TabIndex = 4;
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
            // gvCustomer
            // 
            this.gvCustomer.AllowUserToAddRows = false;
            this.gvCustomer.AllowUserToDeleteRows = false;
            this.gvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CustType,
            this.Col_CustName,
            this.Col_CustNo,
            this.Col_Address});
            this.gvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCustomer.Location = new System.Drawing.Point(3, 126);
            this.gvCustomer.MultiSelect = false;
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.ReadOnly = true;
            this.gvCustomer.RowTemplate.Height = 23;
            this.gvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCustomer.Size = new System.Drawing.Size(455, 513);
            this.gvCustomer.TabIndex = 5;
            this.gvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomer_RowEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Remark, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_CustNo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_CustCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblCbo_CustType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_CustName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Presi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Cate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Condition, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Tel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Fax, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Post, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Email, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.uc_LblTxt_Adress, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(461, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 280);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // uc_LblTxt_Remark
            // 
            this.uc_LblTxt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_LblTxt_Remark, 2);
            this.uc_LblTxt_Remark.DisplayText = "Default Text";
            this.uc_LblTxt_Remark.LblText = "비고";
            this.uc_LblTxt_Remark.LblWidth = 100;
            this.uc_LblTxt_Remark.Location = new System.Drawing.Point(3, 248);
            this.uc_LblTxt_Remark.Name = "uc_LblTxt_Remark";
            this.uc_LblTxt_Remark.Size = new System.Drawing.Size(531, 29);
            this.uc_LblTxt_Remark.TabIndex = 13;
            this.uc_LblTxt_Remark.TxtWdith = 418;
            // 
            // uc_LblTxt_CustNo
            // 
            this.uc_LblTxt_CustNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_CustNo.DisplayText = "Default Text";
            this.uc_LblTxt_CustNo.LblText = "사업자번호";
            this.uc_LblTxt_CustNo.LblWidth = 100;
            this.uc_LblTxt_CustNo.Location = new System.Drawing.Point(3, 73);
            this.uc_LblTxt_CustNo.Name = "uc_LblTxt_CustNo";
            this.uc_LblTxt_CustNo.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_CustNo.TabIndex = 12;
            this.uc_LblTxt_CustNo.TxtWdith = 150;
            // 
            // uc_LblTxt_CustCode
            // 
            this.uc_LblTxt_CustCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_CustCode.DisplayText = "Default Text";
            this.uc_LblTxt_CustCode.Enabled = false;
            this.uc_LblTxt_CustCode.LblText = "거래처코드";
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
            this.uc_LblCbo_CustType.CboDefaultText = "Cbo 기본 Text";
            this.uc_LblCbo_CustType.CboWdith = 150;
            this.uc_LblCbo_CustType.LblText = "거래처타입";
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
            this.uc_LblTxt_CustName.LblText = "거래처명";
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
            this.uc_LblTxt_Presi.LblText = "대표자명";
            this.uc_LblTxt_Presi.LblWidth = 100;
            this.uc_LblTxt_Presi.Location = new System.Drawing.Point(271, 38);
            this.uc_LblTxt_Presi.Name = "uc_LblTxt_Presi";
            this.uc_LblTxt_Presi.Size = new System.Drawing.Size(263, 29);
            this.uc_LblTxt_Presi.TabIndex = 3;
            this.uc_LblTxt_Presi.TxtWdith = 150;
            // 
            // uc_LblTxt_Cate
            // 
            this.uc_LblTxt_Cate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Cate.DisplayText = "Default Text";
            this.uc_LblTxt_Cate.LblText = "업종";
            this.uc_LblTxt_Cate.LblWidth = 100;
            this.uc_LblTxt_Cate.Location = new System.Drawing.Point(3, 213);
            this.uc_LblTxt_Cate.Name = "uc_LblTxt_Cate";
            this.uc_LblTxt_Cate.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_Cate.TabIndex = 9;
            this.uc_LblTxt_Cate.TxtWdith = 150;
            // 
            // uc_LblTxt_Condition
            // 
            this.uc_LblTxt_Condition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Condition.DisplayText = "Default Text";
            this.uc_LblTxt_Condition.LblText = "업태";
            this.uc_LblTxt_Condition.LblWidth = 100;
            this.uc_LblTxt_Condition.Location = new System.Drawing.Point(271, 213);
            this.uc_LblTxt_Condition.Name = "uc_LblTxt_Condition";
            this.uc_LblTxt_Condition.Size = new System.Drawing.Size(263, 29);
            this.uc_LblTxt_Condition.TabIndex = 10;
            this.uc_LblTxt_Condition.TxtWdith = 150;
            // 
            // uc_LblTxt_Tel
            // 
            this.uc_LblTxt_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Tel.DisplayText = "Default Text";
            this.uc_LblTxt_Tel.LblText = "담당자 번호";
            this.uc_LblTxt_Tel.LblWidth = 100;
            this.uc_LblTxt_Tel.Location = new System.Drawing.Point(3, 178);
            this.uc_LblTxt_Tel.Name = "uc_LblTxt_Tel";
            this.uc_LblTxt_Tel.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_Tel.TabIndex = 7;
            this.uc_LblTxt_Tel.TxtWdith = 150;
            // 
            // uc_LblTxt_Fax
            // 
            this.uc_LblTxt_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Fax.DisplayText = "Default Text";
            this.uc_LblTxt_Fax.LblText = "팩스 번호";
            this.uc_LblTxt_Fax.LblWidth = 100;
            this.uc_LblTxt_Fax.Location = new System.Drawing.Point(271, 178);
            this.uc_LblTxt_Fax.Name = "uc_LblTxt_Fax";
            this.uc_LblTxt_Fax.Size = new System.Drawing.Size(263, 29);
            this.uc_LblTxt_Fax.TabIndex = 8;
            this.uc_LblTxt_Fax.TxtWdith = 150;
            // 
            // uc_LblTxt_Post
            // 
            this.uc_LblTxt_Post.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Post.DisplayText = "Default Text";
            this.uc_LblTxt_Post.LblText = "우편번호";
            this.uc_LblTxt_Post.LblWidth = 100;
            this.uc_LblTxt_Post.Location = new System.Drawing.Point(3, 143);
            this.uc_LblTxt_Post.Name = "uc_LblTxt_Post";
            this.uc_LblTxt_Post.Size = new System.Drawing.Size(262, 29);
            this.uc_LblTxt_Post.TabIndex = 5;
            this.uc_LblTxt_Post.TxtWdith = 150;
            // 
            // uc_LblTxt_Email
            // 
            this.uc_LblTxt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_LblTxt_Email.DisplayText = "Default Text";
            this.uc_LblTxt_Email.LblText = "이메일";
            this.uc_LblTxt_Email.LblWidth = 100;
            this.uc_LblTxt_Email.Location = new System.Drawing.Point(271, 143);
            this.uc_LblTxt_Email.Name = "uc_LblTxt_Email";
            this.uc_LblTxt_Email.Size = new System.Drawing.Size(263, 29);
            this.uc_LblTxt_Email.TabIndex = 6;
            this.uc_LblTxt_Email.TxtWdith = 150;
            // 
            // uc_LblTxt_Adress
            // 
            this.uc_LblTxt_Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_LblTxt_Adress, 2);
            this.uc_LblTxt_Adress.DisplayText = "Default Text";
            this.uc_LblTxt_Adress.LblText = "주소";
            this.uc_LblTxt_Adress.LblWidth = 100;
            this.uc_LblTxt_Adress.Location = new System.Drawing.Point(3, 108);
            this.uc_LblTxt_Adress.Name = "uc_LblTxt_Adress";
            this.uc_LblTxt_Adress.Size = new System.Drawing.Size(531, 29);
            this.uc_LblTxt_Adress.TabIndex = 4;
            this.uc_LblTxt_Adress.TxtWdith = 418;
            // 
            // Col_CustType
            // 
            this.Col_CustType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_CustType.HeaderText = "타입";
            this.Col_CustType.Name = "Col_CustType";
            this.Col_CustType.ReadOnly = true;
            // 
            // Col_CustName
            // 
            this.Col_CustName.HeaderText = "거래처명";
            this.Col_CustName.Name = "Col_CustName";
            this.Col_CustName.ReadOnly = true;
            // 
            // Col_CustNo
            // 
            this.Col_CustNo.HeaderText = "사업자번호";
            this.Col_CustNo.Name = "Col_CustNo";
            this.Col_CustNo.ReadOnly = true;
            // 
            // Col_Address
            // 
            this.Col_Address.HeaderText = "주소";
            this.Col_Address.Name = "Col_Address";
            this.Col_Address.ReadOnly = true;
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
            // Frm_Info_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.TableLayoutMain);
            this.Name = "Frm_Info_Customer";
            this.Text = "거래처정보 관리";
            this.Load += new System.EventHandler(this.Frm_Info_Customer_Load);
            this.TableLayoutMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Pnl_Search.ResumeLayout(false);
            this.Pnl_MailTitle.ResumeLayout(false);
            this.Pnl_Contents1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.Panel Pnl_MailTitle;
        private System.Windows.Forms.Label Lbl_MailTitle;
        private System.Windows.Forms.DataGridView gvCustomer;
        private System.Windows.Forms.Panel Pnl_Contents1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_Contents1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Label Lbl_Contents0;
        private System.Windows.Forms.Panel Pnl_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustCode;
        private Control.CustomUc.Common.Uc_LblCbo uc_LblCbo_CustType;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustName;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Presi;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Adress;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Post;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Email;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Tel;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Fax;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Cate;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Condition;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_CustNo;
        private Control.CustomUc.Common.Uc_LblTxt uc_LblTxt_Remark;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_CustType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Address;
        private System.Windows.Forms.Button Btn_Delete;
    }
}