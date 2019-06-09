using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blogpost.Models
{
    [Table("blgtable")]
    public class blg
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="This filed is required"),MinLength(3,ErrorMessage ="Minimum 3 charectors required")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
