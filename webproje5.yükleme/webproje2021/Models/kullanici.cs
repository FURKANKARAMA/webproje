using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webproje2021.Models
{
    public class kullanici
    {
        public int Id { get; set; }
        [Required]
        public string kullaniciadi { get; set; }
        [Required]
        public string kullanicisifre { get; set; }
    }
}
