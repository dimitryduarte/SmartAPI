using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartAPI.Entidades.Dto.Entidades;
using SmartAPI.Entidades.Entidades;

namespace SmartAPI.Business.Serviços
{
    public interface IFuncionarioServico
    {
        // GET
        IEnumerable<FuncionariosGetDTO> BuscarFuncionarios(FuncionariosGetDTO modelo);
        IEnumerable<FuncionariosGetDTO> BuscarFuncionarios();
        IEnumerable<FuncionariosGetDTO> BuscarFuncionariosNome(string nome);
        IEnumerable<FuncionariosGetDTO> BuscarFuncionariosCpf(string Cpf);
        IEnumerable<FuncionariosGetDTO> BuscarFuncionariosCargo(string Cargo);
        IEnumerable<FuncionariosGetDTO> BuscarFuncionariosStatus(string Status);
        IEnumerable<FuncionariosGetDTO> BuscarFuncionariosData(DateTime DataCad);
        IEnumerable<FuncionariosGetDTO> BuscarFuncionariosSalario(decimal SalInicial, decimal SalFinal);
        IEnumerable<FuncionariosAgrupUFDTO> BuscarFuncionariosUf();

        //DELETE
        bool ExcluirFuncionarioCpf(string Cpf);

        //POST
        FuncionariosGetDTO InserirFuncionario(FuncionariosPostDTO Func);
    }
}
