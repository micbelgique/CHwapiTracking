using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.ViewModels
{
    public abstract class ViewModelBase
    {
        public string Notification { get; private set; }

        public bool IsNotificationError { get; private set; }

        public void Error(string message)
        {
            Notification = message;
            IsNotificationError = true;
        }

        public void Notify(string message)
        {
            Notification = message;
            IsNotificationError = false;
        }
    }
}