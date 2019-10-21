﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace openlayerAPI.Registers.Dto
{
    [AutoMapFrom(typeof(Register))]
    public class RegisterDto
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}
