using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Mapping.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeightsAuctionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] InvoiceDto invoiceDto)
        {
            var createdInvoice = await _invoiceService.CreateInvoice(invoiceDto);
            return Ok(createdInvoice);
        }
    }
}
