using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _8Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeButton(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox2.Text = GetNextDay(textBox1.Text);
            }
        }
        public  String GetNextDay(String date)
        {

            String pattern = "[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]";

            MatchCollection matches;

            Regex reg = new Regex(pattern);
            matches = reg.Matches(date);
            for (int i = 0; i < matches.Count; i++)
            {

                String prevDay = DateTime.Parse(matches[i].Value).AddDays(-1).ToShortDateString();
                date = date.Replace(matches[i].Value, prevDay);
            }
            return date;

        }
    }
}
