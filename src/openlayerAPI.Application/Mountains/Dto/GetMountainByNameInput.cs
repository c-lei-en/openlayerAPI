using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace openlayerAPI.Mountains.Dto
{
    public class GetMountainByNameInput
    {
        [Required]
        public string Name { get; set; }
    }
}
