using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "please enter {0}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter {0}")]
        public string Family { get; set; }

        public string WebSite { get; set; }

    }
}