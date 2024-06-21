using System.Data.Common;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CollegeApp
{
    public partial class Form1 : Form
    {

        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();


        }

        private void GetData(string selectCommand)
        {
            
                // Specify a connection string.
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString =
                    "Data Source=TANNIVH\\NATOLISQL;" +
                    "Initial Catalog=master;" +
                    "Integrated Security=True;" +
                    "Trust Server Certificate=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
        
                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                //dataGridClass.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

                textClassName.DataBindings.Add(new Binding("Text", bindingSource1.DataSource, "Class.Name"));

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
            dataGridClass.DataSource = bindingSource1;
            GetData("select * from Class");
        }
    }
}
