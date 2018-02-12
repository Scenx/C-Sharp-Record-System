namespace 学生成绩管理系统
{
    partial class InsertSCForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.textBox_cno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.textBox_cgrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // textBox_sno
            // 
            this.textBox_sno.Location = new System.Drawing.Point(75, 23);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(166, 21);
            this.textBox_sno.TabIndex = 1;
            // 
            // textBox_cno
            // 
            this.textBox_cno.Location = new System.Drawing.Point(75, 66);
            this.textBox_cno.Name = "textBox_cno";
            this.textBox_cno.Size = new System.Drawing.Size(166, 21);
            this.textBox_cno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程号：";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(75, 156);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 4;
            this.button_insert.Text = "录入";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // textBox_cgrade
            // 
            this.textBox_cgrade.Location = new System.Drawing.Point(75, 107);
            this.textBox_cgrade.Name = "textBox_cgrade";
            this.textBox_cgrade.Size = new System.Drawing.Size(166, 21);
            this.textBox_cgrade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "成绩：";
            // 
            // InsertSCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.textBox_cgrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textBox_cno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.label1);
            this.Name = "InsertSCForm";
            this.Text = "录入学生成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.TextBox textBox_cno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox textBox_cgrade;
        private System.Windows.Forms.Label label3;
    }
}