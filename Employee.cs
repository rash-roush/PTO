//test git

using System;
using System.Collections.Generic;
using PTOApp;

namespace PTOApp
{

    // Employee subclass
    public class Employee : User
    {
        public int EmpID;
        public string EmpDepartment;
        public double EmpSalary;

        public Employee
            (
            int sin,
            string lname,
            string fname,
            DateTime dob,
            string address,
            string email,
            string phone,
            DateTime startDate,
            DateTime endDate,
            int empID,
            string empDepartment,
            double empSalary
            )
            : base(sin, lname, fname, dob, address, email, phone, startDate, endDate)
        {
            EmpID = empID;
            EmpDepartment = empDepartment;
            EmpSalary = empSalary;
        }

        // Constructor
        public Employee(int empID, string empDepartment, double empSalary)
        {
            EmpID = empID;
            EmpDepartment = empDepartment;
            EmpSalary = empSalary;
        }

        // Methods

        private double GetSalary(int empID)
        {
            string filePath = @"path\to\your\employee_data.csv"; // Update with the actual file path
            try
            {
                // Read each line from the CSV file
                foreach (string line in File.ReadLines(filePath))
                {
                    string[] columns = line.Split(',');
                    // Assuming the first column is EmpID and the salary is in the third column
                    if (int.TryParse(columns[0], out int id) && id == empID)
                    {
                        // Try to parse the salary column
                        if (double.TryParse(columns[2], out double salary)) // Adjust the index [2] as necessary
                        {
                            return salary;
                        }
                        break; // Exit the loop if the employee is found
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return 0; // Return 0 or an appropriate default value if the salary is not found
        }
    }

    public void ViewPTOHistory()
    {
        DataTable dataTable = new DataTable();
        string[] csvLines = File.ReadAllLines(filePath);

        if (csvLines.Length > 0)
        {
            // Use the first line to add columns to DataTable
            string[] columnNames = csvLines[0].Split(',');
            foreach (string columnName in columnNames)
            {
                dataTable.Columns.Add(columnName);
            }

            // Add rows to DataTable
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(',');
                dataTable.Rows.Add(rowData);
            }
        }

        return dataTable;
    }
}



public void SubmitPTORequest(string comment, string priority, DateTime startDate, DateTime endDate)
{
    // Construct the record to be saved
    string record = $"Employee ID: {EmpID}, " +
                    $"Comment: {comment}, " +
                    $"Priority: {priority}, " +
                    $"Start Date: {startDate.ToShortDateString()}, " +
                    $"End Date: {endDate.ToShortDateString()}";

    // File path where the data will be saved
    string filePath = "PTORequestsData.txt";

    // Append the record to the file
    File.AppendAllText(filePath, record + Environment.NewLine);

    // Optionally, inform the user that the data has been saved
    MessageBox.Show("PTO request submitted successfully.", "Success");
}

// Method to submit PTO cancellation
public string SubmitPTOCancellation(DateTime startDate)
{
    string filePath = "PTORequestsData.txt";
    bool requestFound = false;

    // Read all lines from the file
    List<string> lines = File.ReadAllLines(filePath).ToList();

    // Process each line to find and update the request
    for (int i = 0; i < lines.Count; i++)
    {
        if (lines[i].Contains($"Employee ID: {EmpID}") && lines[i].Contains($"Start Date: {startDate.ToShortDateString()}"))
        {
            // Assuming the status of the request is part of the line
            lines[i] += " [Canceled]"; // Mark the request as canceled
            requestFound = true;
            break; // Assuming there's only one matching request
        }
    }

    // Write the updated lines back to the file
    File.WriteAllLines(filePath, lines);

    return requestFound ? "PTO request canceled successfully." : "PTO request not found.";
}


public string ReceiveSchedule(int scheduleID)
{
    const string filePath = "Schedules.txt"; // File containing schedules
    string scheduleDetails = string.Empty;

    try
    {
        // Check if the schedules file exists
        if (File.Exists(filePath))
        {
            // Read the file and find the line with the matching ScheduleID
            scheduleDetails = File.ReadLines(filePath)
                                  .FirstOrDefault(line => line.StartsWith($"ScheduleID: {scheduleID},"));

            if (!string.IsNullOrEmpty(scheduleDetails))
            {
                // For demonstration, we'll just return the schedule details
                return $"Schedule found: {scheduleDetails}";
            }
            else
            {
                return "Schedule not found.";
            }
        }
        else
        {
            return "Schedules file does not exist.";
        }
    }
    catch (Exception ex)
    {
        // Log or handle the exception as needed
        return $"An error occurred: {ex.Message}";
    }
}


