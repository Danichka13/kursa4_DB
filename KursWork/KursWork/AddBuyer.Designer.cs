namespace KursWork
{
    partial class AddBuyer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox_PhoneNum = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nameGood = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Age = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_kolvoGoods = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolvoGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Бронхит",
            "Нехватка витамина Б",
            "Сердечная недостаточность",
            "Сыпь"});
            this.comboBox1.Location = new System.Drawing.Point(226, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(75, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Введите данные о покупателе";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(153, 300);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(122, 42);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBox_PhoneNum
            // 
            this.textBox_PhoneNum.Location = new System.Drawing.Point(226, 101);
            this.textBox_PhoneNum.MaxLength = 11;
            this.textBox_PhoneNum.Name = "textBox_PhoneNum";
            this.textBox_PhoneNum.Size = new System.Drawing.Size(162, 20);
            this.textBox_PhoneNum.TabIndex = 22;
            this.textBox_PhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PhoneNum_KeyPress);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(226, 63);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(162, 20);
            this.textBox_Name.TabIndex = 21;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FIO_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(90, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Код рецепта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(131, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Возраст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(53, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер телефона:";
            // 
            // label_nameGood
            // 
            this.label_nameGood.AutoSize = true;
            this.label_nameGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nameGood.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_nameGood.Location = new System.Drawing.Point(161, 58);
            this.label_nameGood.Name = "label_nameGood";
            this.label_nameGood.Size = new System.Drawing.Size(59, 24);
            this.label_nameGood.TabIndex = 17;
            this.label_nameGood.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Количество товара:";
            // 
            // numericUpDown_Age
            // 
            this.numericUpDown_Age.Location = new System.Drawing.Point(226, 138);
            this.numericUpDown_Age.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_Age.Name = "numericUpDown_Age";
            this.numericUpDown_Age.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown_Age.TabIndex = 29;
            this.numericUpDown_Age.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDown_kolvoGoods
            // 
            this.numericUpDown_kolvoGoods.Location = new System.Drawing.Point(226, 224);
            this.numericUpDown_kolvoGoods.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolvoGoods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolvoGoods.Name = "numericUpDown_kolvoGoods";
            this.numericUpDown_kolvoGoods.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown_kolvoGoods.TabIndex = 30;
            this.numericUpDown_kolvoGoods.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 379);
            this.Controls.Add(this.numericUpDown_kolvoGoods);
            this.Controls.Add(this.numericUpDown_Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBox_PhoneNum);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nameGood);
            this.Name = "AddBuyer";
            this.Text = "Добавить нового покупателя";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolvoGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox_PhoneNum;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nameGood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Age;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolvoGoods;
    }
}