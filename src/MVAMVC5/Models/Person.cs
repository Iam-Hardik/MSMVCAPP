using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC5.Models
{
    public class person
    {
        [Required]
        [StringLength(8,ErrorMessage ="this is wrong",MinimumLength =0)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
