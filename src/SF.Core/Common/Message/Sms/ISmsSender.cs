﻿using SF.Core.Extensions;
using SF.Core.WorkContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SF.Core.Common.Message.Sms
{
    public interface ISmsSender
    {
        Task SendSmsAsync(ISiteContext site, string number, string message);
    }
}
