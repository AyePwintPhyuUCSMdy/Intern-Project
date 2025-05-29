using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        private Button currentButton = null;
        private Color activeColor = Color.LightBlue;   // Highlight color
        private Color defaultColor = SystemColors.Control; // Default color
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadControl(UserControl uc)
        {
            splitContainer1.Panel2.Controls.Clear();

            //For Add New Employee Form
            // Check if it's the AddNewEmployee control
            if (uc is AddNewEmployee)
            {
                // Fill the entire panel
                uc.Dock = DockStyle.Fill;
            }
            else
            {
                // Set size and center the other controls
                uc.Width = 600;
                uc.Height = 630;
                uc.Dock = DockStyle.None;
                uc.Left = (splitContainer1.Panel2.Width - uc.Width) / 2;
                uc.Top = (splitContainer1.Panel2.Height - uc.Height) / 2;
            }


            // Set the size of the UC first (optional)
            //uc.Width = 600;  // or uc.PreferredSize.Width;
            //uc.Height = 630; // or uc.PreferredSize.Height;

            // Manually center the UC inside the panel
            //uc.Left = (splitContainer1.Panel2.Width - uc.Width) / 2;
            //uc.Top = (splitContainer1.Panel2.Height - uc.Height) / 2;

            // Ensure no Docking
            //uc.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(uc);

           
        }

        private void HighlightButton(Button clickedButton)
        {
            if (currentButton != null)
                currentButton.BackColor = Color.FromArgb(27, 161, 226);

            currentButton = clickedButton;
            currentButton.BackColor = Color.FromArgb(28, 28, 226);
        }

        //btn close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //btn minimize 
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        //btn maximize
        private void btnMaximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        //split container
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // It might be empty or have some code
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnRequestLeave_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRequestLeave);
            LoadControl(new RequestLeaveUserControl());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            HighlightButton(btnAttendance);
            LoadControl(new AttendanceUserControl());
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            HighlightButton(btnAddNewEmployee);
            LoadControl(new AddNewEmployee());
        }
    }
}
