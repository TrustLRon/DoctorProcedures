using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorProcedures
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void helpTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (helpTree.SelectedNode.Text == "About")
            {
                helpTextBox.Text = "About";
            }
            else if (helpTree.SelectedNode.Text == "Add")
            {
                helpTextBox.Text = "Add";
            }
            else if (helpTree.SelectedNode.Text == "Delete")
            {
                helpTextBox.Text = "Delete";
            }
            else if (helpTree.SelectedNode.Text == "View")
            {
                helpTextBox.Text = "View";
            }
            else
            {
                helpTextBox.Text = "";
            }
        }
    }
}
