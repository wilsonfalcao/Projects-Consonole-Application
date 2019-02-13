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
            for (int cont1 = 1; cont1 <10000; cont1++)
            {
                Start_Game Game = new Start_Game(1);
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Mesa: ");
                for(int cont =1;cont<4;cont++)
                {
                    Game.Round_Poker_Texas();
                }
                foreach (var Data in Game.Mesa as List<Card_One>)
                {
                    Console.Write(Data.CARTA + " ");
                }
                Console.Write(" ");
                foreach (var Data in Game.Mao_Texas as List<Body_Card_Texas_Holdem>)
                {
                    Console.Write(" " + Data.CARTA + " ");
                }
                Console.Write(Game.WIN);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
