using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return  num1 + num2; 
        }
        public int subtrair(int num1, int num2)
        {
            return  num1 - num2; 
        }
        public int multiplicar(int num1, int num2)
        {
            return  num1 * num2; 
        }
        public int dividir(int num1, int num2)
        {
            return  num1 / num2; 
        }
    }
}