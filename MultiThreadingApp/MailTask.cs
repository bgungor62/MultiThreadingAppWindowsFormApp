using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    public class MailTask
    {
        public Guid TaskId { get; set; } = Guid.NewGuid();
        public bool IsRunning { get; set; }
        public bool IsStarted { get; set; }
        public int Second { get; set; } = 60;

        public DateTime? NextRunning { get; set; }

        public async Task Run()
        {
            while (IsStarted)
            {
                IsRunning = true;

                ///


                IsRunning = false;
                NextRunning = DateTime.Now.AddSeconds(Second);

                await Task.Delay(Second * 1000);
            }
        }


        public void Start()
        {
            IsStarted = true;
            NextRunning = DateTime.Now.AddSeconds(Second);
        }

        public void Stop()
        {
            IsStarted = false;
        }
    }
}
