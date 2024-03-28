using System;
using System.Collections.Generic;
using PTOApp;

namespace PTOApp
{
    
    // HumanResource subclass
    public class HumanResource : User
    {
        public HumanResource(int sin, string lname, string fname, DateTime dob, 
            string address, string email, string phone, DateTime startDate, DateTime endDate)
            : base(sin, lname, fname, dob, address, email, phone, startDate, endDate) 
        {
        
        }
        public List<string> SendNotification(int EmpID)
        {
            // Logic to send notification
            return new List<string>(); // Assuming list of notification messages to return
        }

        public void SendNotificationPTO(int PTOID)
        {
            // Logic to send PTO notification
        }
    }

}
