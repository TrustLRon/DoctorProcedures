using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoctorProcedures
{
    public partial class Form1 : Form
    {

        public static string connectionString = Properties.Settings.Default.LocalDoctorsAndProceduresDBConnectionString;
        
        public static List<DoctorsProcedure> DoctorProceduresList = new List<DoctorsProcedure>();
        public static List<String> ModalitiesList = new List<string> { };
        public static List<Procedure> ProceduresList = new List<Procedure> { };
        public static List<Doctor> DoctorsList = new List<Doctor> { };

        public Form1()
        {
            InitializeComponent();
            GetDoctorsProcedures();
            GetProcedures();
            GetDoctors();
            loadDoctors();
            loadProcedures();
            loadModalities();
        }

        public static void GetDoctorsProcedures()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT * FROM DoctorsProcedures";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            DoctorsProcedure doctorProcedure = new DoctorsProcedure();
                            
                            doctorProcedure.doctorName = (!reader.IsDBNull(reader.GetOrdinal("doctorName"))) ? reader.GetString(0) : "null";
                            doctorProcedure.doctorID = (!reader.IsDBNull(reader.GetOrdinal("doctorID"))) ? reader.GetString(1) : "null";
                            doctorProcedure.gloveSize = reader.GetDecimal(2);

                            doctorProcedure.procedureName = (!reader.IsDBNull(reader.GetOrdinal("procedureName"))) ? reader.GetString(3) : "null";
                            doctorProcedure.modality = (!reader.IsDBNull(reader.GetOrdinal("modality"))) ? reader.GetString(4) : "null";
                            doctorProcedure.patientOrientation = (!reader.IsDBNull(reader.GetOrdinal("patientOrientation"))) ? reader.GetString(5) : "null";
                            doctorProcedure.ifBilateral = (!reader.IsDBNull(reader.GetOrdinal("ifBilateral"))) ? reader.GetString(6) : "null";

                            doctorProcedure.syringes1mL = (!reader.IsDBNull(reader.GetOrdinal("syringes1mL"))) ? reader.GetDecimal(7) : 0;
                            doctorProcedure.syringes3mL = (!reader.IsDBNull(reader.GetOrdinal("syringes3mL"))) ? reader.GetDecimal(8) : 0;
                            doctorProcedure.syringes5mL = (!reader.IsDBNull(reader.GetOrdinal("syringes5mL"))) ? reader.GetDecimal(9) : 0;
                            doctorProcedure.syringes10mL = (!reader.IsDBNull(reader.GetOrdinal("syringes10mL"))) ? reader.GetDecimal(10) : 0;
                            doctorProcedure.needleDrawingUp = (!reader.IsDBNull(reader.GetOrdinal("needleDrawingUp"))) ? reader.GetDecimal(11) : 0;
                            doctorProcedure.needle25g = (!reader.IsDBNull(reader.GetOrdinal("needle25g"))) ? reader.GetDecimal(12) : 0;
                            doctorProcedure.needle19g = (!reader.IsDBNull(reader.GetOrdinal("needle19g"))) ? reader.GetDecimal(13) : 0;
                            doctorProcedure.needle22g50mm = (!reader.IsDBNull(reader.GetOrdinal("needle22g50mm"))) ? reader.GetDecimal(14) : 0;
                            doctorProcedure.needle22g90mm = (!reader.IsDBNull(reader.GetOrdinal("needle22g90mm"))) ? reader.GetDecimal(15) : 0;
                            doctorProcedure.contrast = (!reader.IsDBNull(reader.GetOrdinal("contrast"))) ? reader.GetString(16) : "null";

                            doctorProcedure.lignocaine = (!reader.IsDBNull(reader.GetOrdinal("lignocaine"))) ? reader.GetDecimal(17) : 0;
                            doctorProcedure.bupivacaine = (!reader.IsDBNull(reader.GetOrdinal("bupivacaine"))) ? reader.GetDecimal(18) : 0;
                            doctorProcedure.steroidType = (!reader.IsDBNull(reader.GetOrdinal("steroidType"))) ? reader.GetString(19) : "null";
                            doctorProcedure.steroidAmount = (!reader.IsDBNull(reader.GetOrdinal("steroidAmount"))) ? reader.GetDecimal(20) : 0;

                            doctorProcedure.otherEquipment = (!reader.IsDBNull(reader.GetOrdinal("otherEquipment"))) ? reader.GetString(21) : "null";
                            doctorProcedure.comments = (!reader.IsDBNull(reader.GetOrdinal("comments"))) ? reader.GetString(22) : "null";
                            
                            DoctorProceduresList.Add(doctorProcedure);                                  
                     
                        }
                    }
                }
            }
        }

        public static void GetProcedures()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT * FROM Procedures";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Procedure procedure = new Procedure();
                            procedure.procedure = (!reader.IsDBNull(reader.GetOrdinal("procedure"))) ? reader.GetString(0) : "null";
                            ProceduresList.Add(procedure);
                        }
                    }
                }
            }
        }

        public static void GetDoctors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT * FROM Doctors";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor();
                            doctor.doctorID = (!reader.IsDBNull(reader.GetOrdinal("doctorID"))) ? reader.GetString(0) : "null";
                            doctor.doctorName = (!reader.IsDBNull(reader.GetOrdinal("doctorName"))) ? reader.GetString(1) : "null";
                            doctor.gloveSize = (!reader.IsDBNull(reader.GetOrdinal("gloveSize"))) ? reader.GetDecimal(2) : 0;
                            DoctorsList.Add(doctor);
                        }
                    }
                }
            }
        }

        public void loadDoctors()
        {
            doctorBox.Items.Clear();
            foreach (Doctor doctor in DoctorsList)
            {
                if (!doctorBox.Items.Contains(doctor.doctorName))
                {
                    doctorBox.Items.Add(doctor.doctorName);
                }                
            }   
        }

        public void loadProcedures()
        {
            foreach (Procedure procedure in ProceduresList)
            {
                //Search.procedureListBox.Items.Add(procedure.procedure);
            }
        }

        public void loadModalities()
        {
            ModalitiesList.Add("All");
            ModalitiesList.Add("CT");
            ModalitiesList.Add("Ultrasound");
            ModalitiesList.Add("Screening");
            ModalitiesList.Add("Mammography");
            ModalitiesList.Add("Xray");

            foreach (String modality in ModalitiesList)
            {
                modalityListBox.Items.Add(modality);
            }
        }
        
        public void updateDoctor() 
        {
            IEnumerable<Doctor> allDoctors =
                from doctor in DoctorsList
                where doctor.doctorName == doctorBox.Text
                select doctor;

            foreach (Doctor doctor in allDoctors)
            {
                if (doctorBox.Text == doctor.doctorName)
                {
                    initialsBox.Text = doctor.doctorID;
                    glovesBox.Text = doctor.gloveSize.ToString();
                }
            }

            if (modalityListBox.Text == "CT" || 
                modalityListBox.Text == "Ultrasound" ||
                modalityListBox.Text == "Screening" ||
                modalityListBox.Text == "Mammography" ||
                modalityListBox.Text == "Xray")
            {
                IEnumerable<DoctorsProcedure> doctorQuery = 
                    from doctor in DoctorProceduresList
                    where doctor.doctorName == doctorBox.Text && 
                            doctor.modality == modalityListBox.Text
                    select doctor;
                
                if (doctorQuery.Any() == true)
                {
                    foreach (DoctorsProcedure doctor in doctorQuery)
                    {
                        if (doctorBox.Text == doctor.doctorName && doctor.procedureName != null)
                        {
                            procedureBox.Items.Add(doctor.procedureName);
                        }
                    }
                }
            }
            else
            {
                IEnumerable<DoctorsProcedure> doctorQuery =
                    from doctor in DoctorProceduresList
                    where doctor.doctorName == doctorBox.Text
                    select doctor;

                if (doctorQuery.Any() == true)
                {
                    foreach (DoctorsProcedure doctor in doctorQuery)
                    {
                        if (doctorBox.Text == doctor.doctorName && doctor.procedureName != null)
                        {
                            procedureBox.Items.Add(doctor.procedureName);
                        }
                    }
                }   
            } 
        }

        public void updateProcedure()
        {
            IEnumerable<DoctorsProcedure> procedureQuery =
                from procedure in DoctorProceduresList
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

                }
            }
        }

        private void doctorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            procedureBox.Text = "";
            procedureBox.Items.Clear();
            initialsBox.Text = "";
            clearInfo();
            updateDoctor();
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
        }

        private void modalityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            procedureBox.Text = "";
            procedureBox.Items.Clear();
            initialsBox.Text = "";
            clearInfo();
            updateDoctor();
        }

        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoctor newDoctor = new NewDoctor();
            newDoctor.ShowDialog();

            if (newDoctor.DialogResult == DialogResult.OK)
            {
                procedureBox.Items.Clear();
                DoctorProceduresList.Clear();
                ProceduresList.Clear();
                clearInfo();
                GetDoctors();
                loadDoctors();
                GetProcedures();
                loadProcedures();
                GetDoctorsProcedures();
                updateProcedure();
            }
        }

        private void newProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProcedure newProcedure = new NewProcedure();
            newProcedure.ShowDialog();

            if (newProcedure.DialogResult == DialogResult.OK)
            {
                ProceduresList.Clear();
                GetProcedures();
                loadProcedures();
            }
        }

        private void newDoctorProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoctorProcedure newDoctorProcedure = new NewDoctorProcedure();
            newDoctorProcedure.doctorBox.Text = doctorBox.Text;
            newDoctorProcedure.procedureBox.Text = procedureBox.Text;
            newDoctorProcedure.ShowDialog(this);
            
            if (newDoctorProcedure.DialogResult == DialogResult.OK)
            {
                procedureBox.Items.Clear();
                DoctorProceduresList.Clear();
                ProceduresList.Clear();
                clearInfo();
                GetDoctors();
                loadDoctors();
                GetProcedures();
                loadProcedures();
                GetDoctorsProcedures();
                updateProcedure();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Login")
            {
                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                {
                    loginToolStripMenuItem.Text = "Logout";
                    loggedOutToolStripMenuItem.Text = "Logged in as Admin";

                    newDoctorToolStripMenuItem.Enabled = true;
                    newProcedureToolStripMenuItem.Enabled = true;
                    newDoctorProcedureToolStripMenuItem.Enabled = true;
                }
                else
                {
                    loggedOutToolStripMenuItem.Text = "Logged Out";

                    newDoctorToolStripMenuItem.Enabled = false;
                    newProcedureToolStripMenuItem.Enabled = false;
                    newDoctorProcedureToolStripMenuItem.Enabled = false;
                }
            }
            else if (loginToolStripMenuItem.Text == "Logout")
            {
                loginToolStripMenuItem.Text = "Login";
                loggedOutToolStripMenuItem.Text = "Logged Out";

                newDoctorToolStripMenuItem.Enabled = false;
                newProcedureToolStripMenuItem.Enabled = false;
                newDoctorProcedureToolStripMenuItem.Enabled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage about = new AboutPage();
            about.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
