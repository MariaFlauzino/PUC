using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Aluno
{
    public class AprovacaoAluno
    {
        string resultado;
        public AprovacaoAluno()
        {
            
        }

        public string determinarAprovacao(int frequencia, int notaFinal, int notaEspecial)
        {
            if (notaFinal < 0 || notaEspecial < 0 || frequencia < 0)
            {
                resultado = "Reprovado";
            }
            else if ((notaFinal + notaEspecial) / 2 < 60 || frequencia < 75)
            {
                resultado = "Reprovado";
            }

            else if (notaFinal >= 60 || (notaFinal + notaEspecial) / 2 >= 60)
            {
                resultado = "Aprovado";
            }
           
            return resultado;
        }
    }
}
