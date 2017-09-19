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
    public partial class Login : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        //函数*****************************************************************
        //构造
        public Login()
        {
            InitializeComponent();
        }
        //退出按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //登录按钮事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = "";
            string strUserPwd = "";

            strUserName = tbUserName.Text.Trim();
            strUserPwd = tbUserPwd.Text.Trim();

            if (strUserName == "")
            {
                MessageBox.Show("用户名不能为空！", "警告");
                return;
            }
            if (strUserPwd == "")
            {
                MessageBox.Show("密码不能为空！", "警告");
                return;
            }

            string strSql = "";
            strSql = "select UserPwd from UserTable where UserName = '"+strUserName+"'";
            SqlDataReader dr = db.DB_Red(strSql);
            if(dr.Read())
            {
                if (strUserPwd.Equals(db.DB_C(strSql, 0)))
                {
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }
                else
                { 
                    MessageBox.Show("密码错误！","警告");
                    return;
                }
            }
            else
            {
                MessageBox.Show("用户名不存在！", "警告");
                return;
            }
        }
    }
}
