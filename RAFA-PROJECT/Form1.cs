using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAFA_PROJECT
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignInButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SignInButton.Width, SignInButton.Height, 20, 20));
            SignUpButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SignUpButton.Width, SignUpButton.Height, 20, 20));
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private /*async*/ void SignInButton_Click(object sender, EventArgs e)
        {
            //string email = EmailTextBox.Text;
            //string password = PasswordTextBox.Text;

            //var user = await client.Find(u => u.Email == email).FirstOrDefaultAsync();

            //if (user != null && user.Password == password)
            //{
            //    MessageBox.Show("Sign in successful!");
            //}
            //else
            //{
            //    MessageBox.Show("Invalid email or password!");
            //}
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
