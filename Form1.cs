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
    public partial class Form1 : Form
    {
        //2019-11-19
        Form3 form3;
        //2019-11-15
        public delegate void TextEventHandler(string text);
        string ID, date_new, admin, customer, age, gender, phone, specialnote, date_call, call, result_OX, result_call, date_modify = "";

        private void Text_Phone_Click(object sender, EventArgs e)
        {
            if (Text_Phone.Text == "   -    -")
            {
                Text_Phone.Focus();
                Text_Phone.SelectionStart = 0;
            }
        }

        //2019-11-20
        private void Text_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            { //키를 조사해서 숫자만입력 !을 없애만 문자만 입력 받게된다.
                e.Handled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        //2019-11-16
        private void Text_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))   //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        //2019-11-15~16
        //insert form
        public Form1(Form3 _form3, string id)
        {
            InitializeComponent();
            form3 = _form3;
            ID = id;
            Combo_Gender.SelectedIndex = 0;
            Combo_Result.SelectedIndex = 1;
            Text_Phone.Mask = "999-9000-0000";
        }
        
        //2019-11-15
        //update form
        public Form1(Form3 _form3, string id, string dtnew, string s_adm, string s_cus, string s_age, string s_gen, string s_pho, string s_spe, string s_dtc, string s_call, string s_rOX, string s_rcall)
        {
            InitializeComponent();
            form3 = _form3;
            ID = id;
            date_new = dtnew;
            admin = s_adm;
            customer = s_cus;
            age = s_age;
            gender = s_gen;
            phone = s_pho;
            specialnote = s_spe;
            date_call = s_dtc;
            call = s_call;
            result_OX = s_rOX;
            result_call = s_rcall;

            Date_New.Value = new DateTime(int.Parse(date_new.Substring(0, 4)), int.Parse(date_new.Substring(5, 2)), int.Parse(date_new.Substring(8)));
            Text_Admin.Text = admin;
            Text_Customer.Text = customer;
            Text_Age.Text = age.ToString();
            if (gender == "남")
                Combo_Gender.SelectedIndex = 0;
            else
                Combo_Gender.SelectedIndex = 1;
            Text_Phone.Text = phone;
            Text_SpecialNote.Text = specialnote;
            Date_Call.Value = new DateTime(int.Parse(date_call.Substring(0, 4)), int.Parse(date_call.Substring(5, 2)), int.Parse(date_call.Substring(8)));
            Text_Call.Text = call;
            if (result_OX == "○")
                Combo_Result.SelectedIndex = 0;
            else if (result_OX == "△")
                Combo_Result.SelectedIndex = 1;
            else
                Combo_Result.SelectedIndex = 2;
            Text_Result.Text = result_call;

            Text_Phone.ReadOnly = true;
            Text_Call.Select();
        }

        //2019-11-15
        //Register button
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            date_new = Date_New.Value.ToString();              //신규일
            admin = Text_Admin.Text;                           //담당자
            customer = Text_Customer.Text;                     //고객명
            age = Text_Age.Text;                               //나이
            gender = Combo_Gender.SelectedIndex.ToString();    //성별
            phone = Text_Phone.Text;                           //연락처
            specialnote = Text_SpecialNote.Text;               //특이사항
            date_call = Date_Call.Value.ToString();            //콜일자
            call = Text_Call.Text;                             //전화자
            result_OX = Combo_Result.SelectedIndex.ToString(); //콜결과
            result_call = Text_Result.Text;                    //콜결과내역
            date_modify = DateTime.Now.ToString("yyyy-MM-dd"); //수정일
            if (String.IsNullOrEmpty(admin))
            {
                MessageBox.Show("담당자는 필수입니다.");
                Text_Admin.Focus();
            }
            else
            {
                if (String.IsNullOrEmpty(customer))
                {
                    MessageBox.Show("고객명은 필수입니다.");
                    Text_Customer.Focus();
                }
                else
                {
                    if (String.IsNullOrEmpty(age))
                    {
                        MessageBox.Show("나이를 입력하세요");
                        Text_Age.Focus();
                    }
                    else
                    {
                        if (Text_Phone.Text == "   -    -")
                        {
                            MessageBox.Show("연락처를 입력하세요");
                            Text_Phone.Focus();
                        }
                        else
                        {
                            if (MessageBox.Show("연락처를 확실히 입력했습니까?", "주의", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                MySqlConnection mySqlConnection = new MySqlConnection();
                                //String Connstr = "Data Source=127.0.0.1;Database=accountDB;UserId=root;Password=;charset=utf8";
                                mySqlConnection.ConnectionString = Form2.Connstr;
                                MySqlCommand cmd = mySqlConnection.CreateCommand();

                                string search_sql = "Select count(*) from " + ID + " where `연락처`=\"" + phone + "\"";
                                cmd.CommandText = search_sql;
                                try
                                {
                                    mySqlConnection.Open();
                                    if (int.Parse(cmd.ExecuteScalar().ToString()) == 0) //insert
                                    {
                                        string sql = "insert into " + ID + "(신규일, 담당자, 고객명, 나이, 성별, 연락처, 특이사항, 콜일자, 전화자, 콜결과, 콜결과내역, 수정일) values(\"" + date_new + "\", \"" + admin + "\", \"" + customer + "\", " + age + ", " + gender + ", \"" + phone + "\", \"" + specialnote + "\", \"" + date_call + "\", \"" + call + "\", " + result_OX + ", \"" + result_call + "\", \"" + date_modify + "\")";
                                        cmd.CommandText = sql;

                                        try
                                        {
                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("등록 성공");
                                            //2019-11-19
                                            form3.button1_Click(sender, e);
                                            Close();
                                        }
                                        catch (Exception ex)
                                        {
                                            if (ex.Message.Contains("Duplicate"))
                                                MessageBox.Show("중복데이터가 있습니다." + ex.Message);
                                            else
                                                MessageBox.Show("등록 실패" + ex.Message);
                                        }
                                    }
                                    //2019-11-16
                                    else //update
                                    {
                                        if (MessageBox.Show("이미 데이터가 있습니다. 수정하시겠습니까?", "경고", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                        {
                                            string sql = "update " + ID + " set `신규일`=\"" + date_new + "\", `담당자`=\"" + admin + "\", `고객명`=\"" + customer + "\", `나이`=" + age + ", `성별`=" + gender + ", `특이사항`=\"" + specialnote + "\", `콜일자`=\"" + date_call + "\", `전화자`=\"" + call + "\", `콜결과`=\"" + result_OX + "\", `콜결과내역`=\"" + result_call + "\", `수정일`=\"" + date_modify + "\" where `연락처`=\"" + phone + "\"";
                                            cmd.CommandText = sql;

                                            try
                                            {
                                                cmd.ExecuteNonQuery();
                                                MessageBox.Show("수정 성공");
                                                //2019-11-19
                                                form3.button1_Click(sender, e);
                                                Close();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("수정 실패" + ex.Message);
                                            }
                                        }
                                        else
                                        {
                                        }
                                    }
                                }
                                catch (Exception exc)
                                {
                                    MessageBox.Show("검색실패" + exc.Message);
                                }
                                finally
                                {
                                    mySqlConnection.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        //2019-11-15
        //close button
        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Text_Admin.Text) || !String.IsNullOrEmpty(Text_Customer.Text) || !String.IsNullOrEmpty(Text_SpecialNote.Text))
                if (MessageBox.Show("작성하던 정보가 있습니다. 닫으시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
                else
                { }
            else
                Close();
        }

    }
}
