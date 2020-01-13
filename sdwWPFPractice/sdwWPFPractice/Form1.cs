using System;
using System.Windows.Forms;
using CustomForms;

namespace sdwWPFPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForms.MsgControl.show(button1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomForms.MsgControl.show(button2.Text);
        }
    }
}
