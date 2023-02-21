using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Lab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            var str = ConfigurationManager.ConnectionStrings["Config"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            listBoxTest.Items.Add("Строка соединения: " + conn.ConnectionString);
            try
            {
                listBoxTest.Items.Add("Соединение открыто");
                conn.Open();
            }
            catch (SqlException ex)
            {
                listBoxTest.Items.Add("Ошибка соединения");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                listBoxTest.Items.Add("Соединение закрыто");
            }

        }
    }
}
