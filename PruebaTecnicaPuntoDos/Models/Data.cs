using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaPuntoDos.Models
{
    public class Data
    {
        [Required]
        [Range(50, 500)]
        [Display(Name = "Number")]
        public int n { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }
    }
}
