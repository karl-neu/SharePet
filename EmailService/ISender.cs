﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public interface ISender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
