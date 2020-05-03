using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SmartAPI.Entidades.Entidades
{
    [Table(@"TB_FUNCIONARIOSAGRUP")]
    public class TB_FUNCIONARIOSAGRUP
    {
        [Key()]
        [Column(name: @"UfNasc")]
        public string UfNasc { get; set; }

        [Column(name: @"Quant")]
        public int Quant { get; set; }
    }
}