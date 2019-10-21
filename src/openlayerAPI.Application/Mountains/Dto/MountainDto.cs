using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace openlayerAPI.Mountains.Dto
{
    [AutoMapFrom(typeof(Mountain))]
    public class MountainDto
    {
        public string Name { get; set; }

        public string Information { get; set; }
    }
}
