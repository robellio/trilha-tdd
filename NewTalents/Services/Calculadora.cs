using System;

namespace NewTalents.Services
{
    public class Calculadora
    {
        public int somar(int val1, int val2)
        {
           int res = val1 + val2;
           return res;
        }
        public int subtrair(int val1, int val2)
        {
           return 0;
        }
        public int multiplicar(int val1, int val2)
        {
           return 0;
        }
        public int dividir(int val1, int val2)
        {
           return 0;
        }

        public List<string> historico()
        {
            return new List<string>();
        }
    }
}