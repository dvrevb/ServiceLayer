using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Business.Abstract;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;
using Urprog.DataAccess.Abstract;

namespace Urprog.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDataAccess _notificationDataAccess;


        public NotificationManager(INotificationDataAccess notificationDataAccess)
        {
            _notificationDataAccess = notificationDataAccess;
        }

        public GetOneResult<Notification> CreateOne(Notification notification)
        {
            GetOneResult<Notification> result = _notificationDataAccess.InsertOne(notification);
            return result;
        }

        public async Task<GetOneResult<Notification>> DeleteNotificationByIdAsync(string notification_id)
        {
            GetOneResult<Notification> result =await _notificationDataAccess.DeleteByIdAsync(notification_id);
            return result;
        }

        public GetManyResult<Notification> GetNotifications(string receiver_id)
        {
            var notificationList = _notificationDataAccess.FilterBy(n => n.ReceiverId == receiver_id);
            return notificationList;
        }
    }
}
