using System;
using System.Collections.Generic;

public class PTOPlan
{
    public int PTOPlanID { get; set; }
    public DateTime StartDatePTOPlan { get; set; }
    public DateTime EndDatePTOPlan { get; set; }
    public string WeeksTakenPTO { get; set; }
    public double PTORemaining { get; set; }
    public bool ConfirmationReception { get; set; }

    private static int nextPTOPlanID = 1; // Static counter to generate unique PTOPlanID

    public PTOPlan()
    {
        PTOPlanID = nextPTOPlanID++;
    }

    // Constructor
    public PTOPlan(int ptoPlanID, string startDate, string endDate, double ptoRemaining)
    {
        PTOPlanID = ptoPlanID;
        StartDatePTOPlan = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        EndDatePTOPlan = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        PTORemaining = ptoRemaining;
    }

    // Method to create and save a PTO plan
    public void CreatePTOPlan(int empID, string startDate, string endDate, string weeksTaken, double ptoRemaining)
    {
        // Assigning PTO plan details
        StartDatePTOPlan = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        EndDatePTOPlan = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        WeeksTakenPTO = weeksTaken;
        PTORemaining = ptoRemaining;

        // Construct the plan details as a string
        string planDetails = $"PTOPlanID: {PTOPlanID}, EmpID: {empID}, " +
                             $"StartDate: {StartDatePTOPlan.ToString("dd/MM/yyyy")}, " +
                             $"EndDate: {EndDatePTOPlan.ToString("dd/MM/yyyy")}, " +
                             $"WeeksTaken: {WeeksTakenPTO}, PTORemaining: {PTORemaining}";

        // Path to the file where PTO plans are saved
        string filePath = "PTOPlans.txt";

        // Save the PTO plan by appending it to the file
        File.AppendAllText(filePath, planDetails + Environment.NewLine);
    }

    // Method to view a schedule by PTO Plan ID
    public List<string> ViewSchedule(int ptoPlanID)
    {
        public List<string> ViewSchedule(int ptoPlanID)
        {
            const string filePath = "Schedules.txt"; // File containing schedules
            List<string> scheduleDetails = new List<string>();

            try
            {
                // Check if the schedules file exists
                if (File.Exists(filePath))
                {
                    // Read the file and find the line with the matching PTOPlanID
                    string scheduleLine = File.ReadLines(filePath)
                                              .FirstOrDefault(line => line.Contains($"PTOPlanID: {ptoPlanID},"));

                    if (!string.IsNullOrEmpty(scheduleLine))
                    {
                        // Assuming the schedule details are comma-separated
                        string[] details = scheduleLine.Split(',');
                        foreach (string detail in details)
                        {
                            scheduleDetails.Add(detail.Trim());
                        }
                    }
                    else
                    {
                        scheduleDetails.Add("Schedule not found.");
                    }
                }
                else
                {
                    scheduleDetails.Add("Schedules file does not exist.");
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                scheduleDetails.Add($"An error occurred: {ex.Message}");
            }

            return scheduleDetails;
        }
    }

}
