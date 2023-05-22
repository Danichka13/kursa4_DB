using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork
{
    public partial class sing_up : Form
    {
        DB db = new DB();

        public sing_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox_password.UseSystemPasswordChar = true;
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var pass = textBox_password.Text;

            string querystr = $"insert into loginUsers(login_of, password_of) values ('{login}','{pass}')";

            SqlCommand command = new SqlCommand(querystr, db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in formLog = new log_in();
                this.Hide();
                formLog.Show();
            }
            else
                MessageBox.Show("Аккаунт не создан");
            db.closeConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_login.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystr = $"select * from loginUser where login_of = '{loginUser}' and password_of = '{passUser}'";

            SqlCommand command = new SqlCommand(querystr, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            return false;

        }
    }
}
