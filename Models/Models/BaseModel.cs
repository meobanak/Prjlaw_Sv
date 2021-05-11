using System;
using System.Collections.Generic;
using System.Text;


namespace Models
{
    public class BaseModel
    {

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
