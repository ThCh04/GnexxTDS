﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnexx.Services.DTOs.Account
{
    public class AcceptResponse
    {
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
