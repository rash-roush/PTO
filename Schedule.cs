using System;
using System.Collections.Generic;

public class Schedule
{
    private int ScheduleID;
    private bool ScheduleConfirmation;
    private string MonthDisplayed;
    private string Employees;
    private string WeeksBeingUsedPTO;
    private string AssignedWeeks;
    public DateTime ReceiveDate;

    // Constructor
    public Schedule(int scheduleID, bool scheduleConfirmation, string monthDisplayed,
                    string employees, string weeksBeingUsedPTO, string assignedWeeks, DateTime receiveDate)
    {
        ScheduleID = scheduleID;
        ScheduleConfirmation = scheduleConfirmation;
        MonthDisplayed = monthDisplayed;
        Employees = employees;
        WeeksBeingUsedPTO = weeksBeingUsedPTO;
        AssignedWeeks = assignedWeeks;
        ReceiveDate = receiveDate;
    }

    // Methods
    public DateTime AssignSchedule(string ptoDate)
    {
        ReceiveDate = DateTime.ParseExact(ptoDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        return ReceiveDate;
    }

    // Method to send the schedule to a database handler or another storage mechanism
    public List<string> SendSchedule()
    {
        // Path to the file where schedules are saved
        string filePath = "Schedules.txt";
        // Format the schedule details as a string
        string scheduleDetails = $"ScheduleID: {ScheduleID}, " +
                                 $"ScheduleConfirmation: {ScheduleConfirmation}, " +
                                 $"MonthDisplayed: {MonthDisplayed}, " +
                                 $"Employees: {Employees}, " +
                                 $"WeeksBeingUsedPTO: {WeeksBeingUsedPTO}, " +
                                 $"AssignedWeeks: {AssignedWeeks}, " +
                                 $"ReceiveDate: {ReceiveDate.ToString("dd/MM/yyyy")}";

        // Append the new schedule to the file
        File.AppendAllText(filePath, scheduleDetails + Environment.NewLine);
    }
}
