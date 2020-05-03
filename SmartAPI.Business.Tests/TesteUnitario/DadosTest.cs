using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartAPI.Dados.Repositorios;
using SmartAPI.Entidades.Entidades;
using SmartAPI.Entidades.Dto.Entidades;
using System.Linq;

namespace SmartAPI.Business.Tests.TesteUnitario
{
    [TestClass]
    public class DadosTest
    {
        #region Teste de sucesso
        [TestMethod]
        public void InserirFuncionario_DeveRetornar()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
            TB_FUNCIONARIOS tb = new TB_FUNCIONARIOS();

            tb.Cargo = "PRESIDENTE";
            tb.Cpf = "111111111111";
            tb.DataCad = DateTime.Now;
            tb.Nome = "FULANO DA SILVA";
            tb.Salario = 8888;
            tb.Status = "ATIVO";
            tb.UfNasc = "SP";

            //Act
            var resultado = repositorio.InserirFuncionario(tb);

            //Assert
            Assert.AreEqual(tb, resultado);
        }
        [TestMethod]
        public void AlterarFuncionario_DeveRetornar()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
            TB_FUNCIONARIOS tb = new TB_FUNCIONARIOS();

            tb.Cargo = "PRESIDENTE";
            tb.Cpf = "111111111111";
            tb.DataCad = DateTime.Now;
            tb.Nome = "FULANO DA SILVA";
            tb.Status = "ATIVO";
            tb.UfNasc = "SP";

            //Act
            var resultado = repositorio.InserirFuncionario(tb);

            //Asert
            Assert.AreEqual(tb, resultado);
        }
        [TestMethod]
        public void BuscarFuncionarios_DeveRetornar()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();

            //Act
            var resultado = repositorio.BuscarFuncionarios();

            //Assert
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void BuscarFuncionariosUf_DeveRetornar()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();

            //Act
            var resultado = repositorio.BuscarFuncionariosUF();

            //Assert
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ExcluirFuncionarioCpf_DeveRetornarTrue()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
            var cpf = "111111111111";

            //Act
            var resultado = repositorio.ExcluirFuncionarioCpf(cpf);

            //Assert
            Assert.IsTrue(resultado);
        }

        #endregion

        #region Testes de Failure
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InserirFuncionario_DeveRetornarErro()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
            TB_FUNCIONARIOS tb = new TB_FUNCIONARIOS();
            tb.Cargo = "Cargo teste";
            tb.Nome = "Nome teste;";
            
            //Act
            var resultado = repositorio.InserirFuncionario(tb);

            //Assert
            Assert.AreNotEqual(tb, resultado);

        }
        [TestMethod]
        public void BuscarFuncionarios_DeveRetornarNulo()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();

            //Act
            var resultado = repositorio.BuscarFuncionarios();
            resultado = resultado.Where(Func => Func.Cargo == "NÃO EXISTE");
            var respostaDTO = from Func in resultado.ToList()
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


            //Assert
            Assert.AreEqual(0, respostaDTO.Count());
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AlterarFuncionario_DeveRetornarErro()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
            TB_FUNCIONARIOS tb = new TB_FUNCIONARIOS();

            //Act
            var resultado = repositorio.InserirFuncionario(tb);

            //Assert
            Assert.AreNotEqual(tb, resultado);
        }
        [TestMethod]
        public void ExcluirFuncionarioCpf_DeveRetornarFalse()
        {
            //Arrange
            FuncionariosRepositorio repositorio = new FuncionariosRepositorio();
            var cpf = "000";

            //Act
            var resultado = repositorio.ExcluirFuncionarioCpf(cpf);

            //Assert
            Assert.IsFalse(resultado);
        }
        
        #endregion

    }
}
