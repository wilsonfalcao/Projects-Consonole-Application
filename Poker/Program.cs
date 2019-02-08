using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Cartas;
using Poker.Mao;
using Poker.Jogo;

namespace Poker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start_Game Game = new Start_Game(1);
            Console.Write(" Cartas na Mão: ");
            foreach (var Data in Game.Mao_Texas as List<Body_Card_Texas_Holdem>)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write(" "+Data.CARTA+" ");
            }
            Console.ReadKey();
        }
    }
}
