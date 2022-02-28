
namespace Lucky_Numbers__Activity_15_
{
    partial class userLuckyNumber
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
            this.userLuckyNumberLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLuckyNumberLabel
            // 
            this.userLuckyNumberLabel.AutoSize = true;
            this.userLuckyNumberLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.userLuckyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLuckyNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userLuckyNumberLabel.Location = new System.Drawing.Point(237, 147);
            this.userLuckyNumberLabel.Name = "userLuckyNumberLabel";
            this.userLuckyNumberLabel.Padding = new System.Windows.Forms.Padding(10);
            this.userLuckyNumberLabel.Size = new System.Drawing.Size(20, 51);
            this.userLuckyNumberLabel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(182, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10);
            this.exitButton.Size = new System.Drawing.Size(159, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userLuckyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lucky_Numbers__Activity_15_.Properties.Resources.Cosmic;
            this.ClientSize = new System.Drawing.Size(576, 618);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.userLuckyNumberLabel);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Name = "userLuckyNumber";
            this.Text = "User Lucky Number";
            this.Load += new System.EventHandler(this.userLuckyNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLuckyNumberLabel;
        private System.Windows.Forms.Button exitButton;
    }
}