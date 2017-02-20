namespace AlcoholSimulatorUI
{
    partial class Configuration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAlco = new System.Windows.Forms.Button();
            this.tbRankAlco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameAlco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAlco = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelAlco = new System.Windows.Forms.Button();
            this.btnDelCoctail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCoctails = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delSoloAlco = new System.Windows.Forms.Button();
            this.editSoloAlco = new System.Windows.Forms.Button();
            this.lbAssembly = new System.Windows.Forms.ListBox();
            this.tbQuantCoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCostCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addSoloAlco = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbNameCoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditCoctail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAlco);
            this.groupBox1.Controls.Add(this.tbRankAlco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNameAlco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить алкоголь";
            // 
            // btnAddAlco
            // 
            this.btnAddAlco.Location = new System.Drawing.Point(10, 119);
            this.btnAddAlco.Name = "btnAddAlco";
            this.btnAddAlco.Size = new System.Drawing.Size(326, 41);
            this.btnAddAlco.TabIndex = 4;
            this.btnAddAlco.Text = "Добавить";
            this.btnAddAlco.UseVisualStyleBackColor = true;
            this.btnAddAlco.Click += new System.EventHandler(this.btnAddAlco_Click);
            // 
            // tbRankAlco
            // 
            this.tbRankAlco.Location = new System.Drawing.Point(10, 90);
            this.tbRankAlco.Name = "tbRankAlco";
            this.tbRankAlco.Size = new System.Drawing.Size(326, 22);
            this.tbRankAlco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Градус алкоголя:";
            // 
            // tbNameAlco
            // 
            this.tbNameAlco.Location = new System.Drawing.Point(10, 42);
            this.tbNameAlco.Name = "tbNameAlco";
            this.tbNameAlco.Size = new System.Drawing.Size(326, 22);
            this.tbNameAlco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // lbAlco
            // 
            this.lbAlco.FormattingEnabled = true;
            this.lbAlco.ItemHeight = 16;
            this.lbAlco.Location = new System.Drawing.Point(7, 201);
            this.lbAlco.Name = "lbAlco";
            this.lbAlco.Size = new System.Drawing.Size(342, 500);
            this.lbAlco.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Список алкоголя:";
            // 
            // btnDelAlco
            // 
            this.btnDelAlco.Location = new System.Drawing.Point(7, 710);
            this.btnDelAlco.Name = "btnDelAlco";
            this.btnDelAlco.Size = new System.Drawing.Size(342, 41);
            this.btnDelAlco.TabIndex = 5;
            this.btnDelAlco.Text = "Удалить выбранный";
            this.btnDelAlco.UseVisualStyleBackColor = true;
            this.btnDelAlco.Click += new System.EventHandler(this.btnDelAlco_Click);
            // 
            // btnDelCoctail
            // 
            this.btnDelCoctail.Location = new System.Drawing.Point(366, 710);
            this.btnDelCoctail.Name = "btnDelCoctail";
            this.btnDelCoctail.Size = new System.Drawing.Size(291, 41);
            this.btnDelCoctail.TabIndex = 8;
            this.btnDelCoctail.Text = "Удалить выбранный";
            this.btnDelCoctail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Список коктейлей:";
            // 
            // lbCoctails
            // 
            this.lbCoctails.FormattingEnabled = true;
            this.lbCoctails.ItemHeight = 16;
            this.lbCoctails.Location = new System.Drawing.Point(366, 361);
            this.lbCoctails.Name = "lbCoctails";
            this.lbCoctails.Size = new System.Drawing.Size(582, 340);
            this.lbCoctails.TabIndex = 7;
            this.lbCoctails.SelectedIndexChanged += new System.EventHandler(this.lbCoctails_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delSoloAlco);
            this.groupBox2.Controls.Add(this.editSoloAlco);
            this.groupBox2.Controls.Add(this.lbAssembly);
            this.groupBox2.Controls.Add(this.tbQuantCoc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbCostCoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.addSoloAlco);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbNameCoc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(366, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 333);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить алкоголь";
            // 
            // delSoloAlco
            // 
            this.delSoloAlco.Location = new System.Drawing.Point(391, 22);
            this.delSoloAlco.Name = "delSoloAlco";
            this.delSoloAlco.Size = new System.Drawing.Size(172, 26);
            this.delSoloAlco.TabIndex = 17;
            this.delSoloAlco.Text = "Удалить";
            this.delSoloAlco.UseVisualStyleBackColor = true;
            this.delSoloAlco.Click += new System.EventHandler(this.delSoloAlco_Click);
            // 
            // editSoloAlco
            // 
            this.editSoloAlco.Location = new System.Drawing.Point(203, 22);
            this.editSoloAlco.Name = "editSoloAlco";
            this.editSoloAlco.Size = new System.Drawing.Size(182, 26);
            this.editSoloAlco.TabIndex = 16;
            this.editSoloAlco.Text = "Изменить";
            this.editSoloAlco.UseVisualStyleBackColor = true;
            this.editSoloAlco.Click += new System.EventHandler(this.editSoloAlco_Click);
            // 
            // lbAssembly
            // 
            this.lbAssembly.FormattingEnabled = true;
            this.lbAssembly.ItemHeight = 16;
            this.lbAssembly.Location = new System.Drawing.Point(15, 54);
            this.lbAssembly.Name = "lbAssembly";
            this.lbAssembly.Size = new System.Drawing.Size(548, 164);
            this.lbAssembly.TabIndex = 11;
            // 
            // tbQuantCoc
            // 
            this.tbQuantCoc.Location = new System.Drawing.Point(100, 268);
            this.tbQuantCoc.Name = "tbQuantCoc";
            this.tbQuantCoc.Size = new System.Drawing.Size(191, 22);
            this.tbQuantCoc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Объем:";
            // 
            // tbCostCoc
            // 
            this.tbCostCoc.Location = new System.Drawing.Point(100, 296);
            this.tbCostCoc.Name = "tbCostCoc";
            this.tbCostCoc.Size = new System.Drawing.Size(191, 22);
            this.tbCostCoc.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена:";
            // 
            // addSoloAlco
            // 
            this.addSoloAlco.Location = new System.Drawing.Point(15, 22);
            this.addSoloAlco.Name = "addSoloAlco";
            this.addSoloAlco.Size = new System.Drawing.Size(182, 26);
            this.addSoloAlco.TabIndex = 11;
            this.addSoloAlco.Text = "Добавить";
            this.addSoloAlco.UseVisualStyleBackColor = true;
            this.addSoloAlco.Click += new System.EventHandler(this.addSoloAlco_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNameCoc
            // 
            this.tbNameCoc.Location = new System.Drawing.Point(100, 240);
            this.tbNameCoc.Name = "tbNameCoc";
            this.tbNameCoc.Size = new System.Drawing.Size(191, 22);
            this.tbNameCoc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Название:";
            // 
            // btnEditCoctail
            // 
            this.btnEditCoctail.Location = new System.Drawing.Point(657, 710);
            this.btnEditCoctail.Name = "btnEditCoctail";
            this.btnEditCoctail.Size = new System.Drawing.Size(291, 41);
            this.btnEditCoctail.TabIndex = 10;
            this.btnEditCoctail.Text = "Изменить выбранный";
            this.btnEditCoctail.UseVisualStyleBackColor = true;
            this.btnEditCoctail.Click += new System.EventHandler(this.btnEditCoctail_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 763);
            this.Controls.Add(this.btnEditCoctail);
            this.Controls.Add(this.btnDelCoctail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCoctails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelAlco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAlco);
            this.Controls.Add(this.groupBox1);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAlco;
        private System.Windows.Forms.TextBox tbRankAlco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameAlco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAlco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelAlco;
        private System.Windows.Forms.Button btnDelCoctail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbCoctails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbNameCoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditCoctail;
        private System.Windows.Forms.Button addSoloAlco;
        public System.Windows.Forms.ListBox lbAssembly;
        private System.Windows.Forms.TextBox tbQuantCoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCostCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delSoloAlco;
        private System.Windows.Forms.Button editSoloAlco;
    }
}