using System.Data.SqlClient;



namespace Lab3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public void ConnectToSql()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=ILYA\\SQLEXPRESS;Initial Catalog=Hobbies;Integrated Security=True";
                conn.Open();
                listBoxTest.Items.Add("Соединение открыто");
                conn.Close();
                listBoxTest.Items.Add("Соединение закрыто");
            }
            catch (System.Exception ex)
            {
                throw;
            }
            
        }

        private void btnRun_Click(object sender, System.EventArgs e)
        {
            ConnectToSql();
        }
    }
}
