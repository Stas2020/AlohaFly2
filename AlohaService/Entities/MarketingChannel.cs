﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlohaService.Entities
{
    public class MarketingChannel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}