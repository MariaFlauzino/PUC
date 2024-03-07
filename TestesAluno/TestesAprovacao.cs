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
            aprovacaoAluno = new();
        }

        [TestMethod]
        public void ReprovadoFrequenciaMenor75()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(74, 100, 100));
        }

        [TestMethod]
        public void AprovadoNotaFinalMaiorOuIgual60()
        {
            Assert.AreEqual(expected: "Aprovado", aprovacaoAluno.determinarAprovacao(75, 60, 60));
        }

        [TestMethod]
        public void AprovadoFrequenciaMaior75()
        {
            Assert.AreEqual(expected: "Aprovado", aprovacaoAluno.determinarAprovacao(80, 60, 60));
        }

        [TestMethod]
        public void ReprovadoNotaFinalMenor60()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(80, 30, 60));
        }

        [TestMethod]
        public void ReprovadoNotaFinalMaisNotaEspecialMenor60()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(80, 60, 20));
        }

        [TestMethod]
        public void AprovadoNotaFinalMaisNotaEspecialMaiorOuIgual60()
        {
            Assert.AreEqual(expected: "Aprovado", aprovacaoAluno.determinarAprovacao(80, 20, 100));
        }

        [TestMethod]
        public void ReprovadoFrequenciaNegativa()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(-80, 60, 60));
        }

        [TestMethod]
        public void ReprovadoNotaFinalNegativa()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(80, -80, 60));
        }

        [TestMethod]
        public void ReprovadoNotaEspecialNegativa()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(80, -80, 60));
        }

        [TestMethod]
        public void ReprovadoFrequenciaNotaFinalNotaEspecialNegativa()
        {
            Assert.AreEqual(expected: "Reprovado", aprovacaoAluno.determinarAprovacao(-80, -80, -60));
        }
    }
}