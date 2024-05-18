using System;
using MongoDB.Driver;
using System.Windows.Forms;

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
            Application.Run(new Form1(client));
        }

        static void ConnectToMongoDB()
        {
            string connectionString = "mongodb://localhost:27017";

            try
            {
                // Create a new MongoClient instance
                client = new MongoClient(connectionString);

                // use 'client' to interact with your MongoDB server
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error connecting to MongoDB: {ex.Message}");
            }
        }
    }
}
