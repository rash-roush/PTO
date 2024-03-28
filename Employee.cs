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



        public bool VerifyPTOStatus()
        {
            // Implementation needed
            return false;
        }

        public double GetSalary()
        {
            // Implementation needed
            return EmpSalary;
        }

        public void ViewSubmittedRequests()
        {
            // Implementation needed
        }

        public string GetRequestStatus()
        {
            // Implementation needed
            return "";
        }

        public string SubmitPTOModification()
        {
            // Implementation needed
            return "";
        }

        public string SubmitPTOCancellation()
        {
            // Implementation needed
            return "";
        }

        public string SubmitReasonModification()
        {
            // Implementation needed
            return "";
        }

        public string SubmitReasonCancellation()
        {
            // Implementation needed
            return "";
        }

        public void SetNewDuration(int newDuration)
        {
            // Implementation needed
        }

        public int ReceiveSchedule(int scheduleID)
        {
            // Implementation needed
            return 0;
        }

        public void ReviewRequest(int docID)
        {
            // Implementation needed
        }
    }
}
