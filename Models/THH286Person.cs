using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace THHBT2324.Models
{
    [Table("THH286Person")]
    public class THH286Person
    {
     [Key]
        public string THH286ID { get; set; }
        public string THH286Name { get; set;}
        public string THH286DiaChi   { get; set; } 
    }
}