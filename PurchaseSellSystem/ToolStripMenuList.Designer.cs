namespace PurchaseSellSystem
{
    partial class ToolStripMenuList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripMenuList));
            this.toolStripManage = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDataAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFoodBuy = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemCG = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGYS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonRest = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemRK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonFinance = new System.Windows.Forms.ToolStripDropDownButton();
            this.退货单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripManage
            // 
            this.toolStripManage.AutoSize = false;
            this.toolStripManage.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripManage.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripManage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDataAll,
            this.toolStripButtonFoodBuy,
            this.toolStripButtonRest,
            this.toolStripButtonFinance});
            this.toolStripManage.Location = new System.Drawing.Point(0, 0);
            this.toolStripManage.Name = "toolStripManage";
            this.toolStripManage.Size = new System.Drawing.Size(83, 375);
            this.toolStripManage.TabIndex = 0;
            this.toolStripManage.Text = "toolStripManage";
            // 
            // toolStripButtonDataAll
            // 
            this.toolStripButtonDataAll.AutoSize = false;
            this.toolStripButtonDataAll.AutoToolTip = false;
            this.toolStripButtonDataAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDataAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDataAll.Image")));
            this.toolStripButtonDataAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDataAll.Name = "toolStripButtonDataAll";
            this.toolStripButtonDataAll.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonDataAll.Text = "我的仓库";
            this.toolStripButtonDataAll.Click += new System.EventHandler(this.toolStripButtonDataAll_Click);
            // 
            // toolStripButtonFoodBuy
            // 
            this.toolStripButtonFoodBuy.AutoSize = false;
            this.toolStripButtonFoodBuy.AutoToolTip = false;
            this.toolStripButtonFoodBuy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCG,
            this.ToolStripMenuItemDD,
            this.ToolStripMenuItemGYS});
            this.toolStripButtonFoodBuy.Name = "toolStripButtonFoodBuy";
            this.toolStripButtonFoodBuy.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonFoodBuy.Text = "食品采购";
            this.toolStripButtonFoodBuy.MouseEnter += new System.EventHandler(this.toolStripButtonFoodBuy_MouseEnter);
            this.toolStripButtonFoodBuy.MouseLeave += new System.EventHandler(this.toolStripButtonFoodBuy_MouseLeave);
            // 
            // ToolStripMenuItemCG
            // 
            this.ToolStripMenuItemCG.Name = "ToolStripMenuItemCG";
            this.ToolStripMenuItemCG.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripMenuItemCG.Size = new System.Drawing.Size(160, 20);
            this.ToolStripMenuItemCG.Text = "采购";
            this.ToolStripMenuItemCG.Click += new System.EventHandler(this.ToolStripMenuItemCG_Click);
            // 
            // ToolStripMenuItemDD
            // 
            this.ToolStripMenuItemDD.Name = "ToolStripMenuItemDD";
            this.ToolStripMenuItemDD.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemDD.Text = "采购单查询";
            this.ToolStripMenuItemDD.Click += new System.EventHandler(this.ToolStripMenuItemDD_Click);
            // 
            // ToolStripMenuItemGYS
            // 
            this.ToolStripMenuItemGYS.Name = "ToolStripMenuItemGYS";
            this.ToolStripMenuItemGYS.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemGYS.Text = "供应商货品汇总";
            this.ToolStripMenuItemGYS.Click += new System.EventHandler(this.ToolStripMenuItemGYS_Click);
            // 
            // toolStripButtonRest
            // 
            this.toolStripButtonRest.AutoSize = false;
            this.toolStripButtonRest.AutoToolTip = false;
            this.toolStripButtonRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRK,
            this.入库单查询ToolStripMenuItem,
            this.ToolStripMenuItemCK,
            this.出库单查询ToolStripMenuItem});
            this.toolStripButtonRest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRest.Image")));
            this.toolStripButtonRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRest.Name = "toolStripButtonRest";
            this.toolStripButtonRest.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonRest.Text = "库存管理";
            this.toolStripButtonRest.MouseEnter += new System.EventHandler(this.toolStripButtonRest_MouseEnter);
            this.toolStripButtonRest.MouseLeave += new System.EventHandler(this.toolStripButtonRest_MouseLeave);
            // 
            // ToolStripMenuItemRK
            // 
            this.ToolStripMenuItemRK.Name = "ToolStripMenuItemRK";
            this.ToolStripMenuItemRK.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemRK.Text = "入库";
            this.ToolStripMenuItemRK.Click += new System.EventHandler(this.ToolStripMenuItemRK_Click);
            // 
            // ToolStripMenuItemCK
            // 
            this.ToolStripMenuItemCK.Name = "ToolStripMenuItemCK";
            this.ToolStripMenuItemCK.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCK.Text = "出库";
            this.ToolStripMenuItemCK.Click += new System.EventHandler(this.ToolStripMenuItemCK_Click);
            // 
            // toolStripButtonFinance
            // 
            this.toolStripButtonFinance.AutoSize = false;
            this.toolStripButtonFinance.AutoToolTip = false;
            this.toolStripButtonFinance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退货ToolStripMenuItem,
            this.退货单查询ToolStripMenuItem});
            this.toolStripButtonFinance.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFinance.Image")));
            this.toolStripButtonFinance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFinance.Name = "toolStripButtonFinance";
            this.toolStripButtonFinance.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonFinance.Text = "退货管理";
            this.toolStripButtonFinance.MouseEnter += new System.EventHandler(this.toolStripButtonFinance_MouseEnter);
            this.toolStripButtonFinance.MouseLeave += new System.EventHandler(this.toolStripButtonFinance_MouseLeave);
            // 
            // 退货单查询ToolStripMenuItem
            // 
            this.退货单查询ToolStripMenuItem.Name = "退货单查询ToolStripMenuItem";
            this.退货单查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退货单查询ToolStripMenuItem.Text = "退货单查询";
            this.退货单查询ToolStripMenuItem.Click += new System.EventHandler(this.退货单查询ToolStripMenuItem_Click);
            // 
            // 入库单查询ToolStripMenuItem
            // 
            this.入库单查询ToolStripMenuItem.Name = "入库单查询ToolStripMenuItem";
            this.入库单查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.入库单查询ToolStripMenuItem.Text = "入库单查询";
            this.入库单查询ToolStripMenuItem.Click += new System.EventHandler(this.入库单查询ToolStripMenuItem_Click);
            // 
            // 出库单查询ToolStripMenuItem
            // 
            this.出库单查询ToolStripMenuItem.Name = "出库单查询ToolStripMenuItem";
            this.出库单查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.出库单查询ToolStripMenuItem.Text = "出库单查询";
            this.出库单查询ToolStripMenuItem.Click += new System.EventHandler(this.出库单查询ToolStripMenuItem_Click);
            // 
            // 退货ToolStripMenuItem
            // 
            this.退货ToolStripMenuItem.Name = "退货ToolStripMenuItem";
            this.退货ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退货ToolStripMenuItem.Text = "退货";
            this.退货ToolStripMenuItem.Click += new System.EventHandler(this.退货ToolStripMenuItem_Click);
            // 
            // ToolStripMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.toolStripManage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ToolStripMenuList";
            this.Size = new System.Drawing.Size(92, 375);
            this.toolStripManage.ResumeLayout(false);
            this.toolStripManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonRest;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRK;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonFoodBuy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCK;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonFinance;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCG;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGYS;
        public System.Windows.Forms.ToolStrip toolStripManage;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataAll;
        private System.Windows.Forms.ToolStripMenuItem 退货单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退货ToolStripMenuItem;

    }
}
