using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HeightsAuctionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send-email")]
        public async Task<IActionResult> SendEmail([FromBody] EmailDto emailDto)
        {
            await _notificationService.SendEmailAsync(emailDto.To, emailDto.Subject, emailDto.Body);
            return Ok();
        }
    }
}
