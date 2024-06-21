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
        private SqlDataAdapter studentDataAdapter = new SqlDataAdapter();
        private SqlDataAdapter studentClassDataAdapter = new SqlDataAdapter();
        private DataRelation studentClassRelation;
        private BindingSource classBindingSource = new BindingSource();
        private BindingSource studentBindingSource = new BindingSource();
        private BindingSource studentClassBindingSource = new BindingSource();
        private CurrencyManager classCurrencyManager;
        private CurrencyManager studentCurrencyManager;

        public Form1()
        {
            InitializeComponent();


        }


        public class ClassViewModel : INotifyPropertyChanged
        {
            public event EventHandler Save;

            public string Name { get; set; }
            public string Description { get; set; }
            public int Credits { get; set; }

            public void onSave(object sender, EventArgs e)
            {
                NotifyPropertyChanged(nameof(Credits));
                Save?.Invoke(sender, e);
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged(string info)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
            }

        }

        private void GetData()
        {
            // Specify a connection string.
            String connectionString =
                "Data Source=TANNIVH\\NATOLISQL;" + "Initial Catalog=master;" +
                "Integrated Security=True;" + "Trust Server Certificate=True";

            String classQuery = "select * from Class";

            // Create a new data adapter based on the specified query.
            classDataAdapter = new SqlDataAdapter(classQuery, connectionString);

            // Create a command builder to generate SQL update, insert, and delete commands based on selectCommand.
            SqlCommandBuilder classCommandBuilder = new SqlCommandBuilder(classDataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable classTable = new DataTable { Locale = CultureInfo.InvariantCulture };
            classDataAdapter.Fill(classTable);
            classBindingSource.DataSource = classTable;

            //Create data bindings for classes page controls
            textClassName.DataBindings.Add("Text", classBindingSource.DataSource, "Name");
            textClassDescription.DataBindings.Add("Text", classBindingSource.DataSource, "Description");
            maskedTextBox1.DataBindings.Add("Text", classBindingSource.DataSource, "Credits");
            
            // Set the initial Position of the class grid control.
            classCurrencyManager = (CurrencyManager)this.BindingContext[classTable];
            classCurrencyManager.Position = 0;

            //Hide primarykey
            dataGridClass.Columns[0].Visible = false;


            String studentQuery = "select * from Student";

            // Create a new data adapter based on the specified query.
            studentDataAdapter = new SqlDataAdapter(studentQuery, connectionString);

            // Create a command builder to generate SQL update, insert, and delete commands based on selectCommand.
            SqlCommandBuilder studentCommandBuilder = new SqlCommandBuilder(studentDataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable studentTable = new DataTable { Locale = CultureInfo.InvariantCulture };
            studentDataAdapter.Fill(studentTable);
            //studentBindingSource.DataSource = studentTable;

            //Create data bindings for classes page controls
            //textStudentName.DataBindings.Add("Text", studentBindingSource.DataSource, "Name");
            //maskedTextBox2.DataBindings.Add("Text", studentBindingSource.DataSource, "EnrolledCredits");

            // Set the initial Position of the class grid control.
            //studentCurrencyManager = (CurrencyManager)this.BindingContext[studentTable];
            //studentCurrencyManager.Position = 0;

            //Hide primarykey
            //dataGridStudent.Columns[0].Visible = false;


            String studentClassQuery = "select StudentClassID,StudentID,ClassID, (select top 1 Name from Class where ClassID = ClassID) ClassName from Student_Class";
            studentClassDataAdapter = new SqlDataAdapter(studentClassQuery, connectionString);
            SqlCommandBuilder studentClassCommandBuilder = new SqlCommandBuilder(studentClassDataAdapter);

            DataSet dataSet = new DataSet();
            studentDataAdapter.Fill(dataSet, "Student");
            studentClassDataAdapter.Fill(dataSet, "Student_Class");
            studentClassRelation = new DataRelation(
                "StudentsClasses", 
                dataSet.Tables["Student"].Columns["StudentID"], 
                dataSet.Tables["Student_Class"].Columns["StudentClassID"]);
            dataSet.Relations.Add(studentClassRelation);

            studentBindingSource.DataSource = dataSet;
            studentBindingSource.DataMember = "Student";
            textStudentName.DataBindings.Add("Text", studentBindingSource.DataSource, "Student.Name");
            maskedTextBox2.DataBindings.Add("Text", studentBindingSource.DataSource, "Student.EnrolledCredits");
            dataGridStudent.Columns[0].Visible = false;
            

            studentClassBindingSource.DataSource = studentBindingSource;
            studentClassBindingSource.DataMember = "StudentsClasses";

            studentCurrencyManager = (CurrencyManager)this.BindingContext[dataSet, "Student"];
            studentCurrencyManager.Position = 0;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int rem;
            tabControl1.ItemSize = new Size(
                Math.DivRem(tabControl1.Size.Width - tabControl1.Margin.Left - tabControl1.Margin.Right, tabControl1.TabCount, out rem),
                tabControl1.ItemSize.Height
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridClass.DataSource = classBindingSource;
            
            
            dataGridStudent.DataSource = studentBindingSource;
            GetData();
            listStudentClasses.DisplayMember = "Name";
            listStudentClasses.DataSource = classBindingSource;
        }

        private void dataGridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classCurrencyManager.Position = e.RowIndex;
        }

        private void dataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentCurrencyManager.Position = e.RowIndex;
        }

        private void ToggleClassControls()
        {
            bool flip = !textClassDescription.Enabled;
            textClassDescription.Enabled = flip;
            textClassName.Enabled = flip;
            maskedTextBox1.Enabled = flip;
        }

        private void bClassSaveEdit_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Save")
            {
                classBindingSource.EndEdit();
                classDataAdapter.Update((DataTable)classBindingSource.DataSource);
                (sender as Button).Text = "Edit";
                ToggleClassControls();
            }
            else
            {
                //Change UI to show data is editable
                (sender as Button).Text = "Save";
                ToggleClassControls();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            classBindingSource.AddNew();
            classCurrencyManager.Position = classCurrencyManager.Count - 1;
            bClassSaveEdit.Text = "Save";
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
            maskedTextBox2.Enabled = flip;
            bStudentClassAdd.Enabled = flip;
            bStudentClassDelete.Enabled = flip;
            listStudentClasses.Enabled = flip;
        }

        private void bStudentEditSave_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Save")
            {
                //studentBindingSource.EndEdit();
                studentDataAdapter.Update(/*(DataTable)*/studentBindingSource.DataSource as DataSet,"Student");
                (sender as Button).Text = "Edit";
                ToggleStudentControls();
            }
            else
            {
                //Change UI to show data is editable
                (sender as Button).Text = "Save";
                ToggleStudentControls();
            }
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            studentBindingSource.AddNew();
            studentCurrencyManager.Position = studentCurrencyManager.Count;
            bStudentEditSave.Text = "Save";
            ToggleStudentControls();
        }

        private void bDeleteStudent_Click(object sender, EventArgs e)
        {
            studentBindingSource.RemoveCurrent();
            studentDataAdapter.Update((DataTable)studentBindingSource.DataSource);
        }
    }
}
