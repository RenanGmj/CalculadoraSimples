using CalcSimples.Models;

namespace CalcSimplesTest;

public class Tests
{
    private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [TestCase("+", 5, 3, ExpectedResult = 8)]
        [TestCase("somar", 5, 3, ExpectedResult = 8)]
        [TestCase("soma", 5, 3, ExpectedResult = 8)]
        public double Calculalar_DeveRetornarSoma_QuandoOperacaoSoma(string operacao, double primeiroNumero, double segundoNumero)
        {
            return _calculadora.Calculalar(operacao, primeiroNumero, segundoNumero);
        }

        [TestCase("-", 5, 3, ExpectedResult = 2)]
        [TestCase("subtrair", 5, 3, ExpectedResult = 2)]
        [TestCase("menos", 5, 3, ExpectedResult = 2)]
        public double Calculalar_DeveRetornarSubtracao_QuandoOperacaoSubtracao(string operacao, double primeiroNumero, double segundoNumero)
        {
            return _calculadora.Calculalar(operacao, primeiroNumero, segundoNumero);
        }

        [TestCase("/", 6, 3, ExpectedResult = 2)]
        [TestCase("divisão", 6, 3, ExpectedResult = 2)]
        public double Calculalar_DeveRetornarDivisao_QuandoOperacaoDivisao(string operacao, double primeiroNumero, double segundoNumero)
        {
            return _calculadora.Calculalar(operacao, primeiroNumero, segundoNumero);
        }

        [TestCase("*", 5, 3, ExpectedResult = 15)]
        [TestCase("Multiplicação", 5, 3, ExpectedResult = 15)]
        public double Calculalar_DeveRetornarMultiplicacao_QuandoOperacaoMultiplicacao(string operacao, double primeiroNumero, double segundoNumero)
        {
            return _calculadora.Calculalar(operacao, primeiroNumero, segundoNumero);
        }

        [Test]
        public void Calculalar_DeveLancarExcecao_QuandoOperacaoInvalida()
        {
            Assert.Throws<InvalidOperationException>(() => _calculadora.Calculalar("invalida", 5, 3));
        }

        [Test]
        public void Calculalar_DeveLancarExcecao_QuandoDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Calculalar("/", 5, 0));
        }
    }
