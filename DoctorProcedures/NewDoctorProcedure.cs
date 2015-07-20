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
    public partial class NewDoctorProcedure : Form
    {
        public NewDoctorProcedure()
        {
            InitializeComponent();
            loadDoctors();
            loadProcedures();
            foreach (String modality in Form1.ModalitiesList)
            {
                modalityBox.Items.Add(modality);
            }
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

        public void loadProcedures()
        {
            foreach (Procedure procedure in Form1.ProceduresList)
            {
                    procedureBox.Items.Add(procedure.procedure);
            }
        }

        public void updateProcedure()
        {
            IEnumerable<DoctorsProcedure> procedureQuery =
                from procedure in Form1.DoctorProceduresList
                where procedure.doctorName == doctorBox.Text &&
                        procedure.procedureName == procedureBox.Text
                select procedure;

            if (procedureQuery.Any() == true)
            {
                foreach (DoctorsProcedure procedure in procedureQuery)
                {
                    modalityBox.Text = procedure.modality;
                    patientOrientationBox.Text = procedure.patientOrientation;
                    syringes1mLBox.Text = procedure.syringes1mL.ToString();
                    syringes3mLBox.Text = procedure.syringes3mL.ToString();
                    syringes5mLBox.Text = procedure.syringes5mL.ToString();
                    syringes10mLBox.Text = procedure.syringes10mL.ToString();
                    needleDrawingUpBox.Text = procedure.needleDrawingUp.ToString();
                    needle25gBox.Text = procedure.needle25g.ToString();
                    needle19gBox.Text = procedure.needle19g.ToString();
                    needle22g50mmBox.Text = procedure.needle22g50mm.ToString();
                    needle22g90mmBox.Text = procedure.needle22g90mm.ToString();
                    contrastBox.Text = procedure.contrast;
                    ifBilateralBox.Text = procedure.ifBilateral;
                    otherEquipmentBox.Text = procedure.otherEquipment;
                    commentsBox.Text = procedure.comments;
                    lignocaineBox.Text = procedure.lignocaine.ToString();
                    bupivacaineBox.Text = procedure.bupivacaine.ToString();
                    steroidTypeBox.Text = procedure.steroidType;
                    steroidAmountBox.Text = procedure.steroidAmount.ToString();
                    nameBox.Text = procedure.doctorName;
                    initialsBox.Text = procedure.doctorID;
                    glovesBox.Text = procedure.gloveSize.ToString();

                }
            }
        }

        private void doctorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearInfo();
            updateProcedure();
        }

        private void procedureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearInfo();
            updateProcedure();
        }

        private void clearInfo()
        {
            modalityBox.Text = "";
            syringes1mLBox.Text = "";
            syringes3mLBox.Text = "";
            syringes5mLBox.Text = "";
            syringes10mLBox.Text = "";
            needleDrawingUpBox.Text = "";
            needle25gBox.Text = "";
            needle19gBox.Text = "";
            needle22g50mmBox.Text = "";
            needle22g90mmBox.Text = "";
            contrastBox.Text = "";
            patientOrientationBox.Text = "";
            ifBilateralBox.Text = "";
            otherEquipmentBox.Text = "";
            commentsBox.Text = "";
            lignocaineBox.Text = "";
            bupivacaineBox.Text = "";
            steroidTypeBox.Text = "";
            steroidAmountBox.Text = "";
            nameBox.Text = "";
            initialsBox.Text = "";
            glovesBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DoctorProcedureClassDataContext setupContext = new DoctorProcedureClassDataContext();
            DataClasses1DataContext doctorContext = new DataClasses1DataContext();

            try
            {
                var checkDB = (from setupCheck in setupContext.DoctorsProcedures
                               where setupCheck.doctorName == doctorBox.Text &&
                               setupCheck.procedureName == procedureBox.Text
                               select setupCheck).Any();

                var doctor = (from initials in doctorContext.Doctors
                                      where initials.doctorName == doctorBox.Text
                                      select initials).First(); 
                
                if (checkDB == true)
                {
                    var doctorSetup = (from setupCheck in setupContext.DoctorsProcedures
                                       where setupCheck.doctorName == doctorBox.Text &&
                                       setupCheck.procedureName == procedureBox.Text
                                       select setupCheck).First();

                    doctorSetup.doctorName = doctorBox.Text;
                    doctorSetup.doctorID = doctor.doctorID;
                    doctorSetup.gloveSize = doctor.gloveSize;
                    doctorSetup.procedureName = procedureBox.Text;
                    doctorSetup.modality = modalityBox.Text;
                    doctorSetup.patientOrientation = patientOrientationBox.Text;
                    doctorSetup.ifBilateral = ifBilateralBox.Text;
                    doctorSetup.syringes1mL = Decimal.Parse(syringes1mLBox.Text);
                    doctorSetup.syringes3mL = Decimal.Parse(syringes3mLBox.Text);
                    doctorSetup.syringes5mL = Decimal.Parse(syringes5mLBox.Text);
                    doctorSetup.syringes10mL = Decimal.Parse(syringes10mLBox.Text);
                    doctorSetup.needleDrawingUp = Decimal.Parse(needleDrawingUpBox.Text);
                    doctorSetup.needle25g = Decimal.Parse(needle25gBox.Text);
                    doctorSetup.needle19g = Decimal.Parse(needle19gBox.Text);
                    doctorSetup.needle22g50mm = Decimal.Parse(needle22g50mmBox.Text);
                    doctorSetup.needle22g90mm = Decimal.Parse(needle22g90mmBox.Text);
                    doctorSetup.contrast = contrastBox.Text;
                    doctorSetup.lignocaine = Decimal.Parse(lignocaineBox.Text);
                    doctorSetup.bupivacaine = Decimal.Parse(bupivacaineBox.Text);
                    doctorSetup.steroidType = steroidTypeBox.Text;
                    doctorSetup.steroidAmount = Decimal.Parse(steroidAmountBox.Text);
                    doctorSetup.otherEquipment = otherEquipmentBox.Text;
                    doctorSetup.comments = commentsBox.Text;

                    setupContext.SubmitChanges();
                    Form1.DoctorProceduresList.Clear();
                    Form1.GetDoctorsProcedures();

                    MessageBox.Show("Updated", "Setup", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DoctorsProcedure setup = new DoctorsProcedure();
                    try
                    {
                        setup.doctorName = doctorBox.Text;
                        setup.doctorID = doctor.doctorID;
                        setup.gloveSize = doctor.gloveSize;
                        setup.procedureName = procedureBox.Text;
                        setup.modality = modalityBox.Text;
                        setup.patientOrientation = patientOrientationBox.Text;
                        setup.ifBilateral = ifBilateralBox.Text;
                        setup.syringes1mL = Decimal.Parse(syringes1mLBox.Text);
                        setup.syringes3mL = Decimal.Parse(syringes3mLBox.Text);
                        setup.syringes5mL = Decimal.Parse(syringes5mLBox.Text);
                        setup.syringes10mL = Decimal.Parse(syringes10mLBox.Text);
                        setup.needleDrawingUp = Decimal.Parse(needleDrawingUpBox.Text);
                        setup.needle25g = Decimal.Parse(needle25gBox.Text);
                        setup.needle19g = Decimal.Parse(needle19gBox.Text);
                        setup.needle22g50mm = Decimal.Parse(needle22g50mmBox.Text);
                        setup.needle22g90mm = Decimal.Parse(needle22g90mmBox.Text);
                        setup.contrast = contrastBox.Text;
                        setup.lignocaine = Decimal.Parse(lignocaineBox.Text);
                        setup.bupivacaine = Decimal.Parse(bupivacaineBox.Text);
                        setup.steroidType = steroidTypeBox.Text;
                        setup.steroidAmount = Decimal.Parse(steroidAmountBox.Text);
                        setup.otherEquipment = otherEquipmentBox.Text;
                        setup.comments = commentsBox.Text;

                        setupContext.DoctorsProcedures.InsertOnSubmit(setup);
                
                        setupContext.SubmitChanges();
                        Form1.DoctorProceduresList.Clear();
                        Form1.GetDoctorsProcedures();

                        MessageBox.Show("Added", "Setup", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Please make sure all fields are filled out correctly...", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Please select a doctor and procedure...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


           
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DoctorProcedureClassDataContext setupContext = new DoctorProcedureClassDataContext();
           
                if (!String.IsNullOrEmpty(procedureBox.Text) &&
                    !String.IsNullOrEmpty(doctorBox.Text))
                {
                    var setup = (from docset in setupContext.DoctorsProcedures
                                     where docset.procedureName == procedureBox.Text &&
                                     docset.doctorName == doctorBox.Text
                                     select docset).First();
                    setupContext.DoctorsProcedures.DeleteOnSubmit(setup);

                    setupContext.SubmitChanges();
                    clearInfo();
                    Form1.DoctorProceduresList.Clear();
                    Form1.GetDoctorsProcedures();

                    MessageBox.Show("Entry Deleted", "Delete", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                else           
                {
                    MessageBox.Show("Please select a doctor and procedure...", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No Changes Made", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
