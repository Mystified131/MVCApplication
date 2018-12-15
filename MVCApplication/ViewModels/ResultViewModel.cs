using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        [Required]
        public double sidelength { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public String Error { get; set; }
    }
}


