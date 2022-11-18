using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Program by Joseph Estes
 * This program demonstrates buttons and labels in a form.
 * 
 * User selects the "click here" button and that displays a label,
 * and enables a "click me last" button. This second button changes the label.
 * 
 */

namespace Joseph.Estes.Ch3.You.Do.It
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void DisplayOutputButton_Click(object sender, EventArgs e)
        {
            helloLabel.Visible = true;

            changeOutputButton.Enabled = true;
        }

        private void ChangeOutputButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Goodbye";
        }
    }
}
