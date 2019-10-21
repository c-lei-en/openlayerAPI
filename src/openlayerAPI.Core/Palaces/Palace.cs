using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace openlayerAPI.Palaces
{
    [Table("Palace")]
    public class Palace : Entity<int>
    {

        [Required]
        [StringLength(20000)]
        public string province { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Required]
        [StringLength(20000)]
        public string Information { get; set; }

    }
}
