using System.Data.Common;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace CollegeApp
{
    public partial class Form1 : Form
    {

        private SqlDataAdapter classDataAdapter = new SqlDataAdapter();
        private BindingSource classBindingSource = new BindingSource();
        private CurrencyManager classCurrencyManager;

        private SqlDataAdapter studentDataAdapter = new SqlDataAdapter();
        private BindingSource studentBindingSource = new BindingSource();
        private CurrencyManager studentCurrencyManager;

        private SqlDataAdapter attendanceDataAdapter = new SqlDataAdapter();
        private BindingSource attendanceBindingSource = new BindingSource();
        private CurrencyManager attendanceCurrencyManager;

        //private BindingSource studentClassBindingSource = new BindingSource();
        //private SqlDataAdapter studentClassDataAdapter = new SqlDataAdapter();
        //private DataRelation studentClassRelation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int rem;
            tabControl1.ItemSize = new Size(
                Math.DivRem(tabControl1.Size.Width - tabControl1.Margin.Left - tabControl1.Margin.Right, tabControl1.TabCount, out rem),
                tabControl1.ItemSize.Height
                );
        }


        private void GetData()
        {
            // Specify a connection string.
            String connectionString =
                "Data Source=TANNIVH\\NATOLISQL;" + "Initial Catalog=master;" +
                "Integrated Security=True;" + "Trust Server Certificate=True";

            String classQuery =         "select * from Class";

            String studentQuery =       "select StudentID,Name,ClassID, " +
                                        "coalesce((select top 1 Name from Class where Class.ClassID = Student.ClassID),'Unenrolled')" +
                                        "EnrolledClass from Student";

            String attendanceQuery =    "select Class.Name as ClassName, coalesce(Student.Name,'Empty') as StudentName from Class left join Student on Class.ClassID = Student.ClassID";

            // Create a new data adapter based on the specified query.
            classDataAdapter = new SqlDataAdapter(classQuery, connectionString);
            studentDataAdapter = new SqlDataAdapter(studentQuery, connectionString);
            attendanceDataAdapter = new SqlDataAdapter(attendanceQuery, connectionString);

            // Create a command builder to generate SQL update, insert, and delete commands based on selectCommand.
            SqlCommandBuilder classCommandBuilder = new SqlCommandBuilder(classDataAdapter);
            SqlCommandBuilder studentCommandBuilder = new SqlCommandBuilder(studentDataAdapter);
            SqlCommandBuilder attendanceCommandBuilder = new SqlCommandBuilder(attendanceDataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable classTable = new DataTable { Locale = CultureInfo.InvariantCulture };
            classDataAdapter.Fill(classTable);
            classBindingSource.DataSource = classTable;

            DataTable studentTable = new DataTable { Locale = CultureInfo.InvariantCulture };
            studentDataAdapter.Fill(studentTable);
            studentBindingSource.DataSource = studentTable;

            DataTable attendanceTable = new DataTable { Locale = CultureInfo.InvariantCulture };
            attendanceDataAdapter.Fill(attendanceTable);
            attendanceBindingSource.DataSource = attendanceTable;

            //Create data bindings for classes page controls
            textClassName.DataBindings.Add("Text", classBindingSource.DataSource, "Name");
            textClassDescription.DataBindings.Add("Text", classBindingSource.DataSource, "Description");

            textStudentName.DataBindings.Add("Text", studentBindingSource.DataSource, "Name");

            // Set the initial Position of the class grid control.
            classCurrencyManager = (CurrencyManager)this.BindingContext[classTable];
            classCurrencyManager.Position = 0;

            studentCurrencyManager = (CurrencyManager)this.BindingContext[studentTable];
            studentCurrencyManager.Position = 0;

            attendanceCurrencyManager = (CurrencyManager)this.BindingContext[attendanceTable];
            attendanceCurrencyManager.Position = 0;

            //Hide primarykey
            dataGridClass.Columns[0].Visible = false;
            dataGridStudent.Columns[0].Visible = false;
            dataGridStudent.Columns[2].Visible = false;
            //dataGridAttendance.Columns[0].Visible = false;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Attach bindings to data grids
            dataGridClass.DataSource = classBindingSource;
            dataGridStudent.DataSource = studentBindingSource;
            dataGridAttendance.DataSource = attendanceBindingSource;

            GetData();

            //Bind class list on student page
            listStudentClasses.DisplayMember = "Name";
            listStudentClasses.DataSource = classBindingSource;
        }

        private void UpdateStudentData()
        {
            DataTable dataTable = new DataTable();
            studentDataAdapter.Fill(dataTable);
            studentBindingSource.DataSource = dataTable;
        }

        private void UpdateAttendanceData()
        {
            DataTable dataTable = new DataTable();
            attendanceDataAdapter.Fill(dataTable);
            attendanceBindingSource.DataSource = dataTable;
        }

        private void dataGridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classCurrencyManager.Position = e.RowIndex;
        }

        private void ToggleClassControls()
        {
            bool flip = !textClassDescription.Enabled;
            textClassDescription.Enabled = flip;
            textClassName.Enabled = flip;
            //maskedTextBox1.Enabled = flip;
        }

        private void bClassSaveEdit_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Save")
            {
                classBindingSource.EndEdit();
                classDataAdapter.Update((DataTable)classBindingSource.DataSource);
                (sender as Button).Text = "Edit";
                ToggleClassControls();
                UpdateAttendanceData();
            }
            else
            {
                //Change UI to show data is editable
                (sender as Button).Text = "Save";
                dataGridClass.BeginEdit(true);
                ToggleClassControls();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            classBindingSource.AddNew();
            classCurrencyManager.Position = classCurrencyManager.Count - 1;
            bClassSaveEdit.Text = "Save";
            dataGridClass.BeginEdit(true);
            ToggleClassControls();
        }

        private void bDeleteClass_Click(object sender, EventArgs e)
        {
            classBindingSource.RemoveCurrent();
            classDataAdapter.Update((DataTable)classBindingSource.DataSource);
        }


        private void ToggleStudentControls()
        {
            bool flip = !textStudentName.Enabled;
            textStudentName.Enabled = flip;
            //maskedTextBox2.Enabled = flip;
            bStudentClassAdd.Enabled = flip;
            bStudentClassDelete.Enabled = flip;
            listStudentClasses.Enabled = flip;
        }

        private void EnrollStudentClass()
        {
            int listValue;
            int.TryParse((listStudentClasses.SelectedItem as DataRowView).Row.ItemArray[0].ToString(), out listValue);
            dataGridStudent.Rows[studentCurrencyManager.Position].Cells[2].Value = listValue;
            //dataGridStudent.InvalidateCell(studentCurrencyManager.Position, 2);
        }

        private void UnenrollStudentClass()
        {
            studentBindingSource.EndEdit();
            dataGridStudent.Rows[studentCurrencyManager.Position].Cells[2].Value = DBNull.Value;
            studentDataAdapter.Update((DataTable)studentBindingSource.DataSource);
            bStudentEditSave.Text = "Edit";
            ToggleStudentControls();
            UpdateStudentData();
            UpdateAttendanceData();
        }

        private void bStudentEditSave_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Save")
            { 
                try
                {
                    EnrollStudentClass();
                    studentBindingSource.EndEdit();
                    studentDataAdapter.Update((DataTable)studentBindingSource.DataSource);
                    (sender as Button).Text = "Edit";
                    ToggleStudentControls();
                    //UpdateStudentData();
                    dataGridStudent.RefreshEdit();
                    UpdateAttendanceData();
                    dataGridStudent.InvalidateCell(3, studentCurrencyManager.Position);
                }
                catch
                {
                    MessageBox.Show("Failed");
                }
                
            }
            else
            {
                //Change UI to show data is editable
                (sender as Button).Text = "Save";
                dataGridStudent.BeginEdit(true);
                ToggleStudentControls();
            }
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            studentBindingSource.AddNew();
            studentCurrencyManager.Position = studentCurrencyManager.Count;
            bStudentEditSave.Text = "Save";
            dataGridStudent.BeginEdit(true);
            ToggleStudentControls();
            
        }

        private void bDeleteStudent_Click(object sender, EventArgs e)
        {
            studentBindingSource.RemoveCurrent();
            studentDataAdapter.Update((DataTable)studentBindingSource.DataSource);
        }

        private void listStudentClasses_DoubleClick(object sender, EventArgs e)
        {
            EnrollStudentClass();
        }

        private void bStudentClassAdd_MouseClick(object sender, MouseEventArgs e)
        {
            EnrollStudentClass();
        }

        private void bStudentClassDelete_Click(object sender, EventArgs e)
        {
            UnenrollStudentClass();
        }

        private void dataGridStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (studentCurrencyManager != null)
            {
                //studentCurrencyManager.Position = e.RowIndex;
                // = e.RowIndex;
            }

        }

        private void dataGridClass_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (classCurrencyManager != null)
            {
                //classCurrencyManager.Position = e.RowIndex;
            }
        }
    }
}
