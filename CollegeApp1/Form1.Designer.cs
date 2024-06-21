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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
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
            pClassEditBottomLeft = new Panel();
            Students = new TabPage();
            pStudentBottom = new Panel();
            pStudentBottomManagement = new Panel();
            bAddStudent = new Button();
            bDeleteStudent = new Button();
            dataGridStudent = new DataGridView();
            Schedule = new TabPage();
            Configuration = new TabPage();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
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
            Students.SuspendLayout();
            pStudentBottom.SuspendLayout();
            pStudentBottomManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(Students);
            tabControl1.Controls.Add(Schedule);
            tabControl1.Controls.Add(Configuration);
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
            // 
            // dataGridClass
            // 
            dataGridClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClass.Dock = DockStyle.Fill;
            dataGridClass.Location = new Point(0, 0);
            dataGridClass.Name = "dataGridClass";
            dataGridClass.RowHeadersWidth = 82;
            dataGridClass.Size = new Size(664, 335);
            dataGridClass.TabIndex = 2;
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
            pClassEditTop.Size = new Size(664, 226);
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
            pClassDescription.Size = new Size(644, 146);
            pClassDescription.TabIndex = 11;
            // 
            // textClassDescription
            // 
            textClassDescription.Dock = DockStyle.Fill;
            textClassDescription.Location = new Point(10, 42);
            textClassDescription.Margin = new Padding(3, 3, 3, 10);
            textClassDescription.Multiline = true;
            textClassDescription.Name = "textClassDescription";
            textClassDescription.ScrollBars = ScrollBars.Vertical;
            textClassDescription.Size = new Size(624, 94);
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
            pClassEditBottom.Controls.Add(pClassEditBottomLeft);
            pClassEditBottom.Dock = DockStyle.Bottom;
            pClassEditBottom.ForeColor = SystemColors.ControlText;
            pClassEditBottom.Location = new Point(0, 226);
            pClassEditBottom.Margin = new Padding(0);
            pClassEditBottom.Name = "pClassEditBottom";
            pClassEditBottom.Padding = new Padding(10);
            pClassEditBottom.Size = new Size(664, 106);
            pClassEditBottom.TabIndex = 1;
            // 
            // pClassEditSave
            // 
            pClassEditSave.Controls.Add(bClassSaveEdit);
            pClassEditSave.Dock = DockStyle.Right;
            pClassEditSave.Location = new Point(566, 10);
            pClassEditSave.Name = "pClassEditSave";
            pClassEditSave.Padding = new Padding(0, 25, 0, 0);
            pClassEditSave.Size = new Size(88, 86);
            pClassEditSave.TabIndex = 9;
            // 
            // bClassSaveEdit
            // 
            bClassSaveEdit.Dock = DockStyle.Fill;
            bClassSaveEdit.Location = new Point(0, 25);
            bClassSaveEdit.Name = "bClassSaveEdit";
            bClassSaveEdit.Size = new Size(88, 61);
            bClassSaveEdit.TabIndex = 4;
            bClassSaveEdit.Text = "Edit";
            bClassSaveEdit.UseVisualStyleBackColor = true;
            // 
            // pClassEditBottomLeft
            // 
            pClassEditBottomLeft.Dock = DockStyle.Left;
            pClassEditBottomLeft.Location = new Point(10, 10);
            pClassEditBottomLeft.Name = "pClassEditBottomLeft";
            pClassEditBottomLeft.Size = new Size(98, 86);
            pClassEditBottomLeft.TabIndex = 7;
            // 
            // Students
            // 
            Students.Controls.Add(pStudentBottom);
            Students.ForeColor = SystemColors.ControlText;
            Students.Location = new Point(8, 68);
            Students.Name = "Students";
            Students.Padding = new Padding(3);
            Students.Size = new Size(694, 697);
            Students.TabIndex = 1;
            Students.Text = "Students";
            // 
            // pStudentBottom
            // 
            pStudentBottom.BackgroundImageLayout = ImageLayout.None;
            pStudentBottom.CausesValidation = false;
            pStudentBottom.Controls.Add(pStudentBottomManagement);
            pStudentBottom.Controls.Add(dataGridStudent);
            pStudentBottom.Dock = DockStyle.Fill;
            pStudentBottom.ForeColor = SystemColors.ControlText;
            pStudentBottom.Location = new Point(3, 3);
            pStudentBottom.Margin = new Padding(0);
            pStudentBottom.Name = "pStudentBottom";
            pStudentBottom.Size = new Size(688, 691);
            pStudentBottom.TabIndex = 4;
            // 
            // pStudentBottomManagement
            // 
            pStudentBottomManagement.Controls.Add(bAddStudent);
            pStudentBottomManagement.Controls.Add(bDeleteStudent);
            pStudentBottomManagement.Dock = DockStyle.Bottom;
            pStudentBottomManagement.Location = new Point(0, 633);
            pStudentBottomManagement.Name = "pStudentBottomManagement";
            pStudentBottomManagement.Size = new Size(688, 58);
            pStudentBottomManagement.TabIndex = 3;
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
            // 
            // dataGridStudent
            // 
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Dock = DockStyle.Fill;
            dataGridStudent.Location = new Point(0, 0);
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.RowHeadersWidth = 82;
            dataGridStudent.Size = new Size(688, 691);
            dataGridStudent.TabIndex = 2;
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
            // Configuration
            // 
            Configuration.Location = new Point(8, 68);
            Configuration.Name = "Configuration";
            Configuration.Size = new Size(694, 697);
            Configuration.TabIndex = 3;
            Configuration.Text = "Configuration";
            Configuration.UseVisualStyleBackColor = true;
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
            tabControl1.ResumeLayout(false);
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
            Students.ResumeLayout(false);
            pStudentBottom.ResumeLayout(false);
            pStudentBottomManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private TabControl tabControl1;
        private TabPage Classes;
        private Panel pClassEdit;
        private Panel pClassEditTop;
        private Panel pClassEditTopTop;

        private Panel pClassBottom;
        private TabPage Students;
        private TabPage Schedule;
        private TabPage Configuration;
        
        private Panel pClassEditBottom;
        
        
        private DataGridView dataGridClass;
        private Panel pClassManagement;
        private Button bAdd;
        private Button bDeleteClass;
        private Panel pClassDescription;
        private TextBox textClassDescription;
        private Label lClassDescription;
        private Panel pClassEditCredits;
        private MaskedTextBox maskedTextBox1;
        private Label lClassCredits;
        private Panel pClassEditBottomLeft;
        private Panel pClassEditTopName;
        private TextBox textClassName;
        private Label lClassName;
        private Panel pClassEditSave;
        private Button bClassSaveEdit;
        private Panel pStudentBottom;
        private Panel pStudentBottomManagement;
        private Button bAddStudent;
        private Button bDeleteStudent;
        private DataGridView dataGridStudent;
    }
}
