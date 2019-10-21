using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace openlayerAPI.Palaces.Dto
{
    [AutoMapFrom(typeof(Palace))]
    public class PalaceDto
    {
        public string Name { get; set; }

        public string province { get; set; }

        public string Information { get; set; }
    }
}
