using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace RAFA_PROJECT
{
    public partial class Form1 : Form
    {
        private readonly MongoClient client;

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

        public Form1(MongoClient mongoClient)
        {
            InitializeComponent();
            client = mongoClient;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            signInButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signInButton.Width, signInButton.Height, 20, 20));
            signUpButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signUpButton.Width, signUpButton.Height, 20, 20));
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e) // Also Password Text Box
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) // Also Email Text Box
        {

        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passwordTB.Text;

            var usersCollection = client.GetDatabase("ReLife").GetCollection<User>("users");

            var user = await usersCollection.Find(u => u.Email == email).FirstOrDefaultAsync();

            if (user != null && user.Password == password)
            {
                MessageBox.Show("Sign in successful!");
                // Create an instance of the main page and pass the username
                MainPage mainPage = new MainPage(user.fName);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password!");
            }
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Creating an instance of the sign-up form
            SignUp signUp = new SignUp(client);

            signUp.Show();
            this.Hide();
        }

        private void emailTB_Enter(object sender, EventArgs e)
        {
            if (emailTB.Text == "Email")
            {
                emailTB.Text = "";
                emailTB.ForeColor = Color.Black;
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

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (emailTB.Text == "")
            {
                emailTB.Text = "Email";
                emailTB.ForeColor = Color.Gray;
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
    }
}
