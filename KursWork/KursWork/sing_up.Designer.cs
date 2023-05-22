namespace KursWork
{
    partial class sing_up
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_loginPreview = new System.Windows.Forms.Label();
            this.label_hidepass = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label2_login = new System.Windows.Forms.Label();
            this.label1_login = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, -65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 35);
            this.textBox1.TabIndex = 0;
            // 
            // label_loginPreview
            // 
            this.label_loginPreview.AutoSize = true;
            this.label_loginPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_loginPreview.Location = new System.Drawing.Point(21, 32);
            this.label_loginPreview.Name = "label_loginPreview";
            this.label_loginPreview.Size = new System.Drawing.Size(477, 31);
            this.label_loginPreview.TabIndex = 6;
            this.label_loginPreview.Text = "Регистрация нового пользователя";
            // 
            // label_hidepass
            // 
            this.label_hidepass.AutoSize = true;
            this.label_hidepass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_hidepass.Location = new System.Drawing.Point(325, 149);
            this.label_hidepass.Name = "label_hidepass";
            this.label_hidepass.Size = new System.Drawing.Size(95, 13);
            this.label_hidepass.TabIndex = 25;
            this.label_hidepass.Text = "Показать пароль";
            this.label_hidepass.Click += new System.EventHandler(this.label_hidepass_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(187, 192);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(132, 45);
            this.btnEnter.TabIndex = 24;
            this.btnEnter.Text = "Зарегистрироваться";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2_login
            // 
            this.label2_login.AutoSize = true;
            this.label2_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_login.Location = new System.Drawing.Point(100, 142);
            this.label2_login.Name = "label2_login";
            this.label2_login.Size = new System.Drawing.Size(81, 24);
            this.label2_login.TabIndex = 23;
            this.label2_login.Text = "Пароль:";
            // 
            // label1_login
            // 
            this.label1_login.AutoSize = true;
            this.label1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_login.Location = new System.Drawing.Point(112, 116);
            this.label1_login.Name = "label1_login";
            this.label1_login.Size = new System.Drawing.Size(69, 24);
            this.label1_login.TabIndex = 22;
            this.label1_login.Text = "Логин:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(187, 146);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(132, 20);
            this.textBox_password.TabIndex = 21;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(187, 120);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(132, 20);
            this.textBox_login.TabIndex = 20;
            // 
            // sing_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 347);
            this.Controls.Add(this.label_hidepass);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2_login);
            this.Controls.Add(this.label1_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_loginPreview);
            this.Controls.Add(this.textBox1);
            this.Name = "sing_up";
            this.Text = "log_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_loginPreview;
        private System.Windows.Forms.Label label_hidepass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label2_login;
        private System.Windows.Forms.Label label1_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
    }
}