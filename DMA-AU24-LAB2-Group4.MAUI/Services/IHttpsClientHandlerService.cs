﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.MAUI.Services
{
    public interface IHttpsClientHandlerService
    {
        HttpMessageHandler GetPlatformMessageHandler();
    }
}
