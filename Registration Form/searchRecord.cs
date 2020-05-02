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
    public partial class searchRecord : UserControl
    {
        public searchRecord()
        {
            InitializeComponent();
        }

        public string connectionName = "Data Source=MSSQLSERVER;Initial Catalog=Database_Lab;Integrated Security=True";

        private void insert_Click(object sender, EventArgs e)
        {
            if(rollNumber.Text == "")
            {
                SqlConnection con = new SqlConnection(connectionName);
                try
                {
                    con.Open();
                    string cmd = "SELECT * FROM registration_form";
                    SqlCommand command = new SqlCommand(cmd, con);
                    //command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ss");
                    dataGridView1.DataSource = ds.Tables["ss"]; ;


                }
                catch 
                {
                    MessageBox.Show("No Result Found ");
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                }

            }else
            {
                int inDigit;
                if( !int.TryParse(rollNumber.Text, out inDigit))
                {
                    MessageBox.Show("Roll Number Must Be in Digit", "Error");
                }
                else
                {
                    SqlConnection con = new SqlConnection(connectionName);
                    try
                    {
                        con.Open();
                        string cmd = "SELECT * FROM registration_form WHERE Roll_Number = " + rollNumber.Text;
                        SqlCommand command = new SqlCommand(cmd, con);
                        //command.ExecuteNonQuery();
                        command.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ss");
                        dataGridView1.DataSource = ds.Tables["ss"]; ;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                            con.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
