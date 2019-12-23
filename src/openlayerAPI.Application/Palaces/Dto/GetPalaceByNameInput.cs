using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace openlayerAPI.Palaces.Dto
{
    public class GetPalaceByNameInput
    {
        [Required]
        public string Name { get; set; }
    }
}
