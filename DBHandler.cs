using System;
using System.Collections.Generic;

//Git hub push test 5

public class DBHandler
{
    //Private attributes
    private int DBID;
    private string DBName;
    private string DBServer;
    private DateTime FiscalYear;
    private int EmpID;
    private int PTOID;
    private List<string> EmpPTORecords;

    //Public attributes
    public bool PTOApproved { get; set; }
    public bool ApprovedPTOPayout { get; set; }
    public bool PTOStatus { get; set; }
    public double PTOBalance { get; set; }
    public bool ConfirmationPTOPlan { get; set; }
    public List<string> ScheduleView { get; set; }

    // Constructor
    public DBHandler(int dbid, string dbName, string dbServer, DateTime fiscalYear, int empID, int ptoID)
    {
        DBID = dbid;
        DBName = dbName;
        DBServer = dbServer;
        FiscalYear = fiscalYear;
        EmpID = empID;
        PTOID = ptoID;
        EmpPTORecords = new List<string>();
        ScheduleView = new List<string>();
    }

    // Methods
    public string InputDocumentation(int DOCID) //ask michelle 
    {

        // Return true if documentation is confirmed received, false otherwise
        return $"Documentation {DOCID} has been received and processed."; // assuming documentation is received for this
    }
    public string StartRequest(int PTOID)  //michelle
    {
        // Logic to start the request for PTO form
        // Update UI to indicate that the PTO request process has started
        return $"PTO request {PTOID} has been started.";
    }
    public string InputInfo(int PTOID)
    {
     
        return $"Additional information for PTO request {PTOID} has been saved.";
    }
    public string FormSent(int PTOID) //Michelle
    {
        // Logic to handle the event when a form is sent to the DBHandler
        return $"Form for PTO request {PTOID} has been sent.";
    }
    public void UpdatePTO()
    {
        // Actual implementation would update PTO records as necessary need DB again
    }
    public int GetInformation(int PTOID) 
    {
        {
            // Simulate a database query to fetch details for the given PTOID
            Dictionary<string, string> ptoDetails = new Dictionary<string, string>();

            return ptoDetails;
        }
    }
    public int ConfirmSchedule(int ScheduleID) 
    {
        //confirmation only 
        return 0;
    }
    public List<string> ViewPTOHistory() 
    {
        //returns past pto s
        {
            List<string> ptoHistory = new List<string>();


            return ptoHistory;
        }
    public List<string> FilterPTOHistory() 
    {
        // Ask jonathan //need DB before
         return new List<string>();
    }
    public string UpdateRequest(int DOCID, int EmpID) //ask kevin 
            return ""; 
    }
    
    public List<string> StartPTOPlan() //noemie
        // opens PTOPlan.vb
    {
        Process.Start("PTOPlan.vb");
    }
    public List<string> SelectWeeksPTOPlan() //noemie
    { 
        // need DB
        return new List<string>(); 
    }
    public List<string> ViewSchedule(int PTOPlanID) //noemie
        {
            // Retrieve the PTO Plan from storage DB
            PTOPlan ptoPlan = RetrievePTOPlanFromStorage(PTOPlanID); 

            // Check if PTOPlan was successfully retrieved
            if (ptoPlan == null)
            {
                throw new ArgumentException("No PTO Plan found with the provided ID.");
            }

            // Compile the PTO Plan details into a list of strings
            List<string> ptoPlanDetails = new List<string>
    {
        $"PTO Plan ID: {ptoPlan.PTOPlanID}",
        $"Start Date: {ptoPlan.StartDatePTOPlan.ToString("dd/MM/yyyy")}",
        $"End Date: {ptoPlan.EndDatePTOPlan.ToString("dd/MM/yyyy")}",
        $"Weeks Taken PTO: {ptoPlan.WeeksTakenPTO}",
        $"PTO Remaining: {ptoPlan.PTORemaining}",
        $"Confirmation Received: {ptoPlan.ConfirmationReception}"
    };

            return ptoPlanDetails;
        }
    }
