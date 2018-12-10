using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace aomsin
{
    public partial class payment : Form
    {
        string storenamelogin = "";
        string datestartfilter = "";
        string dateendfilter = "";
        string typeincomefilter = "";
        string sqlfilter = "";

        public payment()
        {
            InitializeComponent();
            addTypeIncomeBox.Hide();
            QueryTypepayment();
            QueryAllpayment();
            QuerySumpayment(name);
            storenamelogin = name;

            dateendsearch.Value = DateTime.Now;
            datestartsearch.Value = DateTime.Now;
        }

        private void QueryAllpayment()
        {
            string sql = "SELECT id_payment as id, date as date, description as description, totalmoney as total, name_typepayment as type FROM `payment` join type_payment using (id_typepayment) WHERE username = '" + storenamelogin + "'";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            allpayment.DataSource = ds.Tables[0];
        }

        private void QuerySumpayment(object name)
        {
            /*string sql = "SELECT COALESCE(SUM(totalmoney),0) as totalmoney FROM aomsin.income WHERE username ='" + namelogin + "'";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString("totalmoney") == "0")
                    {
                        allprice.Text = "0";
                    }
                    else
                    {
                        allprice.Text = reader.GetString("totalmoney");
                    }
                }
            }
            else
            {
                allprice.Text = "0";
            }*/
        }

        public void QueryTypepayment()
        {
            string sql = "SELECT * FROM type_payment";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            typepaymentsearch.Items.Add("");
            while (reader.Read())
            {
                typepayment.Items.Add(reader.GetString("name_typepayment") + " " + reader.GetString("id_typepayment"));
                typepaymentsearch.Items.Add(reader.GetString("name_typepayment") + " " + reader.GetString("id_typepayment"));
            }
        }


        private void btnAddTypePayment_Click(object sender, EventArgs e)
        {
            addTypeIncomeBox.Show();

            string sql = "SELECT * FROM type_payment";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            dataG_ShowAllTypepayment.DataSource = ds.Tables[0];
        }

        private void save_payment_Click(object sender, EventArgs e)
        {

            string date = date_payment.Text;
            string type = Regex.Match(typepayment.Text, @"\d+").Value;
            string descriptions = descriptionpayment.Text;
            string price = money.Text;
            string sql = "INSERT INTO `payment` (`id_income`, `date`, `id_typepayment`, `description`, `totalmoney`,`username`) VALUES (NULL, '" + date + "', '" + type + "', '" + descriptions + "', '" + price + "')";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin;charset=utf8;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void closetypepayment_Click(object sender, EventArgs e)
        {
            addTypeIncomeBox.Hide();
        }

        private void saveTypepayment_Click(object sender, EventArgs e)
        {
            string id = txtBox_addIdpayment.Text;
            string namepayment = txtBox_addnamepayment.Text;

            string sql = "INSERT INTO `type_payment` (`id_typepayment`, `name_typepayment`) VALUES ('" + id + "', '" + namepayment+ "')";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin;charset=utf8;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        public void UpdateAllIncome(string sqlcmd)
        {
            MessageBox.Show(sqlcmd);
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin");
            MySqlCommand cmd = new MySqlCommand(sqlcmd, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            allpayment.DataSource = ds.Tables[0];
        }

        private void closetypeincome_Click(object sender, EventArgs e)
        {
            addTypeIncomeBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryAllpayment();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string datestart = datestartfilter;
            string dateend = dateendfilter;
            string type = typeincomefilter;

            if (datestart.Trim() == "" && dateend.Trim() == "" && type.Trim() == "")
            {
                MessageBox.Show("กรุณาใส่ข้อมูลเพื่อทำการค้นหา");
            }
            else
            {
                sqlfilter = "SELECT * FROM income WHERE username = '" + storenamelogin + "' AND id_typeincome = '" + type + "' AND date BETWEEN '" + datestart + "' AND '" + dateend + "'";
                UpdateAllIncome(sqlfilter);
            }
        }

        private void datestartsearch_ValueChanged(object sender, EventArgs e)
        {
            datestartfilter = datestartsearch.Text == "" ? "" : datestartsearch.Text;
        }

        private void dateendsearch_ValueChanged(object sender, EventArgs e)
        {
            dateendfilter = dateendsearch.Text == "" ? "" : dateendsearch.Text;
        }

        private void typeincomesearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeincomefilter = typepaymentsearch.Text == "" ? "" : Regex.Match(typepayment.Text, @"\d+").Value;
        }



    }
}
