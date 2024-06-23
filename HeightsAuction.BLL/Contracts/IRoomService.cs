using HeightsAuction.DAL.Mapping.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Contracts
{
    public interface IRoomService
    {
        Task<RoomDto> CreateRoom(RoomDto roomDto);
        Task EnterRoom(int roomId, UserDto userDto);
    }
}
