using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace day_two.Models
{
    public class Product
    {
        [Key]
        public int ProduceID { get; set; }
        public string Description { get; set; }
    }

}
