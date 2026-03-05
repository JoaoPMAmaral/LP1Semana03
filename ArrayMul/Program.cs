using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float arg0 = float.Parse(args[0]);
            float arg1 = float.Parse(args[1]);
            float arg2 = float.Parse(args[2]);
            float arg3 = float.Parse(args[3]);
            float arg4 = float.Parse(args[4]);
            float arg5 = float.Parse(args[5]);
            

            float primeiroNumero = arg0 * arg4 + arg1 * arg5;
            float segundoNumero = arg2 * arg4 + arg3 * arg5;
        }
    }
}
