using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace aomsin
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            status.Text = "Ready";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM user WHERE username = '" + userBox.Text + "' AND password = '" + passBox.Text + "'";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin"﻿);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    status.Text = "เข้าสู่ระบบสำเร็จ";
                    this.Hide();
                    Dashboard dbs = new Dashboard(userBox.Text);
                    dbs.Show();
                }
            }
            else
            {
                status.Text = "เข้าสู่ระบบไม่สำเร็จ อันเนื่องมาจากรหัสผ่านผิดหรือชื่อผู้ใช้ผิด กรุณาติดต่อผู้ดูแลระบบ";
            }
        }
    }
}
