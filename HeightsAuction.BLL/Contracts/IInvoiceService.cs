using HeightsAuction.DAL.Mapping.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Contracts
{
    public interface IInvoiceService
    {
        Task<InvoiceDto> CreateInvoice(InvoiceDto invoiceDto);
    }
}
