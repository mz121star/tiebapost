using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using core;

namespace baidutieba
{
    public partial class SelectAccount : Form
    {
        public SelectAccount()
        {
            InitializeComponent();
        }

        public LoginModel CurrentLogin = new LoginModel();
        public SelectAccount(List<LoginModel> accounts)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = accounts;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var login = (LoginModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            CurrentLogin = login;
            this.DialogResult=DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
