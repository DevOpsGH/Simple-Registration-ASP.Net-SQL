using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Registration_Form
{
    public partial class emergencyTab : UserControl
    {
        public emergencyTab()
        {
            InitializeComponent();
        }

        public string connectionName = "Data Source=MTALHA_001;Initial Catalog=Database_Lab;Integrated Security=True";
        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionName);
            if (agreement.Checked)
            {

                try
                {
                    con.Open();
                    string cmd = "CREATE TABLE registration_form(Name varchar(50),Address varchar(50),CNIC varchar(20),Class varchar(20),Section varchar(10),Roll_Number int NOT NULL, DOB varchar(20) , PRIMARY KEY (Roll_Number) );";
                    SqlCommand command = new SqlCommand(cmd, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Table Created Successfully ", "Done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                }




                agreement.Checked = false;
            }
        }
    }
}
