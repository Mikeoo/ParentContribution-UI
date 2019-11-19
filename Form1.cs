using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentContribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> childs = new List<string>();
        int addedKids = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            childs.Add(monthCalendar1.SelectionRange.ToString());
            addedKids += 1;
            numberOfKidsAdded.Text = Convert.ToString(addedKids);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            childs.RemoveAt(childs.Count - 1);
            addedKids -= 1;
            numberOfKidsAdded.Text = Convert.ToString(addedKids);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime kid = Convert.ToDateTime(childs[1]);
            int age = today.Year - kid.Year;
            if (today.Month < kid.Month)
            {
                age--;
            }
            else if (today.Month == kid.Month && today.Day < kid.Day)
            {
                age--;
            }
            textBox1.Text = Convert.ToString(age);
        }
    }
}
