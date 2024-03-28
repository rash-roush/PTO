using System;
using System.Collections.Generic;

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
        return true; // assuming documentation is received for this
    }
    public string StartRequest(int PTOID)  //michelle
    {
        // Logic to start the request for PTO form
        // Update UI to indicate that the PTO request process has started
    }
    public string InputInfo(int PTOID)
    {
        /* Implementation needed */ return "";
    }
    public string FormSent(int PTOID) //Michelle
    {
        // Logic to handle the event when a form is sent to the DBHandler
    }
    public void UpdatePTO()
    { 
        /* Implementation needed */ 
    }
    public int GetInformation(int PTOID) 
    {
        /* Implementation needed */ return 0; 
    }
    public int ConfirmSchedule(int ScheduleID) 
    {
        /* Implementation needed */ return 0;
    }
    public List<string> ViewPTOHistory() 
    {
        /* Implementation needed */ return new List<string>();
    }
    public List<string> FilterPTOHistory() 
    {
        /* Implementation needed */ return new List<string>();
    }
    public string UpdateRequest(int DOCID, int EmpID) 
    {
        /* Implementation needed */ return ""; 
    }
    public string GetRequestStatus(int DOCID, int EmpID) 
    { 
        /* Implementation needed */ return ""; 
    }
    public List<string> StartPTOPlan() 
    {
        /* Implementation needed */ return new List<string>(); 
    }
    public List<string> SelectWeeksPTOPlan() 
    { 
        /* Implementation needed */ return new List<string>(); 
    }
    public List<string> ViewSchedule(int PTOPlanID) 
    {
        /* Implementation needed */ return new List<string>(); 
    }
}
