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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            foreach (Procedure procedure in Form1.ProceduresList)
            {
                procedureListBox.Items.Add(procedure.procedure);
            }
        }

        private void whoElse_Click(object sender, EventArgs e)
        {
            IEnumerable<DoctorsProcedure> whoElse =
                from doctor in Form1.DoctorProceduresList
                where doctor.procedureName == procedureListBox.Text
                select doctor;

            if (string.IsNullOrWhiteSpace(procedureListBox.Text))
            {
                MessageBox.Show("Please select a procedure", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (whoElse.Any() == true)
            {
                string theseDoctors = "";
                List<String> docs = new List<String> { };

                foreach (DoctorsProcedure doc in whoElse)
                {
                    if (!docs.Contains(doc.doctorName))
                    {
                        docs.Add(doc.doctorName + " - " + doc.modality);
                    }
                }

                docs.Sort();

                foreach (String doc in docs)
                {
                    theseDoctors += doc + "\n";
                }

                MessageBox.Show(theseDoctors, procedureListBox.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("None", "Hmmm...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
