using AutoMapper;
using HeightsAuction.DAL.Entities;
using HeightsAuction.DAL.Mapping.DTO;

namespace HeightsAuction.DAL.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // User mappings
            CreateMap<User, UserDto>().ReverseMap();

            // Room mappings
            CreateMap<Room, RoomDto>().ReverseMap();

            // Bid mappings
            CreateMap<Bid, BidDto>().ReverseMap();

            // Invoice mappings
            CreateMap<Invoice, InvoiceDto>().ReverseMap();

            // Message mappings
            CreateMap<Message, MessageDto>().ReverseMap();

        }
    }
}
