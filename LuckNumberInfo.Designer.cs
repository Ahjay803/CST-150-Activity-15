
namespace Lucky_Numbers__Activity_15_
{
    partial class LuckNumberInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthYearComboBox = new System.Windows.Forms.ComboBox();
            this.birthMonthComboBox = new System.Windows.Forms.ComboBox();
            this.birthDayComboBox = new System.Windows.Forms.ComboBox();
            this.favColorComboBox = new System.Windows.Forms.ComboBox();
            this.luckyNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(127, 61);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(127, 112);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your birth month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(130, 163);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(120, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your birth day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(127, 227);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(141, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your favorite color";
            // 
            // birthYearComboBox
            // 
            this.birthYearComboBox.FormattingEnabled = true;
            this.birthYearComboBox.Location = new System.Drawing.Point(322, 61);
            this.birthYearComboBox.Name = "birthYearComboBox";
            this.birthYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthYearComboBox.TabIndex = 4;
            this.birthYearComboBox.SelectedIndexChanged += new System.EventHandler(this.birthYearComboBox_SelectedIndexChanged);
            // 
            // birthMonthComboBox
            // 
            this.birthMonthComboBox.FormattingEnabled = true;
            this.birthMonthComboBox.Location = new System.Drawing.Point(322, 112);
            this.birthMonthComboBox.Name = "birthMonthComboBox";
            this.birthMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthMonthComboBox.TabIndex = 5;
            this.birthMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.birthMonthComboBox_SelectedIndexChanged);
            // 
            // birthDayComboBox
            // 
            this.birthDayComboBox.FormattingEnabled = true;
            this.birthDayComboBox.Location = new System.Drawing.Point(322, 163);
            this.birthDayComboBox.Name = "birthDayComboBox";
            this.birthDayComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthDayComboBox.TabIndex = 6;
            this.birthDayComboBox.SelectedIndexChanged += new System.EventHandler(this.birthDayComboBox_SelectedIndexChanged);
            // 
            // favColorComboBox
            // 
            this.favColorComboBox.FormattingEnabled = true;
            this.favColorComboBox.Items.AddRange(new object[] {
            "Blue ",
            "Green",
            "Purple",
            "Red",
            "Orange",
            "Black",
            "Brown",
            "Yellow",
            "White"});
            this.favColorComboBox.Location = new System.Drawing.Point(322, 227);
            this.favColorComboBox.Name = "favColorComboBox";
            this.favColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.favColorComboBox.TabIndex = 7;
            this.favColorComboBox.SelectedIndexChanged += new System.EventHandler(this.favColorComboBox_SelectedIndexChanged);
            // 
            // luckyNumberButton
            // 
            this.luckyNumberButton.BackColor = System.Drawing.Color.GreenYellow;
            this.luckyNumberButton.Location = new System.Drawing.Point(105, 385);
            this.luckyNumberButton.Name = "luckyNumberButton";
            this.luckyNumberButton.Padding = new System.Windows.Forms.Padding(10);
            this.luckyNumberButton.Size = new System.Drawing.Size(338, 59);
            this.luckyNumberButton.TabIndex = 8;
            this.luckyNumberButton.Text = "Get Your Lucky Number";
            this.luckyNumberButton.UseVisualStyleBackColor = false;
            this.luckyNumberButton.Click += new System.EventHandler(this.luckyNumberButton_Click);
            // 
            // LuckNumberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Lucky_Numbers__Activity_15_.Properties.Resources.Cosmic;
            this.ClientSize = new System.Drawing.Size(543, 512);
            this.Controls.Add(this.luckyNumberButton);
            this.Controls.Add(this.favColorComboBox);
            this.Controls.Add(this.birthDayComboBox);
            this.Controls.Add(this.birthMonthComboBox);
            this.Controls.Add(this.birthYearComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LuckNumberInfo";
            this.Text = "Lucky Numbers ";
            this.Load += new System.EventHandler(this.LuckNumberInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox birthYearComboBox;
        private System.Windows.Forms.ComboBox birthMonthComboBox;
        private System.Windows.Forms.ComboBox birthDayComboBox;
        private System.Windows.Forms.ComboBox favColorComboBox;
        private System.Windows.Forms.Button luckyNumberButton;
    }
}

