using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using core;

namespace baidutieba
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }
        private static RFile arFile =null;
        private List<LoginModel> loginModels = new List<LoginModel>();
        private void button1_Click(object sender, EventArgs e)
        {
           if(txtuser.Text.Trim()==""||txtpwd.Text.Trim()=="")
               return;
            LoginModel loginModel = new LoginModel();
            loginModel.UserName = txtuser.Text.Trim();
            loginModel.PassWord = txtpwd.Text.Trim();
            try
            {
                loginModels.Add(loginModel);
                Common.WriteAccount(arFile, loginModels);
                BindData();
                InitTxt();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            

        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ENV.BaseDir + "/info.acc"))
            {
               
               var s= File.Create(ENV.BaseDir + "/info.acc");
                s.Close();
                
            }
                

             arFile = new RFile(ENV.BaseDir + "info.acc");
             BindData();
        }
        private void InitTxt()
        {
            txtpwd.Text = string.Empty;
            txtuser.Text = string.Empty;
        }
        private void BindData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                loginModels = Common.ReadAccount(arFile);
                dataGridView1.DataSource = loginModels;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
          
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 2)
            {
                if( MessageBox.Show("确定删除吗？","确定",MessageBoxButtons.YesNo)!=DialogResult.Yes)
                    return;
                
                var login = (LoginModel) dataGridView1.Rows[e.RowIndex].DataBoundItem;
                loginModels.Remove(login);
                Common.WriteAccount(arFile,loginModels);
                BindData();
            }
        }
    }
}
