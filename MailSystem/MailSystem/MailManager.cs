using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    public class MailManager
    {
        public event EventHandler<MailArrivedEventArgs> MailArrived;

        protected virtual void OnOnMailArrived(MailArrivedEventArgs e)
        {
            if (MailArrived != null)
            {
                MailArrived(this, e);
            }
        }
       
        public void SimulateMailArrived(string title,string body)
        {
            OnOnMailArrived(new MailArrivedEventArgs(title,body));
        }
    }

    public class MailArrivedEventArgs
    {
        private string _mTitle;
        private string _mBody;

        public MailArrivedEventArgs(string title, string body)
        {
            _mTitle = title;
            _mBody = body;
        }
        public string Title { get { return _mTitle; } }
        public string Body { get { return _mBody; } }
    }
}
