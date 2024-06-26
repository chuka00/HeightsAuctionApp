using HeightsAuction.BLL;
using HeightsAuction.BLL.Contracts;
using HeightsAuction.BLL.Services;
using HeightsAuction.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace HeightsAuctionApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AuctionDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

            //builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IRoomService, RoomService>();
            builder.Services.AddTransient<IBidService, BidService>();
            builder.Services.AddTransient<IInvoiceService, InvoiceService>();
            builder.Services.AddTransient<IPaymentService, PaymentService>();
            builder.Services.AddTransient<IMessageService, MessageService>();
            builder.Services.AddTransient<INotificationService, NotificationService>();

            builder.Services.AddSignalR();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<AuctionHub>("/auctionHub");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AuctionChatApp V1");
            });

            app.Run();
        }
    }
}
