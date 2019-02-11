using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Mao;

namespace Poker.Cartas
{
    public class Criar_Cartas
    {
        //Construtor
        public Criar_Cartas()
        {
            Create();               
        }

        //Atributos
        public string[,] Cartas_Jogo;
        public static List<Body_Card_One> Cartas_Distribuidas = new List<Body_Card_One>();

        //Métodos
        private void Create()
        {
            string[,] Deck = {
                          //   0    1      1     1      2    1     3     1
                             {"21","2♥"},{"22","2♠"},{"23","2♣"},{"24","2♦"},
                             {"31","3♥"},{"32","3♠"},{"33","3♣"},{"34","3♦"},
                             {"41","4♥"},{"42","4♠"},{"43","4♣"},{"44","4♦"},
                             {"51","5♥"},{"52","5♠"},{"53","5♣"},{"54","5♦"},
                             {"61","6♥"},{"62","6♠"},{"63","6♣"},{"64","6♦"},
                             {"71","7♥"},{"72","7♠"},{"73","7♣"},{"74","7♦"},
                             {"81","8♥"},{"82","8♠"},{"83","8♣"},{"84","8♦"},
                             {"91","9♥"},{"92","9♠"},{"93","9♣"},{"94","9♦"},
                             {"101","10♥"},{"102","10♠"},{"103","10♣"},{"104","10♦"},
                             {"111","J♥"},{"112","J♠"},{"113","J♣"},{"114","J♦"},
                             {"121","Q♥"},{"122","Q♠"},{"123","Q♣"},{"124","Q♦"},
                             {"131","K♥"},{"132","K♠"},{"133","K♣"},{"134","K♦"},
                             {"141","A♥"},{"142","A♠"},{"143","A♣"},{"144","A♦"}};
            Cartas_Jogo = Deck;
        }
    }
}
