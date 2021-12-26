using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webproje2021.Models
{
    public class urunler
    {
        public int Id { get; set; }

        public string urunadi { get; set; }

        public int kalori { get; set; }

        public float fiyati { get; set; }

        public string resim { get; set; }

        public kategori kategori { get; set; }
    }

    public enum kategori
    {
        Pizza,Salata,Noodle
    }
}
