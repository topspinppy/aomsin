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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usernamez = username.Text;
            string passz = password.Text;
            string namez = name.Text;

            if (usernamez == "" && passz == "" && namez == "" 
                || usernamez != "" && passz == "" && namez == "" 
                || usernamez == "" && passz != "" && namez == ""
                || usernamez == "" && passz == "" && namez != "")
                ////////////////////////////////////////////////
            {
                MessageBox.Show("ข้อมูลของคุณไม่สมบูรณ์ กรุณากรอกใหม่");

            }
            else
            {
                string sql = "INSERT INTO `user` (`id`, `username`, `password`, `name`) VALUES (NULL, '" + username.Text + "', '" + password.Text + "','" + name.Text + "')";
                MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin;charset=utf8;");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialog = MessageBox.Show("Successfully save", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialog == DialogResult.OK)
                {
                    this.Hide();
                    LoginPage login = new LoginPage();
                    login.Show();
                }
            }
        }
    }
}
