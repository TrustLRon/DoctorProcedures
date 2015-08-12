namespace DoctorProcedures
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doctorBox = new System.Windows.Forms.ListBox();
            this.procedureBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modalityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.glovesBox = new System.Windows.Forms.TextBox();
            this.syringes3mLBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientOrientationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ifBilateralBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.otherEquipmentBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.commentsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lignocaineBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bupivacaineBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.steroidTypeBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.initialsBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.modalityListBox = new System.Windows.Forms.ComboBox();
            this.syringes5mLBox = new System.Windows.Forms.TextBox();
            this.syringes10mLBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.needleDrawingUpBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.needle25gBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.needle22g50mmBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.needle22g90mmBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.needle19gBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contrastBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.syringes1mLBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDoctorProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loggedOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label28 = new System.Windows.Forms.Label();
            this.steroidAmountBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.doctorBox, 2);
            this.doctorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorBox.FormattingEnabled = true;
            this.doctorBox.ItemHeight = 20;
            this.doctorBox.Location = new System.Drawing.Point(12, 102);
            this.doctorBox.Name = "doctorBox";
            this.tableLayoutPanel1.SetRowSpan(this.doctorBox, 10);
            this.doctorBox.Size = new System.Drawing.Size(141, 392);
            this.doctorBox.Sorted = true;
            this.doctorBox.TabIndex = 3;
            this.doctorBox.SelectedIndexChanged += new System.EventHandler(this.doctorBox_SelectedIndexChanged);
            // 
            // procedureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.procedureBox, 2);
            this.procedureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procedureBox.FormattingEnabled = true;
            this.procedureBox.ItemHeight = 20;
            this.procedureBox.Location = new System.Drawing.Point(159, 102);
            this.procedureBox.Name = "procedureBox";
            this.tableLayoutPanel1.SetRowSpan(this.procedureBox, 10);
            this.procedureBox.Size = new System.Drawing.Size(182, 392);
            this.procedureBox.Sorted = true;
            this.procedureBox.TabIndex = 4;
            this.procedureBox.SelectedIndexChanged += new System.EventHandler(this.procedureBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modality:";
            // 
            // modalityBox
            // 
            this.modalityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modalityBox.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.modalityBox, 2);
            this.modalityBox.Location = new System.Drawing.Point(576, 70);
            this.modalityBox.Name = "modalityBox";
            this.modalityBox.ReadOnly = true;
            this.modalityBox.Size = new System.Drawing.Size(123, 26);
            this.modalityBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 568);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gloves:";
            // 
            // glovesBox
            // 
            this.glovesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.glovesBox.Enabled = false;
            this.glovesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glovesBox.Location = new System.Drawing.Point(95, 559);
            this.glovesBox.Name = "glovesBox";
            this.glovesBox.Size = new System.Drawing.Size(58, 38);
            this.glovesBox.TabIndex = 9;
            this.glovesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // syringes3mLBox
            // 
            this.syringes3mLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.syringes3mLBox.Location = new System.Drawing.Point(705, 230);
            this.syringes3mLBox.Name = "syringes3mLBox";
            this.syringes3mLBox.ReadOnly = true;
            this.syringes3mLBox.Size = new System.Drawing.Size(42, 26);
            this.syringes3mLBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Patient Orientation:";
            // 
            // patientOrientationBox
            // 
            this.patientOrientationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.patientOrientationBox, 6);
            this.patientOrientationBox.Location = new System.Drawing.Point(576, 102);
            this.patientOrientationBox.Name = "patientOrientationBox";
            this.patientOrientationBox.ReadOnly = true;
            this.patientOrientationBox.Size = new System.Drawing.Size(362, 26);
            this.patientOrientationBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "If Bilateral:";
            // 
            // ifBilateralBox
            // 
            this.ifBilateralBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.ifBilateralBox, 6);
            this.ifBilateralBox.Location = new System.Drawing.Point(576, 134);
            this.ifBilateralBox.Name = "ifBilateralBox";
            this.ifBilateralBox.ReadOnly = true;
            this.ifBilateralBox.Size = new System.Drawing.Size(362, 26);
            this.ifBilateralBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Other Equipment:";
            // 
            // otherEquipmentBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.otherEquipmentBox, 6);
            this.otherEquipmentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherEquipmentBox.Location = new System.Drawing.Point(576, 390);
            this.otherEquipmentBox.Multiline = true;
            this.otherEquipmentBox.Name = "otherEquipmentBox";
            this.otherEquipmentBox.ReadOnly = true;
            this.otherEquipmentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.otherEquipmentBox.Size = new System.Drawing.Size(362, 104);
            this.otherEquipmentBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 497);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Comments:";
            // 
            // commentsBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.commentsBox, 6);
            this.commentsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsBox.Location = new System.Drawing.Point(576, 500);
            this.commentsBox.Multiline = true;
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.commentsBox, 2);
            this.commentsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsBox.Size = new System.Drawing.Size(362, 102);
            this.commentsBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(755, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Lignocaine:";
            // 
            // lignocaineBox
            // 
            this.lignocaineBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lignocaineBox.Location = new System.Drawing.Point(848, 198);
            this.lignocaineBox.Name = "lignocaineBox";
            this.lignocaineBox.ReadOnly = true;
            this.lignocaineBox.Size = new System.Drawing.Size(42, 26);
            this.lignocaineBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(755, 227);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 32);
            this.label10.TabIndex = 24;
            this.label10.Text = "Bupivacaine:";
            // 
            // bupivacaineBox
            // 
            this.bupivacaineBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bupivacaineBox.Location = new System.Drawing.Point(848, 230);
            this.bupivacaineBox.Name = "bupivacaineBox";
            this.bupivacaineBox.ReadOnly = true;
            this.bupivacaineBox.Size = new System.Drawing.Size(42, 26);
            this.bupivacaineBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(777, 259);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "Steroid Type:";
            // 
            // steroidTypeBox
            // 
            this.steroidTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.steroidTypeBox, 2);
            this.steroidTypeBox.Location = new System.Drawing.Point(848, 262);
            this.steroidTypeBox.Name = "steroidTypeBox";
            this.steroidTypeBox.ReadOnly = true;
            this.steroidTypeBox.Size = new System.Drawing.Size(90, 26);
            this.steroidTypeBox.TabIndex = 25;
            // 
            // label13
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label13, 2);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 32);
            this.label13.TabIndex = 28;
            this.label13.Text = "Doctor";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label14, 2);
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(160, 67);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 32);
            this.label14.TabIndex = 29;
            this.label14.Text = "Procedure";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 514);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Initials:";
            // 
            // initialsBox
            // 
            this.initialsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.initialsBox.Enabled = false;
            this.initialsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialsBox.Location = new System.Drawing.Point(95, 505);
            this.initialsBox.Name = "initialsBox";
            this.initialsBox.Size = new System.Drawing.Size(58, 38);
            this.initialsBox.TabIndex = 31;
            this.initialsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 2);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(577, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 26);
            this.label12.TabIndex = 34;
            this.label12.Text = "Setup";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label16, 2);
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 32);
            this.label16.TabIndex = 37;
            this.label16.Text = "Modality Filter:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modalityListBox
            // 
            this.modalityListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modalityListBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modalityListBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.modalityListBox, 2);
            this.modalityListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalityListBox.FormattingEnabled = true;
            this.modalityListBox.Location = new System.Drawing.Point(159, 38);
            this.modalityListBox.Name = "modalityListBox";
            this.modalityListBox.Size = new System.Drawing.Size(182, 28);
            this.modalityListBox.TabIndex = 38;
            this.modalityListBox.SelectedIndexChanged += new System.EventHandler(this.modalityListBox_SelectedIndexChanged);
            // 
            // syringes5mLBox
            // 
            this.syringes5mLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.syringes5mLBox.Location = new System.Drawing.Point(705, 262);
            this.syringes5mLBox.Name = "syringes5mLBox";
            this.syringes5mLBox.ReadOnly = true;
            this.syringes5mLBox.Size = new System.Drawing.Size(42, 26);
            this.syringes5mLBox.TabIndex = 39;
            // 
            // syringes10mLBox
            // 
            this.syringes10mLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.syringes10mLBox.Location = new System.Drawing.Point(705, 294);
            this.syringes10mLBox.Name = "syringes10mLBox";
            this.syringes10mLBox.ReadOnly = true;
            this.syringes10mLBox.Size = new System.Drawing.Size(42, 26);
            this.syringes10mLBox.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(633, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 32);
            this.label17.TabIndex = 41;
            this.label17.Text = "3mL Syringe:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(633, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 32);
            this.label18.TabIndex = 42;
            this.label18.Text = "5mL Syringe:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(633, 291);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 32);
            this.label19.TabIndex = 43;
            this.label19.Text = "10mL Syringe:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(435, 195);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 32);
            this.label20.TabIndex = 44;
            this.label20.Text = "Drawing Up (Pink Blunt):";
            // 
            // needleDrawingUpBox
            // 
            this.needleDrawingUpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.needleDrawingUpBox.Location = new System.Drawing.Point(576, 198);
            this.needleDrawingUpBox.Name = "needleDrawingUpBox";
            this.needleDrawingUpBox.ReadOnly = true;
            this.needleDrawingUpBox.Size = new System.Drawing.Size(42, 26);
            this.needleDrawingUpBox.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(482, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 32);
            this.label21.TabIndex = 46;
            this.label21.Text = "25g 35mm (Orange):";
            // 
            // needle25gBox
            // 
            this.needle25gBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.needle25gBox.Location = new System.Drawing.Point(576, 230);
            this.needle25gBox.Name = "needle25gBox";
            this.needle25gBox.ReadOnly = true;
            this.needle25gBox.Size = new System.Drawing.Size(42, 26);
            this.needle25gBox.TabIndex = 47;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(434, 297);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 20);
            this.label22.TabIndex = 48;
            this.label22.Text = "22g 50mm (Grey):";
            // 
            // needle22g50mmBox
            // 
            this.needle22g50mmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.needle22g50mmBox.Location = new System.Drawing.Point(576, 294);
            this.needle22g50mmBox.Name = "needle22g50mmBox";
            this.needle22g50mmBox.ReadOnly = true;
            this.needle22g50mmBox.Size = new System.Drawing.Size(42, 26);
            this.needle22g50mmBox.TabIndex = 49;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(434, 323);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 32);
            this.label23.TabIndex = 50;
            this.label23.Text = "22g 90mm Spinal (Black):";
            // 
            // needle22g90mmBox
            // 
            this.needle22g90mmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.needle22g90mmBox.Location = new System.Drawing.Point(576, 326);
            this.needle22g90mmBox.Name = "needle22g90mmBox";
            this.needle22g90mmBox.ReadOnly = true;
            this.needle22g90mmBox.Size = new System.Drawing.Size(42, 26);
            this.needle22g90mmBox.TabIndex = 51;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(427, 265);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(143, 20);
            this.label24.TabIndex = 52;
            this.label24.Text = "19g 35mm (White):";
            // 
            // needle19gBox
            // 
            this.needle19gBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.needle19gBox.Location = new System.Drawing.Point(576, 262);
            this.needle19gBox.Name = "needle19gBox";
            this.needle19gBox.ReadOnly = true;
            this.needle19gBox.Size = new System.Drawing.Size(42, 26);
            this.needle19gBox.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Contrast:";
            // 
            // contrastBox
            // 
            this.contrastBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.contrastBox, 2);
            this.contrastBox.Location = new System.Drawing.Point(848, 326);
            this.contrastBox.Name = "contrastBox";
            this.contrastBox.ReadOnly = true;
            this.contrastBox.Size = new System.Drawing.Size(90, 26);
            this.contrastBox.TabIndex = 55;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label25, 2);
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(576, 163);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 32);
            this.label25.TabIndex = 56;
            this.label25.Text = "Equipment";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(633, 195);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 32);
            this.label26.TabIndex = 58;
            this.label26.Text = "1mL Syringe:";
            // 
            // syringes1mLBox
            // 
            this.syringes1mLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.syringes1mLBox.Location = new System.Drawing.Point(705, 198);
            this.syringes1mLBox.Name = "syringes1mLBox";
            this.syringes1mLBox.ReadOnly = true;
            this.syringes1mLBox.Size = new System.Drawing.Size(42, 26);
            this.syringes1mLBox.TabIndex = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.loggedOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripSeparator3,
            this.newDoctorToolStripMenuItem,
            this.newProcedureToolStripMenuItem,
            this.newDoctorProcedureToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // newDoctorToolStripMenuItem
            // 
            this.newDoctorToolStripMenuItem.Enabled = false;
            this.newDoctorToolStripMenuItem.Name = "newDoctorToolStripMenuItem";
            this.newDoctorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newDoctorToolStripMenuItem.Text = "Edit Doctors";
            this.newDoctorToolStripMenuItem.Click += new System.EventHandler(this.newDoctorToolStripMenuItem_Click);
            // 
            // newProcedureToolStripMenuItem
            // 
            this.newProcedureToolStripMenuItem.Enabled = false;
            this.newProcedureToolStripMenuItem.Name = "newProcedureToolStripMenuItem";
            this.newProcedureToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newProcedureToolStripMenuItem.Text = "Edit Procedures";
            this.newProcedureToolStripMenuItem.Click += new System.EventHandler(this.newProcedureToolStripMenuItem_Click);
            // 
            // newDoctorProcedureToolStripMenuItem
            // 
            this.newDoctorProcedureToolStripMenuItem.Enabled = false;
            this.newDoctorProcedureToolStripMenuItem.Name = "newDoctorProcedureToolStripMenuItem";
            this.newDoctorProcedureToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newDoctorProcedureToolStripMenuItem.Text = "Edit Setups";
            this.newDoctorProcedureToolStripMenuItem.Click += new System.EventHandler(this.newDoctorProcedureToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // loggedOutToolStripMenuItem
            // 
            this.loggedOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loggedOutToolStripMenuItem.Enabled = false;
            this.loggedOutToolStripMenuItem.Name = "loggedOutToolStripMenuItem";
            this.loggedOutToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loggedOutToolStripMenuItem.Text = "Logged Out";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label28, 3);
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(576, 355);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 32);
            this.label28.TabIndex = 61;
            this.label28.Text = "Other Information";
            // 
            // steroidAmountBox
            // 
            this.steroidAmountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.steroidAmountBox.Location = new System.Drawing.Point(848, 294);
            this.steroidAmountBox.Name = "steroidAmountBox";
            this.steroidAmountBox.ReadOnly = true;
            this.steroidAmountBox.Size = new System.Drawing.Size(42, 26);
            this.steroidAmountBox.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 32);
            this.label4.TabIndex = 64;
            this.label4.Text = "Steroid Amount:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 14;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9514492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.770596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.706926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.48755F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.264711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.296546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.05599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.549488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.05599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.949835F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.05599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.05599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.068474F));
            this.tableLayoutPanel1.Controls.Add(this.contrastBox, 11, 10);
            this.tableLayoutPanel1.Controls.Add(this.steroidAmountBox, 11, 9);
            this.tableLayoutPanel1.Controls.Add(this.label4, 10, 9);
            this.tableLayoutPanel1.Controls.Add(this.syringes1mLBox, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.steroidTypeBox, 11, 8);
            this.tableLayoutPanel1.Controls.Add(this.syringes10mLBox, 9, 9);
            this.tableLayoutPanel1.Controls.Add(this.bupivacaineBox, 11, 7);
            this.tableLayoutPanel1.Controls.Add(this.lignocaineBox, 11, 6);
            this.tableLayoutPanel1.Controls.Add(this.syringes5mLBox, 9, 8);
            this.tableLayoutPanel1.Controls.Add(this.label26, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.needle22g90mmBox, 7, 10);
            this.tableLayoutPanel1.Controls.Add(this.needle19gBox, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.needle22g50mmBox, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.syringes3mLBox, 9, 7);
            this.tableLayoutPanel1.Controls.Add(this.label28, 7, 11);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label25, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.needle25gBox, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.initialsBox, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.needleDrawingUpBox, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.label24, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.label23, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.label19, 8, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 10, 8);
            this.tableLayoutPanel1.Controls.Add(this.label18, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 10, 7);
            this.tableLayoutPanel1.Controls.Add(this.label17, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.label22, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.doctorBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.procedureBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 13);
            this.tableLayoutPanel1.Controls.Add(this.label21, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.ifBilateralBox, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.commentsBox, 7, 13);
            this.tableLayoutPanel1.Controls.Add(this.patientOrientationBox, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.otherEquipmentBox, 7, 12);
            this.tableLayoutPanel1.Controls.Add(this.modalityBox, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 10, 10);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.glovesBox, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.modalityListBox, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.674792F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.257696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.71059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831955F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831955F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.116043F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 622);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 622);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors Procedure Preferences 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modalityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox glovesBox;
        private System.Windows.Forms.TextBox syringes3mLBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientOrientationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ifBilateralBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox otherEquipmentBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox commentsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lignocaineBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bupivacaineBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox steroidTypeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox initialsBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox modalityListBox;
        private System.Windows.Forms.TextBox syringes5mLBox;
        private System.Windows.Forms.TextBox syringes10mLBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox needleDrawingUpBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox needle25gBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox needle22g50mmBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox needle22g90mmBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox needle19gBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contrastBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox syringes1mLBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox steroidAmountBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDoctorProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ListBox doctorBox;
        public System.Windows.Forms.ListBox procedureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem loggedOutToolStripMenuItem;
    }
}

