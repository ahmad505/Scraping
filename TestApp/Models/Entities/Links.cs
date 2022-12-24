using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.Entities
{
    public class Links
    {
        [Key]
        public int id { get; set; }
        public string Link { get; set; }
    }
}
