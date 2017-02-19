namespace AlcoholSimulatorUI
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
            this.dgvAlcohols = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvCoctails = new System.Windows.Forms.DataGridView();
            this.lbCoctails = new System.Windows.Forms.ListBox();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohols)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoctails)).BeginInit();
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
            this.dgvAlcohols.Size = new System.Drawing.Size(866, 466);
            this.dgvAlcohols.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 495);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAlcohols);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Алкоголь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbIngredients);
            this.tabPage2.Controls.Add(this.lbCoctails);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ингредиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvCoctails);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(866, 466);
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
            this.dgvCoctails.Size = new System.Drawing.Size(866, 466);
            this.dgvCoctails.TabIndex = 3;
            // 
            // lbCoctails
            // 
            this.lbCoctails.FormattingEnabled = true;
            this.lbCoctails.ItemHeight = 16;
            this.lbCoctails.Location = new System.Drawing.Point(443, 3);
            this.lbCoctails.Name = "lbCoctails";
            this.lbCoctails.Size = new System.Drawing.Size(423, 452);
            this.lbCoctails.TabIndex = 0;
            this.lbCoctails.SelectedIndexChanged += new System.EventHandler(this.lbCoctails_SelectedIndexChanged);
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.ItemHeight = 16;
            this.lbIngredients.Location = new System.Drawing.Point(3, 0);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(434, 452);
            this.lbIngredients.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohols)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoctails)).EndInit();
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
    }
}

