using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace openlayerAPI.FamousPeoples
{
    [Table("FamousPeople")]
    public class FamousPeople : Entity<int>
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20000)]
        public string Information { get; set; }
    }
}
