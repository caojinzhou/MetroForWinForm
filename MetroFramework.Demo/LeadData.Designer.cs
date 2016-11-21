namespace MetroFramework.Demo
{
    partial class LeadData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeadData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okbt = new System.Windows.Forms.Button();
            this.cancelbt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.isTitle = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Spacerb = new MetroFramework.Controls.MetroRadioButton();
            this.commarb = new MetroFramework.Controls.MetroRadioButton();
            this.semicolonrb = new MetroFramework.Controls.MetroRadioButton();
            this.tabrb = new MetroFramework.Controls.MetroRadioButton();
            this.nextbt = new System.Windows.Forms.Button();
            this.backbt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(15, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指定字段";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(119, 170);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(82, 25);
            this.comboBox5.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(119, 133);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(82, 25);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(119, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 25);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 25);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "lon字段：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "lat字段：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "locationid字段：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "time字段：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "uid字段：";
            // 
            // okbt
            // 
            this.okbt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okbt.Location = new System.Drawing.Point(156, 275);
            this.okbt.Name = "okbt";
            this.okbt.Size = new System.Drawing.Size(75, 23);
            this.okbt.TabIndex = 1;
            this.okbt.Text = "确定";
            this.okbt.UseVisualStyleBackColor = true;
            this.okbt.Click += new System.EventHandler(this.okbt_Click);
            // 
            // cancelbt
            // 
            this.cancelbt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelbt.Location = new System.Drawing.Point(15, 251);
            this.cancelbt.Name = "cancelbt";
            this.cancelbt.Size = new System.Drawing.Size(75, 23);
            this.cancelbt.TabIndex = 2;
            this.cancelbt.Text = "取消";
            this.cancelbt.UseVisualStyleBackColor = true;
            this.cancelbt.Click += new System.EventHandler(this.cancelbt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "文件来源：";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(75, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // isTitle
            // 
            this.isTitle.AutoSize = true;
            this.isTitle.Location = new System.Drawing.Point(15, 42);
            this.isTitle.Name = "isTitle";
            this.isTitle.Size = new System.Drawing.Size(96, 17);
            this.isTitle.TabIndex = 5;
            this.isTitle.Text = "数据包含标题";
            this.isTitle.UseSelectable = true;
            this.isTitle.CheckedChanged += new System.EventHandler(this.isTitle_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Spacerb);
            this.groupBox2.Controls.Add(this.commarb);
            this.groupBox2.Controls.Add(this.semicolonrb);
            this.groupBox2.Controls.Add(this.tabrb);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(15, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 120);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择分隔符号";
            // 
            // Spacerb
            // 
            this.Spacerb.AutoSize = true;
            this.Spacerb.Location = new System.Drawing.Point(130, 79);
            this.Spacerb.Name = "Spacerb";
            this.Spacerb.Size = new System.Drawing.Size(48, 17);
            this.Spacerb.TabIndex = 4;
            this.Spacerb.Text = "空格";
            this.Spacerb.UseSelectable = true;
            // 
            // commarb
            // 
            this.commarb.AutoSize = true;
            this.commarb.Location = new System.Drawing.Point(130, 39);
            this.commarb.Name = "commarb";
            this.commarb.Size = new System.Drawing.Size(48, 17);
            this.commarb.TabIndex = 3;
            this.commarb.Text = "逗号";
            this.commarb.UseSelectable = true;
            // 
            // semicolonrb
            // 
            this.semicolonrb.AutoSize = true;
            this.semicolonrb.Location = new System.Drawing.Point(17, 79);
            this.semicolonrb.Name = "semicolonrb";
            this.semicolonrb.Size = new System.Drawing.Size(48, 17);
            this.semicolonrb.TabIndex = 2;
            this.semicolonrb.Text = "分号";
            this.semicolonrb.UseSelectable = true;
            // 
            // tabrb
            // 
            this.tabrb.AutoSize = true;
            this.tabrb.Checked = true;
            this.tabrb.Location = new System.Drawing.Point(17, 39);
            this.tabrb.Name = "tabrb";
            this.tabrb.Size = new System.Drawing.Size(58, 17);
            this.tabrb.TabIndex = 1;
            this.tabrb.TabStop = true;
            this.tabrb.Text = "Tab键";
            this.tabrb.UseSelectable = true;
            // 
            // nextbt
            // 
            this.nextbt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextbt.Location = new System.Drawing.Point(156, 251);
            this.nextbt.Name = "nextbt";
            this.nextbt.Size = new System.Drawing.Size(75, 23);
            this.nextbt.TabIndex = 7;
            this.nextbt.Text = "下一步";
            this.nextbt.UseVisualStyleBackColor = true;
            this.nextbt.Click += new System.EventHandler(this.nextbt_Click);
            // 
            // backbt
            // 
            this.backbt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backbt.Location = new System.Drawing.Point(15, 275);
            this.backbt.Name = "backbt";
            this.backbt.Size = new System.Drawing.Size(75, 23);
            this.backbt.TabIndex = 8;
            this.backbt.Text = "上一步";
            this.backbt.UseVisualStyleBackColor = true;
            this.backbt.Click += new System.EventHandler(this.backbt_Click);
            // 
            // LeadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(251, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backbt);
            this.Controls.Add(this.nextbt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.isTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.okbt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelbt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeadData";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "指定字段";
            this.Load += new System.EventHandler(this.LeadData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okbt;
        private System.Windows.Forms.Button cancelbt;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Controls.MetroCheckBox isTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.MetroRadioButton tabrb;
        private Controls.MetroRadioButton Spacerb;
        private Controls.MetroRadioButton commarb;
        private Controls.MetroRadioButton semicolonrb;
        private System.Windows.Forms.Button nextbt;
        private System.Windows.Forms.Button backbt;
    }
}