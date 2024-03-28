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
            // Implementation for sending a notification
            return new List<string>(); //to be adjusted
        }
        public bool ApprovePTOPayout(int PTOID) 
        { 
            //implementation for approving PTO payout
            return false; //bool based on logic
        }
        public bool IssuePayment(int PTOID) 
        {
            // Implementation for issuing a payment
            return false;
        }
    }
}