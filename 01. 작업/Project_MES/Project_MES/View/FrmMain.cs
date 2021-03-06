using Project_MES.View._00_Basic;
using Project_MES.View._01_Sales;
using Project_MES.View._02_Product;
using Project_MES.View._03_POP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.View
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Open 컨텐츠

        private void Tree_Menu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OpenForm(e.Node.Name);//노드 더블클릭시 해당 화면 열기
        }

        private void OpenForm(string nodeName)
        {
            Form frm = null;

            switch (nodeName.Replace("Node_", ""))
            {
                //////////////////기초정보//////////////////
                case "InfoCategoryItem": frm = new Frm_Info_CategoryItem(); break;  //종합코드관리
                case "InfoMaterial": frm = new Frm_Info_Material(); break;          //자재관리
                case "InfoCustomer": frm = new Frm_Info_Customer(); break;          //거래처관리
                case "InfoProcess":  frm = new Frm_Info_Process(); break;           //공정관리

                //////////////////영업관리//////////////////
                case "SalesOrder": frm = new Frm_Sales_PlaceOrderView(); break; //수주관리
                case "SalesOut":   frm = new Frm_Sales_DeliverOrder(); break;     //출하관리

                //////////////////생산관리//////////////////
                case "WorkPlan":  frm = new Frm_Product_WorkPlan(); break;     //생산계획
                case "WorkOrder": frm = new Frm_Product_WorkOrder(); break;    //작업지시
                case "WorkPerformance": frm = new Frm_Product_WorkOrderPerformance(); break;  //생산실적

                /////////////////// POP ///////////////////
                //case "Product": frm = new Frm_POP_Product(); break;    //실적등록
            }

            if(frm != null)
            {
                InsertForm(frm);
            }
        }

        private void InsertForm(Form frm)
        {
            frm.TopLevel = false;   //최상위창 표시 해제
            frm.Dock = DockStyle.Fill;  //최대화
            frm.FormBorderStyle = FormBorderStyle.None; //상단 타이틀 삭제

            PnlContents.Controls.Clear();   //컨텐츠창 초기화
            PnlContents.Controls.Add(frm);  //컨텐츠에 Form 삽입(보이지는 않음)

            frm.Show(); //Form 보이기
        }

        #endregion Open 컨텐츠 End
    }
}
