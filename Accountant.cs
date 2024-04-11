using System;
using System.Collections.Generic;
using PTOApp;

namespace PTOApp {
    // Accountant subclass
    public class Accountant : User
    {
        private double empSalary;
        private int accID;
    
        public Accountant
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
            double EmpSalary,
            int AccID
            )
            : base(sin, lname, fname, dob, address, email, phone, startDate, endDate) 
        {
            EmpSalary = empSalary;
            AccID = accID;
        }

        public List<string> SendNotification(int AccID)
        {
            // Example implementation test
            var notifications = new List<string>();
            if (this.accID == AccID)
            {
                notifications.Add("You have pending PTO payouts to review.");
            }
            else
            {
                notifications.Add($"No pending tasks for accountant ID: {AccID}.");
            }
            return notifications;
        }

        public bool ApprovePTOPayout(int PTOID)
        {
            var ptoRequest = PTORequest.GetPTORequestById(PTOID);
            if (ptoRequest != null)
            {
                // Logic to approve the PTO payout
                return true;
            }
            return false;
        }

        public bool IssuePayment(int PTOID)
        {
            var ptoRequest = PTORequest.GetPTORequestById(PTOID);
            if (ptoRequest != null)
            {
                // Logic to issue the payment
                
                return ptoRequest.GetFullPTODetails(); // Added to PTORequest.cs
            }
            return null; 
        }
    }
}