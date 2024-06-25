using AutoMapper;
using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Context;
using HeightsAuction.DAL.Entities;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.EntityFrameworkCore;

namespace HeightsAuction.BLL.Services
{
    public class RoomService : IRoomService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public RoomService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RoomDto> CreateRoom(RoomDto roomDto)
        {
            var room = _mapper.Map<Room>(roomDto);
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            return _mapper.Map<RoomDto>(room);
        }

        public async Task EnterRoom(int roomId, UserDto userDto)
        {
            var room = await _context.Rooms.Include(r => r.Users).FirstOrDefaultAsync(r => r.Id == roomId);
            if (room == null)
                throw new KeyNotFoundException("Room not found");

            var user = _mapper.Map<User>(userDto);
            room.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
