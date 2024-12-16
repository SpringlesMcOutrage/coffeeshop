using System.Data;
using MySql.Data.MySqlClient;
namespace Shop
{
    public partial class Form1 : Form
    {
        class DB {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; database=coffeeshop; password=");
            public void openConnection() { 
                if(connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            public MySqlConnection GetConnection()
            {
                return connection;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = loginfield.Text;
            String passUser = passfield.Text;
            
            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employees` WHERE `login` = @userlogin AND `password` = @userpassword", dB.GetConnection());
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string role = table.Rows[0]["role"].ToString();

                if (role == "worker")
                {
                    this.Hide();
                    Worker workForm = new Worker();
                    workForm.Show();
                }
                else if (role == "admin")
                {
                    this.Hide();
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
            }
            else
                MessageBox.Show("No");
        }
    }
}
