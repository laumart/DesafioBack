using Desafio.Api.Titulos.Models;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Desafio.Api.Titulos.Test
{
    public class UnitTest1
    {
        private readonly Titulo _titulo;
        private readonly int _juros = 1;
        private readonly int _multa = 2;

        ITestOutputHelper _itestOutputHelper;
        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _titulo = new Titulo();
            _itestOutputHelper = testOutputHelper;
    }

        [Fact]
        public void Calculo_Multa()
        {

        }

        [Fact]
        public void Calculo_Multa_Juros()
        {

        }

        [Fact]
        public void Calculo_Valor_Atualizado()
        {

        }
    }
}
