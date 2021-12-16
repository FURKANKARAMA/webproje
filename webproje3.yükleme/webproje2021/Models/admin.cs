using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webproje2021.Models
{
    public class admin
    {
        public int Id { get; set; }
        [Required]
        public string adminadi { get; set; }
        [Required]
        public string adminsifre { get; set; }
    }
}
