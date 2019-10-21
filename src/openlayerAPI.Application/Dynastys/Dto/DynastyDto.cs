using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace openlayerAPI.Dynastys.Dto
{
    [AutoMapFrom(typeof(Dynasty))]
    public class DynastyDto
    {
        public string Dnt { get; set; }

        public string Ifm { get; set; }
    }
}
