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
    public class InvoiceService : IInvoiceService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public InvoiceService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<InvoiceDto> CreateInvoice(InvoiceDto invoiceDto)
        {
            var invoice = _mapper.Map<Invoice>(invoiceDto);
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return _mapper.Map<InvoiceDto>(invoice);
        }
    }
}
