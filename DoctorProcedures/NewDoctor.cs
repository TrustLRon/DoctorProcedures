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
    public partial class NewDoctor : Form
    {
        public NewDoctor()
        {
            InitializeComponent();
            loadDoctors();
        }

        public void loadDoctors()
        {
            doctorBox.Items.Clear();
            foreach (Doctor doctor in Form1.DoctorsList)
            {
                if (!doctorBox.Items.Contains(doctor.doctorName))
                {
                    doctorBox.Items.Add(doctor.doctorName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(textBox1.Text) &&
                    !String.IsNullOrWhiteSpace(textBox2.Text) &&
                    !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    DataClasses1DataContext doctorContext= new DataClasses1DataContext();
                    Doctor doctor = new Doctor();
                    doctor.doctorName = textBox1.Text;
                    doctor.doctorID = textBox2.Text;
                    doctor.gloveSize = Decimal.Parse(textBox3.Text);
                    doctorContext.Doctors.InsertOnSubmit(doctor);

                    doctorContext.SubmitChanges();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    Form1.GetDoctors();
                    loadDoctors();
                }
                else
                {
                    MessageBox.Show("Cannot be empty...", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong, does the doctor already exist? Please try again...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataClasses1DataContext deleteContext = new DataClasses1DataContext();
                if (!String.IsNullOrEmpty(doctorBox.Text))
                {
                    var doctor = (from doc in deleteContext.Doctors
                                  where doc.doctorName == doctorBox.Text
                                  select doc).First();
                    deleteContext.Doctors.DeleteOnSubmit(doctor);

                    deleteContext.SubmitChanges();
                    Form1.DoctorsList.Clear();
                    Form1.GetDoctors();
                    loadDoctors();

                    MessageBox.Show("Deleted", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a doctor...", "Error",
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DoctorEdit docEdit = new DoctorEdit();

            if (!String.IsNullOrEmpty(doctorBox.Text))
            {
                DataClasses1DataContext editContext = new DataClasses1DataContext();

                var doctor = (from doc in editContext.Doctors
                              where doc.doctorName == doctorBox.Text
                              select doc).First();

                
                docEdit.oldDoctorName.Text = doctor.doctorName;
                docEdit.oldInitials.Text = doctor.doctorID;
                docEdit.oldGloves.Text = doctor.gloveSize.ToString();
                docEdit.newDoctorName.Text = doctor.doctorName;
                docEdit.newInitials.Text = doctor.doctorID;
                docEdit.newGloves.Text = doctor.gloveSize.ToString();

                docEdit.ShowDialog(this);

                if (docEdit.DialogResult == DialogResult.OK)
                {
                    Form1.DoctorsList.Clear();
                    Form1.GetDoctors();
                    loadDoctors();
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor from the list", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
