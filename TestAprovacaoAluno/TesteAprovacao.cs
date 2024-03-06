 
using Aluno;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesAluno
{
    [TestClass]
    public class TestesAprovacaoAluno
    {
        AprovacaoAluno aprovacaoAluno;

        [TestInitialize]
        public void Setup()
        {
            AprovacaoAluno aprovacaoAluno = new AprovacaoAluno();
        }

        [TestMethod]
        public void ReprovadoFrequenciaMenor75()
        {
            Assert.AreEqual(expected: "Aprovado", aprovacaoAluno.determinarAprovacao(74, 100, 100));
        }
    }
}