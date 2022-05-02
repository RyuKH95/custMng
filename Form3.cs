using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        //2019-11-19
        string ID = "";
        int cntM, cntF, cntO, cntT, cntX = 0;

        public Form3()
        {
            InitializeComponent();
        }

        //2019-11-19
        public Form3(string id)
        {
            InitializeComponent();
            ID = id;
        }

        //2019-11-14
        //select
        public void button1_Click(object sender, EventArgs e)
        {
            //2019-11-20
            cntM = cntF = cntO = cntT = cntX = 0;

            MySqlConnection mySqlConnection = new MySqlConnection();
            //String Connstr = "Data Source=127.0.0.1;Database=test;UserId=root;Password=;charset=utf8;";
            mySqlConnection.ConnectionString = Form2.Connstr;
            MySqlCommand cmd = mySqlConnection.CreateCommand();
            string sql = "Select * from " + ID + " order by 신규일 asc";
            cmd.CommandText = sql;
            try
            {
                mySqlConnection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0).Substring(0, 10)); //신규일
                    lvi.SubItems.Add(reader.GetString(1));                  //담당자
                    lvi.SubItems.Add(reader.GetString(2));                  //고객명
                    lvi.SubItems.Add(reader.GetString(3));                  //나이
                    if (reader.GetString(4) == "0")                         //성별
                    {
                        lvi.SubItems.Add("남");
                        ++cntM;
                    }
                    else
                    {
                        lvi.SubItems.Add("여");
                        ++cntF;
                    }
                    lvi.SubItems.Add(reader.GetString(5));                  //연락처
                    lvi.SubItems.Add(reader.GetString(6));                  //특이사항
                    lvi.SubItems.Add(reader.GetString(7).Substring(0, 10)); //콜일자
                    lvi.SubItems.Add(reader.GetString(8));                  //전화자
                    switch (reader.GetString(9))                            //콜결과
                    {
                        case "0":
                            lvi.SubItems.Add("○");
                            ++cntO;
                            break;
                        case "1":
                            lvi.SubItems.Add("△");
                            ++cntT;
                            break;
                        case "2":
                            lvi.SubItems.Add("Ⅹ");
                            ++cntX;
                            break;
                    }
                    lvi.SubItems.Add(reader.GetString(10));                 //콜결과내역
                    lvi.SubItems.Add(reader.GetString(11));                 //수정일
                    listView1.Items.Add(lvi);
                }
                //2019-11-20
                label1.Text = "검색 개수 : " + listView1.Items.Count + "개";
                label2.Text = "남 : " + cntM + "개";
                label3.Text = "여 : " + cntF + "개";
                label4.Text = "○ : " + cntO + "개";
                label5.Text = "△ : " + cntT + "개";
                label6.Text = "Ⅹ : " + cntX + "개";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        //2019-11-14~16
        //search
        private void button5_Click(object sender, EventArgs e)
        {
            //2019-11-20
            cntM = cntF = cntO = cntT = cntX = 0;

            MySqlConnection mySqlConnection = new MySqlConnection();
            //String Connstr = "Data Source=127.0.0.1;Database=test;UserId=root;Password=;charset=utf8";
            mySqlConnection.ConnectionString = Form2.Connstr;
            MySqlCommand cmd = mySqlConnection.CreateCommand();
            string sql = "Select * from " + ID + " where ";
            string q = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0: q = sql + "`신규일`=\"" + textBox4.Text + "\""; break;
                case 1: q = sql + "`담당자`=\"" + textBox4.Text + "\""; break;
                case 2: q = sql + "`고객명`=\"" + textBox4.Text + "\""; break;
                case 3: q = sql + "`나이`=\"" + textBox4.Text + "\""; break;
                //2019-11-19
                case 4:
                    if (textBox4.Text == "남")
                        q = sql + "`성별`=\"0\"";
                    else if (textBox4.Text == "여")
                        q = sql + "`성별`=\"1\"";
                    else
                    {
                        MessageBox.Show("남 또는 여 를 입력해주세요.");
                        q = sql + "`성별`=\"2\"";
                    }
                    break;
                case 5: q = sql + "`연락처`=\"" + textBox4.Text + "\""; break;
                case 6: q = sql + "`콜일자`=\"" + textBox4.Text + "\""; break;
                case 7: q = sql + "`전화자`=\"" + textBox4.Text + "\""; break;
                case 8: q = sql + "`콜결과`=\"" + comboBox2.SelectedIndex + "\""; break;
                case 9: q = sql + "`수정일`=\"" + textBox4.Text + "\""; break;
            }
            q = q + " order by 신규일 asc";
            cmd.CommandText = q;

            try
            {
                mySqlConnection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0).Substring(0, 10)); //신규일
                    lvi.SubItems.Add(reader.GetString(1));                  //담당자
                    lvi.SubItems.Add(reader.GetString(2));                  //고객명
                    lvi.SubItems.Add(reader.GetString(3));                  //나이
                    if (reader.GetString(4) == "0")                         //성별
                    {
                        lvi.SubItems.Add("남");
                        ++cntM;
                    }
                    else
                    {
                        lvi.SubItems.Add("여");
                        ++cntF;
                    }
                    lvi.SubItems.Add(reader.GetString(5));                  //연락처
                    lvi.SubItems.Add(reader.GetString(6));                  //특이사항
                    lvi.SubItems.Add(reader.GetString(7).Substring(0, 10)); //콜일자
                    lvi.SubItems.Add(reader.GetString(8));                  //전화자
                    switch (reader.GetString(9))                            //콜결과
                    {
                        case "0":
                            lvi.SubItems.Add("○");
                            ++cntO;
                            break;
                        case "1":
                            lvi.SubItems.Add("△");
                            ++cntT;
                            break;
                        case "2":
                            lvi.SubItems.Add("Ⅹ");
                            ++cntX;
                            break;
                    }
                    lvi.SubItems.Add(reader.GetString(10));                 //콜결과내역
                    lvi.SubItems.Add(reader.GetString(11));                 //수정일
                    listView1.Items.Add(lvi);
                }
                //2019-11-20
                label1.Text = "검색 개수 : " + listView1.Items.Count + "개";
                label2.Text = "남 : " + cntM + "개";
                label3.Text = "여 : " + cntF + "개";
                label4.Text = "○ : " + cntO + "개";
                label5.Text = "△ : " + cntT + "개";
                label6.Text = "Ⅹ : " + cntX + "개";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        //2019-11-15
        //search enter
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(textBox4.Text))
                button5_Click(sender, e);
        }

        //2019-11-15
        //insert
        private void button2_Click(object sender, EventArgs e)
        {
            //2019-11-19
            Form1 showForm1 = new Form1(this, ID);
            showForm1.ShowDialog();
        }

        //2019-11-16
        //update1
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvitem = items[0];
                string select_date_new = lvitem.SubItems[0].Text;
                string select_admin = lvitem.SubItems[1].Text;
                string select_customer = lvitem.SubItems[2].Text;
                string select_age = lvitem.SubItems[3].Text;
                string select_gender = lvitem.SubItems[4].Text;
                string select_phone = lvitem.SubItems[5].Text;
                string select_specialnote = lvitem.SubItems[6].Text;
                string select_date_call = lvitem.SubItems[7].Text;
                string select_call = lvitem.SubItems[8].Text;
                string select_resultOX = lvitem.SubItems[9].Text;
                string select_result_call = lvitem.SubItems[10].Text;

                //2019-11-19
                Form1 showForm1 = new Form1(this, ID, select_date_new, select_admin, select_customer, select_age, select_gender, select_phone, select_specialnote, select_date_call, select_call, select_resultOX, select_result_call);
                showForm1.Owner = this;
                showForm1.ShowDialog();
            }
            else
                MessageBox.Show("수정할 항목을 선택해주세요.");
        }

        //2019-11-16
        //update2
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
            ListViewItem lvitem = items[0];
            string select_date_new = lvitem.SubItems[0].Text;
            string select_admin = lvitem.SubItems[1].Text;
            string select_customer = lvitem.SubItems[2].Text;
            string select_age = lvitem.SubItems[3].Text;
            string select_gender = lvitem.SubItems[4].Text;
            string select_phone = lvitem.SubItems[5].Text;
            string select_specialnote = lvitem.SubItems[6].Text;
            string select_date_call = lvitem.SubItems[7].Text;
            string select_call = lvitem.SubItems[8].Text;
            string select_resultOX = lvitem.SubItems[9].Text;
            string select_result_call = lvitem.SubItems[10].Text;
            string select_date_modify = lvitem.SubItems[11].Text;

            //2019-11-19
            Form1 showForm1 = new Form1(this, ID, select_date_new, select_admin, select_customer, select_age, select_gender, select_phone, select_specialnote, select_date_call, select_call, select_resultOX, select_result_call);
            showForm1.Owner = this;
            showForm1.ShowDialog();
        }

        //2019-11-17
        //delete
        private void button4_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("선택된 데이터가 삭제됩니다. 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No)
                { }
                else
                {
                    ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                    ListViewItem lvitem = items[0];
                    string select_date_new = lvitem.SubItems[0].Text;
                    string select_admin = lvitem.SubItems[1].Text;
                    string select_customer = lvitem.SubItems[2].Text;
                    string select_age = lvitem.SubItems[3].Text;
                    string select_gender = "";
                    if (lvitem.SubItems[4].Text == "남")
                        select_gender = "0";
                    else
                        select_gender = "1";
                    string select_phone = lvitem.SubItems[5].Text;
                    string select_specialnote = lvitem.SubItems[6].Text;
                    string select_date_call = lvitem.SubItems[7].Text;
                    string select_call = lvitem.SubItems[8].Text;
                    string select_resultOX = "";
                    if (lvitem.SubItems[9].Text == "○")
                        select_resultOX = "0";
                    else if (lvitem.SubItems[9].Text == "△")
                        select_resultOX = "1";
                    else
                        select_resultOX = "2";
                    string select_result_call = lvitem.SubItems[10].Text;

                    MySqlConnection mySqlConnection = new MySqlConnection();
                    //String Connstr = "Data Source=127.0.0.1;Database=test;UserId=root;Password=;charset=utf8";
                    mySqlConnection.ConnectionString = Form2.Connstr;
                    MySqlCommand cmd = mySqlConnection.CreateCommand();
                    string sql = "DELETE FROM `" + ID + "` WHERE `신규일`=\"" + select_date_new + "\" and `담당자`=\"" + select_admin + "\" and `고객명`=\"" + select_customer + "\" and `나이`=\"" + select_age + "\" and `성별`=\"" + select_gender + "\" and `연락처`=\"" + select_phone + "\" and `특이사항`=\"" + select_specialnote + "\" and `콜일자`=\"" + select_date_call + "\" and `전화자`=\"" + select_call + "\" and `콜결과`=\"" + select_resultOX + "\" and `콜결과내역`=\"" + select_result_call + "\"";

                    cmd.CommandText = sql;

                    try
                    {
                        mySqlConnection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("삭제 성공");
                        button1_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("삭제 실패" + ex.Message);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
            else
                MessageBox.Show("삭제할 항목을 선택해주세요.");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            //2019-11-19
            button1_Click(sender, e);
        }

        //2019-11-19
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 8)
            {
                textBox4.Visible = false;
                comboBox2.Visible = true;
            }
            else
            {
                textBox4.Visible = true;
                comboBox2.Visible = false;
            }
        }
        
    }
}
