namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.Text_PW = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // Text_ID
            // 
            this.Text_ID.Location = new System.Drawing.Point(68, 10);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(190, 25);
            this.Text_ID.TabIndex = 2;
            // 
            // Text_PW
            // 
            this.Text_PW.Location = new System.Drawing.Point(68, 40);
            this.Text_PW.Name = "Text_PW";
            this.Text_PW.PasswordChar = '*';
            this.Text_PW.Size = new System.Drawing.Size(190, 25);
            this.Text_PW.TabIndex = 3;
            this.Text_PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_PW_KeyDown);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(282, 10);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(110, 25);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "로그인";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Signup
            // 
            this.Btn_Signup.Location = new System.Drawing.Point(282, 40);
            this.Btn_Signup.Name = "Btn_Signup";
            this.Btn_Signup.Size = new System.Drawing.Size(110, 26);
            this.Btn_Signup.TabIndex = 5;
            this.Btn_Signup.Text = "회원가입";
            this.Btn_Signup.UseVisualStyleBackColor = true;
            this.Btn_Signup.Click += new System.EventHandler(this.Btn_Signup_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 81);
            this.Controls.Add(this.Btn_Signup);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Text_PW);
            this.Controls.Add(this.Text_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "고객관리 프로그램 - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.TextBox Text_PW;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Signup;
    }
}