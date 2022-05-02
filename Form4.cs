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
    public partial class Form4 : Form
    {
        int createid = 0;
        string id = "";
        public Form4()
        {
            InitializeComponent();
        }

        //2019-11-19
        //Duplicate check
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            //String Connstr = "Data Source=127.0.0.1;Database=accountDB;UserId=root;Password=;charset=utf8;";
            mySqlConnection.ConnectionString = Form2.Connstr;
            MySqlCommand cmd = mySqlConnection.CreateCommand();
            string sql = "Select count(*) from " + textBox1.Text;
            cmd.CommandText = sql;
            try
            {
                mySqlConnection.Open();
                if (int.Parse(cmd.ExecuteScalar().ToString()) == 0)
                {
                    MessageBox.Show("중복된 ID입니다.");
                    createid = 0;
                }
            }
            catch
            {
                MessageBox.Show("생성가능한 ID입니다.");
                createid = 1;
                id = textBox1.Text;
            }
        }

        //2019-11-19
        //Register ID
        private void button2_Click(object sender, EventArgs e)
        {
            if (id == textBox1.Text && createid == 1)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    MySqlConnection mySqlConnection = new MySqlConnection();
                    //String Connstr = "Data Source=127.0.0.1;Database=accountDB;UserId=root;Password=;charset=utf8;";
                    mySqlConnection.ConnectionString = Form2.Connstr;
                    MySqlCommand cmd = mySqlConnection.CreateCommand();
                    string sql_create = "CREATE TABLE `accountDB`.`" + textBox1.Text + "` ( `신규일` VARCHAR(10) NOT NULL , `담당자` VARCHAR(10) NOT NULL , `고객명` VARCHAR(10) NOT NULL , `나이` VARCHAR(5) NOT NULL , `성별` VARCHAR(1) NOT NULL , `연락처` VARCHAR(15) NOT NULL , `특이사항` TEXT NOT NULL , `콜일자` VARCHAR(10) NOT NULL , `전화자` VARCHAR(10) NOT NULL , `콜결과` VARCHAR(1) NOT NULL , `콜결과내역` TEXT NOT NULL , `수정일` VARCHAR(10) NOT NULL , PRIMARY KEY (`연락처`)) ENGINE = InnoDB;";
                    cmd.CommandText = sql_create;
                    try
                    {
                        mySqlConnection.Open();
                        cmd.ExecuteNonQuery();
                        string sql_id = "insert into signup(ID, PW) values(\"" + textBox1.Text + "\", \"" + textBox2.Text + "\")";
                        cmd.CommandText = sql_id;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("회원가입 성공");
                        Close();
                    }
                    catch(Exception ex)
                    {
                        if (ex.Message.Contains("exists"))
                            MessageBox.Show("이미 가입된 ID입니다");
                        else
                            MessageBox.Show("회원가입 실패" + ex.Message);
                    }
                }
                else
                    MessageBox.Show("비밀번호가 다릅니다.");
            }
            else
                MessageBox.Show("ID중복확인이 필요합니다.");
        }
    }
}
