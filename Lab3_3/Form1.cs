using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            Microsoft.Data.ConnectionUI.DataConnectionDialog dlg = new Microsoft.Data.ConnectionUI.DataConnectionDialog();
            Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(dlg);
            Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(dlg);
            listBoxTest.Items.Add("Строка соединения:" + dlg.ConnectionString);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = dlg.ConnectionString;
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
