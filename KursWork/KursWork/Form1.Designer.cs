namespace KursWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОВсехТоварахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкахПокупателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_buyers = new System.Windows.Forms.TabPage();
            this.dataGridView_buyer = new System.Windows.Forms.DataGridView();
            this.tabPage_orders = new System.Windows.Forms.TabPage();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.tabPage_suppliers = new System.Windows.Forms.TabPage();
            this.dataGridView_supplier = new System.Windows.Forms.DataGridView();
            this.tabPage_request = new System.Windows.Forms.TabPage();
            this.dataGridView_request = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage_purchase = new System.Windows.Forms.TabPage();
            this.dataGridView_purchase = new System.Windows.Forms.DataGridView();
            this.покупкахТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_buyers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buyer)).BeginInit();
            this.tabPage_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.tabPage_suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).BeginInit();
            this.tabPage_request.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_request)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_purchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияОToolStripMenuItem
            // 
            this.информацияОToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОВсехТоварахToolStripMenuItem,
            this.покупкахПокупателейToolStripMenuItem,
            this.покупкахТоваровToolStripMenuItem});
            this.информацияОToolStripMenuItem.Name = "информацияОToolStripMenuItem";
            this.информацияОToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.информацияОToolStripMenuItem.Text = "Информация о";
            // 
            // ОВсехТоварахToolStripMenuItem
            // 
            this.ОВсехТоварахToolStripMenuItem.Name = "ОВсехТоварахToolStripMenuItem";
            this.ОВсехТоварахToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ОВсехТоварахToolStripMenuItem.Text = "о всех товарах";
            this.ОВсехТоварахToolStripMenuItem.Click += new System.EventHandler(this.информацияОВсехТоварахToolStripMenuItem_Click);
            // 
            // покупкахПокупателейToolStripMenuItem
            // 
            this.покупкахПокупателейToolStripMenuItem.Name = "покупкахПокупателейToolStripMenuItem";
            this.покупкахПокупателейToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.покупкахПокупателейToolStripMenuItem.Text = "покупках покупателей";
            this.покупкахПокупателейToolStripMenuItem.Click += new System.EventHandler(this.покупкахПокупателейToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.покупателяToolStripMenuItem,
            this.покупкуToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.товарToolStripMenuItem.Text = "Товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // покупателяToolStripMenuItem
            // 
            this.покупателяToolStripMenuItem.Name = "покупателяToolStripMenuItem";
            this.покупателяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупателяToolStripMenuItem.Text = "Покупателя";
            this.покупателяToolStripMenuItem.Click += new System.EventHandler(this.покупателяToolStripMenuItem_Click);
            // 
            // покупкуToolStripMenuItem
            // 
            this.покупкуToolStripMenuItem.Name = "покупкуToolStripMenuItem";
            this.покупкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупкуToolStripMenuItem.Text = "Покупку";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_buyers);
            this.tabControl1.Controls.Add(this.tabPage_suppliers);
            this.tabControl1.Controls.Add(this.tabPage_orders);
            this.tabControl1.Controls.Add(this.tabPage_purchase);
            this.tabControl1.Controls.Add(this.tabPage_request);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 458);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage_buyers
            // 
            this.tabPage_buyers.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_buyers.Controls.Add(this.dataGridView_buyer);
            this.tabPage_buyers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_buyers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_buyers.Name = "tabPage_buyers";
            this.tabPage_buyers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_buyers.Size = new System.Drawing.Size(875, 432);
            this.tabPage_buyers.TabIndex = 0;
            this.tabPage_buyers.Text = "Покупатели";
            // 
            // dataGridView_buyer
            // 
            this.dataGridView_buyer.AllowUserToAddRows = false;
            this.dataGridView_buyer.AllowUserToDeleteRows = false;
            this.dataGridView_buyer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_buyer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_buyer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_buyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_buyer.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_buyer.Name = "dataGridView_buyer";
            this.dataGridView_buyer.Size = new System.Drawing.Size(869, 426);
            this.dataGridView_buyer.TabIndex = 0;
            // 
            // tabPage_orders
            // 
            this.tabPage_orders.Controls.Add(this.dataGridView_order);
            this.tabPage_orders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_orders.Location = new System.Drawing.Point(4, 22);
            this.tabPage_orders.Name = "tabPage_orders";
            this.tabPage_orders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_orders.Size = new System.Drawing.Size(875, 432);
            this.tabPage_orders.TabIndex = 1;
            this.tabPage_orders.Text = "Заказы";
            this.tabPage_orders.UseVisualStyleBackColor = true;
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.AllowUserToDeleteRows = false;
            this.dataGridView_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_order.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.ReadOnly = true;
            this.dataGridView_order.Size = new System.Drawing.Size(869, 426);
            this.dataGridView_order.TabIndex = 1;
            // 
            // tabPage_suppliers
            // 
            this.tabPage_suppliers.Controls.Add(this.dataGridView_supplier);
            this.tabPage_suppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_suppliers.Name = "tabPage_suppliers";
            this.tabPage_suppliers.Size = new System.Drawing.Size(875, 432);
            this.tabPage_suppliers.TabIndex = 3;
            this.tabPage_suppliers.Text = "Поставщики";
            this.tabPage_suppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_supplier
            // 
            this.dataGridView_supplier.AllowUserToAddRows = false;
            this.dataGridView_supplier.AllowUserToDeleteRows = false;
            this.dataGridView_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_supplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_supplier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_supplier.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_supplier.Name = "dataGridView_supplier";
            this.dataGridView_supplier.Size = new System.Drawing.Size(875, 432);
            this.dataGridView_supplier.TabIndex = 1;
            // 
            // tabPage_request
            // 
            this.tabPage_request.Controls.Add(this.dataGridView_request);
            this.tabPage_request.Location = new System.Drawing.Point(4, 22);
            this.tabPage_request.Name = "tabPage_request";
            this.tabPage_request.Size = new System.Drawing.Size(875, 432);
            this.tabPage_request.TabIndex = 4;
            this.tabPage_request.Text = "Запрос";
            this.tabPage_request.UseVisualStyleBackColor = true;
            // 
            // dataGridView_request
            // 
            this.dataGridView_request.AllowUserToAddRows = false;
            this.dataGridView_request.AllowUserToDeleteRows = false;
            this.dataGridView_request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_request.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_request.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_request.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_request.Name = "dataGridView_request";
            this.dataGridView_request.Size = new System.Drawing.Size(875, 432);
            this.dataGridView_request.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.buttonDelete);
            this.panel3.Controls.Add(this.label_search);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 58);
            this.panel3.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(742, 9);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 38);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(19, 23);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(50, 16);
            this.label_search.TabIndex = 7;
            this.label_search.Text = "Поиск:";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.White;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(623, 9);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 38);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(75, 19);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(172, 20);
            this.textBox_search.TabIndex = 7;
            this.textBox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 458);
            this.panel1.TabIndex = 3;
            // 
            // tabPage_purchase
            // 
            this.tabPage_purchase.Controls.Add(this.dataGridView_purchase);
            this.tabPage_purchase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_purchase.Name = "tabPage_purchase";
            this.tabPage_purchase.Size = new System.Drawing.Size(875, 432);
            this.tabPage_purchase.TabIndex = 6;
            this.tabPage_purchase.Text = "Покупки";
            this.tabPage_purchase.UseVisualStyleBackColor = true;
            // 
            // dataGridView_purchase
            // 
            this.dataGridView_purchase.AllowUserToAddRows = false;
            this.dataGridView_purchase.AllowUserToDeleteRows = false;
            this.dataGridView_purchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_purchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_purchase.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_purchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_purchase.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_purchase.Name = "dataGridView_purchase";
            this.dataGridView_purchase.ReadOnly = true;
            this.dataGridView_purchase.Size = new System.Drawing.Size(875, 432);
            this.dataGridView_purchase.TabIndex = 2;
            // 
            // покупкахТоваровToolStripMenuItem
            // 
            this.покупкахТоваровToolStripMenuItem.Name = "покупкахТоваровToolStripMenuItem";
            this.покупкахТоваровToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.покупкахТоваровToolStripMenuItem.Text = "покупках товаров";
            this.покупкахТоваровToolStripMenuItem.Click += new System.EventHandler(this.покупкахТоваровToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Учёт товар и заказов аптеки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_buyers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buyer)).EndInit();
            this.tabPage_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.tabPage_suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).EndInit();
            this.tabPage_request.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_request)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage_purchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацияОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОВсехТоварахToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_buyers;
        private System.Windows.Forms.DataGridView dataGridView_buyer;
        private System.Windows.Forms.TabPage tabPage_orders;
        private System.Windows.Forms.TabPage tabPage_suppliers;
        private System.Windows.Forms.TabPage tabPage_request;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.DataGridView dataGridView_supplier;
        private System.Windows.Forms.DataGridView dataGridView_request;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкахПокупателейToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_purchase;
        private System.Windows.Forms.DataGridView dataGridView_purchase;
        private System.Windows.Forms.ToolStripMenuItem покупкахТоваровToolStripMenuItem;
    }
}

