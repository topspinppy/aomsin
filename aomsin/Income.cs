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
    public partial class Income : Form
    {
        string storenamelogin = "";
        string datestartfilter = "";
        string dateendfilter = "";
        string typeincomefilter = "";
        string sqlfilter = "";
        public Income(string name)
        {
            InitializeComponent();
            addTypeIncomeBox.Hide();
            QueryTypeIncome();
            QueryAllIncome();
            QuerySumIncome(name);
            storenamelogin = name;

            dateendsearch.Value = DateTime.Now;
            datestartsearch.Value = DateTime.Now;
        }

        public void QuerySumIncome(string namelogin)
        {
            string sql = "SELECT COALESCE(SUM(totalmoney),0) as totalmoney FROM aomsin.income WHERE username ='" + namelogin + "'";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin"﻿);
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
            } 
        }

        public void QueryAllIncome()
        {
            string sql = "SELECT id_income as id, date as date, description as description, totalmoney as total, name_typeincome as type FROM `income` join type_income using (id_typeincome) WHERE username = '"+storenamelogin+"'";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin"﻿);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            allIncome.DataSource = ds.Tables[0];
        }

        public void QueryTypeIncome()
        {
            string sql = "SELECT * FROM type_income";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin"﻿);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                typeincomesearch.Items.Add("");
                typeincoms.Items.Add(reader.GetString("name_typeincome")+" "+reader.GetString("id_typeincome"));
                typeincomesearch.Items.Add(reader.GetString("name_typeincome") + " " + reader.GetString("id_typeincome"));
            }
        }

        private void btnAddTypeIncome_Click(object sender, EventArgs e)
        {
            addTypeIncomeBox.Show();

            string sql = "SELECT * FROM type_income";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin"﻿);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            dataG_ShowAllTypeIncome.DataSource = ds.Tables[0];
        }

        private void saveTypeIncome_Click(object sender, EventArgs e)
        {
            string id = txtBox_addIdIncome.Text;
            string nameincome = txtBox_addnameIncome.Text;

            string sql = "INSERT INTO `type_income` (`id_typeincome`, `name_typeincome`) VALUES ('"+id+"', '"+nameincome+"')";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin;charset=utf8;"﻿);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            QueryTypeIncome();
        }

        private void save_income_Click(object sender, EventArgs e)
        {
            string date = date_income.Text;
            string type = Regex.Match(typeincoms.Text, @"\d+").Value;
            string descriptions = descriptionincome.Text;
            string price = money.Text;
            string sql = "INSERT INTO `income` (`id_income`, `date`, `id_typeincome`, `description`, `totalmoney`,`username`) VALUES (NULL, '"+date+"', '"+type+"', '"+descriptions+"', '"+price+"','"+storenamelogin+"')";
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin;charset=utf8;"﻿);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            QueryAllIncome();
            QuerySumIncome(storenamelogin);
        }


        public void UpdateAllIncome(string sqlcmd)
        {
            MessageBox.Show(sqlcmd);
            MySqlConnection con = new MySqlConnection("host=27.254.174.46;user=aomsin;password=q64_3aoL;database=aomsin"﻿);
            MySqlCommand cmd = new MySqlCommand(sqlcmd, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            allIncome.DataSource = ds.Tables[0];
        }

        private void closetypeincome_Click(object sender, EventArgs e)
        {
            addTypeIncomeBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryAllIncome();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string datestart = datestartfilter;
            string dateend = dateendfilter;
            string type = typeincomefilter;
                
            if(datestart.Trim() == "" && dateend.Trim() == "" && type.Trim() == "")
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
            typeincomefilter = typeincomesearch.Text == "" ? "" : Regex.Match(typeincomesearch.Text, @"\d+").Value;
        }
    }
}
