using HeightsAuction.BLL.Contracts;
using HeightsAuction.DAL.Mapping.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly string _paystackSecretKey = "your_paystack_secret_key";

        public Task<string> ProcessPayment(InvoiceDto invoiceDto)
        {
            throw new NotImplementedException();
        }
        /* private readonly PaystackTransaction _paystackTransaction;

public PaymentService()
{
    _paystackTransaction = new PaystackTransaction(_paystackSecretKey);
}*/

        /* public async Task<string> ProcessPayment(InvoiceDto invoiceDto)
         {
             var response = await _paystackTransaction.InitializeTransaction(new TransactionInitializeRequest
             {
                 AmountInKobo = (int)(invoiceDto.Amount * 100),
                 Email = "customer@example.com", // Fetch user's email from the database
                 Reference = "unique_transaction_reference",
                 CallbackUrl = "your_callback_url"
             });

             if (response.Status)
             {
                 return response.Data.AuthorizationUrl;
             }

             throw new Exception(response.Message);
         }*/
    }
}
