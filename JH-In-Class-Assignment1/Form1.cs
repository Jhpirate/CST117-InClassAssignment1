using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JH_In_Class_Assignment1
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            helloThereLabel.Visible = true;
            clickMeButtonHint.Visible = false;

            appearOnButtonClick.Text = "Pooof! I have appeared out of nowhere!";
        }
    }
}
