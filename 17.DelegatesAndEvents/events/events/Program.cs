using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Program
    {
        static void Main()
        {
            var registerUser = new RegisterUser();
            var emailVerification = new EmailVerification();
            var smsVerification = new SMSVerification();
            registerUser.registerUserEvent += emailVerification.OnUserRegistered; //subscribe to an event  
            registerUser.registerUserEvent += smsVerification.OnUserRegistered; //subscribe to an event  
            registerUser.RegisterAUser(); // publisher  
            Console.ReadLine();
        }
    }
    public class RegisterUser
    {
        public delegate void registerUserEventHandler(object source, EventArgs Args); //define a delegate  
        public event registerUserEventHandler registerUserEvent; // define an event  
        public void RegisterAUser()
        {
            Console.WriteLine("User registered");
            if (registerUserEvent != null)
            {
                registerUserEvent(this, EventArgs.Empty); // call event  
            }
        }
    }
    public class EmailVerification
    {
        public void OnUserRegistered(object source, EventArgs e)
        {
            Console.WriteLine("Sent Email for Verification");
        }
    }
    public class SMSVerification
    {
        public void OnUserRegistered(object source, EventArgs e)
        {
            Console.WriteLine("Sent SMS for Verification");
        }
    }
}
