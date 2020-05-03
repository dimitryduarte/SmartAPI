using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartAPI.Entidades.Dto.Entidades;
using SmartAPI.Entidades.Entidades;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using SmartAPI.Dados.Repositorios;

namespace SmartAPI.Business.Serviços
{
    public class FuncionarioServico
    {
        #region Variáveis     
        public FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
        #endregion

        #region Serviços de Busca

        public IEnumerable<FuncionariosGetDTO> BuscarFuncionarios(FuncionariosGetDTO modelo)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (!string.IsNullOrEmpty(modelo.Cargo))
                {
                    consulta = consulta.Where(Func => Func.Cargo == modelo.Cargo);
                }

                if (!string.IsNullOrEmpty(modelo.Cpf))
                {
                    consulta = consulta.Where(Func => Func.Cpf == modelo.Cpf);
                }

                if (!string.IsNullOrEmpty(modelo.Nome))
                {
                    consulta = consulta.Where(Func => Func.Nome == modelo.Nome);
                }

                if (!string.IsNullOrEmpty(modelo.UfNasc))
                {
                    consulta = consulta.Where(Func => Func.UfNasc == modelo.UfNasc);
                }

                if (modelo.Salario > 0)
                {
                    consulta = consulta.Where(Func => Func.Salario == modelo.Salario);
                }

                if (!string.IsNullOrEmpty(modelo.Status))
                {
                    consulta = consulta.Where(Func => Func.Status == modelo.Status);
                }

                if (modelo.DataCad != DateTime.MinValue)
                {
                    consulta = consulta.Where(Func => Func.DataCad == modelo.DataCad);
                }

                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionarios()
        {
            try
            {                
                var consulta = repositorio.BuscarFuncionarios();
                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionariosNome(string nome)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (!string.IsNullOrEmpty(nome))
                {
                    consulta = consulta.Where(Func => Func.Nome == nome);
                }

                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionariosCpf(string Cpf)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (!string.IsNullOrEmpty(Cpf))
                {
                    consulta = consulta.Where(Func => Func.Cpf == Cpf);
                }

                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionariosCargo(string Cargo)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (!string.IsNullOrEmpty(Cargo))
                {
                    consulta = consulta.Where(Func => Func.Cargo == Cargo);
                }

                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionariosStatus(string Status)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (!string.IsNullOrEmpty(Status))
                {
                    consulta = consulta.Where(Func => Func.Status == Status);
                }

                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionariosData(DateTime DataCad)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (DataCad != DateTime.MinValue)
                {
                    consulta = consulta.Where(Func => Func.DataCad == DataCad);
                }

                consulta = consulta.OrderBy(Func => Func.Nome);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosGetDTO> BuscarFuncionariosSalario(decimal SalInicial, decimal SalFinal)
        {
            try
            {
                var consulta = repositorio.BuscarFuncionarios();

                if (SalInicial >= 0)
                {
                    consulta = consulta.Where(Func => Func.Salario >= SalInicial);
                }

                if (SalFinal >= 0 && SalFinal >= SalInicial)
                {
                    consulta = consulta.Where(Func => Func.Salario <= SalFinal);
                }

                consulta = consulta.OrderBy(Func => Func.Salario);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosGetDTO
                                  {
                                      DataCad = Func.DataCad,
                                      Cargo = Func.Cargo,
                                      Cpf = Func.Cpf,
                                      Nome = Func.Nome,
                                      UfNasc = Func.UfNasc,
                                      Salario = Func.Salario,
                                      Status = Func.Status
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }
        public IEnumerable<FuncionariosAgrupUFDTO> BuscarFuncionariosUf()
        {
            try
            {
                var consulta = repositorio.BuscarFuncionariosUF();

                consulta = consulta.OrderBy(Func => Func.UfNasc);

                var respostaDTO = from Func in consulta.ToList()
                                  select new FuncionariosAgrupUFDTO
                                  {
                                      UfNasc = Func.UfNasc,
                                      Quant = Func.Quant
                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }

        #endregion

        #region Serviços de Exclusão
        public bool ExcluirFuncionarioCpf(string Cpf)
        {
            try
            {
                return repositorio.ExcluirFuncionarioCpf(Cpf);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir funcionário.", ex);
            }
        }
        #endregion

        #region Serviços de Inserção/Alteração
        public FuncionariosGetDTO InserirFuncionario(FuncionariosPostDTO Func)
        {
            try
            {

                var funcionario = new TB_FUNCIONARIOS()
                {
                    DataCad = DateTime.Today,
                    Cargo = Func.Cargo,
                    Cpf = Func.Cpf,
                    Nome = Func.Nome,
                    UfNasc = Func.UfNasc,
                    Salario = Func.Salario,
                    Status = Func.Status
                };

                funcionario = repositorio.InserirFuncionario(funcionario);

                FuncionariosGetDTO respostaDTO =  new FuncionariosGetDTO
                                                  {
                                                      DataCad = funcionario.DataCad,
                                                      Cargo = funcionario.Cargo,
                                                      Cpf = funcionario.Cpf,
                                                      Nome = funcionario.Nome,
                                                      UfNasc = funcionario.UfNasc,
                                                      Salario = funcionario.Salario,
                                                      Status = funcionario.Status
                                                  };

                return respostaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir/alterar o funcionário.", ex);
            }

        }
        #endregion
    }
}