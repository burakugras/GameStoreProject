﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests
{
    public class CreateCampaignRequest
    {
        public string Name { get; set; }
        public float? Discount { get; set; }
    }
}
