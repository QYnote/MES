using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MES.View._01_Sales
{
    public partial class Frm_SalesOrder : Form
    {
        public Frm_SalesOrder()
        {
            InitializeComponent();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            Frm_SalesOrder_Create frmCreate = new Frm_SalesOrder_Create();
            
            if(frmCreate.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
