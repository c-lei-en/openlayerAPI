﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace openlayerAPI.FamousPeoples.Dto
{
    public class GetFamousPeopleByNameInput
    {
        [Required]
        public string Name { get; set; }
    }
}
