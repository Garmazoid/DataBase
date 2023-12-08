namespace ADO.NET1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InsetTab = new System.Windows.Forms.TabPage();
            this.Clear_buttom = new System.Windows.Forms.Button();
            this.INSERT_buttom = new System.Windows.Forms.Button();
            this.vbnvng_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SELECT_buttom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.InsetTab.SuspendLayout();
            this.SelectTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InsetTab);
            this.tabControl1.Controls.Add(this.SelectTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // InsetTab
            // 
            this.InsetTab.Controls.Add(this.Clear_buttom);
            this.InsetTab.Controls.Add(this.INSERT_buttom);
            this.InsetTab.Controls.Add(this.vbnvng_textBox);
            this.InsetTab.Controls.Add(this.Phone_textBox);
            this.InsetTab.Controls.Add(this.Age_textBox);
            this.InsetTab.Controls.Add(this.Name_textBox);
            this.InsetTab.Location = new System.Drawing.Point(4, 22);
            this.InsetTab.Name = "InsetTab";
            this.InsetTab.Padding = new System.Windows.Forms.Padding(3);
            this.InsetTab.Size = new System.Drawing.Size(768, 400);
            this.InsetTab.TabIndex = 0;
            this.InsetTab.Text = "INSERT";
            this.InsetTab.UseVisualStyleBackColor = true;
            // 
            // Clear_buttom
            // 
            this.Clear_buttom.Location = new System.Drawing.Point(6, 61);
            this.Clear_buttom.Name = "Clear_buttom";
            this.Clear_buttom.Size = new System.Drawing.Size(376, 23);
            this.Clear_buttom.TabIndex = 5;
            this.Clear_buttom.Text = "Clear";
            this.Clear_buttom.UseVisualStyleBackColor = true;
            this.Clear_buttom.Click += new System.EventHandler(this.Clear_buttom_Click);
            // 
            // INSERT_buttom
            // 
            this.INSERT_buttom.Location = new System.Drawing.Point(6, 32);
            this.INSERT_buttom.Name = "INSERT_buttom";
            this.INSERT_buttom.Size = new System.Drawing.Size(756, 23);
            this.INSERT_buttom.TabIndex = 4;
            this.INSERT_buttom.Text = "INSERT";
            this.INSERT_buttom.UseVisualStyleBackColor = true;
            this.INSERT_buttom.Click += new System.EventHandler(this.INSERT_Buttom_Click);
            // 
            // vbnvng_textBox
            // 
            this.vbnvng_textBox.Location = new System.Drawing.Point(579, 6);
            this.vbnvng_textBox.Name = "vbnvng_textBox";
            this.vbnvng_textBox.Size = new System.Drawing.Size(185, 20);
            this.vbnvng_textBox.TabIndex = 3;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(388, 6);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(185, 20);
            this.Phone_textBox.TabIndex = 2;
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(197, 6);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(185, 20);
            this.Age_textBox.TabIndex = 1;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(6, 6);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(185, 20);
            this.Name_textBox.TabIndex = 0;
            // 
            // SelectTab
            // 
            this.SelectTab.Controls.Add(this.tableLayoutPanel1);
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(768, 400);
            this.SelectTab.TabIndex = 1;
            this.SelectTab.Text = "SELECT";
            this.SelectTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textBox1.Location = new System.Drawing.Point(3, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 33);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SELECT_buttom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SELECT_buttom
            // 
            this.SELECT_buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SELECT_buttom.Location = new System.Drawing.Point(3, 318);
            this.SELECT_buttom.Name = "SELECT_buttom";
            this.SELECT_buttom.Size = new System.Drawing.Size(756, 33);
            this.SELECT_buttom.TabIndex = 0;
            this.SELECT_buttom.Text = "SELECT";
            this.SELECT_buttom.UseVisualStyleBackColor = true;
            this.SELECT_buttom.Click += new System.EventHandler(this.SELECT_buttom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 309);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.InsetTab.ResumeLayout(false);
            this.InsetTab.PerformLayout();
            this.SelectTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InsetTab;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.Button INSERT_buttom;
        private System.Windows.Forms.TextBox vbnvng_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.Button Clear_buttom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SELECT_buttom;
        private System.Windows.Forms.TextBox textBox1;
    }
}

