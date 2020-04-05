using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registration_Form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            addRecord1.BringToFront();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point currentLocation;
        private bool mouseEvent = false;
        
        private void moveForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent = true;
            currentLocation = e.Location;

        }

        private void moveForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent = false;
        }

        private void moveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseEvent)
            {
                this.Location = new Point (
                    (this.Location.X - currentLocation.X) + e.X,
                    (this.Location.Y - currentLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            activeTab.Show();
            activeTab.Height = insert.Height;
            activeTab.Top = insert.Top;
            addRecord1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activeTab.Hide();
            helpMe1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeTab.Show();
            activeTab.Height = search.Height;
            activeTab.Top = search.Top;
            searchRecord1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeTab.Show();
            activeTab.Height = button2.Height;
            activeTab.Top = button2.Top;
            updateRecord1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activeTab.Show();
            activeTab.Height = button3.Height;
            activeTab.Top = button3.Top;
            emergencyTab1.BringToFront();
        }

        private void addRecord1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
