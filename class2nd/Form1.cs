using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace class2nd
{
    public partial class Form1 : Form
    {
        String con = "server=192.168.0.200;port=3306;user=root;password=14789632;database=temps;";  

        public Form1()
        {

            InitializeComponent(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkDB();
        }
        private void checkDB()
        {
            dataGridView1.DataSource = null;
            DataTable dataTable = new DataTable();
            string Query = $"SELECT * FROM ai";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataAdapter db = new MySqlDataAdapter(cmd);
            db.Fill(dataTable);
            dataGridView1.DataSource = dataTable; //告訴GridView資料來源為誰
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string Query = $"INSERT INTO arts(id,name) VALUES({id},'{name}');";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myreader = cmd.ExecuteReader();
            myreader.Close();
            connection.Close();
            checkDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string Query = $"UPDATE arts SET name = '{name}' WHERE id = {id};";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myreader = cmd.ExecuteReader();
            myreader.Close();
            connection.Close();
            checkDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string Query = $"DELETE FROM arts WHERE id = {id};";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myreader = cmd.ExecuteReader();
            myreader.Close();
            connection.Close();
            checkDB();
        }
    }
}
