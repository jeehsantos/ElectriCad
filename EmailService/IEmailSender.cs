﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
