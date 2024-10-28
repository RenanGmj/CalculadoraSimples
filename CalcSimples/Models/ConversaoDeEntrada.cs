using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcSimples.Models
{
    public class ConversaoDeEntrada
    {
        public double ConverterEntradaParaTipoNumerico(string entradaDoUsuario)
        {
            double numeroConvertido;
            if(!double.TryParse(entradaDoUsuario, out numeroConvertido))throw new ArgumentException("É esperado um valor numerico");
            return numeroConvertido;
            
        }
    }
}