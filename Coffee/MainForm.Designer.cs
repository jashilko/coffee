namespace Coffee
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cof2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cof2015DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.orderItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cof2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cof2015DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(894, 24);
            this.mainmenu.TabIndex = 5;
            this.mainmenu.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 411);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(457, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Заказ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 161);
            this.dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderItemBindingSource1
            // 
            this.orderItemBindingSource1.DataSource = typeof(Coffee.model.OrderItem);
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(Coffee.model.OrderItem);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 507);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainmenu);
            this.MainMenuStrip = this.mainmenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cof2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cof2015DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cof2015DataSetBindingSource;
        private System.Windows.Forms.BindingSource cof2015DataSetBindingSource1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource orderItemBindingSource1;
        private System.Data.DataSet dataSet1;
    }
}

