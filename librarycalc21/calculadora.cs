using System;
using System.Collections.Generic;
using System.Text;

namespace librarycalc21
{
     public class calculadora : ICalculadora
    {
        public double dividir(double x, double y)
        {
            return x / y;
        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        public int somar(int x, int y)
        {
            return x + y;
        }

        public int subtrair(int x, int y)
        {
            return x - y;
        }
        
        public int somar(int x, int y, int z)
        {
            return x + y + z;
        }                

        public int subtrair(int x, int y, int z)
        {
            return x - y - z;
        }
        
        public int multiplicar(int x, int y, int z)
        {
            return x * y * z;
        }

        public int multiplicarsubtrair(int x , int y, int z)
        {
            return x * y - z;
            
        }
    }
}
