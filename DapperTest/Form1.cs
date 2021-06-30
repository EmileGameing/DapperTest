using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DapperTest.Module;
using Dapper;
using MySql.Data.MySqlClient;

namespace DapperTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using(MySqlConnection connection = new MySqlConnection(ConnectOption.connectionString))
            {
                connection.Open();
                var obj = connection.Query<TestObject>("select*from test");
            }
        }
    }
}
