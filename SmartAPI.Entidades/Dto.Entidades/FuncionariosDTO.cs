using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartAPI.Entidades.Dto.Entidades
{        
    /// <summary>
    /// Modelo de dados de consulta e retorno de funcionários     
    /// </summary>
    public class FuncionariosDTO
    {
        /// <summary>
        /// Data de Cadastro.        
        /// </summary>
        //[StringLength(50)]
        public DateTime DataCad { get; set; }

        /// <summary>
        /// Cargo do Funcionário
        /// </summary>
        [StringLength(50)]
        public string Cargo { get; set; }

        /// <summary>
        /// CPF do funcionário        
        /// </summary>
        [StringLength(50)]
        public string Cpf { get; set; }

        /// <summary>
        /// Nome do funcionário      
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Data de Nascimento do funcionário      
        /// </summary>
        [StringLength(2)]
        public string UfNasc { get; set; }

        /// <summary>
        /// Salário do funcionário   
        /// </summary>
        public decimal Salario { get; set; }

        /// <summary>
        /// Status do funcionário: ATIVO/BLOQUEADO      
        /// </summary>
        [StringLength(50)]
        public string Status { get; set; }
    }
}