namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Admin = new System.Windows.Forms.TextBox();
            this.Text_Customer = new System.Windows.Forms.TextBox();
            this.Text_Age = new System.Windows.Forms.TextBox();
            this.Text_SpecialNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Text_Call = new System.Windows.Forms.TextBox();
            this.Text_Result = new System.Windows.Forms.TextBox();
            this.Combo_Gender = new System.Windows.Forms.ComboBox();
            this.Date_New = new System.Windows.Forms.DateTimePicker();
            this.Date_Call = new System.Windows.Forms.DateTimePicker();
            this.Combo_Result = new System.Windows.Forms.ComboBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Text_Phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "신규일";
            // 
            // Text_Admin
            // 
            this.Text_Admin.Location = new System.Drawing.Point(338, 10);
            this.Text_Admin.Name = "Text_Admin";
            this.Text_Admin.Size = new System.Drawing.Size(110, 25);
            this.Text_Admin.TabIndex = 2;
            // 
            // Text_Customer
            // 
            this.Text_Customer.Location = new System.Drawing.Point(517, 10);
            this.Text_Customer.Name = "Text_Customer";
            this.Text_Customer.Size = new System.Drawing.Size(110, 25);
            this.Text_Customer.TabIndex = 3;
            // 
            // Text_Age
            // 
            this.Text_Age.Location = new System.Drawing.Point(90, 48);
            this.Text_Age.Name = "Text_Age";
            this.Text_Age.Size = new System.Drawing.Size(90, 25);
            this.Text_Age.TabIndex = 4;
            this.Text_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Age_KeyPress);
            // 
            // Text_SpecialNote
            // 
            this.Text_SpecialNote.Location = new System.Drawing.Point(90, 89);
            this.Text_SpecialNote.Multiline = true;
            this.Text_SpecialNote.Name = "Text_SpecialNote";
            this.Text_SpecialNote.Size = new System.Drawing.Size(537, 265);
            this.Text_SpecialNote.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "담당자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "고객명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "나이";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "성별";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "연락처";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "특이사항";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "콜일자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "콜결과";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "전화자";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "콜결과내역";
            // 
            // Text_Call
            // 
            this.Text_Call.Location = new System.Drawing.Point(338, 370);
            this.Text_Call.Name = "Text_Call";
            this.Text_Call.Size = new System.Drawing.Size(110, 25);
            this.Text_Call.TabIndex = 20;
            // 
            // Text_Result
            // 
            this.Text_Result.Location = new System.Drawing.Point(112, 414);
            this.Text_Result.Multiline = true;
            this.Text_Result.Name = "Text_Result";
            this.Text_Result.Size = new System.Drawing.Size(515, 83);
            this.Text_Result.TabIndex = 21;
            // 
            // Combo_Gender
            // 
            this.Combo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Gender.FormattingEnabled = true;
            this.Combo_Gender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.Combo_Gender.Location = new System.Drawing.Point(241, 48);
            this.Combo_Gender.Name = "Combo_Gender";
            this.Combo_Gender.Size = new System.Drawing.Size(88, 23);
            this.Combo_Gender.TabIndex = 22;
            // 
            // Date_New
            // 
            this.Date_New.Location = new System.Drawing.Point(80, 10);
            this.Date_New.Name = "Date_New";
            this.Date_New.Size = new System.Drawing.Size(193, 25);
            this.Date_New.TabIndex = 23;
            // 
            // Date_Call
            // 
            this.Date_Call.Location = new System.Drawing.Point(80, 370);
            this.Date_Call.Name = "Date_Call";
            this.Date_Call.Size = new System.Drawing.Size(193, 25);
            this.Date_Call.TabIndex = 24;
            // 
            // Combo_Result
            // 
            this.Combo_Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Result.FormattingEnabled = true;
            this.Combo_Result.Items.AddRange(new object[] {
            "○",
            "△",
            "Ⅹ"});
            this.Combo_Result.Location = new System.Drawing.Point(517, 372);
            this.Combo_Result.Name = "Combo_Result";
            this.Combo_Result.Size = new System.Drawing.Size(110, 23);
            this.Combo_Result.TabIndex = 25;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(112, 516);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(344, 39);
            this.Btn_Register.TabIndex = 26;
            this.Btn_Register.Text = "등록";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Text_Phone
            // 
            this.Text_Phone.Location = new System.Drawing.Point(393, 46);
            this.Text_Phone.Name = "Text_Phone";
            this.Text_Phone.ResetOnSpace = false;
            this.Text_Phone.Size = new System.Drawing.Size(234, 25);
            this.Text_Phone.TabIndex = 28;
            this.Text_Phone.Click += new System.EventHandler(this.Text_Phone_Click);
            this.Text_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Phone_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 567);
            this.Controls.Add(this.Text_Phone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Combo_Result);
            this.Controls.Add(this.Date_Call);
            this.Controls.Add(this.Date_New);
            this.Controls.Add(this.Combo_Gender);
            this.Controls.Add(this.Text_Result);
            this.Controls.Add(this.Text_Call);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_SpecialNote);
            this.Controls.Add(this.Text_Age);
            this.Controls.Add(this.Text_Customer);
            this.Controls.Add(this.Text_Admin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "고객관리 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Admin;
        private System.Windows.Forms.TextBox Text_Customer;
        private System.Windows.Forms.TextBox Text_Age;
        private System.Windows.Forms.TextBox Text_SpecialNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Text_Call;
        private System.Windows.Forms.TextBox Text_Result;
        private System.Windows.Forms.ComboBox Combo_Gender;
        private System.Windows.Forms.DateTimePicker Date_New;
        private System.Windows.Forms.DateTimePicker Date_Call;
        private System.Windows.Forms.ComboBox Combo_Result;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Text_Phone;
    }
}

