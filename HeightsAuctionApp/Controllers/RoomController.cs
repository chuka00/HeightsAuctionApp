using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeightsAuctionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] RoomDto roomDto)
        {
            var createdRoom = await _roomService.CreateRoom(roomDto);
            return Ok(createdRoom);
        }

        [HttpPost("{roomId}/enter")]
        public async Task<IActionResult> EnterRoom(int roomId, [FromBody] UserDto userDto)
        {
            await _roomService.EnterRoom(roomId, userDto);
            return Ok();
        }
    }
}
