using System;
using CyberHack;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //tipo de sistema a atacar
            string sistema = Console.ReadLine();

            //uma ou mais ferramentas de ataque
            string ferramenta = Console.ReadLine();

            switch (sistema)
            {
                case "CorporateServer":
                break;

                case "BankDatabase":
                break;

                case "SmartCityCore":
                break;

                case "MilitaryAI":
                break;
            }

        }
    }
}
