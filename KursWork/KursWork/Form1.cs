using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork
{

    public partial class Form1 : Form
    {
        DataGridView dgw;
        DB db = new DB();
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string queryString;
        string querySearchString;
        string querySearchStringEnd;
        string searchString;

        int selecterRow;
        string currentTableName;
        string sqlSelectQueryWithParamNames;



        public Form1()
        {
            InitializeComponent();
        }

        private void start()
        {
            currentTableName = "buyer";
            queryString = "SELECT Id, FIO AS ФИО, PhoneNumber As \"Номер телефона\", Age AS Возраст, ReceptCode AS \"Код рецепта\", KolvoGoods AS \"Количество товара\" FROM Buyer";
            adapter = new SqlDataAdapter(queryString, db.getConnection());
            FillDataAdapter(queryString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage_request);
            start();
            //tabPage_request.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ds);
            /*db.openConnection();
            foreach (DataGridViewRow row in dgw.Rows)
            {
                switch (currentTableName)
                {
                    case "buyer":
                        dataGridView_buyer.DataSource = ds.Tables[0];
                        dataGridView_buyer.Columns[0].ReadOnly = true;
                        break;
                    case "supplier":
                        dataGridView_order.DataSource = ds.Tables[0];
                        dataGridView_order.Columns[0].ReadOnly = true;
                        break;
                    case "order":
                        adapter.UpdateCommand = new SqlCommand("UPDATE Order SET Date = @Date, Summ = @Summ, Id_Supplier = @Id_Supplier" +
                                " WHERE Id = @Id", db.getConnection());
                        adapter.UpdateCommand.Parameters.Add("@DateStart", SqlDbType.DateTime).Value = ds.Tables[0].Rows[row.Index][3];
                        adapter.UpdateCommand.Parameters.Add("@TotalRentCost", SqlDbType.Money).Value = ds.Tables[0].Rows[row.Index][5];
                        adapter.UpdateCommand.Parameters.Add("@TotalDepositCost", SqlDbType.Money).Value = ds.Tables[0].Rows[row.Index][6];
                        adapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ds.Tables[0].Rows[row.Index][0];
                        break;
                    case "purchase":
                        dataGridView_purchase.DataSource = ds.Tables[0];
                        dataGridView_purchase.Columns[0].ReadOnly = true;
                        break;
                }
            }
            adapter.UpdateCommand.ExecuteNonQuery();
            db.closeConnection();*/


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            db.openConnection();
            string sqlDeleteQuery;
            switch (currentTableName)
            {
                case "request":
                    dgw = dataGridView_request;
                    sqlDeleteQuery = "DELETE FROM Product WHERE Number = @Number";
                    break;
                case "order":
                    dgw = dataGridView_order;
                    sqlDeleteQuery = "DELETE FROM Orders WHERE Id = @Id";
                    break;
                case "purchase":
                    dgw = dataGridView_purchase;
                    sqlDeleteQuery = "DELETE FROM Purchase WHERE Id = @Id";
                    break;
                case "buyer":
                    dgw = dataGridView_buyer;
                    sqlDeleteQuery = "DELETE FROM Buyer WHERE Id = @Id";
                    break;
                case "supplier":
                    dgw = dataGridView_supplier;
                    sqlDeleteQuery = "DELETE FROM Supplier WHERE Id = @Id";
                    break;
                default:
                    sqlDeleteQuery = "";
                    break;
            }
            foreach (DataGridViewRow row in dgw.SelectedRows)
            {
                adapter.DeleteCommand = new SqlCommand(sqlDeleteQuery, db.getConnection());
                if (currentTableName.Equals("request"))
                    adapter.DeleteCommand.Parameters.Add("@Number", SqlDbType.Int).Value = ds.Tables[0].Rows[row.Index][0];
                else
                    adapter.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ds.Tables[0].Rows[row.Index][0];
                adapter.DeleteCommand.ExecuteNonQuery();
                dgw.Rows.Remove(row);
            }
            db.closeConnection();
        }

        private void FillDataAdapter(string queryString)
        {
            db.openConnection();
            adapter = new SqlDataAdapter(queryString, db.getConnection());
            ds = new DataSet();
            adapter.Fill(ds);
            switch (currentTableName)
            {
                case "request":
                    dataGridView_request.DataSource = ds.Tables[0];
                    dataGridView_request.Columns[0].ReadOnly = true;
                    break;
                case "order":
                    dataGridView_order.DataSource = ds.Tables[0];
                    dataGridView_order.Columns[0].ReadOnly = true;
                    break;
                case "purchase":
                    dataGridView_purchase.DataSource = ds.Tables[0];
                    dataGridView_purchase.Columns[0].ReadOnly = true;
                    break;
                case "buyer":
                    dataGridView_buyer.DataSource = ds.Tables[0];
                    dataGridView_buyer.Columns[0].ReadOnly = true;
                    break;
                case "supplier":
                    dataGridView_supplier.DataSource = ds.Tables[0];
                    dataGridView_supplier.Columns[0].ReadOnly = true;
                    break;
                default:
                    break;
            }
            db.closeConnection();
        }

        private void textBox_search_KeyPress(object sender, KeyEventArgs e)
        {
            searchString = querySearchString + textBox_search.Text + "%'" + querySearchStringEnd;
            adapter = new SqlDataAdapter(searchString, db.getConnection());
            FillDataAdapter(searchString);
            //querySearchStringEnd = "";
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    querySearchString = "SELECT Id, FIO AS ФИО, PhoneNumber As \"Номер телефона\", Age AS Возраст, ReceptCode AS \"Код рецепта\", KolvoGoods AS \"Количество товара\" FROM Buyer" +
                        " WHERE CONCAT (Id, FIO, PhoneNumber, Age, ReceptCode, KolvoGoods) LIKE '%";

                    currentTableName = "buyer";

                    queryString = "SELECT Id, FIO AS ФИО, PhoneNumber As \"Номер телефона\", Age AS Возраст, ReceptCode AS \"Код рецепта\", KolvoGoods AS \"Количество товара\" FROM Buyer";
                    adapter = new SqlDataAdapter(queryString, db.getConnection());
                    FillDataAdapter(queryString);
                    break;

                case 2:
                    querySearchString = "SELECT Orders.Id, Orders.Date AS \"Дата завоза\", Orders.Summ AS \"Общая сумма\", Supplier.FIO AS \"ФИО поставщика\"," +
                        " Supplier.SuppGoods AS \"Поставляемые товары\" FROM Orders JOIN Supplier ON Orders.Id_Supplier = Supplier.Id" +
                        " WHERE CONCAT (Orders.Id, Orders.Date, Orders.Summ, Supplier.FIO, Supplier.SuppGoods) LIKE '%";

                    currentTableName = "order";

                    queryString = "SELECT Orders.Id, Orders.Date AS \"Дата завоза\", Orders.Summ AS \"Общая сумма\", Supplier.FIO AS \"ФИО поставщика\"," +
                        " Supplier.SuppGoods AS \"Поставляемые товары\" FROM Orders JOIN Supplier ON Orders.Id_Supplier = Supplier.Id";
                    adapter = new SqlDataAdapter(queryString, db.getConnection());
                    FillDataAdapter(queryString);
                    break;

                case 3:
                    querySearchString = "SELECT Purchase.ID AS ID, Buyer.FIO AS \"ФИО покупателя\", Purchase.Summ AS \"Сумма покупки\"," +
                        " Buyer.KolvoGoods AS \"Количество товара\" FROM Purchase JOIN Buyer ON Purchase.BuyerId = Buyer.Id" +
                        " WHERE CONCAT (Purchase.ID, Buyer.FIO, Purchase.Summ, Buyer.KolvoGoods) LIKE '%";

                    currentTableName = "purchase";

                    queryString = "SELECT Purchase.ID AS ID, Buyer.FIO AS \"ФИО покупателя\", Purchase.Summ AS \"Сумма покупки\"," +
                        " Buyer.KolvoGoods AS \"Количество товара\" FROM Purchase JOIN Buyer ON Purchase.BuyerId = Buyer.Id";
                    adapter = new SqlDataAdapter(queryString, db.getConnection());
                    FillDataAdapter(queryString);
                    break;

                case 1:
                    querySearchString = "SELECT Id, FIO AS ФИО, SuppGoods AS \"Поставляемые товары\" FROM Supplier" +
                        " WHERE CONCAT (Id, FIO, SuppGoods) LIKE '%";
                    currentTableName = "supplier";
                    queryString = "SELECT Id, FIO AS ФИО, SuppGoods AS \"Поставляемые товары\" FROM Supplier";
                    adapter = new SqlDataAdapter(queryString, db.getConnection());
                    FillDataAdapter(queryString);
                    break;
                default:
                    break;
            }
            if (currentTableName != "request")
            {
                tabControl1.TabPages.Remove(tabPage_request);
                currentTableName = "";
            }
            else
                return;
        }



        private void информацияОВсехТоварахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage_request);
            tabControl1.TabPages.Add(tabPage_request);
            currentTableName = "request";
            tabControl1.SelectTab(tabPage_request);
            queryString = "SELECT Number AS Артикул, ProductSubcategoryCode AS \"Код категории продукта\", Name AS Наименование, Price AS Цена, ExpirationDate AS \"Срок годности(до)\" FROM Product";
            FillDataAdapter(queryString);
        }

        private void покупкахПокупателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage_request);
            tabControl1.TabPages.Add(tabPage_request);
            currentTableName = "request";
            tabControl1.SelectTab(tabPage_request);
            queryString = "select Purchase.Id AS ID, Buyer.Id AS \"ID покупателя\", Buyer.FIO AS ФИО," +
                "Buyer.PhoneNumber AS \"Номер телефона\", Buyer.Age AS Возраст, Buyer.KolvoGoods AS \"Количество товара\"," +
                " Purchase.Summ \"Сумма покупки\" from Purchase join Buyer on Purchase.BuyerId = Buyer.Id";
            adapter = new SqlDataAdapter(queryString, db.getConnection());
            FillDataAdapter(queryString);

            querySearchString = "select Purchase.Id AS ID, Buyer.Id AS \"ID покупателя\", Buyer.FIO AS ФИО," +
                "Buyer.PhoneNumber AS \"Номер телефона\", Buyer.Age AS Возраст, Buyer.KolvoGoods AS \"Количество товара\"," +
                " Purchase.Summ \"Сумма покупки\" from Purchase join Buyer on Purchase.BuyerId = Buyer.Id" +
                " WHERE CONCAT (Purchase.Id, Buyer.Id, Buyer.FIO, Buyer.PhoneNumber, Buyer.Age, Buyer.KolvoGoods," +
                " Purchase.Summ) LIKE '%";
        }

        private void покупкахТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage_request);
            tabControl1.TabPages.Add(tabPage_request);
            currentTableName = "request";
            tabControl1.SelectTab(tabPage_request);
            queryString = " SELECT Purchase.Id AS Id, STRING_AGG(Product.Number,', ') AS \"Артикул\", STRING_AGG(Product.Name, ', ') AS \"Название товара\"," +
                " STRING_AGG(Product.Price, ', ') AS \"Цена продукта\", Purchase.Summ AS \"Сумма покупки\"" +
                " FROM ProductBuy" +
                " JOIN Product ON Product.Number = ProductBuy.ProductNumber" +
                " JOIN Purchase ON Purchase.Id = ProductBuy.PurchaseId" +
                " GROUP BY Purchase.Id, Purchase.Summ";
            querySearchString = " SELECT Purchase.Id AS Id, STRING_AGG(Product.Number,', ') AS \"Артикул\", STRING_AGG(Product.Name, ', ') AS \"Название товара\"," +
                " STRING_AGG(Product.Price, ', ') AS \"Цена продукта\", Purchase.Summ AS \"Сумма покупки\"" +
                " FROM ProductBuy" +
                " JOIN Product ON Product.Number = ProductBuy.ProductNumber" +
                " JOIN Purchase ON Purchase.Id = ProductBuy.PurchaseId" +
                " WHERE CONCAT (Purchase.Id, Product.Number, Product.Name, Product.Price, Purchase.Summ) LIKE '%";
            querySearchStringEnd = " GROUP BY Purchase.Id, Purchase.Summ";
            FillDataAdapter(queryString);
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string expression;
            AddProduct newProduct = new AddProduct();
            DialogResult result = newProduct.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                db.openConnection();

                queryString = "INSERT INTO Product(Number, ProductSubcategoryCode, Code, Name, Price, ExpirationDate)" +
                    " VALUES ( " + newProduct.Number + ", " + newProduct.ProductSubCatCode + ", " + newProduct.Code +
                    ", '" + newProduct.Name1 + "', " + newProduct.Price + ", '" + newProduct.ExpirationDate + "')";
                currentTableName = "";
                FillDataAdapter(queryString);
            }
            else
                return;
        }

        private void покупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string expression;
            AddBuyer newBuyer = new AddBuyer();
            DialogResult result1 = newBuyer.ShowDialog(this);
            if (result1 == DialogResult.OK)
            {
                db.openConnection();

                queryString = "INSERT INTO Buyer(FIO, PhoneNumber, Age, ReceptCode, KolvoGoods)" +
                    " VALUES ('" + newBuyer.FIO + "', " + newBuyer.PhoneNumber + ", " + newBuyer.Age +
                    ", " + newBuyer.ReceptCode + ", " + newBuyer.KolvoGoods + ")";
                currentTableName = "";
                FillDataAdapter(queryString);
                /*adapter = new SqlDataAdapter(queryString, db.getConnection());
                ds = new DataSet();
                adapter.Fill(ds);*/
            }
            else
                return;
        }
    }
}

