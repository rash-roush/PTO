using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Data.OleDb;

namespace YourNamespace // Replace with your actual namespace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new YourMainForm()); // Replace 'YourMainForm' with the actual name of your main form
        }
    }
}

// Excel DB trying it -rasha
using System;
using System.Data.OleDb;

class Program
{
    static void Main(string[] args)
    {
        // Connection string for Excel file
        string excelFilePath = @"C:\Users\Rashaa\Documents\W2024\BTM495\PTO_Request_Data.xlsx";
        string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={excelFilePath};Extended Properties='Excel 12.0;'";

        // Create connection to Excel file
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();

            // excel DB tryout -rasha

            // Insert data into "Employees" table
            string insertDataQuery = "INSERT INTO [Employees$] ([Id], [Name], [Age]) VALUES (1, 'John Doe', 30)";
            using (OleDbCommand command = new OleDbCommand(insertDataQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Retrieve data from "Employees" table
            string selectDataQuery = "SELECT * FROM [Employees$]";
            using (OleDbCommand command = new OleDbCommand(selectDataQuery, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                    }
                }
            }
        }
    }
}
