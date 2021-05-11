using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BusinessLine : BaseModel
    {
        [Column("ID")]
        [Key]
        [Required]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
