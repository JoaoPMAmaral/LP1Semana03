using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Frase: ");
            string frase = Console.ReadLine();

            Console.Write("Caracter: ");
            string caracter = Console.ReadLine();

            char character = char.Parse(caracter);

            for(int i = 0; i < frase.Length; i++)
            {
                if(frase[i] == character)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(frase[i]);
                }
            }
        }
    }
}
