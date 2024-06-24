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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Schedule = new TabPage();
            dataGridAttendance = new DataGridView();
            lAttendance = new Label();
            Students = new TabPage();
            dataGridStudent = new DataGridView();
            pStudentBottomManagement = new Panel();
            bAddStudent = new Button();
            bDeleteStudent = new Button();
            pStudentEdit = new Panel();
            pStudentEditClasses = new Panel();
            listStudentClasses = new ListBox();
            pStudentClassesBar = new Panel();
            lClassesList = new Label();
            bStudentClassAdd = new Button();
            bStudentClassDelete = new Button();
            lStudentClasses = new Label();
            pStudentClassButtons = new Panel();
            bStudentEditSave = new Button();
            pStudentEditTop = new Panel();
            pStudentEditName = new Panel();
            textStudentName = new TextBox();
            lStudentName = new Label();
            Classes = new TabPage();
            pClassBottom = new Panel();
            pClassManagement = new Panel();
            bAdd = new Button();
            bDeleteClass = new Button();
            dataGridClass = new DataGridView();
            pClassEdit = new Panel();
            pClassDescription = new Panel();
            textClassDescription = new TextBox();
            lClassDescription = new Label();
            pClassEditTopName = new Panel();
            textClassName = new TextBox();
            lClassName = new Label();
            pClassEditBottom = new Panel();
            bClassSaveEdit = new Button();
            tabControl1 = new TabControl();
            Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAttendance).BeginInit();
            Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            pStudentBottomManagement.SuspendLayout();
            pStudentEdit.SuspendLayout();
            pStudentEditClasses.SuspendLayout();
            pStudentClassesBar.SuspendLayout();
            pStudentClassButtons.SuspendLayout();
            pStudentEditTop.SuspendLayout();
            pStudentEditName.SuspendLayout();
            Classes.SuspendLayout();
            pClassBottom.SuspendLayout();
            pClassManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClass).BeginInit();
            pClassEdit.SuspendLayout();
            pClassDescription.SuspendLayout();
            pClassEditTopName.SuspendLayout();
            pClassEditBottom.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Schedule
            // 
            Schedule.Controls.Add(dataGridAttendance);
            Schedule.Controls.Add(lAttendance);
            Schedule.Location = new Point(8, 68);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(678, 697);
            Schedule.TabIndex = 2;
            Schedule.Text = "Attendance";
            Schedule.UseVisualStyleBackColor = true;
            // 
            // dataGridAttendance
            // 
            dataGridAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAttendance.Dock = DockStyle.Fill;
            dataGridAttendance.Location = new Point(0, 83);
            dataGridAttendance.Name = "dataGridAttendance";
            dataGridAttendance.ReadOnly = true;
            dataGridAttendance.RowHeadersWidth = 82;
            dataGridAttendance.Size = new Size(678, 614);
            dataGridAttendance.TabIndex = 0;
            // 
            // lAttendance
            // 
            lAttendance.Dock = DockStyle.Top;
            lAttendance.Font = new Font("Segoe UI Variable Display Semib", 12F);
            lAttendance.Location = new Point(0, 0);
            lAttendance.Name = "lAttendance";
            lAttendance.Size = new Size(678, 83);
            lAttendance.TabIndex = 1;
            lAttendance.Text = "Class Attendance";
            lAttendance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Students
            // 
            Students.Controls.Add(dataGridStudent);
            Students.Controls.Add(pStudentBottomManagement);
            Students.Controls.Add(pStudentEdit);
            Students.ForeColor = SystemColors.ControlText;
            Students.Location = new Point(8, 68);
            Students.Name = "Students";
            Students.Padding = new Padding(10);
            Students.Size = new Size(678, 697);
            Students.TabIndex = 1;
            Students.Text = "Students";
            // 
            // dataGridStudent
            // 
            dataGridStudent.AllowUserToAddRows = false;
            dataGridStudent.AllowUserToDeleteRows = false;
            dataGridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Dock = DockStyle.Fill;
            dataGridStudent.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridStudent.Location = new Point(10, 230);
            dataGridStudent.MultiSelect = false;
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.RowHeadersWidth = 82;
            dataGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudent.Size = new Size(658, 399);
            dataGridStudent.TabIndex = 8;
            // 
            // pStudentBottomManagement
            // 
            pStudentBottomManagement.Controls.Add(bAddStudent);
            pStudentBottomManagement.Controls.Add(bDeleteStudent);
            pStudentBottomManagement.Dock = DockStyle.Bottom;
            pStudentBottomManagement.Location = new Point(10, 629);
            pStudentBottomManagement.Name = "pStudentBottomManagement";
            pStudentBottomManagement.Size = new Size(658, 58);
            pStudentBottomManagement.TabIndex = 7;
            // 
            // bAddStudent
            // 
            bAddStudent.Dock = DockStyle.Right;
            bAddStudent.Location = new Point(308, 0);
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
            bDeleteStudent.Location = new Point(468, 0);
            bDeleteStudent.Name = "bDeleteStudent";
            bDeleteStudent.Size = new Size(190, 58);
            bDeleteStudent.TabIndex = 4;
            bDeleteStudent.Text = "Delete Student";
            bDeleteStudent.UseVisualStyleBackColor = true;
            bDeleteStudent.Click += bDeleteStudent_Click;
            // 
            // pStudentEdit
            // 
            pStudentEdit.BackgroundImageLayout = ImageLayout.None;
            pStudentEdit.CausesValidation = false;
            pStudentEdit.Controls.Add(pStudentEditClasses);
            pStudentEdit.Controls.Add(pStudentEditTop);
            pStudentEdit.Dock = DockStyle.Top;
            pStudentEdit.ForeColor = SystemColors.ControlText;
            pStudentEdit.Location = new Point(10, 10);
            pStudentEdit.Margin = new Padding(0);
            pStudentEdit.Name = "pStudentEdit";
            pStudentEdit.Padding = new Padding(3);
            pStudentEdit.Size = new Size(658, 220);
            pStudentEdit.TabIndex = 5;
            // 
            // pStudentEditClasses
            // 
            pStudentEditClasses.AutoSize = true;
            pStudentEditClasses.Controls.Add(listStudentClasses);
            pStudentEditClasses.Controls.Add(pStudentClassesBar);
            pStudentEditClasses.Controls.Add(pStudentClassButtons);
            pStudentEditClasses.Dock = DockStyle.Fill;
            pStudentEditClasses.Location = new Point(3, 63);
            pStudentEditClasses.Name = "pStudentEditClasses";
            pStudentEditClasses.Size = new Size(652, 154);
            pStudentEditClasses.TabIndex = 11;
            // 
            // listStudentClasses
            // 
            listStudentClasses.Dock = DockStyle.Fill;
            listStudentClasses.Enabled = false;
            listStudentClasses.FormattingEnabled = true;
            listStudentClasses.Location = new Point(0, 51);
            listStudentClasses.Name = "listStudentClasses";
            listStudentClasses.Size = new Size(555, 103);
            listStudentClasses.TabIndex = 12;
            listStudentClasses.DoubleClick += listStudentClasses_DoubleClick;
            // 
            // pStudentClassesBar
            // 
            pStudentClassesBar.BackColor = SystemColors.ControlDark;
            pStudentClassesBar.Controls.Add(lClassesList);
            pStudentClassesBar.Controls.Add(bStudentClassAdd);
            pStudentClassesBar.Controls.Add(bStudentClassDelete);
            pStudentClassesBar.Controls.Add(lStudentClasses);
            pStudentClassesBar.Dock = DockStyle.Top;
            pStudentClassesBar.Location = new Point(0, 0);
            pStudentClassesBar.Name = "pStudentClassesBar";
            pStudentClassesBar.Padding = new Padding(10, 0, 0, 0);
            pStudentClassesBar.Size = new Size(555, 51);
            pStudentClassesBar.TabIndex = 11;
            // 
            // lClassesList
            // 
            lClassesList.AutoSize = true;
            lClassesList.Dock = DockStyle.Left;
            lClassesList.Location = new Point(10, 0);
            lClassesList.Margin = new Padding(0);
            lClassesList.Name = "lClassesList";
            lClassesList.Size = new Size(198, 32);
            lClassesList.TabIndex = 13;
            lClassesList.Text = "Available Classes";
            // 
            // bStudentClassAdd
            // 
            bStudentClassAdd.Dock = DockStyle.Right;
            bStudentClassAdd.Enabled = false;
            bStudentClassAdd.Location = new Point(315, 0);
            bStudentClassAdd.Name = "bStudentClassAdd";
            bStudentClassAdd.Size = new Size(120, 51);
            bStudentClassAdd.TabIndex = 12;
            bStudentClassAdd.Text = "Enroll";
            bStudentClassAdd.UseVisualStyleBackColor = true;
            bStudentClassAdd.MouseClick += bStudentClassAdd_MouseClick;
            // 
            // bStudentClassDelete
            // 
            bStudentClassDelete.Dock = DockStyle.Right;
            bStudentClassDelete.Enabled = false;
            bStudentClassDelete.Location = new Point(435, 0);
            bStudentClassDelete.Name = "bStudentClassDelete";
            bStudentClassDelete.Size = new Size(120, 51);
            bStudentClassDelete.TabIndex = 10;
            bStudentClassDelete.Text = "Unenroll";
            bStudentClassDelete.UseVisualStyleBackColor = true;
            bStudentClassDelete.Click += bStudentClassDelete_Click;
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
            pStudentClassButtons.Location = new Point(555, 0);
            pStudentClassButtons.Name = "pStudentClassButtons";
            pStudentClassButtons.Padding = new Padding(10);
            pStudentClassButtons.Size = new Size(97, 154);
            pStudentClassButtons.TabIndex = 8;
            // 
            // bStudentEditSave
            // 
            bStudentEditSave.Dock = DockStyle.Bottom;
            bStudentEditSave.Location = new Point(10, 94);
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
            pStudentEditTop.Dock = DockStyle.Top;
            pStudentEditTop.Location = new Point(3, 3);
            pStudentEditTop.Name = "pStudentEditTop";
            pStudentEditTop.Size = new Size(652, 60);
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
            pStudentEditName.Size = new Size(652, 60);
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
            textStudentName.Size = new Size(462, 39);
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
            // Classes
            // 
            Classes.Controls.Add(pClassBottom);
            Classes.Controls.Add(pClassEdit);
            Classes.Location = new Point(8, 68);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(15);
            Classes.Size = new Size(678, 697);
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
            pClassBottom.Location = new Point(15, 235);
            pClassBottom.Margin = new Padding(0);
            pClassBottom.Name = "pClassBottom";
            pClassBottom.Size = new Size(648, 447);
            pClassBottom.TabIndex = 3;
            // 
            // pClassManagement
            // 
            pClassManagement.Controls.Add(bAdd);
            pClassManagement.Controls.Add(bDeleteClass);
            pClassManagement.Dock = DockStyle.Bottom;
            pClassManagement.Location = new Point(0, 389);
            pClassManagement.Name = "pClassManagement";
            pClassManagement.Size = new Size(648, 58);
            pClassManagement.TabIndex = 3;
            // 
            // bAdd
            // 
            bAdd.Dock = DockStyle.Right;
            bAdd.Location = new Point(328, 0);
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
            bDeleteClass.Location = new Point(488, 0);
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
            dataGridClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClass.Dock = DockStyle.Fill;
            dataGridClass.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridClass.Location = new Point(0, 0);
            dataGridClass.MultiSelect = false;
            dataGridClass.Name = "dataGridClass";
            dataGridClass.RowHeadersWidth = 82;
            dataGridClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClass.Size = new Size(648, 447);
            dataGridClass.TabIndex = 2;
            dataGridClass.CellClick += dataGridClass_CellClick;
            dataGridClass.RowEnter += dataGridClass_RowEnter;
            // 
            // pClassEdit
            // 
            pClassEdit.BackgroundImageLayout = ImageLayout.None;
            pClassEdit.CausesValidation = false;
            pClassEdit.Controls.Add(pClassDescription);
            pClassEdit.Controls.Add(pClassEditTopName);
            pClassEdit.Controls.Add(pClassEditBottom);
            pClassEdit.Dock = DockStyle.Top;
            pClassEdit.ForeColor = SystemColors.ControlText;
            pClassEdit.Location = new Point(15, 15);
            pClassEdit.Margin = new Padding(0);
            pClassEdit.Name = "pClassEdit";
            pClassEdit.Size = new Size(648, 220);
            pClassEdit.TabIndex = 0;
            // 
            // pClassDescription
            // 
            pClassDescription.AutoSize = true;
            pClassDescription.Controls.Add(textClassDescription);
            pClassDescription.Controls.Add(lClassDescription);
            pClassDescription.Dock = DockStyle.Fill;
            pClassDescription.Location = new Point(0, 60);
            pClassDescription.Name = "pClassDescription";
            pClassDescription.Padding = new Padding(10);
            pClassDescription.Size = new Size(541, 160);
            pClassDescription.TabIndex = 12;
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
            textClassDescription.Size = new Size(521, 108);
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
            // pClassEditTopName
            // 
            pClassEditTopName.Controls.Add(textClassName);
            pClassEditTopName.Controls.Add(lClassName);
            pClassEditTopName.Dock = DockStyle.Top;
            pClassEditTopName.Location = new Point(0, 0);
            pClassEditTopName.Name = "pClassEditTopName";
            pClassEditTopName.Padding = new Padding(10);
            pClassEditTopName.Size = new Size(541, 60);
            pClassEditTopName.TabIndex = 6;
            // 
            // textClassName
            // 
            textClassName.Dock = DockStyle.Fill;
            textClassName.Enabled = false;
            textClassName.Location = new Point(151, 10);
            textClassName.Margin = new Padding(3, 3, 3, 10);
            textClassName.MaxLength = 100;
            textClassName.Name = "textClassName";
            textClassName.Size = new Size(380, 39);
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
            // pClassEditBottom
            // 
            pClassEditBottom.CausesValidation = false;
            pClassEditBottom.Controls.Add(bClassSaveEdit);
            pClassEditBottom.Dock = DockStyle.Right;
            pClassEditBottom.ForeColor = SystemColors.ControlText;
            pClassEditBottom.Location = new Point(541, 0);
            pClassEditBottom.Margin = new Padding(0);
            pClassEditBottom.Name = "pClassEditBottom";
            pClassEditBottom.Padding = new Padding(10);
            pClassEditBottom.Size = new Size(107, 220);
            pClassEditBottom.TabIndex = 1;
            // 
            // bClassSaveEdit
            // 
            bClassSaveEdit.Dock = DockStyle.Bottom;
            bClassSaveEdit.Location = new Point(10, 165);
            bClassSaveEdit.Name = "bClassSaveEdit";
            bClassSaveEdit.Size = new Size(87, 45);
            bClassSaveEdit.TabIndex = 5;
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
            tabControl1.Size = new Size(694, 773);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 773);
            Controls.Add(tabControl1);
            MinimumSize = new Size(720, 0);
            Name = "Form1";
            Text = "College App";
            Load += Form1_Load;
            Resize += Form1_Resize;
            Schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAttendance).EndInit();
            Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            pStudentBottomManagement.ResumeLayout(false);
            pStudentEdit.ResumeLayout(false);
            pStudentEdit.PerformLayout();
            pStudentEditClasses.ResumeLayout(false);
            pStudentClassesBar.ResumeLayout(false);
            pStudentClassesBar.PerformLayout();
            pStudentClassButtons.ResumeLayout(false);
            pStudentEditTop.ResumeLayout(false);
            pStudentEditName.ResumeLayout(false);
            pStudentEditName.PerformLayout();
            Classes.ResumeLayout(false);
            pClassBottom.ResumeLayout(false);
            pClassManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClass).EndInit();
            pClassEdit.ResumeLayout(false);
            pClassEdit.PerformLayout();
            pClassDescription.ResumeLayout(false);
            pClassDescription.PerformLayout();
            pClassEditTopName.ResumeLayout(false);
            pClassEditTopName.PerformLayout();
            pClassEditBottom.ResumeLayout(false);
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
        private Panel pClassEditBottom;
        private TabControl tabControl1;
        private Panel pStudentBottomManagement;
        private Button bAddStudent;
        private Button bDeleteStudent;
        private Panel pStudentEdit;
        private Panel pStudentEditClasses;
        private Panel pStudentClassButtons;
        private Button bStudentEditSave;
        private Panel pStudentEditTop;
        private Panel pStudentEditName;
        private TextBox textStudentName;
        private Label lStudentName;
        private ListBox listStudentClasses;
        private Panel pStudentClassesBar;
        private Button bStudentClassAdd;
        private Button bStudentClassDelete;
        private Label lStudentClasses;
        private Label lClassesList;
        private Panel pClassDescription;
        private TextBox textClassDescription;
        private Label lClassDescription;
        private Panel pClassEditTopName;
        private TextBox textClassName;
        private Label lClassName;
        private Button bClassSaveEdit;
        private DataGridView dataGridAttendance;
        private DataGridView dataGridStudent;
        private Label lAttendance;
    }
}
