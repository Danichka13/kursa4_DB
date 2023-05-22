using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork
{
    public partial class log_in : Form
    {
        DB db = new DB();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            textBox_login.MaxLength = 50;
            textBox_login.MaxLength = 50;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystr = $"select id, login_of, password_of from loginUsers where login_of = '{loginUser}' and password_of = '{passUser}'";

            SqlCommand command = new SqlCommand(querystr, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void label_singup_Click(object sender, EventArgs e)
        {
            sing_up formSigh = new sing_up();
            formSigh.Show();
            this.Hide();
        }

        private void label_hidepass_Click(object sender, EventArgs e)
        {
            if (label_hidepass.Text == "Показать пароль")
            {
                textBox_password.UseSystemPasswordChar = false;
                label_hidepass.Text = "Скрыть пароль";
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
                label_hidepass.Text = "Показать пароль";
            }
        }
    }
}
