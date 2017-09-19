using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBCL;
using System.Data.SqlClient;

namespace PurchaseSellSystem
{
    public partial class tbRKDiscountM : UserControl
    {
        DBCL.DataBase db = new DBCL.DataBase();
        public tbRKDiscountM()
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

        //ToolStripMenuList点击事件触发而引用的函数群
        //pageShow  all
        //点击出现界面
        //parentDataAll
        public void parentDataAll()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageDataAll;
            this.tabPageDataAll.Parent = tabControlMainWindow;
            //我的仓库*********************************************************************************************************************
            //商品类型下拉单
            tbKCXSJG.ReadOnly = true;
            this.comboBoxKCFoodType.Items.Clear();
            this.comboBoxKCFoodType.Items.Add("全部");
            string sqlcgsplx = "select distinct KCFoodType from KC";
            SqlDataReader dr = db.DB_Red(sqlcgsplx);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.comboBoxKCFoodType.Items.Add(dr[0].ToString());
                    this.comboBoxKCFoodType.SelectedIndex = 0;
                }

            }
            dr.Close();
            this.dataGridViewCG.AutoGenerateColumns = false;
            string sql1 = "select * from KC";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewKC.AutoGenerateColumns = false;
            this.dataGridViewKC.DataSource = dt;
            this.dataGridViewKC.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewKC.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewKC.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewKC.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewKC.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewKC.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //点击灰体字事件
        private void tbKCFoodName_Click(object sender, EventArgs e)
        {
            if (tbKCFoodName.ForeColor.Equals(Color.Gray))
            {
                tbKCFoodName.Clear();
                tbKCFoodName.ForeColor = Color.Black;
            }
        }
        //下拉单改变事件
        private void comboBoxKCFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFoodType = "";
            strFoodType = comboBoxKCFoodType.Text;
            string sql = "";
            if (strFoodType == "全部")
            {
                sql = "select * from KC ";
            }
            else
            {
                sql = "select * from KC where KCFoodType = '" + strFoodType + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewKC.AutoGenerateColumns = false;
            this.dataGridViewKC.DataSource = dt;
            this.dataGridViewKC.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewKC.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewKC.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewKC.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewKC.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewKC.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //查询按钮事件
        private void button8_Click(object sender, EventArgs e)
        {
            string strFoodType = "";
            string strFoodName = "";
            strFoodType = comboBoxKCFoodType.Text;
            strFoodName = tbKCFoodName.Text.Trim();
            string sql = "";
            if (strFoodType == "全部")
            {
                sql = "select * from KC where KCFoodName = '" + strFoodName + "'"; ;
            }
            else
            {
                sql = "select * from KC where KCFoodType = '" + strFoodType + "' and KCFoodName = '" + strFoodName + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewKC.AutoGenerateColumns = false;
            this.dataGridViewKC.DataSource = dt;
            this.dataGridViewKC.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewKC.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewKC.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewKC.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewKC.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewKC.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //显示按钮事件
        private void button12_Click(object sender, EventArgs e)
        {
            string sql = "select * from KC";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewKC.AutoGenerateColumns = false;
            this.dataGridViewKC.DataSource = dt;
            this.dataGridViewKC.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewKC.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewKC.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewKC.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewKC.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewKC.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //点击行表格获取数据
        private void dataGridViewKC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbKCXSJG.ReadOnly = false;
            try
            {
                if (this.dataGridViewKC[0, this.dataGridViewKC.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    tbKCGYS.Text = dataGridViewKC.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbKCName.Text = dataGridViewKC.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbKCFoodType.Text = dataGridViewKC.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbKCBM.Text = dataGridViewKC.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbKCQuantity.Text = dataGridViewKC.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tbKCGYS.ReadOnly = true;
                    tbKCName.ReadOnly = true;
                    tbKCFoodType.ReadOnly = true;
                    tbKCBM.ReadOnly = true;
                    tbKCQuantity.ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("无法选择表头", "警告");
                return;
            }
        }
        //保存按钮事件
        private void button10_Click(object sender, EventArgs e)
        {
            string KCGYS = tbKCGYS.Text;
            string KCFoodName = tbKCName.Text;
            decimal KCSJ = Convert.ToDecimal(tbKCXSJG.Text.Trim());
            if (MessageBox.Show("确认保存此价格吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update KC set KCSJ = '" + KCSJ + "' where KCGYS = '" + KCGYS + "' and KCFoodName = '" + KCFoodName + "'";
                try
                {
                    db.DB_ZSG(sql);
                    MessageBox.Show("保存成功!", "保存");
                    return;
                }
                catch
                {
                    MessageBox.Show("保存失败", "警告");
                    return;
                }
            }
        }
        //parentFoodBuy食品采购
        public void parentCG()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageCG;
            this.tabPageCG.Parent = tabControlMainWindow;
            //采购***********************************************************************************************************************
            //订单编号
            tbCGNum.ReadOnly = true;
            this.tbCGOrderMum.Text = GetRanddom3();
            this.tbCGOrderMum.ReadOnly = true;
            //供应商下拉菜单 
            this.comboBoxCGGYS.Items.Clear();
            this.comboBoxCGGYS.Items.Add("全部");
            string sqlcggys = "select distinct GYS from GYSAllFood";
            SqlDataReader drcggys = db.DB_Red(sqlcggys);
            if (drcggys.HasRows)
            {
                while (drcggys.Read())
                {
                    this.comboBoxCGGYS.Items.Add(drcggys[0].ToString());
                    this.comboBoxCGGYS.SelectedIndex = 0;
                }

            }
            drcggys.Close();
            //商品类型下拉菜单
            this.comboBoxCGFoodType.Items.Clear();
            this.comboBoxCGFoodType.Items.Add("全部");
            string sqlcgsplx = "select distinct GYSFoodType from GYSAllFood";
            SqlDataReader drcgsplx = db.DB_Red(sqlcgsplx);
            if (drcgsplx.HasRows)
            {
                while (drcgsplx.Read())
                {
                    this.comboBoxCGFoodType.Items.Add(drcgsplx[0].ToString());
                    this.comboBoxCGFoodType.SelectedIndex = 0;
                }

            }
            drcgsplx.Close();
            string strGYS = "";
            strGYS = this.comboBoxGYSName.Text;
            //供应商商品表格
            this.dataGridViewGYS.AutoGenerateColumns = false;
            string sql1 = "select * from GYSAllFood";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewGYS.AutoGenerateColumns = false;
            this.dataGridViewCG.DataSource = dt;
            this.dataGridViewCG.Columns[0].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewCG.Columns[1].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewCG.Columns[3].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewCG.Columns[4].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewCG.Columns[5].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewCG.Columns[6].DataPropertyName = dt.Columns["GYSText"].ToString();

        }
        //供应商下拉单改变事件
        private void comboBoxCGGYS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strGYS = "";
            string strFoodType = "";
            strGYS = comboBoxCGGYS.Text;
            strFoodType = comboBoxCGFoodType.Text;
            string sql = "";
            if (strGYS == "全部" && strFoodType == "全部")
            {
                sql = "select * from GYSAllFood";
            }
            else if (strFoodType == "全部")
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "'";
            }
            else if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood where GYSFoodType = '" + strFoodType + "'";
            }
            else
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "' and GYSFoodType = '" + strFoodType + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCG.AutoGenerateColumns = false;
            this.dataGridViewCG.DataSource = dt;
            this.dataGridViewCG.Columns[0].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewCG.Columns[1].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewCG.Columns[3].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewCG.Columns[4].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewCG.Columns[5].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewCG.Columns[6].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //商品类型下拉单事件
        private void comboBoxCGFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strGYS = "";
            string strFoodType = "";
            strGYS = comboBoxCGGYS.Text;
            strFoodType = comboBoxCGFoodType.Text;
            string sql = "";
            if (strGYS == "全部" && strFoodType == "全部")
            {
                sql = "select * from GYSAllFood";
            }
            else if (strFoodType == "全部")
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "'";
            }
            else if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood where GYSFoodType = '" + strFoodType + "'";
            }
            else
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "' and GYSFoodType = '" + strFoodType + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCG.AutoGenerateColumns = false;
            this.dataGridViewCG.DataSource = dt;
            this.dataGridViewCG.Columns[0].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewCG.Columns[1].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewCG.Columns[3].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewCG.Columns[4].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewCG.Columns[5].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewCG.Columns[6].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //文本框灰体字
        private void textBoxCGSearch_Click(object sender, EventArgs e)
        {
            if (textBoxCGSearch.ForeColor.Equals(Color.Gray))
            {
                textBoxCGSearch.Clear();
                textBoxCGSearch.ForeColor = Color.Black;
            }
        }
        //查询按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            string strGYS = "";
            string strGYSFoodName = "";
            string sql = "";
            strGYS = comboBoxCGGYS.Text;
            strGYSFoodName = textBoxCGSearch.Text.Trim();
            if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood where GYSFoodName like '%" + strGYSFoodName + "%'";
            }
            else
            {
                sql = "select * from GYSAllFood where GYSFoodName like '%" + strGYSFoodName + "%' and GYS = '" + strGYS + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCG.AutoGenerateColumns = false;
            this.dataGridViewCG.DataSource = dt;
            this.dataGridViewCG.Columns[0].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewCG.Columns[1].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewCG.Columns[3].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewCG.Columns[4].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewCG.Columns[5].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewCG.Columns[6].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //点击表格行获取数据
        private void dataGridViewCG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCGNum.ReadOnly = false;
            try
            {
                if (this.dataGridViewCG[0, this.dataGridViewCG.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    tbCGGYS.Text = dataGridViewCG.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbCGFoodName.Text = dataGridViewCG.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbCGFoodType.Text = dataGridViewCG.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbCGDM.Text = dataGridViewCG.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbCGDiscountL.Text = dataGridViewCG.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbCGQuantity.Text = dataGridViewCG.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("无法选择表头", "警告");
                return;
            }
        }
        //输入数量动态显示总价
        private void tbCGNum_TextChanged(object sender, EventArgs e)
        {
            if (tbCGNum.Text != "")
            {
                decimal zje = Convert.ToDecimal(tbCGNum.Text.Trim()) * Convert.ToDecimal(tbCGDM.Text.Trim());
                tbCGAllMon.Text = Convert.ToString(zje);
                decimal zke = Convert.ToDecimal(tbCGNum.Text.Trim()) * (1 - Convert.ToDecimal(tbCGDiscountL.Text.Trim())) * Convert.ToDecimal(tbCGDM.Text.Trim());
                tbCGDiscountM.Text = Convert.ToString(zke);
                decimal yfje = zje - zke;
                tbCGAM.Text = Convert.ToString(yfje);
            }
            else
            {
                tbCGAllMon.Text = "";
                tbCGDiscountM.Text = "";
                tbCGAM.Text = "";
            }
           
            
        }
        //购买按钮事件
        private void button2_Click(object sender, EventArgs e)
        {
            string OrderMum = this.tbCGOrderMum.Text;
            DateTime CGTime = dateTimePickerCGTimeNow.Value;
            string CGGYS = tbCGGYS.Text.Trim();
            string CGFoodName = tbCGFoodName.Text.Trim();
            string CGFoodType = tbCGFoodType.Text.Trim();
            decimal CGDM = Convert.ToDecimal(tbCGDM.Text.Trim());
            decimal CGQuantity = Convert.ToDecimal(tbCGNum.Text.Trim());
            decimal CGDiscountL = Convert.ToDecimal(tbCGDiscountL.Text.Trim());
            decimal CGDiscountM = Convert.ToDecimal(tbCGDiscountM.Text.Trim());
            decimal CGAM = Convert.ToDecimal(tbCGAM.Text.Trim());
            string CGText = tbCGText.Text.Trim();

            if (MessageBox.Show("确认购买吗？", "购买", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "insert into CG values('" + OrderMum + "','" + CGTime + "','" + CGGYS + "','" + CGFoodName + "','" + CGFoodType + "','" + CGDM + "','" + CGQuantity + "','" + CGDiscountL + "','" + CGDiscountM + "','" + CGAM + "','" + CGText + "','未入库')";

                try
                {
                    db.DB_ZSG(sql);
                    MessageBox.Show("购买成功!");
                    tbCGOrderMum.Text = GetRanddom3();
                    return;
                }
                catch
                {
                    MessageBox.Show("出错了,购买失败");
                    return;
                }
            }
        }
        public void parentDD()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageDD;
            this.tabPageDD.Parent = tabControlMainWindow;
            //采购单查询*********************************************************************************************************************
            //订单表格
            this.dataGridViewDD.AutoGenerateColumns = false;
            string sql1 = "select * from CG";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewDD.DataSource = dt;
            this.dataGridViewDD.Columns[1].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewDD.Columns[2].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewDD.Columns[3].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewDD.Columns[4].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewDD.Columns[5].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewDD.Columns[6].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewDD.Columns[7].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewDD.Columns[8].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewDD.Columns[9].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewDD.Columns[10].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewDD.Columns[11].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewDD.Columns[12].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        //查询按钮事件
        private void buttonDDSearch_Click(object sender, EventArgs e)
        {
            DateTime timeStar = dateTimePickerDDStart.Value;
            DateTime endStar = dateTimePickerDDEnd.Value;
            string sql = "select * from CG where CGTime between '" + timeStar + "' and '" + endStar + "'";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewDD.DataSource = dt;
            this.dataGridViewDD.Columns[1].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewDD.Columns[2].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewDD.Columns[3].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewDD.Columns[4].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewDD.Columns[5].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewDD.Columns[6].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewDD.Columns[7].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewDD.Columns[8].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewDD.Columns[9].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewDD.Columns[10].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewDD.Columns[11].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewDD.Columns[12].DataPropertyName = dt.Columns["CGState"].ToString();

        }
        //显示全部按钮事件
        private void buttonDDSearchAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from CG";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewDD.DataSource = dt;
            this.dataGridViewDD.Columns[1].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewDD.Columns[2].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewDD.Columns[3].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewDD.Columns[4].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewDD.Columns[5].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewDD.Columns[6].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewDD.Columns[7].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewDD.Columns[8].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewDD.Columns[9].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewDD.Columns[10].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewDD.Columns[11].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewDD.Columns[12].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        //点击表格删除按钮
        private void dataGridViewDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDD.Columns[e.ColumnIndex].Name == "ColumnDDSX")
            {
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string ddbianhao = dataGridViewDD.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string sql = "delete from CG where OrderMum = '" + ddbianhao + "'";
                    try
                    {
                        db.DB_ZSG(sql);
                        dataGridViewDD.Rows.Remove(this.dataGridViewDD.Rows[e.RowIndex]);
                        MessageBox.Show("删除成功", "删除");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("出错啦，删除失败", "警告");
                        return;
                    }
                }
            }
        }
        public void parentGYS()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageGYS;
            this.tabPageGYS.Parent = tabControlMainWindow;
            //供应商商品汇总 **************************************************************************************************************
            //供应商下拉菜单 
            this.comboBoxGYSName.Items.Clear();
            this.comboBoxGYSName.Items.Add("全部");
            string sql = "select distinct GYS from GYSAllFood";
            SqlDataReader dr = db.DB_Red(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.comboBoxGYSName.Items.Add(dr[0].ToString());
                    this.comboBoxGYSName.SelectedIndex = 0;
                }

            }
            dr.Close();
            //商品类型下拉菜单
            this.comboBoxFoodType.Items.Clear();
            this.comboBoxFoodType.Items.Add("全部");
            string sqlsplx = "select distinct GYSFoodType from GYSAllFood";
            SqlDataReader dr1 = db.DB_Red(sqlsplx);
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    this.comboBoxFoodType.Items.Add(dr1[0].ToString());
                    this.comboBoxFoodType.SelectedIndex = 0;
                }

            }
            dr1.Close();
            string strGYS = "";
            strGYS = this.comboBoxGYSName.Text;
            //供应商商品表格
            this.dataGridViewGYS.AutoGenerateColumns = false;
            string sql1 = "select * from GYSAllFood";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewGYS.DataSource = dt;
            this.dataGridViewGYS.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewGYS.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewGYS.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewGYS.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewGYS.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewGYS.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewGYS.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //供应商下拉单改变事件
        private void comboBoxGYSName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strGYS = "";
            string strFoodType = "";
            strGYS = comboBoxGYSName.Text;
            strFoodType = comboBoxFoodType.Text;
            string sql = "";
            this.dataGridViewGYS.AutoGenerateColumns = false;
            if (strGYS == "全部" && strFoodType == "全部")
            {
                sql = "select * from GYSAllFood";
            }
            else if (strFoodType == "全部")
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "'";
            }
            else if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood where GYSFoodType = '" + strFoodType + "'";
            }
            else
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "' and GYSFoodType = '" + strFoodType + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewGYS.DataSource = dt;
            this.dataGridViewGYS.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewGYS.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewGYS.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewGYS.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewGYS.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewGYS.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewGYS.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //商品类型下拉单改变事件
        private void comboBoxFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strGYS = "";
            string strFoodType = "";
            strGYS = comboBoxGYSName.Text;
            strFoodType = comboBoxFoodType.Text;
            string sql = "";
            this.dataGridViewGYS.AutoGenerateColumns = false;
            if (strGYS == "全部" && strFoodType == "全部")
            {
                sql = "select * from GYSAllFood";
            }
            else if (strFoodType == "全部")
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "'";
            }
            else if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood where GYSFoodType = '" + strFoodType + "'";
            }
            else
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "' and GYSFoodType = '" + strFoodType + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewGYS.DataSource = dt;
            this.dataGridViewGYS.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewGYS.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewGYS.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewGYS.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewGYS.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewGYS.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewGYS.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //供应商商品名字灰体字
        private void textBoxGYSSearch_Click(object sender, EventArgs e)
        {
            if (textBoxGYSSearch.ForeColor.Equals(Color.Gray))
            {
                textBoxGYSSearch.Clear();
                textBoxGYSSearch.ForeColor = Color.Black;
            }
        }
        //查询按钮事件
        private void buttonGYSSearch_Click(object sender, EventArgs e)
        {
            string strGYS = "";
            string strGYSFoodName = "";
            string sql = "";
            strGYS = comboBoxGYSName.Text;
            strGYSFoodName = textBoxGYSSearch.Text.Trim();
            this.dataGridViewGYS.AutoGenerateColumns = false;
            if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood where GYSFoodName like '%" + strGYSFoodName + "%'";
            }
            else
            {
                sql = "select * from GYSAllFood where GYSFoodName like '%" + strGYSFoodName + "%' and GYS = '" + strGYS + "'";
            }
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewGYS.DataSource = dt;
            this.dataGridViewGYS.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewGYS.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewGYS.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewGYS.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewGYS.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewGYS.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewGYS.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
        }
        //表格删除按钮事件
        private void dataGridViewGYS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewGYS.Columns[e.ColumnIndex].Name == "ColumnGYSX")
            {
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string gys = dataGridViewGYS.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string foodname = dataGridViewGYS.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string sql = "delete from GYSAllFood where GYS = '" + gys + "' and  GYSFoodName = '" + foodname + "'";
                    try
                    {
                        db.DB_ZSG(sql);
                        dataGridViewGYS.Rows.Remove(this.dataGridViewGYS.Rows[e.RowIndex]);
                        MessageBox.Show("删除成功", "删除");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("出错啦，删除失败", "警告");
                        return;
                    }
                }
            }
        }
        public void parentTH()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageTH;
            this.tabPageTH.Parent = tabControlMainWindow;
            //退货*************************************************************************************************************************
            laTHts.Text = "";
            tbTHNum.ReadOnly = true;
            this.tbTHOrderMum.Text = GetRanddom3();
            this.tbTHOrderMum.ReadOnly = true;
            this.dataGridViewTH.AutoGenerateColumns = false;
            string sql1 = "select * from CG where CGState = '已入库'";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewTH.DataSource = dt;
            this.dataGridViewTH.Columns[0].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewTH.Columns[1].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewTH.Columns[2].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewTH.Columns[3].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewTH.Columns[4].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewTH.Columns[5].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewTH.Columns[6].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewTH.Columns[7].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewTH.Columns[8].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewTH.Columns[9].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewTH.Columns[10].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewTH.Columns[11].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        //查询按钮事件
        private void button17_Click(object sender, EventArgs e)
        {
            DateTime timeStar = dateTimePickerTHStart.Value;
            DateTime endStar = dateTimePickerTHEnd.Value;
            string sql = "select * from CG where CGState = '已入库' and CGTime between '" + timeStar + "' and '" + endStar + "' ";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewTH.DataSource = dt;
            this.dataGridViewTH.Columns[0].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewTH.Columns[1].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewTH.Columns[2].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewTH.Columns[3].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewTH.Columns[4].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewTH.Columns[5].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewTH.Columns[6].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewTH.Columns[7].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewTH.Columns[8].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewTH.Columns[9].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewTH.Columns[10].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewTH.Columns[11].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        //显示全部按钮事件
        private void button16_Click(object sender, EventArgs e)
        {
            string sql = "select * from where CGState = '已入库'";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewTH.DataSource = dt;
            this.dataGridViewTH.Columns[0].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewTH.Columns[1].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewTH.Columns[2].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewTH.Columns[3].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewTH.Columns[4].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewTH.Columns[5].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewTH.Columns[6].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewTH.Columns[7].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewTH.Columns[8].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewTH.Columns[9].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewTH.Columns[10].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewTH.Columns[11].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        string ddstate = "";//订单状态
        //点击行表格获取数据
        private void dataGridViewTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTHNum.ReadOnly = false;
            if (this.dataGridViewTH[0, this.dataGridViewTH.CurrentCell.RowIndex].Value.ToString() != "")
            {
                tbTHGYS.Text = dataGridViewTH.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbTHFoodName.Text = dataGridViewTH.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbTHFoodType.Text = dataGridViewTH.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbTHDM.Text = dataGridViewTH.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbTHGHSL.Text = dataGridViewTH.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbTHDiscountL.Text = dataGridViewTH.Rows[e.RowIndex].Cells[7].Value.ToString();
                ddstate = dataGridViewTH.Rows[e.RowIndex].Cells[11].Value.ToString();

            }
        }
        //输入数量动态显示价格
        private void tbTHNum_TextChanged(object sender, EventArgs e)
        {
            if (tbTHNum.Text.Trim() == "")
            {
                tbTHDiscountM.Text = "";
                tbTHMon.Text = "";
            }
            else
            {
                decimal zke = Convert.ToDecimal(tbTHNum.Text.Trim()) * (1 - Convert.ToDecimal(tbTHDiscountL.Text.Trim())) * Convert.ToDecimal(tbTHDM.Text.Trim());//折扣额
                tbTHDiscountM.Text = Convert.ToString(zke);
                decimal tkje = Convert.ToDecimal(tbTHNum.Text.Trim()) * (Convert.ToDecimal(tbTHDM.Text.Trim())) - zke;
                tbTHMon.Text = Convert.ToString(tkje);
            }
            if (tbTHNum.Text.Trim() != "")
            {
                if (Convert.ToDecimal(tbTHNum.Text.Trim()) > Convert.ToDecimal(tbTHGHSL.Text.Trim()))
                {
                    laTHts.Text = "提示：退货数量不能大于购货数量！";
                    laTHts.ForeColor = Color.Red;
                }
            }
            else if (tbTHNum.Text.Trim() == "")
            {
                laTHts.Text = "";
            }
        }
        //确认退货
        private void button18_Click(object sender, EventArgs e)
        {
            string THNum = this.tbTHOrderMum.Text;
            DateTime THTime = dateTimePickerTHTimeNow.Value;
            string THGYS = tbTHGYS.Text.Trim();
            string THFoodName = tbTHFoodName.Text.Trim();
            string THFoodType = tbTHFoodType.Text.Trim();
            decimal THDM = Convert.ToDecimal(tbTHDM.Text.Trim());
            decimal THQuantity = Convert.ToDecimal(tbTHNum.Text.Trim());
            decimal THDiscountL = Convert.ToDecimal(tbTHDiscountL.Text.Trim());
            decimal THDiscountM = Convert.ToDecimal(tbTHDiscountM.Text.Trim());
            decimal THAM = Convert.ToDecimal(tbTHMon.Text.Trim());
            string THText = tbTHText.Text.Trim();
            decimal ghsl = Convert.ToDecimal(tbTHGHSL.Text.Trim());
            if (ghsl < THQuantity)
            {
                MessageBox.Show("退货数量不能多于订单中的购货量！", "警告");
                return;

            }

            if (MessageBox.Show("确认退货吗？", "退货", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string rrr = "";
                    rrr = "update KC set KCQuantity = KCQuantity - '" + THQuantity + "' where KCFoodName = '" + THFoodName + "' and KCGYS = '" + THGYS + "'";
                    db.DB_ZSG(rrr);
                    string sql = "insert into TH values('" + THNum + "','" + THTime + "','" + THGYS + "','" + THFoodName + "','" + THFoodType + "','" + THDM + "','" + THQuantity + "','" + THDiscountL + "','" + THDiscountM + "','" + THAM + "','" + THText + "')";
                    db.DB_ZSG(sql);
                    MessageBox.Show("成功退货!");
                    return;
                }
                catch
                {
                    MessageBox.Show("出错了,退货失败");
                    return;
                }
            }
        }
        //parentRest库存管理
        public void parentKC()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageKC;
            this.tabPageKC.Parent = tabControlMainWindow;
            //退货单查询*************************************************************************************************************************
            //出库单表格
            this.dataGridViewTHD.AutoGenerateColumns = false;
            string sql1 = "select * from TH";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewTHD.DataSource = dt;
            this.dataGridViewTHD.Columns[1].DataPropertyName = dt.Columns["THNum"].ToString();
            this.dataGridViewTHD.Columns[2].DataPropertyName = dt.Columns["THTime"].ToString();
            this.dataGridViewTHD.Columns[3].DataPropertyName = dt.Columns["THGYS"].ToString();
            this.dataGridViewTHD.Columns[4].DataPropertyName = dt.Columns["THFoodName"].ToString();
            this.dataGridViewTHD.Columns[5].DataPropertyName = dt.Columns["THFoodType"].ToString();
            this.dataGridViewTHD.Columns[6].DataPropertyName = dt.Columns["THDM"].ToString();
            this.dataGridViewTHD.Columns[7].DataPropertyName = dt.Columns["THQuantity"].ToString();
            this.dataGridViewTHD.Columns[8].DataPropertyName = dt.Columns["THDiscountL"].ToString();
            this.dataGridViewTHD.Columns[9].DataPropertyName = dt.Columns["THDiscountM"].ToString();
            this.dataGridViewTHD.Columns[10].DataPropertyName = dt.Columns["THAM"].ToString();
            this.dataGridViewTHD.Columns[11].DataPropertyName = dt.Columns["THText"].ToString();
        }
        //查询按钮事件
        private void button20_Click(object sender, EventArgs e)
        {
            DateTime timeStar = dateTimePickerTHDStart.Value;
            DateTime endStar = dateTimePickerTHDEnd.Value;
            string sql = "select * from TH where THTime between '" + timeStar + "' and '" + endStar + "'";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewTHD.DataSource = dt;
            this.dataGridViewTHD.Columns[1].DataPropertyName = dt.Columns["THNum"].ToString();
            this.dataGridViewTHD.Columns[2].DataPropertyName = dt.Columns["THTime"].ToString();
            this.dataGridViewTHD.Columns[3].DataPropertyName = dt.Columns["THGYS"].ToString();
            this.dataGridViewTHD.Columns[4].DataPropertyName = dt.Columns["THFoodName"].ToString();
            this.dataGridViewTHD.Columns[5].DataPropertyName = dt.Columns["THFoodType"].ToString();
            this.dataGridViewTHD.Columns[6].DataPropertyName = dt.Columns["THDM"].ToString();
            this.dataGridViewTHD.Columns[7].DataPropertyName = dt.Columns["THQuantity"].ToString();
            this.dataGridViewTHD.Columns[8].DataPropertyName = dt.Columns["THDiscountL"].ToString();
            this.dataGridViewTHD.Columns[9].DataPropertyName = dt.Columns["THDiscountM"].ToString();
            this.dataGridViewTHD.Columns[10].DataPropertyName = dt.Columns["THAM"].ToString();
            this.dataGridViewTHD.Columns[11].DataPropertyName = dt.Columns["THText"].ToString();
        }
        //显示全部按钮事件
        private void button19_Click(object sender, EventArgs e)
        {
            string sql = "select * from TH";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewTHD.DataSource = dt;
            this.dataGridViewTHD.Columns[1].DataPropertyName = dt.Columns["THNum"].ToString();
            this.dataGridViewTHD.Columns[2].DataPropertyName = dt.Columns["THTime"].ToString();
            this.dataGridViewTHD.Columns[3].DataPropertyName = dt.Columns["THGYS"].ToString();
            this.dataGridViewTHD.Columns[4].DataPropertyName = dt.Columns["THFoodName"].ToString();
            this.dataGridViewTHD.Columns[5].DataPropertyName = dt.Columns["THFoodType"].ToString();
            this.dataGridViewTHD.Columns[6].DataPropertyName = dt.Columns["THDM"].ToString();
            this.dataGridViewTHD.Columns[7].DataPropertyName = dt.Columns["THQuantity"].ToString();
            this.dataGridViewTHD.Columns[8].DataPropertyName = dt.Columns["THDiscountL"].ToString();
            this.dataGridViewTHD.Columns[9].DataPropertyName = dt.Columns["THDiscountM"].ToString();
            this.dataGridViewTHD.Columns[10].DataPropertyName = dt.Columns["THAM"].ToString();
            this.dataGridViewTHD.Columns[11].DataPropertyName = dt.Columns["THText"].ToString();
        }
        //表格点击删除按钮事件
        private void dataGridViewTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTHD.Columns[e.ColumnIndex].Name == "ColumnTHX")
            {
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string bianhao = dataGridViewTHD.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string sql = "delete from RK where RKNum = '" + bianhao + "'";
                    try
                    {
                        db.DB_ZSG(sql);
                        dataGridViewTHD.Rows.Remove(this.dataGridViewTHD.Rows[e.RowIndex]);
                        MessageBox.Show("删除成功", "删除");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("出错啦，删除失败", "警告");
                        return;
                    }
                }
            }
        }
        public void parentRK()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageRK;
            this.tabPageRK.Parent = tabControlMainWindow;
            //入库*************************************************************************************************************************
            foreach (DataGridViewColumn column in dataGridViewRK.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            laRKts.Text = "";
            tbRKNum.ReadOnly = true;
            this.tbRKOrderMum.Text = GetRanddom3();
            this.tbRKOrderMum.ReadOnly = true;
            //采购单表格
            this.dataGridViewRK.AutoGenerateColumns = false;
            string sql1 = "select * from CG where CGState = '未入库'";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewRK.DataSource = dt;
            this.dataGridViewRK.Columns[0].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewRK.Columns[1].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewRK.Columns[2].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewRK.Columns[3].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewRK.Columns[4].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewRK.Columns[5].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewRK.Columns[6].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewRK.Columns[7].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewRK.Columns[8].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewRK.Columns[9].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewRK.Columns[10].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewRK.Columns[11].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        //查询订单按钮事件
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime timeStar = dateTimePickerRKStart.Value;
            DateTime endStar = dateTimePickerRKEnd.Value;
            string sql = "select * from CG where CGTime between '" + timeStar + "' and '" + endStar + "'";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewRK.DataSource = dt;
            this.dataGridViewRK.Columns[0].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewRK.Columns[1].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewRK.Columns[2].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewRK.Columns[3].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewRK.Columns[4].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewRK.Columns[5].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewRK.Columns[6].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewRK.Columns[7].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewRK.Columns[8].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewRK.Columns[9].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewRK.Columns[10].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewRK.Columns[11].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        //显示全部按钮事件
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from CG";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewRK.DataSource = dt;
            this.dataGridViewRK.Columns[0].DataPropertyName = dt.Columns["OrderMum"].ToString();
            this.dataGridViewRK.Columns[1].DataPropertyName = dt.Columns["CGTime"].ToString();
            this.dataGridViewRK.Columns[2].DataPropertyName = dt.Columns["CGGYS"].ToString();
            this.dataGridViewRK.Columns[3].DataPropertyName = dt.Columns["CGFoodName"].ToString();
            this.dataGridViewRK.Columns[4].DataPropertyName = dt.Columns["CGFoodType"].ToString();
            this.dataGridViewRK.Columns[5].DataPropertyName = dt.Columns["CGDM"].ToString();
            this.dataGridViewRK.Columns[6].DataPropertyName = dt.Columns["CGQuantity"].ToString();
            this.dataGridViewRK.Columns[7].DataPropertyName = dt.Columns["CGDiscountL"].ToString();
            this.dataGridViewRK.Columns[8].DataPropertyName = dt.Columns["CGDiscountM"].ToString();
            this.dataGridViewRK.Columns[9].DataPropertyName = dt.Columns["CGAM"].ToString();
            this.dataGridViewRK.Columns[10].DataPropertyName = dt.Columns["CGText"].ToString();
            this.dataGridViewRK.Columns[11].DataPropertyName = dt.Columns["CGState"].ToString();
        }
        string ddbh = "";
        decimal ghsl = 0;
        //点击表格行获取数据
        private void dataGridViewRK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbRKNum.ReadOnly = false;
            try
            {
                if (this.dataGridViewRK[0, this.dataGridViewRK.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    ddbh = dataGridViewRK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbRKGYS.Text = dataGridViewRK.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbRKFoodName.Text = dataGridViewRK.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbRKFoodType.Text = dataGridViewRK.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbRKDM.Text = dataGridViewRK.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tbRKDiscountL.Text = dataGridViewRK.Rows[e.RowIndex].Cells[7].Value.ToString();
                    tbRKDiscountMM.Text = dataGridViewRK.Rows[e.RowIndex].Cells[8].Value.ToString();
                    tbRKNum.Text = dataGridViewRK.Rows[e.RowIndex].Cells[6].Value.ToString();
                    tbRKAM.Text = dataGridViewRK.Rows[e.RowIndex].Cells[9].Value.ToString();
                    ghsl = Convert.ToDecimal(dataGridViewRK.Rows[e.RowIndex].Cells[6].Value.ToString());

                }
            }
            catch 
            {
                MessageBox.Show("无法选择表头", "警告");
                return;
            }
        }
        //输入数量动态显示价格
        private void tbRKNum_TextChanged(object sender, EventArgs e)
        {
            if (tbRKNum.Text != "")
            {
                decimal rusl = Convert.ToDecimal(tbRKNum.Text);
                if (rusl > ghsl)
                {
                    laRKts.Text = "提示：入库数量不能多于该订单的购货数量！";
                    laRKts.ForeColor = Color.Red;
                }
                else
                {
                    laRKts.Text = "";
                    decimal zje = Convert.ToDecimal(tbRKNum.Text.Trim()) * Convert.ToDecimal(tbRKDM.Text.Trim());//总金额
                    decimal zke = Convert.ToDecimal(tbRKNum.Text.Trim()) * (1 - Convert.ToDecimal(tbRKDiscountL.Text.Trim())) * Convert.ToDecimal(tbRKDM.Text.Trim());//折扣额
                    tbRKDiscountMM.Text = Convert.ToString(zke);
                    decimal sfje = zje - zke;//实付金额
                    tbRKAM.Text = Convert.ToString(sfje);
                }
            }
            else
            {
                tbRKDiscountMM.Text = "";
                tbRKAM.Text = "";
                laRKts.Text = "";
            }
        }
        
        //确认入库按钮事件
        private void button5_Click(object sender, EventArgs e)
        {

            string RKNum = this.tbRKOrderMum.Text;
            DateTime RKTime = dateTimePickerRKTimeNow.Value;
            string RKGYS = tbRKGYS.Text.Trim();
            string RKFoodName = tbRKFoodName.Text.Trim();
            string RKFoodType = tbRKFoodType.Text.Trim();
            decimal RKDM = Convert.ToDecimal(tbRKDM.Text.Trim());
            decimal RKQuantity = Convert.ToDecimal(tbRKNum.Text.Trim());
            decimal RKDiscountL = Convert.ToDecimal(tbRKDiscountL.Text.Trim());
            decimal RKDiscountM = Convert.ToDecimal(tbRKDiscountMM.Text.Trim());
            decimal RKAM = Convert.ToDecimal(tbRKAM.Text.Trim());
            string RKText = tbRKText.Text.Trim();
            if (RKQuantity > ghsl)
            {
                MessageBox.Show("入库数量不能大于订单上的数量！");
                return;
            }

            if (MessageBox.Show("确认入库吗？", "入库", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                string sql = "insert into RK values('" + RKNum + "','" + RKTime + "','" + RKGYS + "','" + RKFoodName + "','" + RKFoodType + "','" + RKDM + "','" + RKQuantity + "','" + RKDiscountL + "','" + RKDiscountM + "','" + RKAM + "','" + RKText + "')";
                try
                {
                    string sql1 = "select * from KC where KCFoodName = '" + RKFoodName + "' and KCGYS = '" + RKGYS + "'";
                    SqlDataReader dr1 = db.DB_Red(sql1);
                    string rrr = "";
                    if (dr1.Read())
                    {
                        rrr = "update KC set KCQuantity = KCQuantity + '" + RKQuantity + "' where KCFoodName = '" + RKFoodName + "' and KCGYS = '" + RKGYS + "'";
                    }
                    else
                    {
                        rrr = "insert into KC values('" + RKGYS + "','" + RKFoodName + "','" + RKFoodType + "','" + RKDM + "','0','" + RKQuantity + "')";
                    }
                    db.DB_ZSG(rrr);
                    db.DB_ZSG(sql);
                    string sss = "update CG set CGState = '已入库' where OrderMum = '" + ddbh + "'";
                    db.DB_ZSG(sss);
                    MessageBox.Show("该商品已成功入库!");
                    return;
                }
                catch
                {
                    MessageBox.Show("出错了,入库失败");
                    return;
                }
            }
        }
        public void parentCK()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageCK;
            this.tabPageCK.Parent = tabControlMainWindow;

            //出库*************************************************************************************************************************
            labCKts.Text = "";
            tbCKNum.ReadOnly = true;
            this.tbCKOrderMum.Text = GetRanddom3();
            this.tbCKOrderMum.ReadOnly = true;
            this.comboBoxCKFoodTyep.Items.Clear();
            this.comboBoxCKFoodTyep.Items.Add("全部");
            string sqlcgsplx = "select distinct KCFoodType from KC";
            SqlDataReader dr = db.DB_Red(sqlcgsplx);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.comboBoxCKFoodTyep.Items.Add(dr[0].ToString());
                    this.comboBoxCKFoodTyep.SelectedIndex = 0;
                }

            }
            dr.Close();
            //采购单表格
            this.dataGridViewCK.AutoGenerateColumns = false;
            string sql1 = "select * from KC";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCK.DataSource = dt;
            this.dataGridViewCK.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewCK.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewCK.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewCK.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewCK.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewCK.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //显示全部按钮事件
        private void button13_Click(object sender, EventArgs e)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;
            string sql1 = "select * from KC";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCK.DataSource = dt;
            this.dataGridViewCK.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewCK.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewCK.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewCK.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewCK.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewCK.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //查询按钮事件
        private void button9_Click(object sender, EventArgs e)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;
            string strCKFoodType = comboBoxCKFoodTyep.Text;
            string strCKFoodName = tbCKName.Text;
            string sql1 = "";
            if (strCKFoodType == "全部")
            {
                sql1 = "select * from KC where KCFoodName = '" + strCKFoodName + "'";
            }
            else 
            {
                sql1 = "select * from KC where KCFoodType = '" + strCKFoodType + "' and KCFoodName = '" + strCKFoodName + "'";
            }
            
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCK.DataSource = dt;
            this.dataGridViewCK.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewCK.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewCK.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewCK.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewCK.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewCK.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //下拉单改变事件
        private void comboBoxCKFoodTyep_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridViewCK.AutoGenerateColumns = false;
            string strCKFoodType = comboBoxCKFoodTyep.Text;
            string sql1 = "";
            if (strCKFoodType == "全部")
            {
                sql1 = "select * from KC";
            }
            else
            {
                sql1 = "select * from KC where KCFoodType = '" + strCKFoodType + "'";
            }

            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCK.DataSource = dt;
            this.dataGridViewCK.Columns[0].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewCK.Columns[1].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewCK.Columns[2].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewCK.Columns[3].DataPropertyName = dt.Columns["KCBM"].ToString();
            this.dataGridViewCK.Columns[4].DataPropertyName = dt.Columns["KCSJ"].ToString();
            this.dataGridViewCK.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
        }
        //灰体字点击事件
        private void tbCKName_Click(object sender, EventArgs e)
        {
            if (tbCKName.ForeColor.Equals(Color.Gray))
            {
                tbCKName.Clear();
                tbCKName.ForeColor = Color.Black;
            }
        }
        //点击表格行获取数据
        private void dataGridViewCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCKNum.ReadOnly = false;
            try
            {
                if (this.dataGridViewCK[0, this.dataGridViewCK.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    tbCKGYS.Text = dataGridViewCK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbCKFoodName.Text = dataGridViewCK.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbCKFoodType.Text = dataGridViewCK.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbCKDM.Text = dataGridViewCK.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbCKSJ.Text = dataGridViewCK.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbCKQuantity.Text = dataGridViewCK.Rows[e.RowIndex].Cells[5].Value.ToString();
                }

            }
            catch
            {
                MessageBox.Show("无法选择表头", "警告");
                return;
            }
        }
        //输入出库数量动态显示价钱
        private void tbCKNum_TextChanged(object sender, EventArgs e)
        {
            if (tbCKNum.Text != "")
            {
                decimal cun = Convert.ToDecimal(tbCKQuantity.Text.Trim());
                decimal CKQuantity = Convert.ToDecimal(tbCKNum.Text.Trim());
                decimal csje = Convert.ToDecimal(tbCKNum.Text.Trim()) * Convert.ToDecimal(tbCKSJ.Text.Trim());//
                tbCKMon.Text = Convert.ToString(csje);
                decimal lr = Convert.ToDecimal(tbCKNum.Text.Trim()) * (Convert.ToDecimal(tbCKSJ.Text.Trim()) - Convert.ToDecimal(tbCKDM.Text.Trim()));
                tbCKCKLR.Text = Convert.ToString(lr);
                if (CKQuantity > cun)
                {
                    labCKts.Text = "提示：仓库里没有这么多的货物！";
                    labCKts.ForeColor = Color.Red;
                }
                else
                {
                    labCKts.Text = "";
                }
            }
            else
            {
                tbCKMon.Text = "";
                tbCKCKLR.Text = "";
                labCKts.Text = "";
            }
        }
        //确认出库按钮
        private void button11_Click(object sender, EventArgs e)
        {
            string CKNum = this.tbCKOrderMum.Text;
            DateTime CKTime = dateTimePickerCKNowTime.Value;
            string CKKGYS = tbCKGYS.Text.Trim();
            string CKFoodName = tbCKFoodName.Text.Trim();
            string CKFoodType = tbCKFoodType.Text.Trim();
            decimal CKDM = Convert.ToDecimal(tbCKDM.Text.Trim());
            decimal CKSJ = Convert.ToDecimal(tbCKSJ.Text.Trim());
            decimal CKQuantity = Convert.ToDecimal(tbCKNum.Text.Trim());
            decimal CKAM = Convert.ToDecimal(tbCKMon.Text.Trim());
            decimal CKLR = Convert.ToDecimal(tbCKCKLR.Text.Trim());
            string CKText = tbCKText.Text.Trim();
            decimal cun =  Convert.ToDecimal(tbCKQuantity.Text.Trim());
            if (CKQuantity > cun)
            { 
                MessageBox.Show("对不起,仓库没有这么多货源！","警告");
                return;
            }

            if (MessageBox.Show("确认出库吗？", "出库", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string rrr = "update KC set KCQuantity = KCQuantity - '" + CKQuantity + "' where KCFoodName = '" + CKFoodName + "' and KCGYS = '" + CKKGYS + "'";
                    db.DB_ZSG(rrr);
                    //MessageBox.Show(rrr);
                    string sql = "insert into CK values('" + CKNum + "','" + CKTime + "','" + CKKGYS + "','" + CKFoodName + "','" + CKFoodType + "','" + CKDM + "','" + CKSJ + "','" + CKQuantity + "','" + CKAM + "','" + CKLR + "','" + CKText + "')";
                    db.DB_ZSG(sql);
                    MessageBox.Show("出库成功!");
                    return;
                }
                catch
                {
                    MessageBox.Show("出错了,出库失败");
                    return;
                }
            }
        }
        
        public void parentSR()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageSR;
            this.tabPageSR.Parent = tabControlMainWindow;
            //入库单查询*******************************************************************************************************************
            //入库单表格
            this.dataGridViewRKD.AutoGenerateColumns = false;
            string sql1 = "select * from RK";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewRKD.DataSource = dt;
            this.dataGridViewRKD.Columns[1].DataPropertyName = dt.Columns["RKNum"].ToString();
            this.dataGridViewRKD.Columns[2].DataPropertyName = dt.Columns["RKTime"].ToString();
            this.dataGridViewRKD.Columns[3].DataPropertyName = dt.Columns["RKGYS"].ToString();
            this.dataGridViewRKD.Columns[4].DataPropertyName = dt.Columns["RKFoodName"].ToString();
            this.dataGridViewRKD.Columns[5].DataPropertyName = dt.Columns["RKFoodType"].ToString();
            this.dataGridViewRKD.Columns[6].DataPropertyName = dt.Columns["RKDM"].ToString();
            this.dataGridViewRKD.Columns[7].DataPropertyName = dt.Columns["RKQuantity"].ToString();
            this.dataGridViewRKD.Columns[8].DataPropertyName = dt.Columns["RKDiscountL"].ToString();
            this.dataGridViewRKD.Columns[9].DataPropertyName = dt.Columns["RKDiscountM"].ToString();
            this.dataGridViewRKD.Columns[10].DataPropertyName = dt.Columns["RKAM"].ToString();
            this.dataGridViewRKD.Columns[11].DataPropertyName = dt.Columns["RKText"].ToString();
        }
        //查询按钮事件
        private void button7_Click(object sender, EventArgs e)
        {
            DateTime timeStar = dateTimePickerRKDStart.Value;
            DateTime endStar = dateTimePickerRKDEnd.Value;
            string sql = "select * from RK where RKTime between '" + timeStar + "' and '" + endStar + "'";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewRKD.DataSource = dt;
            this.dataGridViewRKD.Columns[1].DataPropertyName = dt.Columns["RKNum"].ToString();
            this.dataGridViewRKD.Columns[2].DataPropertyName = dt.Columns["RKTime"].ToString();
            this.dataGridViewRKD.Columns[3].DataPropertyName = dt.Columns["RKGYS"].ToString();
            this.dataGridViewRKD.Columns[4].DataPropertyName = dt.Columns["RKFoodName"].ToString();
            this.dataGridViewRKD.Columns[5].DataPropertyName = dt.Columns["RKFoodType"].ToString();
            this.dataGridViewRKD.Columns[6].DataPropertyName = dt.Columns["RKDM"].ToString();
            this.dataGridViewRKD.Columns[7].DataPropertyName = dt.Columns["RKQuantity"].ToString();
            this.dataGridViewRKD.Columns[8].DataPropertyName = dt.Columns["RKDiscountL"].ToString();
            this.dataGridViewRKD.Columns[9].DataPropertyName = dt.Columns["RKDiscountM"].ToString();
            this.dataGridViewRKD.Columns[10].DataPropertyName = dt.Columns["RKAM"].ToString();
            this.dataGridViewRKD.Columns[11].DataPropertyName = dt.Columns["RKText"].ToString();
        }
        //显示全部按钮事件
        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from RK";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewRKD.DataSource = dt;
            this.dataGridViewRKD.Columns[1].DataPropertyName = dt.Columns["RKNum"].ToString();
            this.dataGridViewRKD.Columns[2].DataPropertyName = dt.Columns["RKTime"].ToString();
            this.dataGridViewRKD.Columns[3].DataPropertyName = dt.Columns["RKGYS"].ToString();
            this.dataGridViewRKD.Columns[4].DataPropertyName = dt.Columns["RKFoodName"].ToString();
            this.dataGridViewRKD.Columns[5].DataPropertyName = dt.Columns["RKFoodType"].ToString();
            this.dataGridViewRKD.Columns[6].DataPropertyName = dt.Columns["RKDM"].ToString();
            this.dataGridViewRKD.Columns[7].DataPropertyName = dt.Columns["RKQuantity"].ToString();
            this.dataGridViewRKD.Columns[8].DataPropertyName = dt.Columns["RKDiscountL"].ToString();
            this.dataGridViewRKD.Columns[9].DataPropertyName = dt.Columns["RKDiscountM"].ToString();
            this.dataGridViewRKD.Columns[10].DataPropertyName = dt.Columns["RKAM"].ToString();
            this.dataGridViewRKD.Columns[11].DataPropertyName = dt.Columns["RKText"].ToString(); ;
        }
        //表格点击删除按钮事件
        private void dataGridViewRKD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRKD.Columns[e.ColumnIndex].Name == "ColumnRKX")
            {
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string bianhao = dataGridViewRKD.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string sql = "delete from RK where RKNum = '" + bianhao + "'";
                    try
                    {
                        db.DB_ZSG(sql);
                        dataGridViewRKD.Rows.Remove(this.dataGridViewRKD.Rows[e.RowIndex]);
                        MessageBox.Show("删除成功", "删除");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("出错啦，删除失败", "警告");
                        return;
                    }
                }
            }
        }
        public void parentZB()
        {
            this.tabControlMainWindow.SelectedTab = this.tabPageZB;
            this.tabPageZB.Parent = tabControlMainWindow;
            //出库单查询*******************************************************************************************************************
            //出库单表格
            this.dataGridViewCKD.AutoGenerateColumns = false;
            string sql1 = "select * from CK";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCKD.DataSource = dt;
            this.dataGridViewCKD.Columns[1].DataPropertyName = dt.Columns["CKNum"].ToString();
            this.dataGridViewCKD.Columns[2].DataPropertyName = dt.Columns["CKTime"].ToString();
            this.dataGridViewCKD.Columns[3].DataPropertyName = dt.Columns["CKGYS"].ToString();
            this.dataGridViewCKD.Columns[4].DataPropertyName = dt.Columns["CKFoodName"].ToString();
            this.dataGridViewCKD.Columns[5].DataPropertyName = dt.Columns["CKFoodType"].ToString();
            this.dataGridViewCKD.Columns[6].DataPropertyName = dt.Columns["CKDM"].ToString();
            this.dataGridViewCKD.Columns[7].DataPropertyName = dt.Columns["CKSJ"].ToString();
            this.dataGridViewCKD.Columns[8].DataPropertyName = dt.Columns["CKQuantity"].ToString();
            this.dataGridViewCKD.Columns[9].DataPropertyName = dt.Columns["CKAM"].ToString();
            this.dataGridViewCKD.Columns[10].DataPropertyName = dt.Columns["CKLR"].ToString();
            this.dataGridViewCKD.Columns[11].DataPropertyName = dt.Columns["CKText"].ToString();
        }
        //查询按钮事件
        private void button15_Click(object sender, EventArgs e)
        {
            DateTime timeStar = dateTimePickerCKDStart.Value;
            DateTime endStar = dateTimePickerCKDEnd.Value;
            string sql = "select * from CK where CKTime between '" + timeStar + "' and '" + endStar + "'";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCKD.DataSource = dt;
            this.dataGridViewCKD.Columns[1].DataPropertyName = dt.Columns["CKNum"].ToString();
            this.dataGridViewCKD.Columns[2].DataPropertyName = dt.Columns["CKTime"].ToString();
            this.dataGridViewCKD.Columns[3].DataPropertyName = dt.Columns["CKGYS"].ToString();
            this.dataGridViewCKD.Columns[4].DataPropertyName = dt.Columns["CKFoodName"].ToString();
            this.dataGridViewCKD.Columns[5].DataPropertyName = dt.Columns["CKFoodType"].ToString();
            this.dataGridViewCKD.Columns[6].DataPropertyName = dt.Columns["CKDM"].ToString();
            this.dataGridViewCKD.Columns[7].DataPropertyName = dt.Columns["CKSJ"].ToString();
            this.dataGridViewCKD.Columns[8].DataPropertyName = dt.Columns["CKQuantity"].ToString();
            this.dataGridViewCKD.Columns[9].DataPropertyName = dt.Columns["CKAM"].ToString();
            this.dataGridViewCKD.Columns[10].DataPropertyName = dt.Columns["CKLR"].ToString();
            this.dataGridViewCKD.Columns[11].DataPropertyName = dt.Columns["CKText"].ToString();
        }
        //显示全部按钮事件
        private void button14_Click(object sender, EventArgs e)
        {
            string sql = "select * from CK";
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewCKD.DataSource = dt;
            this.dataGridViewCKD.Columns[1].DataPropertyName = dt.Columns["CKNum"].ToString();
            this.dataGridViewCKD.Columns[2].DataPropertyName = dt.Columns["CKTime"].ToString();
            this.dataGridViewCKD.Columns[3].DataPropertyName = dt.Columns["CKGYS"].ToString();
            this.dataGridViewCKD.Columns[4].DataPropertyName = dt.Columns["CKFoodName"].ToString();
            this.dataGridViewCKD.Columns[5].DataPropertyName = dt.Columns["CKFoodType"].ToString();
            this.dataGridViewCKD.Columns[6].DataPropertyName = dt.Columns["CKDM"].ToString();
            this.dataGridViewCKD.Columns[7].DataPropertyName = dt.Columns["CKSJ"].ToString();
            this.dataGridViewCKD.Columns[8].DataPropertyName = dt.Columns["CKQuantity"].ToString();
            this.dataGridViewCKD.Columns[9].DataPropertyName = dt.Columns["CKAM"].ToString();
            this.dataGridViewCKD.Columns[10].DataPropertyName = dt.Columns["CKLR"].ToString();
            this.dataGridViewCKD.Columns[11].DataPropertyName = dt.Columns["CKText"].ToString();
        }
        //表格点击删除按钮事件
        private void dataGridViewCKD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCKD.Columns[e.ColumnIndex].Name == "ColumnCKX")
            {
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string bianhao = dataGridViewCKD.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string sql = "delete from CK where CKNum = '" + bianhao + "'";
                    try
                    {
                        db.DB_ZSG(sql);
                        dataGridViewCKD.Rows.Remove(this.dataGridViewCKD.Rows[e.RowIndex]);
                        MessageBox.Show("删除成功", "删除");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("出错啦，删除失败", "警告");
                        return;
                    }
                }
            }
        }
        //
        //.......................


        //CG采购订单的函数群
        //添加商品事件
        private void buttonCGAddItem_Click(object sender, EventArgs e)
        {
            formCGAdd formCGadd = new formCGAdd();
            formCGadd.ShowDialog();
        }
        //GYS供应商货品汇总的函数群
        private void buttonGYSAddItem_Click(object sender, EventArgs e)
        {
            formGYSAdd formGYSadd = new formGYSAdd();
            formGYSadd.ShowDialog();
        }
        //TH退货单的函数群
        private void buttonTHAddItem_Click(object sender, EventArgs e)
        {
            formTHAdd formTHadd = new formTHAdd();
            formTHadd.Show();
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}
