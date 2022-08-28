namespace WindowsFormsProject5_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listSales = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.accessories = new System.Windows.Forms.ComboBox();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Товары в наличии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(410, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Общая стоимость:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(58, 188);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(204, 27);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listSales
            // 
            this.listSales.FormattingEnabled = true;
            this.listSales.Location = new System.Drawing.Point(415, 84);
            this.listSales.Name = "listSales";
            this.listSales.Size = new System.Drawing.Size(174, 147);
            this.listSales.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(410, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Список продаж";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(134, 129);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(133, 25);
            this.price.TabIndex = 7;
            this.price.Text = "0₽";
            // 
            // totalCost
            // 
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCost.Location = new System.Drawing.Point(628, 269);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(133, 25);
            this.totalCost.TabIndex = 8;
            this.totalCost.Text = "0₽";
            // 
            // accessories
            // 
            this.accessories.FormattingEnabled = true;
            this.accessories.Items.AddRange(new object[] {
            "Intel Core i5-10400F",
            " ASUS TUF GAMING B560-PLUS WIFI",
            "GIGABYTE GeForce RTX 3070 Ti GAMING OC",
            " Patriot Viper Steel",
            "be quiet! STRAIGHT POWER 11 PLATINUM 850W",
            "DEEPCOOL MATREXX 55 V3 ADD-RGB WH",
            "1000 ГБ 2.5\" SATA накопитель Samsung 870 QVO"});
            this.accessories.Location = new System.Drawing.Point(58, 74);
            this.accessories.Name = "accessories";
            this.accessories.Size = new System.Drawing.Size(204, 21);
            this.accessories.TabIndex = 10;
            this.accessories.SelectionChangeCommitted += new System.EventHandler(this.accessories_SelectionChangeCommitted);
            // 
            // buttonEditing
            // 
            this.buttonEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditing.Location = new System.Drawing.Point(58, 254);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(209, 58);
            this.buttonEditing.TabIndex = 11;
            this.buttonEditing.Text = "Редактирование составляющих";
            this.buttonEditing.UseVisualStyleBackColor = true;
            this.buttonEditing.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.buttonEditing);
            this.Controls.Add(this.accessories);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSales);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.ComboBox accessories;
        private System.Windows.Forms.Button buttonEditing;
    }
}

