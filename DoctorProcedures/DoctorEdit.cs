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
    public partial class DoctorEdit : Form
    {
        public DoctorEdit()
        {
            InitializeComponent();            
        }

        private void submitEditDoctorButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorProcedureClassDataContext editDocSetupContext = new DoctorProcedureClassDataContext();
                DataClasses1DataContext editDocContext = new DataClasses1DataContext();

                var doctorSetups = (from setups in editDocSetupContext.DoctorsProcedures
                                    where setups.doctorName == oldDoctorName.Text
                                    select setups);

                var doctor = (from docs in editDocContext.Doctors
                              where docs.doctorName == oldDoctorName.Text
                              select docs).First();

                if (!String.IsNullOrWhiteSpace(newDoctorName.Text) &&
                    !String.IsNullOrWhiteSpace(newInitials.Text) &&
                    !String.IsNullOrWhiteSpace(newGloves.Text))
                {
                    foreach (DoctorsProcedure setup in doctorSetups)
                    {
                        setup.doctorName = newDoctorName.Text;
                        setup.gloveSize = Decimal.Parse(newGloves.Text);
                    }

                    doctor.doctorName = newDoctorName.Text;
                    doctor.gloveSize = Decimal.Parse(newGloves.Text);
                    
                    editDocSetupContext.SubmitChanges();
                    editDocContext.SubmitChanges();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;                    

                    MessageBox.Show("Updated", "Setup",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill out all data", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finishedEditDoctorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
