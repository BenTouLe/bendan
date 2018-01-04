using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BenDan.Services
{
    public static class MessageServices
    {
        public static Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service
            return Task.FromResult(0);
        }

        public static Task SendSmsAsync(string number, string message)
        {
            // Plug in your sms service
            return Task.FromResult(0);
        }
    }
}
