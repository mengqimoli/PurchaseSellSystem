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
using PurchaseSellSystem.Share;
using System.Data.SqlClient;

namespace PurchaseSellSystem
{
    public partial class formGYSAdd : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        
        public formGYSAdd()
        {
            InitializeComponent();
        }

        private void formGYSAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonformGYSClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonformGYSAdd_Click(object sender, EventArgs e)
        {
            //定义变量
            string strGYS = "";
            string strFoodName = "";
            decimal strDM = 0;
            decimal strDiscountL = 0;
            decimal strQuantity = 0;
            string strFoodType = "";
            string strText = "";

            //校验
            if (textBoxformGYSFoodName.Text.Trim() == "")
            {
                MessageBox.Show("商品名不能为空!");
                textBoxformGYSFoodName.Focus();
                return;
            }
            if (Validator.IsNumber(textBoxformGYSDM.Text.Trim()) == false)
            {
                MessageBox.Show("请输入单价并输入数值型数!");
                textBoxformGYSDM.Focus();
                return;
            }
            if (Validator.IsNumber(textBoxformGYSDiscountL.Text.Trim()) == false)
            {
                MessageBox.Show("请输入折扣率并输入数值型数!");
                textBoxformGYSDiscountL.Focus();
                return;
            }
            if (Validator.IsNumber(textBoxformGYSQuantity.Text.Trim()) == false)
            {
                MessageBox.Show("请输入货存并输入数值型数!");
                textBoxformGYSQuantity.Focus();
                return;
            }

            // 获取数据 
            strGYS = textBoxformGYS.Text.Trim();
            strFoodName = textBoxformGYSFoodName.Text.Trim();
            strFoodType = comboBoxformGYSFoodType.Text;
            strDM = Convert.ToDecimal(textBoxformGYSDM.Text.Trim());
            strDiscountL = Convert.ToDecimal(textBoxformGYSDiscountL.Text.Trim());
            strQuantity = Convert.ToDecimal(textBoxformGYSQuantity.Text.Trim());
            strText = textBoxformGYSText.Text.Trim();

            string strSql = "select * from GYSAllFood where GYSFoodName = '"+strFoodName+"' and GYS = '" + strGYS + "'";
            SqlDataReader dr = db.DB_Red(strSql);
            if (dr.Read()){
                MessageBox.Show("添加失败,该供应商已拥有此商品！", "警告");
                dr.Close();
                return;
            }
            else {
                string strSql1 = "insert into GYSAllFood values('" + strGYS + "','" + strFoodName + "','" + strFoodType + "','" + strDM + "','" + strDiscountL + "','" + strQuantity + "','" + strText + "')";
                try
                {
                    db.DB_ZSG(strSql1);
                    MessageBox.Show("添加成功!","添加");
                    this.Close();
                }
                catch {
                    MessageBox.Show("添加失败,请重新添加","警告");
                    return;
                }
            }
        }
    }
}
