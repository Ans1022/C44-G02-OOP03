using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaceQ3
{
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
