﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses
{
    public class GetListCampaignResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Discount { get; set; }
    }
}
