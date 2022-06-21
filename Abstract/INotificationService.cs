using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface INotificationService
    {
        GetOneResult<Notification> CreateOne(Notification notification);
        GetManyResult<Notification> GetNotifications(string receiver_id);
        Task<GetOneResult<Notification>> DeleteNotificationByIdAsync(string notification_id);
    }
}
