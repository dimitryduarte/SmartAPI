using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartAPI.Entidades.Entidades;

namespace SmartAPI.Dados.Repositorios
{
    public interface IFuncionariosRepositorio
    {
        IQueryable<TB_FUNCIONARIOS> BuscarFuncionarios();
        IQueryable<TB_FUNCIONARIOSAGRUP> BuscarFuncionariosUF();
        Boolean ExcluirFuncionarioCpf(string Cpf);
        TB_FUNCIONARIOS InserirFuncionario(TB_FUNCIONARIOS entidade);
    }
}
