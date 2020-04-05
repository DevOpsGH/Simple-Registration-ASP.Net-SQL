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
    public partial class updateRecord : UserControl
    {
        public string connectionName = "Data Source=MTALHA_001;Initial Catalog=Database_Lab;Integrated Security=True";

        public updateRecord()
        {
            InitializeComponent();
            pictureBox2.Hide();
        }

        

        private void updateRecord_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionName);


            try
            {
                if (rollNumber.Text == "")
                {
                    MessageBox.Show("Enter Roll Number");
                }
                else
                {
                    int inDigit;
                    if (int.TryParse(rollNumber.Text, out inDigit))
                    {
                        SqlCommand cmdupdate = new SqlCommand("Update registration_form SET Name='" + name.Text.ToString() + "',Address='" + address.Text.ToString() + "',CNIC='" + cnic.Text.ToString() +  "', Class='" +className.Text.ToString()+ "',Section='" +section.Text.ToString()+ "',DOB='" +dateOfBirth.Text.ToString()+ "' where Roll_Number=" + rollNumber.Text.ToString() + "", con);
                        con.Open();
                        cmdupdate.CommandType = CommandType.Text;
                        cmdupdate.ExecuteNonQuery();
                        MessageBox.Show("Data Updated", "Done");
                        pictureBox2.Hide();

                        name.Text = "";
                        section.Text = "";
                        className.Text = "";
                        rollNumber.Text = "";
                        address.Text = "";
                        dateOfBirth.Text = "";
                        cnic.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Roll Number Must Be Digit", "Error");
                        pictureBox2.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                pictureBox2.Show();
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
