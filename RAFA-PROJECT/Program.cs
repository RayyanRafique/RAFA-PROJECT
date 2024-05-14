using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace RAFA_PROJECT
{
    internal static class Program
    {
        private static MongoClient client;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectToMongoDB();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void ConnectToMongoDB()
        {
            string connectionString = "mongodb://localhost:27017/";

            try
            {
                // Creating a new MongoClient instance
                client = new MongoClient(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to MongoDB: {ex.Message}");
            }
        }
    }
}
