using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectCalc1.Models
{
    public class CalcModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = " Input1 should not be zero or negative")]
        public double Input1 { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = " Enter only positive integer value in Input2")]
        public double Input2 { get; set; }
    }
}
