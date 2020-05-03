using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using SmartAPI.Dados.Contexto;
using SmartAPI.Entidades.Entidades;

namespace SmartAPI.Dados.Repositorios
{
    public class FuncionariosRepositorio  : IFuncionariosRepositorio
    {

        #region Variáveis

        private Context db = new Context();

        #endregion Variáveis

        public IQueryable<TB_FUNCIONARIOS> BuscarFuncionarios()
        {
            try
            {
                return db.TB_FUNCIONARIOS.Where(Func => Func.Nome != null).AsNoTracking();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }
        }

        public IQueryable<TB_FUNCIONARIOSAGRUP> BuscarFuncionariosUF()
        {
            try
            {
                return db.TB_FUNCIONARIOSAGRUP.AsNoTracking();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }

        public Boolean ExcluirFuncionarioCpf(string Cpf)
        {
            try
            {
                var remove = db.TB_FUNCIONARIOS.Where(Func => Func.Cpf == Cpf).FirstOrDefault();

                if (remove != null)
                {
                    db.TB_FUNCIONARIOS.Remove(remove);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }

        }

        public TB_FUNCIONARIOS InserirFuncionario(TB_FUNCIONARIOS entidade)
        {
            try
            {
                var existe = db.TB_FUNCIONARIOS.Where(Func => Func.Cpf == entidade.Cpf).FirstOrDefault();

                if (existe != null)
                {
                    existe.Cargo = entidade.Cargo;
                    existe.Nome = entidade.Nome;
                    existe.Salario = entidade.Salario;
                    existe.Status = entidade.Status;
                    existe.UfNasc = entidade.UfNasc;
                }
                else db.TB_FUNCIONARIOS.Add(entidade);

                db.SaveChanges();
                return entidade;

            }catch(Exception ex)
            {
                throw new Exception($"Erro ao buscar os funcionários.", ex);
            }
        }
    }
}