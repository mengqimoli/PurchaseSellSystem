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
    public partial class formCGAdd : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        DataTable dtable = new DataTable();
        DataRow row;
        public formCGAdd()
        {
            InitializeComponent();
        }

        private void formCGAdd_Load(object sender, EventArgs e)
        {
            //下拉菜单
            this.comboBoxformCGGYS.Items.Add("全部");
            string sql = "select distinct GYS from GYSAllFood";
            SqlDataReader dr = db.DB_Red(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.comboBoxformCGGYS.Items.Add(dr[0].ToString());
                    this.comboBoxformCGGYS.SelectedIndex = 0;
                }
                dr.Close();
            }
            //表格
            this.dataGridViewformCG.AutoGenerateColumns = false; 
            string sql1 = "select * from GYSAllFood";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewformCG.DataSource = dt;
            this.dataGridViewformCG.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewformCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewformCG.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewformCG.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewformCG.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewformCG.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewformCG.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
            this.dataGridViewformCG.Columns[8].DataPropertyName = "";
        }

        private void textBoxformCGSearch_Click(object sender, EventArgs e)
        {
            if (textBoxformCGSearch.ForeColor.Equals(Color.Gray))
            {
                textBoxformCGSearch.Clear();
                textBoxformCGSearch.ForeColor = Color.Black;
            }
        }

        private void comboBoxformCGGYS_SelectedIndexChanged(object sender, EventArgs e)
        {

            string strGYS = "";
            strGYS = comboBoxformCGGYS.Text;

            string sql = "";
            if (strGYS == "全部")
            {
                sql = "select * from GYSAllFood";
            }
            else
            {
                sql = "select * from GYSAllFood where GYS = '" + strGYS + "'";
            }
            this.dataGridViewformCG.AutoGenerateColumns = false;
            SqlDataAdapter da = db.DB_Adp(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewformCG.DataSource = dt;
            this.dataGridViewformCG.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewformCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewformCG.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewformCG.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewformCG.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewformCG.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewformCG.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
            this.dataGridViewformCG.Columns[8].DataPropertyName = "";
        }
        private void buttonformCGSearch_Click(object sender, EventArgs e)
        {
            string strGYS = "";
            string strGYSFoodName = "";
            string sql = "";
            strGYS = comboBoxformCGGYS.Text;
            strGYSFoodName = textBoxformCGSearch.Text.Trim();

            this.dataGridViewformCG.AutoGenerateColumns = false;
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
            this.dataGridViewformCG.DataSource = dt;
            this.dataGridViewformCG.Columns[1].DataPropertyName = dt.Columns["GYS"].ToString();
            this.dataGridViewformCG.Columns[2].DataPropertyName = dt.Columns["GYSFoodName"].ToString();
            this.dataGridViewformCG.Columns[3].DataPropertyName = dt.Columns["GYSFoodType"].ToString();
            this.dataGridViewformCG.Columns[4].DataPropertyName = dt.Columns["GYSDM"].ToString();
            this.dataGridViewformCG.Columns[5].DataPropertyName = dt.Columns["GYSDiscountL"].ToString();
            this.dataGridViewformCG.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
            this.dataGridViewformCG.Columns[7].DataPropertyName = dt.Columns["GYSText"].ToString();
            this.dataGridViewformCG.Columns[8].DataPropertyName = "";
        }
        //返回按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public delegate void caigou();

        //public event caigou biaoge;

        //添加按钮事件
        private void buttonformCGAdd_Click(object sender, EventArgs e)
        {
            int flag = 0;
            DataTable dt = new DataTable();
            dt = (dataGridViewformCG.DataSource as DataTable);
            dt.Columns.Add("ColumnformCGNumber", typeof(string));
            dtable = dt.Clone();
            //dtable.Columns.Add("Num", typeof(string));
            foreach (DataGridViewRow Row in dataGridViewformCG.Rows)
            { 
                //判断是否被选中
                if (Row.Cells["ColumnformCGCheck"].Value != null && (bool)Row.Cells["ColumnformCGCheck"].Value != false)
                {
                    flag = 1;
                    DataRowView drv = Row.DataBoundItem as DataRowView;//获取行中所有数据
                    row = (DataRow)drv.Row;//将drv行中数据添加到定义行中
                    dtable.Rows.Add(row.ItemArray); //添加就行了
                }
                else
                {
                    continue;//继续找
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("请选择食品！", "警告");
                return;
            }
            //this.dataGridView1.DataSource = dtable;
            //Form1 frm1 = new Form1();
            //frm1.frm2dtTable = dtable;
            //frm1.Show();
           // biaoge();
            //frm1.Show();
            //this.Hide();
        }
    }
}
