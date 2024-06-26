using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeightsAuctionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messagingService;

        public MessageController(IMessageService messagingService)
        {
            _messagingService = messagingService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] MessageDto messageDto)
        {
            await _messagingService.SendMessage(messageDto.User, messageDto.Message);
            return Ok();
        }
    }
}
