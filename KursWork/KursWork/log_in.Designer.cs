namespace KursWork
{
    partial class log_in
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
            this.label_hidepass = new System.Windows.Forms.Label();
            this.label_singup = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label2_login = new System.Windows.Forms.Label();
            this.label1_login = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_signup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_hidepass
            // 
            this.label_hidepass.AutoSize = true;
            this.label_hidepass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_hidepass.Location = new System.Drawing.Point(276, 138);
            this.label_hidepass.Name = "label_hidepass";
            this.label_hidepass.Size = new System.Drawing.Size(95, 13);
            this.label_hidepass.TabIndex = 19;
            this.label_hidepass.Text = "Показать пароль";
            this.label_hidepass.Click += new System.EventHandler(this.label_hidepass_Click);
            // 
            // label_singup
            // 
            this.label_singup.AutoSize = true;
            this.label_singup.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_singup.Location = new System.Drawing.Point(156, 236);
            this.label_singup.Name = "label_singup";
            this.label_singup.Size = new System.Drawing.Size(104, 13);
            this.label_singup.TabIndex = 18;
            this.label_singup.Text = "Ещё нет аккаунта?";
            this.label_singup.Visible = false;
            this.label_singup.Click += new System.EventHandler(this.label_singup_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(158, 181);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(102, 39);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2_login
            // 
            this.label2_login.AutoSize = true;
            this.label2_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_login.Location = new System.Drawing.Point(51, 131);
            this.label2_login.Name = "label2_login";
            this.label2_login.Size = new System.Drawing.Size(81, 24);
            this.label2_login.TabIndex = 16;
            this.label2_login.Text = "Пароль:";
            // 
            // label1_login
            // 
            this.label1_login.AutoSize = true;
            this.label1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_login.Location = new System.Drawing.Point(63, 105);
            this.label1_login.Name = "label1_login";
            this.label1_login.Size = new System.Drawing.Size(69, 24);
            this.label1_login.TabIndex = 15;
            this.label1_login.Text = "Логин:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(138, 135);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(132, 20);
            this.textBox_password.TabIndex = 14;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(138, 109);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(132, 20);
            this.textBox_login.TabIndex = 13;
            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_signup.Location = new System.Drawing.Point(113, 47);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(189, 31);
            this.label_signup.TabIndex = 12;
            this.label_signup.Text = "Авторизация";
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 300);
            this.Controls.Add(this.label_hidepass);
            this.Controls.Add(this.label_singup);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2_login);
            this.Controls.Add(this.label1_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_signup);
            this.Name = "log_in";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hidepass;
        private System.Windows.Forms.Label label_singup;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label2_login;
        private System.Windows.Forms.Label label1_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_signup;
    }
}