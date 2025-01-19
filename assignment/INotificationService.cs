using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal interface INotificationService
    {
        //1-we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
        #region methods
        public void SendNotification(string recipient, string message);

        #endregion
    }
}
