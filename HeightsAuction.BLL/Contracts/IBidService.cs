using HeightsAuction.DAL.Mapping.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Contracts
{
    public interface IBidService
    {
        Task<BidDto> SubmitBid(BidDto bidDto);
        Task<List<BidDto>> GetBids(int roomId);
    }
}
