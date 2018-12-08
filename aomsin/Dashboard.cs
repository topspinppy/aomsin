using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aomsin
{
    public partial class Dashboard : Form
    {
        string name;
        public Dashboard(string text)
        {
            InitializeComponent();
            name = text;
        }
        Income income;
        payment pay;

        private void IncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(income == null)
            {
                income = new Income(name);
                income.MdiParent = this;
                income.Show();
            }
            else if (pay == null)
            {
                pay = new payment();
                pay.MdiParent = this;
                pay.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            income = new Income(name);
            income.MdiParent = this;
            income.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pay = new payment();
            pay.MdiParent = this;
            pay.Show();
        }
    }
}
