using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //http://112.158.186.29:8000/apps/phpmyadmin/
        //127.0.0.1
        public static String Connstr = "Data Source=112.158.186.29; Database=accountDB; user=accountDB; password=1; charset=utf8";
        //public static String Connstr = "Data Source=127.0.0.1; Database=accountDB; UserId=root; Password=; charset=utf8";
        public Form2()
        {
            InitializeComponent();
        }

        //2019-11-19
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection();
                //string Connstr = "Data Source=127.0.0.1;Database=accountDB;UserId=root;Password=;charset=utf8";
                mySqlConnection.ConnectionString = Form2.Connstr;
                MySqlCommand cmd = mySqlConnection.CreateCommand();
                string sql = "Select count(*) from signup where `ID`=\"" + Text_ID.Text + "\" and `PW`=\"" + Text_PW.Text + "\"";
                cmd.CommandText = sql;

                try
                {
                    mySqlConnection.Open();
                    if (int.Parse(cmd.ExecuteScalar().ToString()) == 1)
                    {
                        Hide();
                        Form3 showForm3 = new Form3(Text_ID.Text);
                        showForm3.ShowDialog();
                        Close();
                    }
                    else
                        MessageBox.Show("ID 또는 PW를 확인해주십시오.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("접속 실패" + ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("실패");
                Btn_Login.Enabled = true;
            }
        }

        //2019-11-19
        private void Btn_Signup_Click(object sender, EventArgs e)
        {
            Form4 showForm4 = new Form4();
            showForm4.ShowDialog();
        }

        //2019-11-19
        private void Text_PW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(Text_ID.Text) && !String.IsNullOrEmpty(Text_PW.Text))
                Btn_Login_Click(sender, e);
        }
    }
}
