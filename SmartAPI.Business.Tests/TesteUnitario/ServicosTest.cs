using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartAPI.Dados.Repositorios;
using SmartAPI.Business.Serviços;
using SmartAPI.Entidades.Entidades;
using SmartAPI.Entidades.Dto.Entidades;
using System.Collections.Generic;

namespace SmartAPI.Business.Tests.TesteUnitario
{
    [TestClass]
    public class ServicosTest
    {
        #region Teste de sucesso

        //POST
        [TestMethod]
        public void InserirFuncionario_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            FuncionariosPostDTO modelo = new FuncionariosPostDTO();
            modelo.Cargo = "PRESIDENTE";
            modelo.Cpf = "111111111111";
            modelo.DataCad = DateTime.Today;
            modelo.Nome = "FULANO DA SILVA";
            modelo.Status = "ATIVO";
            modelo.Salario = 8888;
            modelo.UfNasc = "SP";

            //Act
            var result = servico.InserirFuncionario(modelo);

            //Assert
            Assert.IsNotNull(result);
        }

        //GET
        [TestMethod]
        public void BuscarFuncionariosFull_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();

            //Act
            var result = servico.BuscarFuncionarios();

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void BuscarFuncionariosNome_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var nome = "FULANO DA SILVA";

            //Act
            var result = servico.BuscarFuncionariosNome(nome);

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void BuscarFuncionariosCpf_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var pesq = "111111111111";

            //Act
            var result = servico.BuscarFuncionariosCpf(pesq);

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void BuscarFuncionariosCargo_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var pesq = "PRESIDENTE";

            //Act
            var result = servico.BuscarFuncionariosCargo(pesq);

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void BuscarFuncionariosStatus_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var pesq = "ATIVO";

            //Act
            var result = servico.BuscarFuncionariosStatus(pesq);

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void BuscarFuncionariosData_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var pesq = DateTime.Today;

            //Act
            var result = servico.BuscarFuncionariosData(pesq);

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void BuscarFuncionariosSalario_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var ini = 8887;
            var fim = 8887;

            //Act
            var result = servico.BuscarFuncionariosSalario(ini, fim);

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void BuscarFuncionariosUf_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();

            //Act
            var result = servico.BuscarFuncionariosUf();

            //Assert
            Assert.IsNotNull(result);

        }

        //DELETE
        [TestMethod]
        public void ExcluirFuncionarioCpf_DeveRetornar()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var cpf = "111111111111";

            //Act
            var result = servico.ExcluirFuncionarioCpf(cpf);

            //Assert
            Assert.IsTrue(result);

        }

        #endregion

        #region Testes de Failure

        //POST
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InserirFuncionario_DeveRetornarErro()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            FuncionariosPostDTO modelo = new FuncionariosPostDTO();

            //Act
            var result = servico.InserirFuncionario(modelo);

            //Assert
            Assert.IsNotNull(result);
        }

        //DELETE
        [TestMethod]
        public void ExcluirFuncionarioCpf_DeveRetornarNull()
        {
            //Arrange
            FuncionarioServico servico = new FuncionarioServico();
            var cpf = "NÃO EXISTE";

            //Act
            var result = servico.ExcluirFuncionarioCpf(cpf);

            //Assert
            Assert.IsFalse(result);

        }

        #endregion
    }
}
