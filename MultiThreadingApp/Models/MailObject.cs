using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp.Models
{
    public class MailObject
    {
        public string To { get; set; }
        public string From { get; set; } = "testmail@gmail.com";
        public MailProviderType MyProperty { get; set; }
    }

    public enum MailProviderType
    {
        None = 0,
        Smtp = 1
    }
}
