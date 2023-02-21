using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        string strcon = "Data Source=ILYA\\SQLEXPRESS;Initial Catalog=Hobbies;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = strcon;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    listBoxTest.Items.Add("Соединение закрыто");
                }
                else
                {
                    conn.Open();
                listBoxTest.Items.Add("Соединение открыто");
                }
            }
            catch (SqlException ex)
            {
                listBoxTest.Items.Add("Ошибка соединения");
            }
        }
    }
}
