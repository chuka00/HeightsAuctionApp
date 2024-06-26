using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeightsAuctionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IBidService _bidService;

        public BidController(IBidService bidService)
        {
            _bidService = bidService;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitBid([FromBody] BidDto bidDto)
        {
            var createdBid = await _bidService.SubmitBid(bidDto);
            return Ok(createdBid);
        }

        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetBids(int roomId)
        {
            var bids = await _bidService.GetBids(roomId);
            return Ok(bids);
        }
    }
}
