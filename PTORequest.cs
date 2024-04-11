using System;
using System.Collections.Generic;

public class PTORequest
{
    private int PTOID;
    private int PTOFiscalYear;
    private bool PTOTaken;
    private DateTime PTODate;
    private double PTOAmount;
    private bool PTOStatus;
    private int DOCID;
    private int PTOPlanID;
    private bool PaymentStatus;
    private string RequesterRole;
    private string PTOType;
    private string Department;
    private int YearlyBalance;
    private string Priority;

    // Constructor
    public PTORequest(int ptoID, int ptoFiscalYear, bool ptoTaken, DateTime ptoDate, double ptoAmount, bool ptoStatus, int docID, int ptoPlanID, bool paymentStatus, string requesterRole, string ptoType, string department, int yearlyBalance, string priority)
    {
        PTOID = ptoID;
        PTOFiscalYear = ptoFiscalYear;
        PTOTaken = ptoTaken;
        PTODate = ptoDate;
        PTOAmount = ptoAmount;
        PTOStatus = ptoStatus;
        DOCID = docID;
        PTOPlanID = ptoPlanID;
        PaymentStatus = paymentStatus;
        RequesterRole = requesterRole;
        PTOType = ptoType;
        Department = department;
        YearlyBalance = yearlyBalance;
        Priority = priority;
    }

    // Methods
    public string UpdateRequest(int PTOID) 
    {
        // Without a database, we can't really update anything, so just return a message.
        return $"Request with ID {updatedPTOID} updated to status: {newStatus}.";
    }
    // Verifies the PTO balance and returns a simulated value.
    public double VerifyPTOBalance()
    {
        // need DB
        return 10.0; // Simulated PTO balance
    }

    // Updates the PTO request, possibly including documentation.
    public void UpdatePTORequest(bool withDocumentation)
    {
        // need DB
    }

    // Calculates the PTO based on some business rules and returns a simulated value.
    public double CalculatePTO()
    {
        //need DB
        return 8.0; // Simulated PTO value
    }

    // Retrieves the request date and returns a simulated value.
    public DateTime GetRequestDate()
    {
       //need DB
        return new DateTime(2024, 1, 1); 
    }

    // Gets the request status and returns a simulated value.
    public string GetRequestStatus()
    {
        
        return "Approved"; // Simulated status
    }

    // Receives a new duration for the PTO request and returns a simulated value.
    public int ReceivedNewDuration(DateTime newEndDate)
    {
        //need a DB
        return 1; // Simulated success code
    }

    // Sends data to the DBHandler and returns a simulated value.
    public int SendData(int DBHandlerID)
    {
        // The logic would send data to the DBHandler identified by DBHandlerID.
        return DBHandlerID; 
    }

    // Receives PTO information based on the PTOID and returns a list of simulated details.
    public List<string> ReceivePTOInfo(int PTOID)
    {
        // need db
        return new List<string> { $"Info for PTO ID {PTOID}" }; // Simulated info
    }

    // Views the PTO history and returns a list of simulated history records.
    public List<string> ViewPTOHistory()
    {
        // Return a placeholder list of PTO history records.
        return new List<string> { "PTO Record 1", "PTO Record 2" }; 
    }

    // Sends the PTO plan and returns a simulated success status.
    public bool SendPTOPlan(int PTOPlanID)
    {
       
        return true; // Simulated success
    }

    // Receives PTO information and returns a list of simulated details.
    public List<string> ReceivePTOInfo()
    {
     
        return new List<string> { "General PTO Info 1", "General PTO Info 2" }; // Simulated info
    }


    // for Accountant.cs
    public static PTORequest GetPTORequestById(int ptoID)
    {
        
        return AllPTORequests.FirstOrDefault(req => req.PTOID == ptoID);
    }

    public List<string> GetFullPTODetails()
    {
        var details = new List<string>
    {
        $"PTOID: {PTOID}",
        $"Fiscal Year: {PTOFiscalYear}",
        // Add other details here
    };
        return details;
    }

}



