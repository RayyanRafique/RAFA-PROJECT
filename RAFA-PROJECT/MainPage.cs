using MongoDB.Driver;
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
        private readonly MongoClient _client;
        private readonly string _userId;
        string username;
        public MainPage(string Username, string userId, MongoClient mongoClient)
        {
            InitializeComponent();
            _client = mongoClient;
            _userId = userId;
            this.username = Username;
            label1.Text = $"Hi, {username}!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();   
            doctor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(_client, _userId);
            patient.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            // log out
        }
    }
}
