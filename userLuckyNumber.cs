using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Numbers__Activity_15_
{
    public partial class userLuckyNumber : Form
    {
        public userLuckyNumber()
        {
            InitializeComponent();
        }

        private void userLuckyNumber_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i = 1930; i <= 2022; i++)
            {
                userLuckyNumberLabel.Text = rand.Next(2022).ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close applications
            Application.Exit();
        }
    }
}
