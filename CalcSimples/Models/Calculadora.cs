using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcSimples.Models
{
    public class Calculadora
    {
        public double Calculalar( string tipoDeOperacao, double primeiroNumero, double segundoNumero)
        {
            double resultado;
            switch( tipoDeOperacao.ToLower())
            {
                case "+":
                case "somar":
                case "soma":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                
                case "-":
                case "subtração":
                case "subtrair":
                case "menos":
                    resultado = primeiroNumero - segundoNumero;
                    break;

                case "/":
                case "divisão":
                    resultado = primeiroNumero/segundoNumero;
                    break;

                case "*":
                case "Multiplicação":
                    resultado = primeiroNumero * segundoNumero;
                    break;

                default:
                    throw new InvalidOperationException("Esta operação esta errada, use um dos simbolos a seguir: +, -, *, / ");
                
            }
            return resultado;
        }
    }
}