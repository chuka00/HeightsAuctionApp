﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsAuction.BLL.Contracts
{
    public interface INotificationService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
