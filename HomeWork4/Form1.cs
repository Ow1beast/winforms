using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WinForms
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder SqlConnectionBuild = new SqlConnectionStringBuilder();
        string User = null, Password = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConnectionString);

            if(textBox1.Text==builder.UserID && textBox2.Text == builder.Password)
            {
                User = textBox1.Text;
                Password = textBox2.Text;
                MessageBox.Show("Correct");
            }
            else MessageBox.Show("Invalid");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
