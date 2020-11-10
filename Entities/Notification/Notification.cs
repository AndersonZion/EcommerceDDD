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


        public bool AssertArgumentEquals( object object1, object object2, string strProperty)
        {
            if (object1.Equals(object2))
            {
                return true;
            }
            else
            {
                MyNotifies.Add(new Notification
                {
                    MyMessage = string.Format(""),
                    MyProperty = strProperty
                });
                return false;
            }

        }


    }
}
