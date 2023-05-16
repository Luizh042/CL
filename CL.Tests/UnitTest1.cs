using NUnit.Framework;
using CL;

namespace CL.Tests
{
    public class CLTests
    {
        private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [Test]
        public void Soma_DoisNumeros_RetornaSomaDosNumeros()
        {
            var resultado = _calculadora.Soma(6, 3);
            Assert.AreEqual(9, resultado);
        }
    }    
}