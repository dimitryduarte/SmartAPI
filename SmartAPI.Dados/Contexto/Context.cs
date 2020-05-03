using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity.Infrastructure;
using SmartAPI.Entidades.Entidades;

namespace SmartAPI.Dados.Contexto
{
    public class Context : DbContext
    {
        //public Context() : base("desafioConnectionString")
        public Context() : base("Data Source=localhost;Initial Catalog=desafio;Integrated Security=True")
        {          
        }
        public DbSet<TB_FUNCIONARIOS> TB_FUNCIONARIOS { get; set; }
        public DbSet<TB_FUNCIONARIOSAGRUP> TB_FUNCIONARIOSAGRUP { get; set; }
    }
}