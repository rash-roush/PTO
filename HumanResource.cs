using System;
using System.Collections.Generic;
using PTOApp;

namespace PTOApp
{
    // HumanResource subclass
    //test 4 github commit and pushhh
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
            // Retrieve a list of PTOIDs for terminated employees from the DBHandler
            List<int> ptoIDs = DBHandler.GetPTOIDsForTerminatedEmployees();

            // Check if the specific PTOID is in the list of PTOIDs for terminated employees
            if (ptoIDs.Contains(PTOID))
            {
                // Logic to send PTO notification
                // Need to implement actual notification sending logic
                // For now let's just print a message
                Console.WriteLine($"Notification sent for PTOID: {PTOID}");
            }
            else
            {
                Console.WriteLine($"PTOID {PTOID} is not applicable for notification.");
            }
        }

}
