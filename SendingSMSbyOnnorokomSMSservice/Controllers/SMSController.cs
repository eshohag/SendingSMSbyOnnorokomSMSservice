using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendingSMSbyOnnorokomSMSservice.com.onnorokomsms.api2;

namespace SendingSMSbyOnnorokomSMSservice.Controllers
{
    public class SMSController : Controller
    {
        // GET: SMS
        public ActionResult Send()
        {
          var allNumbersForReminderSMS=new List<string>()
            {
                "01847348931",
                "01926029000",
                "01640661944"
               
            };
            try
            {
                var sms = new SendSms();
                foreach (string number in allNumbersForReminderSMS)
                {
                    string result = sms.OneToOne("UserName", "Password", number, "Hi there, Quick reminder for tomorrow all day your location\'s polio vaccination day. \nReminder from Child Health Care Reminder System!", "User", "DemoMask", "Child Health Care!");
                }
                //string mul=sms.OneToMany("UserName", "Password", "Hi there, Quick reminder for tomorrow all day your location\'s polio vaccination day. \nReminder from Child Health Care Reminder System",allNumbersForReminderSMS, "User Type", "DemoMask", "Test by CampaignName");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

            return Content("Failed");
        }
    }
}