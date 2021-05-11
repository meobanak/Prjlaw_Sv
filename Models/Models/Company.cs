using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Company : BaseModel
    {
        [Key]
        [Required]
        public string ID { get; set; }
        [Required]
        public string NameVN { get; set; }
        [Required]
        public string NameEN { get; set; }
        [Required]
        public string InitName { get; set; }
        [Required]
        public int TypeID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int CharterCap { get; set; }
        [Required]
        public string BusinessLineID { get; set; }
        [Required]
        public string ContactName { get; set; }
    }
}
