using System;
using System.Data;
using System.Data.SqlClient;
using TASK1.BL;
using TASK1.DL;
using TASK1.Utility;
using System.Windows.Forms;

namespace TASK1
{
    public partial class Form1 : Form
    {
        int Key = 0;
        static string Connection = "Server=DESKTOP-L60GA3Q;Database=STUDENTDATA;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void EmptyBoxes() 
        {
            NInput.Text="";
            MInput.Text="";
            AInput.Text="";
        }
        private void LoadData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM Student";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Key = int.Parse(selectedRow.Cells[0].Value.ToString());
                NInput.Text = selectedRow.Cells[1].Value.ToString();
                AInput.Text = selectedRow.Cells[2].Value.ToString();
                MInput.Text = selectedRow.Cells[3].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student(NInput.Text, AInput.Text, MInput.Text);
            StudentDL.AddStudent(s);
            LoadData();
            EmptyBoxes();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StudentDL.DeleteStudent(Key);
            LoadData();
            EmptyBoxes();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Student s = new Student(NInput.Text, AInput.Text, MInput.Text);
            StudentDL.UpdateStudent(Key,s);
            LoadData();
            EmptyBoxes();
        }
        private void NInput_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
