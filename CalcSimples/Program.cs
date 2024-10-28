using CalcSimples.Models;

try
{
Calculadora calculadora = new Calculadora();
ConversaoDeEntrada conversaoDeEntrada= new ConversaoDeEntrada();

Console.WriteLine("Digite o primeiro numero:");
double primeiroNumero = conversaoDeEntrada.ConverterEntradaParaTipoNumerico(Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
double segundoNumero = conversaoDeEntrada.ConverterEntradaParaTipoNumerico(Console.ReadLine());

Console.WriteLine("Digite a operação que deseja realizar:");
string tipoDeOperacao = Console.ReadLine();

double resultado = calculadora.Calculalar(tipoDeOperacao, primeiroNumero, segundoNumero);
Console.WriteLine( resultado);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}