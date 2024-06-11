using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using MongoDB.Driver;
namespace RAFA_PROJECT
{
    public partial class Patient : Form
    {
        private readonly MongoClient _client;
        private readonly string _userId;
        public Patient(MongoClient mongoClient, string userId)
        {
            InitializeComponent();
            _client = mongoClient;
            _userId = userId;
            SetupReminderTimer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)//save medicine button
        {
            string medicineName = textBox1.Text;
            string dosage = textBox2.Text;
            string intake = textBox3.Text;
            int quantity = int.Parse(textBox4.Text);
            string specialInstructions = textBox5.Text;
            DateTime timeToTake = dateTimePicker1.Value;

            var newMedicine = new Medicine
            {
                Name = medicineName,
                Dosage = dosage,
                Intake = intake,
                Quantity = quantity,
                SpecialInstructions = specialInstructions,
                TimeToTake = timeToTake
            };

            var database = _client.GetDatabase("ReLife");
            var usersCollection = database.GetCollection<User>("users");

            var filter = Builders<User>.Filter.Eq(u => u.Id, _userId);
            var update = Builders<User>.Update.Push(u => u.Medicines, newMedicine);

            await usersCollection.UpdateOneAsync(filter, update);

            MessageBox.Show("Medicine added successfully!");
        }
    

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private System.Timers.Timer _reminderTimer;

        private void SetupReminderTimer()
        {
            _reminderTimer = new System.Timers.Timer(60000); // Check every 60 seconds
            _reminderTimer.Elapsed += CheckMedicineReminders;
            _reminderTimer.Start();
        }

        private async void CheckMedicineReminders(object sender, ElapsedEventArgs e)
        {
            var database = _client.GetDatabase("ReLife");
            var usersCollection = database.GetCollection<User>("users");

            var user = await usersCollection.Find(u => u.Id == _userId).FirstOrDefaultAsync();
            if (user != null)
            {
                var now = DateTime.Now;
                var medicinesToTake = user.Medicines.Where(m => m.TimeToTake.TimeOfDay == now.TimeOfDay).ToList();

                foreach (var medicine in medicinesToTake)
                {
                    MessageBox.Show($"Time to take your medicine: {medicine.Name}\nDosage: {medicine.Dosage}\nSpecial Instructions: {medicine.SpecialInstructions}");
                    this.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
