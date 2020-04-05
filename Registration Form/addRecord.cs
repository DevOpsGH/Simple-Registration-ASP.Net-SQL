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
    public partial class addRecord : UserControl
    {
        public addRecord()
        {
            InitializeComponent();
            pictureBox2.Hide();
        }

        public string connectionName = "Data Source=MTALHA_001;Initial Catalog=Database_Lab;Integrated Security=True";

        private void insert_Click(object sender, EventArgs e)
        {
            if(rollNumber.Text == "")
            {
                pictureBox2.Show();
                MessageBox.Show("Roll Number Cannot be Empty","Error");
            }
            else
            {
                int checkDigits;
                if(!int.TryParse(rollNumber.Text , out checkDigits))
                {
                    pictureBox2.Show();
                    MessageBox.Show("Roll Number Must Be in Digit","Error");
                }
                else
                {
                    SqlConnection con = new SqlConnection(connectionName);
                    try {
                        con.Open();
                        string cmd = "INSERT INTO registration_form(Name,Address,CNIC,Class,Section,Roll_Number,DOB)values('" + name.Text.ToString() + " ',' " + address.Text.ToString() + " ',' " + cnic.Text.ToString() + " ',' " + className.Text.ToString() + " ',' " + section.Text.ToString() + " ',' " + rollNumber.Text.ToString() + " ',' " + dateOfBirth.Text.ToString() + " ')";
                        SqlCommand command = new SqlCommand(cmd, con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Added Successfully", "Done");

                        //  EMPTY TEXTBOXES
                        name.Text = "";
                        section.Text = "";
                        className.Text = "";
                        rollNumber.Text = "";
                        address.Text = "";
                        dateOfBirth.Text = "";
                        cnic.Text = "";

                    }
                    catch(Exception ex) {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                            con.Close();
                    }
                    pictureBox2.Hide();
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
