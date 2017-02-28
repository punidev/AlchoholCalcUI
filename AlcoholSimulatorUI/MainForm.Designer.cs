namespace AlcoholSimulatorUI
{
    partial class MainForm
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
            this.dgvAlcohols = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvCoctails = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            this.lbCoctails = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.lbOptimized = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWeight2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lbIn = new System.Windows.Forms.ListBox();
            this.lbOut = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohols)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoctails)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlcohols
            // 
            this.dgvAlcohols.AllowUserToAddRows = false;
            this.dgvAlcohols.AllowUserToDeleteRows = false;
            this.dgvAlcohols.AllowUserToResizeColumns = false;
            this.dgvAlcohols.AllowUserToResizeRows = false;
            this.dgvAlcohols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlcohols.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlcohols.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlcohols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlcohols.Location = new System.Drawing.Point(0, 0);
            this.dgvAlcohols.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlcohols.Name = "dgvAlcohols";
            this.dgvAlcohols.ReadOnly = true;
            this.dgvAlcohols.RowHeadersVisible = false;
            this.dgvAlcohols.RowHeadersWidth = 410;
            this.dgvAlcohols.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlcohols.RowTemplate.Height = 23;
            this.dgvAlcohols.RowTemplate.ReadOnly = true;
            this.dgvAlcohols.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlcohols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAlcohols.Size = new System.Drawing.Size(878, 585);
            this.dgvAlcohols.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 614);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAlcohols);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Алкоголь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvCoctails);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(874, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Коктейли";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvCoctails
            // 
            this.dgvCoctails.AllowUserToAddRows = false;
            this.dgvCoctails.AllowUserToDeleteRows = false;
            this.dgvCoctails.AllowUserToResizeColumns = false;
            this.dgvCoctails.AllowUserToResizeRows = false;
            this.dgvCoctails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoctails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoctails.BackgroundColor = System.Drawing.Color.White;
            this.dgvCoctails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCoctails.Location = new System.Drawing.Point(0, 0);
            this.dgvCoctails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCoctails.Name = "dgvCoctails";
            this.dgvCoctails.ReadOnly = true;
            this.dgvCoctails.RowHeadersVisible = false;
            this.dgvCoctails.RowHeadersWidth = 410;
            this.dgvCoctails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCoctails.RowTemplate.Height = 23;
            this.dgvCoctails.RowTemplate.ReadOnly = true;
            this.dgvCoctails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoctails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCoctails.Size = new System.Drawing.Size(874, 585);
            this.dgvCoctails.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btnSort);
            this.tabPage2.Controls.Add(this.lbIngredients);
            this.tabPage2.Controls.Add(this.lbCoctails);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ингредиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(7, 331);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(428, 46);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Управление коктейлями";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите метод сортировки:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По цене",
            "По названию",
            "По объему",
            "По кол-ву ингредиентов"});
            this.comboBox1.Location = new System.Drawing.Point(191, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(7, 270);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(178, 45);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.ItemHeight = 16;
            this.lbIngredients.Location = new System.Drawing.Point(3, 3);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(434, 260);
            this.lbIngredients.TabIndex = 1;
            // 
            // lbCoctails
            // 
            this.lbCoctails.FormattingEnabled = true;
            this.lbCoctails.ItemHeight = 16;
            this.lbCoctails.Location = new System.Drawing.Point(443, 3);
            this.lbCoctails.Name = "lbCoctails";
            this.lbCoctails.Size = new System.Drawing.Size(423, 580);
            this.lbCoctails.TabIndex = 0;
            this.lbCoctails.SelectedIndexChanged += new System.EventHandler(this.lbCoctails_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbLogs);
            this.tabPage4.Controls.Add(this.lbOptimized);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.tbMoney);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.tbWeight);
            this.tabPage4.Controls.Add(this.btnSelect);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(874, 585);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Оптимизация";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbLogs
            // 
            this.rtbLogs.Location = new System.Drawing.Point(16, 460);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(840, 113);
            this.rtbLogs.TabIndex = 7;
            this.rtbLogs.Text = "";
            // 
            // lbOptimized
            // 
            this.lbOptimized.FormattingEnabled = true;
            this.lbOptimized.ItemHeight = 16;
            this.lbOptimized.Location = new System.Drawing.Point(16, 65);
            this.lbOptimized.Name = "lbOptimized";
            this.lbOptimized.Size = new System.Drawing.Size(840, 388);
            this.lbOptimized.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите кол-во денег:";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(484, 25);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(151, 22);
            this.tbMoney.TabIndex = 4;
            this.tbMoney.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(265, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Оптимизированный расчёт";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите свой вес: ";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(16, 25);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(117, 22);
            this.tbWeight.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(149, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(107, 41);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Расчитать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.tbWeight2);
            this.tabPage5.Controls.Add(this.btnSearch);
            this.tabPage5.Controls.Add(this.btnMinus);
            this.tabPage5.Controls.Add(this.btnPlus);
            this.tabPage5.Controls.Add(this.lbIn);
            this.tabPage5.Controls.Add(this.lbOut);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(874, 585);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Поиск решения";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите свой вес: ";
            // 
            // tbWeight2
            // 
            this.tbWeight2.Location = new System.Drawing.Point(16, 25);
            this.tbWeight2.Name = "tbWeight2";
            this.tbWeight2.Size = new System.Drawing.Size(117, 22);
            this.tbWeight2.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 41);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Расчитать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(419, 345);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(46, 46);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(419, 293);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 46);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lbIn
            // 
            this.lbIn.FormattingEnabled = true;
            this.lbIn.ItemHeight = 16;
            this.lbIn.Location = new System.Drawing.Point(2, 66);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(411, 516);
            this.lbIn.TabIndex = 3;
            // 
            // lbOut
            // 
            this.lbOut.FormattingEnabled = true;
            this.lbOut.ItemHeight = 16;
            this.lbOut.Location = new System.Drawing.Point(471, 66);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(400, 516);
            this.lbOut.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohols)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoctails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlcohols;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvCoctails;
        private System.Windows.Forms.ListBox lbIngredients;
        private System.Windows.Forms.ListBox lbCoctails;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.ListBox lbOptimized;
        public System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.ListBox lbIn;
        private System.Windows.Forms.ListBox lbOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWeight2;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editBtn;
    }
}

