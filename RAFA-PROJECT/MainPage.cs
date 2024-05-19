using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAFA_PROJECT
{
    public partial class MainPage : Form
    {
        string username;
        public MainPage(string Username)
        {
            InitializeComponent();
            this.username = Username;
            label1.Text = $"Hi, {username}!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // log out
        }
    }
}
