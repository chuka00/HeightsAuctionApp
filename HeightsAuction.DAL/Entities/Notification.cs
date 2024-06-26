using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.DAL.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserId { get; set; }
        public bool IsRead { get; set; }
    }
}
