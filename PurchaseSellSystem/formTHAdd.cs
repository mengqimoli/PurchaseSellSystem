using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBCL;

namespace PurchaseSellSystem
{
    public partial class formTHAdd : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        public formTHAdd()
        {
            InitializeComponent();
        }
        private void formTHAdd_Load(object sender, EventArgs e)
        {
            //下拉菜单
            this.comboBoxformTHGYS.Items.Add("全部");
            string sql = "select distinct KCGYS from KC";
            SqlDataReader dr = db.DB_Red(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.comboBoxformTHGYS.Items.Add(dr[0].ToString());
                    this.comboBoxformTHGYS.SelectedIndex = 0;
                }
                dr.Close();
            }
            //表格
            this.dataGridViewformCG.AutoGenerateColumns = false;
            string sql1 = "select * from KC";
            SqlDataAdapter da = db.DB_Adp(sql1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridViewformCG.DataSource = dt;
            this.dataGridViewformCG.Columns[1].DataPropertyName = dt.Columns["KCGYS"].ToString();
            this.dataGridViewformCG.Columns[2].DataPropertyName = dt.Columns["KCFoodName"].ToString();
            this.dataGridViewformCG.Columns[3].DataPropertyName = dt.Columns["KCFoodType"].ToString();
            this.dataGridViewformCG.Columns[4].DataPropertyName = dt.Columns["KCDM"].ToString();
            this.dataGridViewformCG.Columns[5].DataPropertyName = dt.Columns["KCQuantity"].ToString();
            this.dataGridViewformCG.Columns[6].DataPropertyName = dt.Columns["GYSQuantity"].ToString();
        }
        private void textBoxformTHSearch_Click(object sender, EventArgs e)
        {
            if (textBoxformTHSearch.ForeColor.Equals(Color.Gray))
            {
                textBoxformTHSearch.Clear();
                textBoxformTHSearch.ForeColor = Color.Black;
            }
        }

        
    }
}
