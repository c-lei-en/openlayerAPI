using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace openlayerAPI.Dynastys
{
    [Table("Dynasty")]
    public class Dynasty : Entity<int>
    {
        [Required]
        [StringLength(5)]
        public string Dnt { get; set; }

        [Required]
        [StringLength(20000)]
        public string Ifm { get; set; }
    }
}
