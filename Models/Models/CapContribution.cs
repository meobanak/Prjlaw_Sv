using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CapContribution : BaseModel
    {
        [Required]
        public string CompanyID { get; set; }
        [Key]
        [Required]
        public string CapMemberName { get; set; }
        [Required]
        public string NationalityID { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
