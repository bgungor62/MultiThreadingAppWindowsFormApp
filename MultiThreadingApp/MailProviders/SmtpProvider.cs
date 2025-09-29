using MultiThreadingApp.MailProviders.Base;
using MultiThreadingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp.MailProviders
{
    public class SmtpProvider : BaseProvider
    {
        public override async Task Send(MailObject mailObject)
        {
            //send mail
            await Task.Delay(10);
            LogManager.Default.Log(
                $"{mailObject.To} adresine Mail Gönderildi");
        }
    }
}
