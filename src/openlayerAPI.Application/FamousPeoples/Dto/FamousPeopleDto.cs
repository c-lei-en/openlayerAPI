using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace openlayerAPI.FamousPeoples.Dto
{
    [AutoMapFrom(typeof(FamousPeople))]
    public class FamousPeopleDto
    {
        public string Name { get; set; }
        
        public string Information { get; set; }
    }
}
