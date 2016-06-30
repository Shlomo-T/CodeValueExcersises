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
            MailManager mgr= new MailManager();
            mgr.MailArrived += Mgr_MailArrived;
            Timer timer = new Timer(EventsCallbck, mgr, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

            Console.ReadKey();
        }

        private static void Mgr_MailArrived(object sender, MailArrivedEventArgs e)
        {
            Console.WriteLine($"Message title: {e.Title}, Message body: {e.Body}");
        }

        private static void EventsCallbck(Object obj)
        {
            var mgr = obj as MailManager;
            if (mgr != null)
            {
                mgr.SimulateMailArrived("Hi all", "This is the message body");
            }
        }
    }
}
