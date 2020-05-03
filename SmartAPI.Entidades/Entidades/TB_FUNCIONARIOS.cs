using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SmartAPI.Entidades.Entidades
{
    [Table(@"TB_FUNCIONARIOS")]
    public class TB_FUNCIONARIOS
    {
        [Column(name: @"DataCad")]
        public DateTime DataCad { get; set; }

        [Column(name: @"Cargo")]
        public string Cargo { get; set; }

        [Key()]
        [Column(name: @"CPF")]
        public string Cpf { get; set; }

        [Column(name: @"Nome")]
        public string Nome { get; set; }

        [Column(name: @"UfNasc")]
        public string UfNasc { get; set; }


        [Column(name: @"Salario")]
        public decimal Salario { get; set; }

        [Column(name: @"Status")]
        public string Status { get; set; }

    }
}