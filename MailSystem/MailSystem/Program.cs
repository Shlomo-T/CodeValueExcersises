using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating and signing to MailManager and running timer that simulating messages that sent to the MailManager
            MailManager mgr= new MailManager();
            mgr.MailArrived += Mgr_MailArrived;
            Timer timer = new Timer(EventsSimulatorCallbck, mgr, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

            Console.ReadKey();
        }

        private static void Mgr_MailArrived(object sender, MailArrivedEventArgs e)
        {
            var title = !string.IsNullOrEmpty(e.Title) ? e.Title : string.Empty;
            var body = !string.IsNullOrEmpty(e.Body) ? e.Body : string.Empty;

            Console.WriteLine($"Message title: {title}, Message body: {body}");
        }

        private static void EventsSimulatorCallbck(Object obj)
        {
            // this callback simulating mail messaging
            var mgr = obj as MailManager;
            if (mgr != null)
            {
                mgr.SimulateMailArrived("Hi all", "This is the message body");
            }
        }
    }
}
