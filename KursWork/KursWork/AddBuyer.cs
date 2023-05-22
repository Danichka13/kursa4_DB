using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KursWork
{
    public partial class AddBuyer : Form
    {
        DB db = new DB();
        string query;
        int count;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        string str;

        public string FIO { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public int ReceptCode { get; set; }
        public int KolvoGoods { get; set; }
        public string SubcatName { get; set; }


        public AddBuyer()
        {
            InitializeComponent();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox_PhoneNum.Text.Length < 11)
            {
                str = textBox_PhoneNum.Text;
                for (int i = 0; i < 11 - textBox_PhoneNum.Text.Length; i++)
                {
                    str += 1;
                }
            }
            PhoneNumber = str;
            FIO = textBox_Name.Text;
            Age = int.Parse(numericUpDown_Age.Value.ToString());
            KolvoGoods = int.Parse(numericUpDown_kolvoGoods.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Бронхит":
                    SubcatName = "Бронхит";
                    ReceptCode = 1;
                    break;
                case "Нехватка витамина Б":
                    SubcatName = "Нехватка витамина Б";
                    ReceptCode = 2;
                    break;
                case "Сердечная недостаточность":
                    SubcatName = "Сердечная недостаточность";
                    ReceptCode = 3;
                    break;
                case "Сыпь":
                    SubcatName = "Сыпь";
                    ReceptCode = 4;
                    break;
            }
            db.closeConnection();
        }

        private void textBox_FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && !number.Equals(' ') && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_PhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
