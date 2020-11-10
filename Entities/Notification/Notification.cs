using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Notification
{
    public class Notification
    {
        public Notification()
        {
            MyNotifies = new List<Notification>();
        }

        public string MyProperty { get; set; }
        public string MyMessage { get; set; }
        public List<Notification> MyNotifies { get; set; }
    }
}
