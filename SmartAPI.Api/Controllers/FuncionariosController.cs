using System;
using System.Collections.Generic;
using SmartAPI.Api.App_Start;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartAPI.Entidades.Dto.Entidades;
using SmartAPI.Business.Serviços;
using SmartAPI.Dados.Contexto;
using Swashbuckle.Swagger.Annotations;
using System.Web.Http.Description;

namespace SmartAPI.Api.Controllers
{
    [RoutePrefix("api")]
    public class FuncionariosController : ApiController
    {
        #region GET

        #region Consultar dados dos funcionários geral/dinâmico
        /// <summary>
        /// Método que disponibiliza dados dos funcionários - geral/dinâmico
        /// </summary>  
        /// <param name="modelo">FuncionariosGetDTO</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult Listarfuncionarios([FromUri]FuncionariosGetDTO modelo)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

                try
                {
                    if (modelo is null)
                        ListaFuncionarios = negocio.BuscarFuncionarios();
                    else
                        ListaFuncionarios = negocio.BuscarFuncionarios(modelo);

                    if (ListaFuncionarios != null)
                    {
                        return Ok(ListaFuncionarios);
                    }
                    else
                    {
                        return InternalServerError();
                    }
                }
                catch(Exception e)
                {
                    throw e;
                }

        }
        #endregion

        #region Consultar dados dos funcionários por Nome
        /// <summary>
        /// Método que disponibiliza informações dos funcionários por nome
        /// </summary>  
        /// <param name="nome">Nome completo Ex.: Abbey Aadland </param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios-nome")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ListarfuncionariosNome([FromUri]string nome)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

            try
            {
                ListaFuncionarios = negocio.BuscarFuncionariosNome(nome);

                if (ListaFuncionarios != null)
                {
                    return Ok(ListaFuncionarios);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Consultar dados dos funcionários por Cpf
        /// <summary>
        /// Método que disponibiliza informações dos funcionários por Cpf
        /// </summary>  
        /// <param name="cpf">CPF sem acentuação - Ex. 42246917701</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios-cpf")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ListarfuncionariosCpf([FromUri]string Cpf)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

            try
            {
                ListaFuncionarios = negocio.BuscarFuncionariosCpf(Cpf);

                if (ListaFuncionarios != null)
                {
                    return Ok(ListaFuncionarios);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Consultar dados dos funcionários por Cargo
        /// <summary>
        /// Método que disponibiliza informações dos funcionários por Cargo
        /// </summary>  
        /// <param name="cargo">AC Jr / AC Pl / AC Sr / Analista Jr / Analista Pl / Analista Sr / Dev Jr / Dev Pl / Dev Sr / PO Jr / PO Pl / PO Sr</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios-cargo")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ListarfuncionariosCargo([FromUri]string cargo)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

            try
            {
                ListaFuncionarios = negocio.BuscarFuncionariosCargo(cargo);

                if (ListaFuncionarios != null)
                {
                    return Ok(ListaFuncionarios);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Consultar dados dos funcionários por Status
        /// <summary>
        /// Método que disponibiliza informações dos funcionários por Status
        /// </summary>  
        /// <param name="status">ATIVO/BLOQUEADO</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios-status")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ListarfuncionariosStatus([FromUri]string status)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

            try
            {
                ListaFuncionarios = negocio.BuscarFuncionariosStatus(status);

                if (ListaFuncionarios != null)
                {
                    return Ok(ListaFuncionarios);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Consultar dados dos funcionários por Data
        /// <summary>
        /// Método que disponibiliza informações dos funcionários por Data
        /// </summary>  
        /// <param name="data">Formato: 2017-04-17T00:00:00</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios-data")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ListarfuncionariosData([FromUri]DateTime data)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

            try
            {
                ListaFuncionarios = negocio.BuscarFuncionariosData(data);

                if (ListaFuncionarios != null)
                {
                    return Ok(ListaFuncionarios);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Consultar Quantidade de funcionários por UF
        /// <summary>
        /// Método que disponibiliza a quantidade de funcionários por UF
        /// </summary>  
        /// <returns>FuncionariosAgrupUFDTO</returns>
        [HttpGet]
        [Route("funcionarios-por-uf")]
        [ResponseType(typeof(List<FuncionariosAgrupUFDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosAgrupUFDTO))]
        public IHttpActionResult ListarQuantfuncPorUf()
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosAgrupUFDTO> ListaUF = null;

            try
            {

                ListaUF = negocio.BuscarFuncionariosUf();

                if (ListaUF != null)
                {
                    return Ok(ListaUF);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Consultar dados dos funcionários por Salário
        /// <summary>
        /// Método que disponibiliza informações dos funcionários por Salário
        /// </summary>  
        /// <param name="SalInicial">Valor inicial para pesquisa de faixa de salário</param>
        /// <param name="SalFinal">Valor final para pesquisa de faixa de salário</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpGet]
        [Route("funcionarios-salario")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ListarfuncionariosSalario([FromUri]decimal SalInicial, decimal SalFinal)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            IEnumerable<FuncionariosGetDTO> ListaFuncionarios = null;

            try
            {
                ListaFuncionarios = negocio.BuscarFuncionariosSalario(SalInicial, SalFinal);

                if (ListaFuncionarios != null)
                {
                    return Ok(ListaFuncionarios);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #endregion

        #region DELETE
        #region Deletar dados do funcionário por Cpf
        /// <summary>
        /// Método que exclui informações dos funcionários por Cpf
        /// </summary>  
        /// <param name="cpf">CPF sem acentuação - Ex. 42246917701</param>
        /// <returns>FuncionariosGetDTO</returns>
        [HttpDelete]
        [Route("funcionarios-cpf")]
        //[ResponseType(String)]
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult ExcluirfuncionarioCpf([FromUri]string Cpf)
        {

            FuncionarioServico negocio = new FuncionarioServico();
            bool funcExcluido = false;

            try
            {
                funcExcluido = negocio.ExcluirFuncionarioCpf(Cpf);

                if (funcExcluido)
                {
                    return Ok("Funcionário excluído com sucesso!");
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
        #endregion

        #region POST
            #region Incluir dados do funcionário
        /// <summary>
        /// Método que inclui/atualiza dados do funcionário
        /// </summary>  
        /// <param name="modelo">FuncionariosPostDTO</param>
        /// <returns>FuncionariosPostDTO</returns>
        [HttpPost]
        [Route("funcionarios-post")]
        [ResponseType(typeof(List<FuncionariosGetDTO>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FuncionariosGetDTO))]
        public IHttpActionResult InserirFuncionario([FromUri]FuncionariosPostDTO modelo)
        {
            FuncionarioServico negocio = new FuncionarioServico();
            FuncionariosGetDTO ListaFuncionario = null;

            try
            {
                if (modelo != null) ListaFuncionario = negocio.InserirFuncionario(modelo);
                return Created("", ListaFuncionario);

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        #endregion
        #endregion

    }
}
