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
    public partial class LuckNumberInfo : Form
    {


        public LuckNumberInfo()
        {
            InitializeComponent();
        }







        private void LuckNumberInfo_Load(object sender, EventArgs e)
        {

            // Automatically populate birth years from 1930 to 2022
            int birthYear = 1930;
            for (int i = 1930; i <= 2022; i++)
            {
                birthYearComboBox.Items.Add(birthYear);
                birthYear += 1;
            }

            int birthMonth = 1;
            for (int i = 1; i <= 12; i++)
            {
                birthMonthComboBox.Items.Add(birthMonth);
                birthMonth++;
            }


        }







        private void birthDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void luckyNumberButton_Click(object sender, EventArgs e)
        {
            userLuckyNumber luckyNumber = new userLuckyNumber();
            luckyNumber.ShowDialog();
        }

        private void favColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void birthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            birthDayComboBox.Items.Clear();

            int[] ninefourMonthdate = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int datePopulate = ninefourMonthdate[birthMonthComboBox.SelectedIndex];
            for (int i = 1; i < datePopulate + 1; i++)
            {
                birthDayComboBox.Items.Add(i);
            }

        }

        private void birthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
