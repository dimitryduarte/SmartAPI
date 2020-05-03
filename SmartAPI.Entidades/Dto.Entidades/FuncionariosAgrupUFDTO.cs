using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartAPI.Entidades.Dto.Entidades
{
    public class FuncionariosAgrupUFDTO
    {
        /// <summary>
        /// UF de nascimento dos funcionários       
        /// </summary>
        public string UfNasc { get; set; }

        /// <summary>
        /// Quantidade de funcionários por UF
        /// </summary>
        public int Quant { get; set; }
    }
}