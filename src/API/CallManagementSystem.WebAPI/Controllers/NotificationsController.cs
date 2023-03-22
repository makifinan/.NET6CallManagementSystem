using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallManagementSystem.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class NotificationsController : Controller
    {
        private readonly INotificationWriteRepository _notificationWriteRepository;
        private readonly INotificationReadRepository _notificationReadRepository;

        public NotificationsController(INotificationWriteRepository notificationWriteRepository, INotificationReadRepository notificationReadRepository)
        {
            _notificationWriteRepository = notificationWriteRepository;
            _notificationReadRepository = notificationReadRepository;
        }
    }
}

