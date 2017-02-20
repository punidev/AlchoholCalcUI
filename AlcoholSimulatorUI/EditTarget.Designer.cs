namespace AlcoholSimulatorUI
{
    partial class EditTarget
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
            this.btnAddAlco = new System.Windows.Forms.Button();
            this.tbRankAlco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameAlco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPartAlco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAlco
            // 
            this.btnAddAlco.Location = new System.Drawing.Point(12, 166);
            this.btnAddAlco.Name = "btnAddAlco";
            this.btnAddAlco.Size = new System.Drawing.Size(326, 41);
            this.btnAddAlco.TabIndex = 9;
            this.btnAddAlco.Text = "Добавить";
            this.btnAddAlco.UseVisualStyleBackColor = true;
            this.btnAddAlco.Click += new System.EventHandler(this.btnAddAlco_Click);
            // 
            // tbRankAlco
            // 
            this.tbRankAlco.Location = new System.Drawing.Point(12, 80);
            this.tbRankAlco.Name = "tbRankAlco";
            this.tbRankAlco.ReadOnly = true;
            this.tbRankAlco.Size = new System.Drawing.Size(326, 22);
            this.tbRankAlco.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Градус алкоголя:";
            // 
            // tbNameAlco
            // 
            this.tbNameAlco.Location = new System.Drawing.Point(12, 32);
            this.tbNameAlco.Name = "tbNameAlco";
            this.tbNameAlco.ReadOnly = true;
            this.tbNameAlco.Size = new System.Drawing.Size(326, 22);
            this.tbNameAlco.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // tbPartAlco
            // 
            this.tbPartAlco.Location = new System.Drawing.Point(12, 125);
            this.tbPartAlco.Name = "tbPartAlco";
            this.tbPartAlco.Size = new System.Drawing.Size(326, 22);
            this.tbPartAlco.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Доля в коктейле:";
            // 
            // EditTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 226);
            this.Controls.Add(this.tbPartAlco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAlco);
            this.Controls.Add(this.tbRankAlco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameAlco);
            this.Controls.Add(this.label1);
            this.Name = "EditTarget";
            this.Text = "EditTarget";
            this.Load += new System.EventHandler(this.EditTarget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAlco;
        private System.Windows.Forms.TextBox tbRankAlco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameAlco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPartAlco;
        private System.Windows.Forms.Label label3;
    }
}