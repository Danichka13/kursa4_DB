using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork
{
    public partial class AddProduct : Form
    {
        DB db = new DB();
        string query;
        int count;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        string str;

        public int Number { get; set; }
        public int ProductSubCatCode { get; set; }
        public int Code { get; set; }
        public string Name1 { get; set; }
        public int Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string SubcatName { get; set; }


        public AddProduct()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Price = int.Parse(textBox_Price.Text);
            Name1 = textBox_Name.Text;
            ExpirationDate = dateTimePicker1.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (dateTimePicker1.Value <= dt)
            {
                DateTime newDT = dt.AddDays(1);
                dateTimePicker1.Text = newDT.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            db.openConnection();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Противовирусные таблетки":
                    SubcatName = "Противовирусные таблетки";
                    ProductSubCatCode = 10;
                    Code = 1;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703101%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031010" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Противовирусные сиропы":
                    SubcatName = "Противовирусные сиропы";
                    ProductSubCatCode = 10;
                    Code = 2;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703102%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031020" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Противовирусные спреи":
                    SubcatName = "Противовирусные спреи";
                    ProductSubCatCode = 10;
                    Code = 3;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703103%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031030" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Противовирусные ампулы":
                    SubcatName = "Противовирусные ампулы";
                    ProductSubCatCode = 10;
                    Code = 4;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703104%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031040" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Обезболивающие таблетки":
                    SubcatName = "Обезболивающие таблетки";
                    ProductSubCatCode = 13;
                    Code = 1;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703131%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031310" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Обезболивающие ампулы":
                    SubcatName = "Обезболивающие ампулы";
                    ProductSubCatCode = 13;
                    Code = 2;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703132%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031320" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Обезболивающие спреи":
                    SubcatName = "Обезболивающие спреи";
                    ProductSubCatCode = 13;
                    Code = 3;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703133%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031330" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Витамины A":
                    SubcatName = "Витамины A";
                    ProductSubCatCode = 17;
                    Code = 1;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703171%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031710" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Витамины B":
                    SubcatName = "Витамины B";
                    ProductSubCatCode = 17;
                    Code = 2;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703172%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031720" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Витамины C":
                    SubcatName = "Витамины C";
                    ProductSubCatCode = 17;
                    Code = 3;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703173%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031730" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Витамины D":
                    SubcatName = "Витамины D";
                    ProductSubCatCode = 17;
                    Code = 4;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703174%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031740" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Витамины E":
                    SubcatName = "Витамины E";
                    ProductSubCatCode = 17;
                    Code = 5;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703175%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031750" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Заживляющие мази":
                    SubcatName = "Заживляющие мази";
                    ProductSubCatCode = 18;
                    Code = 1;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703181%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031810" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                case "Заживляющие спреи":
                    SubcatName = "Заживляющие спреи";
                    ProductSubCatCode = 18;
                    Code = 2;
                    query = "SELECT COUNT(1) FROM Product WHERE Number LIKE '%1703182%'";
                    cmd = new SqlCommand(query, db.getConnection());
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    str = "17031820" + 1;
                    Number = Int32.Parse(str) + count;
                    break;
                default:
                    break;
            }
            db.closeConnection();
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number))
                e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
