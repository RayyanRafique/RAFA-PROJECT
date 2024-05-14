using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RAFA_PROJECT
{
    public partial class SignUp : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public SignUp()
        {
            InitializeComponent();
        }

        private void fNameTB_Enter(object sender, EventArgs e)
        {
            if (fNameTB.Text == "First Name")
            {
                fNameTB.Text = "";
                fNameTB.ForeColor = Color.Black;
            }
        }

        private void fNameTB_Leave(object sender, EventArgs e)
        {
            if (fNameTB.Text == "")
            {
                fNameTB.Text = "First Name";
                fNameTB.ForeColor = Color.Gray;
            }
        }

        private void lNameTB_Enter(object sender, EventArgs e)
        {
            if (lNameTB.Text == "Last Name")
            {
                lNameTB.Text = "";
                fNameTB.ForeColor = Color.Black;
            }
        }

        private void lNameTB_Leave(object sender, EventArgs e)
        {
            if (lNameTB.Text == "")
            {
                lNameTB.Text = "Last Name";
                lNameTB.ForeColor = Color.Gray;
            }
        }

        private void emailTB_Enter(object sender, EventArgs e)
        {
            if (emailTB.Text == "Email")
            {
                emailTB.Text = "";
                emailTB.ForeColor = Color.Black;
            }
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (emailTB.Text == "")
            {
                emailTB.Text = "Email";
                emailTB.ForeColor = Color.Gray;
            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.Black;
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Password";
                passwordTB.ForeColor = Color.Gray;
            }
        }

        private void confirmPassTB_Enter(object sender, EventArgs e)
        {
            if (confirmPassTB.Text == "Confirm Password")
            {
                confirmPassTB.Text = "";
                confirmPassTB.ForeColor = Color.Black;
            }
        }

        private void confirmPassTB_Leave(object sender, EventArgs e)
        {
            if (confirmPassTB.Text == "")
            {
                confirmPassTB.Text = "Confirm Password";
                confirmPassTB.ForeColor = Color.Gray;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            signUpButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signUpButton.Width, signUpButton.Height, 20, 20));
        }

        private void SignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
