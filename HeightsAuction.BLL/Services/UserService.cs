using AutoMapper;
using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Context;
using HeightsAuction.DAL.Entities;
using HeightsAuction.DAL.Mapping.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public UserService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDto> CreateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return _mapper.Map<UserDto>(user);
        }
    }
}
