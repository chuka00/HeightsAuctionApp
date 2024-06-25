using AutoMapper;
using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Context;
using HeightsAuction.DAL.Entities;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Services
{
    public class BidService : IBidService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public BidService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BidDto> SubmitBid(BidDto bidDto)
        {
            var bid = _mapper.Map<Bid>(bidDto);
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync();
            return _mapper.Map<BidDto>(bid);
        }
        public async Task<List<BidDto>> GetBids(int roomId)
        {
            var bids = await _context.Bids.Where(b => b.RoomId == roomId).ToListAsync();
            return _mapper.Map<List<BidDto>>(bids);
        }
    }
}
