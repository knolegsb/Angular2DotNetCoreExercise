using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2DotNetCoreExcercise.Data
{
    public class FriendDetails
    {
        [Key]
        public int FriendDetailId { get; set; }

        [Required]
        [Display(Name = "FriendId")]
        public int FriendId { get; set; }

        [Required]
        [Display(Name = "Major")]
        public string Major { get; set; }

        [Required]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [Required]
        [Display(Name = "Term")]
        public string Term { get; set; }

        public string Grade { get; set; } 
    }
}
