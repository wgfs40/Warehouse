using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Application.Interfaces;
using Warehouse.Domain.Core.Notifications;

namespace Warehouse.UI.Web.Controllers
{
    public class ItemController : BaseController
    {
        private readonly IItemAppService _itemAppService;
        private const int maxPaged = 10;
        public ItemController(IItemAppService itemAppService,INotificationHandler<DomainNotification> notifications)
            :base(notifications)
        {
            _itemAppService = itemAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("item-management/list-all")]
        public IActionResult Index()
        {
            var getallitem = _itemAppService.GetAllPaged(0,maxPaged);
            return View(getallitem);
        }
    }
}