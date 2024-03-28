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
        /* Implementation needed */ return ""; 
    }
    public double VerifyPTOBalance() 
    { /* Implementation needed */ 
        return 0.0; 
    }
    public void UpdatePTORequest() //michelle
    {
        // Logic to update the PTO request with or without the documentation
        // The 'withDocumentation' parameter indicates if documentation is to be considered in the update
    }
    public double CalculatePTO() 
    {
        /* Implementation needed */ return 0.0; 
    }
    public DateTime GetRequestDate() 
    {
        /* Implementation needed */ return default(DateTime);
    }
    public string GetRequestStatus() 
    { 
        /* Implementation needed */ return ""; 
    }
    public int ReceivedNewDuration() 
    {
        /* Implementation needed */ return 0; 
    }
    public int SendData(int DBHandler) 
    {
        /* Implementation needed */ 
        return 0; 
    }
    public List<string> ReceivePTOInfo(int PTOID) 
    { 
        /* Implementation needed */ 
        return new List<string>(); 
    }
    public List<string> ViewPTOHistory() 
    { 
        /* Implementation needed */ 
        return new List<string>(); 
    }
    public bool SendPTOPlan(int PTOPlanID) 
    {
        /* Implementation needed */ 
        return false; 
    }
    public List<string> ReceivePTOInfo() 
    { 
        /* Implementation needed */ 
        return new List<string>(); 
    }
}
