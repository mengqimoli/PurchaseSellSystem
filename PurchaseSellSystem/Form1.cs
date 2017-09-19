using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBCL;
using System.Data.SqlClient;

namespace PurchaseSellSystem
{
    public partial class Form1 : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        public Form1()
        {
            InitializeComponent();
        }
        //生成采购订单编号
        public static object _lock = new object();
        public string GetRanddom3()
        {
            lock (_lock)
            {
                Random ran = new Random();
                return "U" + DateTime.Now.ToString("yyyyMMdd") + ran.Next(1000, 9999).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
        }
        //TabControl全重绘
        const int CLOSE_SIZE = 8;
        const int Width_SIZE = 10;
        const int Height_SIZE = 3;
        Bitmap image = new Bitmap("C:\\Users\\moli\\Desktop\\C#\\新建文件夹11\\新建文件夹\\进销存\\主程序\\PurchaseSellSystem\\DOC\\cha1.jpg");
        private void mainWindow1_Load(object sender, EventArgs e)
        {
            //formCGAdd frmcgadd = new formCGAdd();
            //frmcgadd.biaoge += new formCGAdd.caigou(mainWindow1.biaoge);

            this.mainWindow1.tabControlMainWindow.TabPages.Clear();
            this.mainWindow1.tabPageDataAll.Parent = mainWindow1.tabControlMainWindow;

            //我的仓库*********************************************************************************************************************
            //商品类型下拉单
            this.mainWindow1.tbKCXSJG.ReadOnly = true;
            this.mainWindow1.comboBoxKCFoodType.Items.Add("全部");
            string sqlcgsplx = "select distinct KCFoodType from KC";
            SqlDataReader dr = db.DB_Red(sqlcgsplx);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.mainWindow1.comboBoxKCFoodType.Items.Add(dr[0].ToString());
                    this.mainWindow1.comboBoxKCFoodType.SelectedIndex = 0;
                }

            }
            dr.Close();
            this.mainWindow1.dataGridViewCG.AutoGenerateColumns = false;
            string sql1 = "select * from KC";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.mainWindow1.dataGridViewKC.AutoGenerateColumns = false;
            this.mainWindow1.dataGridViewKC.DataSource = dt;
            this.mainWindow1.dataGridViewKC.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.mainWindow1.dataGridViewKC.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.mainWindow1.dataGridViewKC.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.mainWindow1.dataGridViewKC.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.mainWindow1.dataGridViewKC.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.mainWindow1.dataGridViewKC.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();

            this.mainWindow1.tabControlMainWindow.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.mainWindow1.tabControlMainWindow.Padding = new System.Drawing.Point(Width_SIZE, Height_SIZE);
            this.mainWindow1.tabControlMainWindow.DrawItem += new DrawItemEventHandler(tabControlMainWindow_DrawItem);
            this.mainWindow1.tabControlMainWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlMainWindow_MouseDown);
        }
        private void tabControlMainWindow_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle myTabRect = this.mainWindow1.tabControlMainWindow.GetTabRect(e.Index);
            //TabPage属性
            e.Graphics.DrawString(this.mainWindow1.tabControlMainWindow.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, myTabRect.X + 2, myTabRect.Y + 2);

            //绘制矩形框
            using (Pen p = new Pen(Color.White))
            {
                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 6), 3);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;
                e.Graphics.DrawRectangle(p, myTabRect);
            }
            //填充矩形框
            Color recColor = e.State == DrawItemState.Selected ? Color.White : Color.White;
            using (Brush b = new SolidBrush(recColor))
            {
                e.Graphics.FillRectangle(b, myTabRect);
            }

            using (Pen objpen = new Pen(Color.Black))
            {
                Bitmap bt = new Bitmap(image);
                Point p5 = new Point(myTabRect.X, 4);


                e.Graphics.DrawImage(bt, p5);

            }
            e.Graphics.Dispose();
        }

        private void tabControlMainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;

                Rectangle myTabRect = this.mainWindow1.tabControlMainWindow.GetTabRect(this.mainWindow1.tabControlMainWindow.SelectedIndex);

                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 6), 3);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;

                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if (isClose == true)
                {
                    this.mainWindow1.tabControlMainWindow.TabPages.Remove(this.mainWindow1.tabControlMainWindow.SelectedTab);
                    if (mainWindow1.tabControlMainWindow.TabCount == 0)
                    {
                        this.mainWindow1.tabPageDataAll.Parent = mainWindow1.tabControlMainWindow;
                    }
                }
            }
        }
        //
        //....................
        private void toolStripMenuList1_Load(object sender, EventArgs e)
        {
            toolStripMenuList1.eventDataAll += new ToolStripMenuList.ShowParent(mainWindow1.parentDataAll);
            toolStripMenuList1.eventCG += new ToolStripMenuList.ShowParent(mainWindow1.parentCG);
            toolStripMenuList1.eventDD += new ToolStripMenuList.ShowParent(mainWindow1.parentDD);
            toolStripMenuList1.eventGYS += new ToolStripMenuList.ShowParent(mainWindow1.parentGYS);
            toolStripMenuList1.eventTH += new ToolStripMenuList.ShowParent(mainWindow1.parentTH);
            toolStripMenuList1.eventKC += new ToolStripMenuList.ShowParent(mainWindow1.parentKC);
            toolStripMenuList1.eventRK += new ToolStripMenuList.ShowParent(mainWindow1.parentRK);
            toolStripMenuList1.eventCK += new ToolStripMenuList.ShowParent(mainWindow1.parentCK);
            toolStripMenuList1.eventSR += new ToolStripMenuList.ShowParent(mainWindow1.parentSR);
            toolStripMenuList1.eventZB += new ToolStripMenuList.ShowParent(mainWindow1.parentZB);

        }

        //状态栏，动态显示当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "当前时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            toolStripStatusLabel1.Font = new Font ("楷体",11);
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
