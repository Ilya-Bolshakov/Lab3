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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=srv\\sql_srv;"
            + "Initial Catalog=Supply;"
            + "User ID=sa;"
            + "Password=sa;";
            conn.Open();
            conn.Close();
        }

    }
}
