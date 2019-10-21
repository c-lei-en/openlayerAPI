using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace openlayerAPI.Dynastys.Dto
{
    public class GetDynastyByDntInput
    {
        [Required]
        public string Dnt { get; set; }

        [Required]
        public string Ifm { get; set; }
    }
}
