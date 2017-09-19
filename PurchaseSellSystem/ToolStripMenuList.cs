using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseSellSystem
{
    public partial class ToolStripMenuList : UserControl
    {

        public ToolStripMenuList()
        {
            InitializeComponent();
        }
        //自动显示和关闭
        //
        //toolStripButtonFoodBuy
        //
        private void toolStripButtonFoodBuy_MouseEnter(object sender, EventArgs e)
        {
            toolStripButtonFoodBuy.ShowDropDown();
        }
        private void toolStripButtonFoodBuy_MouseLeave(object sender, EventArgs e)
        {
            Point p = MousePosition;
            if (toolStripButtonFoodBuy.DropDown.Bounds.Contains(p))
            {
                toolStripButtonFoodBuy.DropDown.MouseLeave += new EventHandler(toolStripButtonFoodBuyDropDownLeave);
            }
            else
            {
                toolStripButtonFoodBuy.DropDown.Close();
            }
        }
        private void toolStripButtonFoodBuyDropDownLeave(object sender, EventArgs e)
        {
            toolStripButtonFoodBuy.DropDown.Close();
        }

        //toolStripButtonRest
        //
        private void toolStripButtonRest_MouseEnter(object sender, EventArgs e)
        {
            toolStripButtonRest.ShowDropDown();
            
        }
        private void toolStripButtonRest_MouseLeave(object sender, EventArgs e)
        {
            Point p = MousePosition;
            if (toolStripButtonRest.DropDown.Bounds.Contains(p))
            {
                toolStripButtonRest.DropDown.MouseLeave += new EventHandler(toolStripButtonRestDropDownLeave);
            }
            else
            {
                toolStripButtonRest.DropDown.Close();
            }
        }
        private void toolStripButtonRestDropDownLeave(object sender, EventArgs e)
        {
            toolStripButtonRest.DropDown.Close();
        }

        //toolStripButtonFinance
        //
        private void toolStripButtonFinance_MouseEnter(object sender, EventArgs e)
        {
                toolStripButtonFinance.ShowDropDown();
        }
        private void toolStripButtonFinance_MouseLeave(object sender, EventArgs e)
        {
            Point p = MousePosition;
            if (toolStripButtonFinance.DropDown.Bounds.Contains(p))
            {
                toolStripButtonFinance.DropDown.MouseLeave += new EventHandler(toolStripButtonFinanceDropDownLeave);
            }
            else
            {
                toolStripButtonFinance.DropDown.Close();
            }
        }
        private void toolStripButtonFinanceDropDownLeave(object sender, EventArgs e)
        {
            toolStripButtonFinance.DropDown.Close();
        }
        //
        //.............................

        public delegate void ShowParent();
        //DataAll
        public event ShowParent eventDataAll;
        //FoodBuy
        public event ShowParent eventCG;
        public event ShowParent eventDD;
        public event ShowParent eventGYS;
        public event ShowParent eventTH;
        //Rest
        public event ShowParent eventKC;
        public event ShowParent eventRK;
        public event ShowParent eventCK;
        //Finance
        public event ShowParent eventSR;
        public event ShowParent eventZC;
        public event ShowParent eventZB;


        //ClickDataAll
        private void toolStripButtonDataAll_Click(object sender, EventArgs e)
        {
            eventDataAll();//我的仓库
        }

        //ClickFoodBuy
        private void ToolStripMenuItemCG_Click(object sender, EventArgs e)
        {
            eventCG();//采购
        }

        private void ToolStripMenuItemDD_Click(object sender, EventArgs e)
        {
            eventDD();//采购单查询
        }

        private void ToolStripMenuItemGYS_Click(object sender, EventArgs e)
        {
            eventGYS();//供应商汇总
        }

        private void ToolStripMenuItemTH_Click(object sender, EventArgs e)
        {
            eventTH();//退货
        }

        //ClickRest
        private void ToolStripMenuItemKC_Click(object sender, EventArgs e)
        {
            eventKC();//退货单查询
        }

        private void ToolStripMenuItemRK_Click(object sender, EventArgs e)
        {
            eventRK();//入库
        }

        private void ToolStripMenuItemCK_Click(object sender, EventArgs e)
        {
            eventCK();//出库
        }
        //ClickFinance
        private void ToolStripMenuItemSR_Click(object sender, EventArgs e)
        {
            eventSR();//入库单查询
        }

        private void ToolStripMenuItemZC_Click(object sender, EventArgs e)
        {
            eventZC();
        }

        private void ToolStripMenuItemZB_Click(object sender, EventArgs e)
        {
            eventZB();
        }

        private void toolStripButtonFoodSell_Click(object sender, EventArgs e)
        {

        }

        private void 采购订单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventTH();
        }

        private void 退货单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventKC();
        }

        private void 采购订单查询ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 入库单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventSR();
        }

        private void 出库单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventZB();
        }

        private void 退货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventTH();//退货
        } 
        



    }
}
