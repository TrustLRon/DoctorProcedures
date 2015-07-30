using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorProcedures
{
    public partial class NewProcedure : Form
    {
        public NewProcedure()
        {
            InitializeComponent();
            loadProcedures();
        }

        public void loadProcedures()
        {
            procedureBox.Items.Clear();
            foreach (Procedure procedure in Form1.ProceduresList)
            {
                if (!procedureBox.Items.Contains(procedure.procedure))
                {
                    procedureBox.Items.Add(procedure.procedure);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    ProcedureClassDataContext procedureContext = new ProcedureClassDataContext();
                    Procedure proc = new Procedure();
                    proc.procedure = textBox1.Text;
                    procedureContext.Procedures.InsertOnSubmit(proc);

                    procedureContext.SubmitChanges();
                    textBox1.Text = "";
                    Form1.GetProcedures();
                    loadProcedures();
                }
                else
                {
                    MessageBox.Show("Cannot be empty...", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong, try again...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ProcedureClassDataContext deleteContext = new ProcedureClassDataContext();
                if (!String.IsNullOrEmpty(procedureBox.Text))
                {
                    var procedure = (from proc in deleteContext.Procedures
                                     where proc.procedure == procedureBox.Text
                                     select proc).First();
                    deleteContext.Procedures.DeleteOnSubmit(procedure);

                    deleteContext.SubmitChanges();
                    Form1.ProceduresList.Clear();
                    Form1.GetProcedures();
                    loadProcedures();

                    MessageBox.Show("Deleted", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a procedure...", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No Changes Made", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }        
    }
}
