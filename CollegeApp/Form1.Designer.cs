namespace CollegeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Schedule = new TabPage();
            Students = new TabPage();
            panel1 = new Panel();
            dataGridStudentClass = new DataGridView();
            dataGridStudent = new DataGridView();
            pStudentBottomManagement = new Panel();
            bAddStudent = new Button();
            bDeleteStudent = new Button();
            panel2 = new Panel();
            pStudentEditClasses = new Panel();
            listStudentClasses = new ListBox();
            pStudentClassesBar = new Panel();
            bStudentClassAdd = new Button();
            bStudentClassDelete = new Button();
            lStudentClasses = new Label();
            pStudentClassButtons = new Panel();
            bStudentEditSave = new Button();
            pStudentEditTop = new Panel();
            pStudentEditName = new Panel();
            textStudentName = new TextBox();
            lStudentName = new Label();
            pStudentEditCredits = new Panel();
            maskedTextBox2 = new MaskedTextBox();
            lStudentCredits = new Label();
            Classes = new TabPage();
            pClassBottom = new Panel();
            pClassManagement = new Panel();
            bAdd = new Button();
            bDeleteClass = new Button();
            dataGridClass = new DataGridView();
            pClassEdit = new Panel();
            pClassEditTop = new Panel();
            pClassDescription = new Panel();
            textClassDescription = new TextBox();
            lClassDescription = new Label();
            pClassEditTopTop = new Panel();
            pClassEditTopName = new Panel();
            textClassName = new TextBox();
            lClassName = new Label();
            pClassEditCredits = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            lClassCredits = new Label();
            pClassEditBottom = new Panel();
            pClassEditSave = new Panel();
            bClassSaveEdit = new Button();
            tabControl1 = new TabControl();
            Students.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudentClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            pStudentBottomManagement.SuspendLayout();
            panel2.SuspendLayout();
            pStudentEditClasses.SuspendLayout();
            pStudentClassesBar.SuspendLayout();
            pStudentClassButtons.SuspendLayout();
            pStudentEditTop.SuspendLayout();
            pStudentEditName.SuspendLayout();
            pStudentEditCredits.SuspendLayout();
            Classes.SuspendLayout();
            pClassBottom.SuspendLayout();
            pClassManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClass).BeginInit();
            pClassEdit.SuspendLayout();
            pClassEditTop.SuspendLayout();
            pClassDescription.SuspendLayout();
            pClassEditTopTop.SuspendLayout();
            pClassEditTopName.SuspendLayout();
            pClassEditCredits.SuspendLayout();
            pClassEditBottom.SuspendLayout();
            pClassEditSave.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Schedule
            // 
            Schedule.Location = new Point(8, 68);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(694, 697);
            Schedule.TabIndex = 2;
            Schedule.Text = "Schedule";
            Schedule.UseVisualStyleBackColor = true;
            // 
            // Students
            // 
            Students.Controls.Add(panel1);
            Students.Controls.Add(pStudentBottomManagement);
            Students.Controls.Add(panel2);
            Students.ForeColor = SystemColors.ControlText;
            Students.Location = new Point(8, 68);
            Students.Name = "Students";
            Students.Padding = new Padding(3);
            Students.Size = new Size(694, 697);
            Students.TabIndex = 1;
            Students.Text = "Students";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridStudentClass);
            panel1.Controls.Add(dataGridStudent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 378);
            panel1.TabIndex = 8;
            // 
            // dataGridStudentClass
            // 
            dataGridStudentClass.AllowUserToAddRows = false;
            dataGridStudentClass.AllowUserToDeleteRows = false;
            dataGridStudentClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudentClass.Dock = DockStyle.Right;
            dataGridStudentClass.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridStudentClass.Location = new Point(471, 0);
            dataGridStudentClass.MultiSelect = false;
            dataGridStudentClass.Name = "dataGridStudentClass";
            dataGridStudentClass.RowHeadersWidth = 82;
            dataGridStudentClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudentClass.Size = new Size(217, 378);
            dataGridStudentClass.TabIndex = 8;
            // 
            // dataGridStudent
            // 
            dataGridStudent.AllowUserToAddRows = false;
            dataGridStudent.AllowUserToDeleteRows = false;
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Dock = DockStyle.Fill;
            dataGridStudent.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridStudent.Location = new Point(0, 0);
            dataGridStudent.MultiSelect = false;
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.RowHeadersWidth = 82;
            dataGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudent.Size = new Size(688, 378);
            dataGridStudent.TabIndex = 7;
            // 
            // pStudentBottomManagement
            // 
            pStudentBottomManagement.Controls.Add(bAddStudent);
            pStudentBottomManagement.Controls.Add(bDeleteStudent);
            pStudentBottomManagement.Dock = DockStyle.Bottom;
            pStudentBottomManagement.Location = new Point(3, 636);
            pStudentBottomManagement.Name = "pStudentBottomManagement";
            pStudentBottomManagement.Size = new Size(688, 58);
            pStudentBottomManagement.TabIndex = 7;
            // 
            // bAddStudent
            // 
            bAddStudent.Dock = DockStyle.Right;
            bAddStudent.Location = new Point(338, 0);
            bAddStudent.Margin = new Padding(3, 3, 10, 3);
            bAddStudent.Name = "bAddStudent";
            bAddStudent.Size = new Size(160, 58);
            bAddStudent.TabIndex = 5;
            bAddStudent.Text = "Add Student";
            bAddStudent.UseVisualStyleBackColor = true;
            bAddStudent.Click += bAddStudent_Click;
            // 
            // bDeleteStudent
            // 
            bDeleteStudent.Dock = DockStyle.Right;
            bDeleteStudent.Location = new Point(498, 0);
            bDeleteStudent.Name = "bDeleteStudent";
            bDeleteStudent.Size = new Size(190, 58);
            bDeleteStudent.TabIndex = 4;
            bDeleteStudent.Text = "Delete Student";
            bDeleteStudent.UseVisualStyleBackColor = true;
            bDeleteStudent.Click += bDeleteStudent_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.CausesValidation = false;
            panel2.Controls.Add(pStudentEditClasses);
            panel2.Controls.Add(pStudentEditTop);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(3, 3);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(688, 255);
            panel2.TabIndex = 5;
            // 
            // pStudentEditClasses
            // 
            pStudentEditClasses.AutoSize = true;
            pStudentEditClasses.Controls.Add(listStudentClasses);
            pStudentEditClasses.Controls.Add(pStudentClassesBar);
            pStudentEditClasses.Controls.Add(pStudentClassButtons);
            pStudentEditClasses.Dock = DockStyle.Fill;
            pStudentEditClasses.Location = new Point(10, 70);
            pStudentEditClasses.Name = "pStudentEditClasses";
            pStudentEditClasses.Size = new Size(668, 175);
            pStudentEditClasses.TabIndex = 11;
            // 
            // listStudentClasses
            // 
            listStudentClasses.Dock = DockStyle.Fill;
            listStudentClasses.Enabled = false;
            listStudentClasses.FormattingEnabled = true;
            listStudentClasses.Location = new Point(0, 51);
            listStudentClasses.Name = "listStudentClasses";
            listStudentClasses.Size = new Size(571, 124);
            listStudentClasses.TabIndex = 12;
            // 
            // pStudentClassesBar
            // 
            pStudentClassesBar.BackColor = SystemColors.ControlDark;
            pStudentClassesBar.Controls.Add(bStudentClassAdd);
            pStudentClassesBar.Controls.Add(bStudentClassDelete);
            pStudentClassesBar.Controls.Add(lStudentClasses);
            pStudentClassesBar.Dock = DockStyle.Top;
            pStudentClassesBar.Location = new Point(0, 0);
            pStudentClassesBar.Name = "pStudentClassesBar";
            pStudentClassesBar.Padding = new Padding(10, 0, 0, 0);
            pStudentClassesBar.Size = new Size(571, 51);
            pStudentClassesBar.TabIndex = 11;
            // 
            // bStudentClassAdd
            // 
            bStudentClassAdd.Dock = DockStyle.Right;
            bStudentClassAdd.Enabled = false;
            bStudentClassAdd.Location = new Point(417, 0);
            bStudentClassAdd.Name = "bStudentClassAdd";
            bStudentClassAdd.Size = new Size(77, 51);
            bStudentClassAdd.TabIndex = 12;
            bStudentClassAdd.Text = "Add";
            bStudentClassAdd.UseVisualStyleBackColor = true;
            // 
            // bStudentClassDelete
            // 
            bStudentClassDelete.Dock = DockStyle.Right;
            bStudentClassDelete.Enabled = false;
            bStudentClassDelete.Location = new Point(494, 0);
            bStudentClassDelete.Name = "bStudentClassDelete";
            bStudentClassDelete.Size = new Size(77, 51);
            bStudentClassDelete.TabIndex = 10;
            bStudentClassDelete.Text = "Del";
            bStudentClassDelete.UseVisualStyleBackColor = true;
            // 
            // lStudentClasses
            // 
            lStudentClasses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lStudentClasses.AutoSize = true;
            lStudentClasses.Location = new Point(248, -92);
            lStudentClasses.Margin = new Padding(3);
            lStudentClasses.Name = "lStudentClasses";
            lStudentClasses.Size = new Size(95, 32);
            lStudentClasses.TabIndex = 9;
            lStudentClasses.Text = "Classes";
            // 
            // pStudentClassButtons
            // 
            pStudentClassButtons.Controls.Add(bStudentEditSave);
            pStudentClassButtons.Dock = DockStyle.Right;
            pStudentClassButtons.Location = new Point(571, 0);
            pStudentClassButtons.Name = "pStudentClassButtons";
            pStudentClassButtons.Padding = new Padding(10);
            pStudentClassButtons.Size = new Size(97, 175);
            pStudentClassButtons.TabIndex = 8;
            // 
            // bStudentEditSave
            // 
            bStudentEditSave.Dock = DockStyle.Bottom;
            bStudentEditSave.Location = new Point(10, 115);
            bStudentEditSave.Name = "bStudentEditSave";
            bStudentEditSave.Size = new Size(77, 50);
            bStudentEditSave.TabIndex = 5;
            bStudentEditSave.Text = "Edit";
            bStudentEditSave.UseVisualStyleBackColor = true;
            bStudentEditSave.Click += bStudentEditSave_Click;
            // 
            // pStudentEditTop
            // 
            pStudentEditTop.Controls.Add(pStudentEditName);
            pStudentEditTop.Controls.Add(pStudentEditCredits);
            pStudentEditTop.Dock = DockStyle.Top;
            pStudentEditTop.Location = new Point(10, 10);
            pStudentEditTop.Name = "pStudentEditTop";
            pStudentEditTop.Size = new Size(668, 60);
            pStudentEditTop.TabIndex = 7;
            // 
            // pStudentEditName
            // 
            pStudentEditName.Controls.Add(textStudentName);
            pStudentEditName.Controls.Add(lStudentName);
            pStudentEditName.Dock = DockStyle.Fill;
            pStudentEditName.Location = new Point(0, 0);
            pStudentEditName.Name = "pStudentEditName";
            pStudentEditName.Padding = new Padding(10);
            pStudentEditName.Size = new Size(437, 60);
            pStudentEditName.TabIndex = 5;
            // 
            // textStudentName
            // 
            textStudentName.Dock = DockStyle.Fill;
            textStudentName.Enabled = false;
            textStudentName.Location = new Point(180, 10);
            textStudentName.Margin = new Padding(3, 3, 3, 10);
            textStudentName.MaxLength = 100;
            textStudentName.Name = "textStudentName";
            textStudentName.Size = new Size(247, 39);
            textStudentName.TabIndex = 5;
            // 
            // lStudentName
            // 
            lStudentName.AutoSize = true;
            lStudentName.Dock = DockStyle.Left;
            lStudentName.Location = new Point(10, 10);
            lStudentName.Margin = new Padding(3);
            lStudentName.Name = "lStudentName";
            lStudentName.Size = new Size(170, 32);
            lStudentName.TabIndex = 4;
            lStudentName.Text = "Student Name";
            // 
            // pStudentEditCredits
            // 
            pStudentEditCredits.Controls.Add(maskedTextBox2);
            pStudentEditCredits.Controls.Add(lStudentCredits);
            pStudentEditCredits.Dock = DockStyle.Right;
            pStudentEditCredits.Location = new Point(437, 0);
            pStudentEditCredits.Name = "pStudentEditCredits";
            pStudentEditCredits.Padding = new Padding(10);
            pStudentEditCredits.Size = new Size(231, 60);
            pStudentEditCredits.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Culture = new System.Globalization.CultureInfo("en-US");
            maskedTextBox2.Dock = DockStyle.Right;
            maskedTextBox2.Enabled = false;
            maskedTextBox2.Location = new Point(181, 10);
            maskedTextBox2.Mask = "0";
            maskedTextBox2.MaximumSize = new Size(40, 0);
            maskedTextBox2.MinimumSize = new Size(40, 0);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(40, 39);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.TextAlign = HorizontalAlignment.Center;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // lStudentCredits
            // 
            lStudentCredits.AutoSize = true;
            lStudentCredits.Dock = DockStyle.Left;
            lStudentCredits.Location = new Point(10, 10);
            lStudentCredits.Margin = new Padding(3);
            lStudentCredits.Name = "lStudentCredits";
            lStudentCredits.Size = new Size(153, 32);
            lStudentCredits.TabIndex = 8;
            lStudentCredits.Text = "Credit Hours";
            // 
            // Classes
            // 
            Classes.Controls.Add(pClassBottom);
            Classes.Controls.Add(pClassEdit);
            Classes.Location = new Point(8, 68);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(15);
            Classes.Size = new Size(694, 697);
            Classes.TabIndex = 0;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // pClassBottom
            // 
            pClassBottom.BackgroundImageLayout = ImageLayout.None;
            pClassBottom.CausesValidation = false;
            pClassBottom.Controls.Add(pClassManagement);
            pClassBottom.Controls.Add(dataGridClass);
            pClassBottom.Dock = DockStyle.Fill;
            pClassBottom.ForeColor = SystemColors.ControlText;
            pClassBottom.Location = new Point(15, 347);
            pClassBottom.Margin = new Padding(0);
            pClassBottom.Name = "pClassBottom";
            pClassBottom.Size = new Size(664, 335);
            pClassBottom.TabIndex = 3;
            // 
            // pClassManagement
            // 
            pClassManagement.Controls.Add(bAdd);
            pClassManagement.Controls.Add(bDeleteClass);
            pClassManagement.Dock = DockStyle.Bottom;
            pClassManagement.Location = new Point(0, 277);
            pClassManagement.Name = "pClassManagement";
            pClassManagement.Size = new Size(664, 58);
            pClassManagement.TabIndex = 3;
            // 
            // bAdd
            // 
            bAdd.Dock = DockStyle.Right;
            bAdd.Location = new Point(344, 0);
            bAdd.Margin = new Padding(3, 3, 10, 3);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(160, 58);
            bAdd.TabIndex = 5;
            bAdd.Text = "Add Class";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bDeleteClass
            // 
            bDeleteClass.Dock = DockStyle.Right;
            bDeleteClass.Location = new Point(504, 0);
            bDeleteClass.Name = "bDeleteClass";
            bDeleteClass.Size = new Size(160, 58);
            bDeleteClass.TabIndex = 4;
            bDeleteClass.Text = "Delete Class";
            bDeleteClass.UseVisualStyleBackColor = true;
            bDeleteClass.Click += bDeleteClass_Click;
            // 
            // dataGridClass
            // 
            dataGridClass.AllowUserToAddRows = false;
            dataGridClass.AllowUserToDeleteRows = false;
            dataGridClass.AllowUserToOrderColumns = true;
            dataGridClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClass.Dock = DockStyle.Fill;
            dataGridClass.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridClass.Location = new Point(0, 0);
            dataGridClass.MultiSelect = false;
            dataGridClass.Name = "dataGridClass";
            dataGridClass.RowHeadersWidth = 82;
            dataGridClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClass.Size = new Size(664, 335);
            dataGridClass.TabIndex = 2;
            dataGridClass.CellClick += dataGridClass_CellClick;
            // 
            // pClassEdit
            // 
            pClassEdit.BackgroundImageLayout = ImageLayout.None;
            pClassEdit.CausesValidation = false;
            pClassEdit.Controls.Add(pClassEditTop);
            pClassEdit.Controls.Add(pClassEditBottom);
            pClassEdit.Dock = DockStyle.Top;
            pClassEdit.ForeColor = SystemColors.ControlText;
            pClassEdit.Location = new Point(15, 15);
            pClassEdit.Margin = new Padding(0);
            pClassEdit.Name = "pClassEdit";
            pClassEdit.Size = new Size(664, 332);
            pClassEdit.TabIndex = 0;
            // 
            // pClassEditTop
            // 
            pClassEditTop.BackgroundImageLayout = ImageLayout.None;
            pClassEditTop.CausesValidation = false;
            pClassEditTop.Controls.Add(pClassDescription);
            pClassEditTop.Controls.Add(pClassEditTopTop);
            pClassEditTop.Dock = DockStyle.Fill;
            pClassEditTop.ForeColor = SystemColors.ControlText;
            pClassEditTop.Location = new Point(0, 0);
            pClassEditTop.Margin = new Padding(0);
            pClassEditTop.Name = "pClassEditTop";
            pClassEditTop.Padding = new Padding(10);
            pClassEditTop.Size = new Size(664, 267);
            pClassEditTop.TabIndex = 2;
            // 
            // pClassDescription
            // 
            pClassDescription.AutoSize = true;
            pClassDescription.Controls.Add(textClassDescription);
            pClassDescription.Controls.Add(lClassDescription);
            pClassDescription.Dock = DockStyle.Fill;
            pClassDescription.Location = new Point(10, 70);
            pClassDescription.Name = "pClassDescription";
            pClassDescription.Padding = new Padding(10);
            pClassDescription.Size = new Size(644, 187);
            pClassDescription.TabIndex = 11;
            // 
            // textClassDescription
            // 
            textClassDescription.Dock = DockStyle.Fill;
            textClassDescription.Enabled = false;
            textClassDescription.Location = new Point(10, 42);
            textClassDescription.Margin = new Padding(3, 3, 3, 10);
            textClassDescription.Multiline = true;
            textClassDescription.Name = "textClassDescription";
            textClassDescription.ScrollBars = ScrollBars.Vertical;
            textClassDescription.Size = new Size(624, 135);
            textClassDescription.TabIndex = 7;
            // 
            // lClassDescription
            // 
            lClassDescription.AutoSize = true;
            lClassDescription.Dock = DockStyle.Top;
            lClassDescription.Location = new Point(10, 10);
            lClassDescription.Margin = new Padding(3);
            lClassDescription.Name = "lClassDescription";
            lClassDescription.Size = new Size(203, 32);
            lClassDescription.TabIndex = 6;
            lClassDescription.Text = "Class Description";
            // 
            // pClassEditTopTop
            // 
            pClassEditTopTop.Controls.Add(pClassEditTopName);
            pClassEditTopTop.Controls.Add(pClassEditCredits);
            pClassEditTopTop.Dock = DockStyle.Top;
            pClassEditTopTop.Location = new Point(10, 10);
            pClassEditTopTop.Name = "pClassEditTopTop";
            pClassEditTopTop.Size = new Size(644, 60);
            pClassEditTopTop.TabIndex = 7;
            // 
            // pClassEditTopName
            // 
            pClassEditTopName.Controls.Add(textClassName);
            pClassEditTopName.Controls.Add(lClassName);
            pClassEditTopName.Dock = DockStyle.Fill;
            pClassEditTopName.Location = new Point(0, 0);
            pClassEditTopName.Name = "pClassEditTopName";
            pClassEditTopName.Padding = new Padding(10);
            pClassEditTopName.Size = new Size(413, 60);
            pClassEditTopName.TabIndex = 5;
            // 
            // textClassName
            // 
            textClassName.Dock = DockStyle.Fill;
            textClassName.Enabled = false;
            textClassName.Location = new Point(151, 10);
            textClassName.Margin = new Padding(3, 3, 3, 10);
            textClassName.MaxLength = 100;
            textClassName.Name = "textClassName";
            textClassName.Size = new Size(252, 39);
            textClassName.TabIndex = 5;
            // 
            // lClassName
            // 
            lClassName.AutoSize = true;
            lClassName.Dock = DockStyle.Left;
            lClassName.Location = new Point(10, 10);
            lClassName.Margin = new Padding(3);
            lClassName.Name = "lClassName";
            lClassName.Size = new Size(141, 32);
            lClassName.TabIndex = 4;
            lClassName.Text = "Class Name";
            // 
            // pClassEditCredits
            // 
            pClassEditCredits.Controls.Add(maskedTextBox1);
            pClassEditCredits.Controls.Add(lClassCredits);
            pClassEditCredits.Dock = DockStyle.Right;
            pClassEditCredits.Location = new Point(413, 0);
            pClassEditCredits.Name = "pClassEditCredits";
            pClassEditCredits.Padding = new Padding(10);
            pClassEditCredits.Size = new Size(231, 60);
            pClassEditCredits.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Culture = new System.Globalization.CultureInfo("en-US");
            maskedTextBox1.Dock = DockStyle.Right;
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Location = new Point(181, 10);
            maskedTextBox1.Mask = "0";
            maskedTextBox1.MaximumSize = new Size(40, 0);
            maskedTextBox1.MinimumSize = new Size(40, 0);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(40, 39);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // lClassCredits
            // 
            lClassCredits.AutoSize = true;
            lClassCredits.Dock = DockStyle.Left;
            lClassCredits.Location = new Point(10, 10);
            lClassCredits.Margin = new Padding(3);
            lClassCredits.Name = "lClassCredits";
            lClassCredits.Size = new Size(153, 32);
            lClassCredits.TabIndex = 8;
            lClassCredits.Text = "Credit Hours";
            // 
            // pClassEditBottom
            // 
            pClassEditBottom.CausesValidation = false;
            pClassEditBottom.Controls.Add(pClassEditSave);
            pClassEditBottom.Dock = DockStyle.Bottom;
            pClassEditBottom.ForeColor = SystemColors.ControlText;
            pClassEditBottom.Location = new Point(0, 267);
            pClassEditBottom.Margin = new Padding(0);
            pClassEditBottom.Name = "pClassEditBottom";
            pClassEditBottom.Padding = new Padding(10);
            pClassEditBottom.Size = new Size(664, 65);
            pClassEditBottom.TabIndex = 1;
            // 
            // pClassEditSave
            // 
            pClassEditSave.Controls.Add(bClassSaveEdit);
            pClassEditSave.Dock = DockStyle.Right;
            pClassEditSave.Location = new Point(566, 10);
            pClassEditSave.Name = "pClassEditSave";
            pClassEditSave.Size = new Size(88, 45);
            pClassEditSave.TabIndex = 9;
            // 
            // bClassSaveEdit
            // 
            bClassSaveEdit.Dock = DockStyle.Fill;
            bClassSaveEdit.Location = new Point(0, 0);
            bClassSaveEdit.Name = "bClassSaveEdit";
            bClassSaveEdit.Size = new Size(88, 45);
            bClassSaveEdit.TabIndex = 4;
            bClassSaveEdit.Text = "Edit";
            bClassSaveEdit.UseVisualStyleBackColor = true;
            bClassSaveEdit.Click += bClassSaveEdit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(Students);
            tabControl1.Controls.Add(Schedule);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Variable Display Semib", 9F);
            tabControl1.ItemSize = new Size(170, 60);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(710, 773);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 773);
            Controls.Add(tabControl1);
            MinimumSize = new Size(720, 0);
            Name = "Form1";
            Text = "College App";
            Load += Form1_Load;
            Resize += Form1_Resize;
            Students.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStudentClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            pStudentBottomManagement.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pStudentEditClasses.ResumeLayout(false);
            pStudentClassesBar.ResumeLayout(false);
            pStudentClassesBar.PerformLayout();
            pStudentClassButtons.ResumeLayout(false);
            pStudentEditTop.ResumeLayout(false);
            pStudentEditName.ResumeLayout(false);
            pStudentEditName.PerformLayout();
            pStudentEditCredits.ResumeLayout(false);
            pStudentEditCredits.PerformLayout();
            Classes.ResumeLayout(false);
            pClassBottom.ResumeLayout(false);
            pClassManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClass).EndInit();
            pClassEdit.ResumeLayout(false);
            pClassEditTop.ResumeLayout(false);
            pClassEditTop.PerformLayout();
            pClassDescription.ResumeLayout(false);
            pClassDescription.PerformLayout();
            pClassEditTopTop.ResumeLayout(false);
            pClassEditTopName.ResumeLayout(false);
            pClassEditTopName.PerformLayout();
            pClassEditCredits.ResumeLayout(false);
            pClassEditCredits.PerformLayout();
            pClassEditBottom.ResumeLayout(false);
            pClassEditSave.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage Schedule;
        private TabPage Students;
        private TabPage Classes;
        private Panel pClassBottom;
        private Panel pClassManagement;
        private Button bAdd;
        private Button bDeleteClass;
        private DataGridView dataGridClass;
        private Panel pClassEdit;
        private Panel pClassEditTop;
        private Panel pClassDescription;
        private TextBox textClassDescription;
        private Label lClassDescription;
        private Panel pClassEditTopTop;
        private Panel pClassEditTopName;
        private TextBox textClassName;
        private Label lClassName;
        private Panel pClassEditCredits;
        private MaskedTextBox maskedTextBox1;
        private Label lClassCredits;
        private Panel pClassEditBottom;
        private Panel pClassEditSave;
        private Button bClassSaveEdit;
        private TabControl tabControl1;
        private Panel pStudentBottomManagement;
        private Button bAddStudent;
        private Button bDeleteStudent;
        private Panel panel2;
        private Panel pStudentEditClasses;
        private Panel pStudentClassButtons;
        private Button bStudentEditSave;
        private Panel pStudentEditTop;
        private Panel pStudentEditName;
        private TextBox textStudentName;
        private Label lStudentName;
        private Panel pStudentEditCredits;
        private MaskedTextBox maskedTextBox2;
        private Label lStudentCredits;
        private ListBox listStudentClasses;
        private Panel pStudentClassesBar;
        private Button bStudentClassAdd;
        private Button bStudentClassDelete;
        private Label lStudentClasses;
        private Panel panel1;
        private DataGridView dataGridStudentClass;
        private DataGridView dataGridStudent;
    }
}
