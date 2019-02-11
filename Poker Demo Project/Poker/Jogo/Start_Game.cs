using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Cartas;
using Poker.Mao;

namespace Poker.Jogo
{
    public class Start_Game
    {
        public Start_Game(int play)
        {
            Start_Poker_Texas(play);
        }


        //Metodo de inicialização de jogo
        public void Start_Poker_Omaha(int Cont_Players)
        {
        }
        public void Start_Poker_Texas(int Cont_Players)
        {
            //Construindo Cartas
            Criar_Cartas Cartoes = new Criar_Cartas();

            //Iniciando Round

            //Construindo Mãos
            Start_Poker_Separador_Cartas(1, Cartoes);
            
        }
        public void Start_Poker_Separador_Cartas(byte TP_Separator, Criar_Cartas Cartoes) 
        {
            switch (TP_Separator)
            {
                case 0:break;

                case 1:
                    int cont1 = 0;
                    while(cont1 < 3)
                    {
                        Random Embaralhar = new Random();
                        int Id_Card = Embaralhar.Next(0, 52);
                        if (Check_Card_D(Id_Card))
                        {
                            Start_Poker_Separador_Cartas(1, Cartoes);
                        }
                        else
                        {
                            //Fazendo a mão de Poker
                            Mao_Texas.Add(new Body_Card_Texas_Holdem
                            {
                                PlayerID = 1,
                                ID = Cartoes.Cartas_Jogo[Id_Card, 0],
                                CARTA = Cartoes.Cartas_Jogo[Id_Card, 1],
                            });
                        }
                        cont1++;
                    }
                    var teste = Criar_Cartas.Cartas_Distribuidas;
                    break;

                case 2:break;
            }
        }
        //Metodos da Classe Chek e Create
        private bool Check_Card_D(int id_card)
        {
            bool Validation = false;
            Criar_Cartas C_Poker = new Criar_Cartas();
            if (Criar_Cartas.Cartas_Distribuidas.Count() != 0)
            {
                List<Body_Card_One> Value = Criar_Cartas.Cartas_Distribuidas.FindAll(s => s.ID == id_card.ToString());
                if (Value.Count() != 0)
                {
                    Validation = true;
                }
                else
                {
                    Criar_Cartas.Cartas_Distribuidas.Add(new Body_Card_One { ID = id_card.ToString(), CARTA = C_Poker.Cartas_Jogo[id_card, 1] });
                    Validation = false;
                }
            }
            else
            {
                Criar_Cartas.Cartas_Distribuidas.Add(new Body_Card_One { ID = id_card.ToString(), CARTA = C_Poker.Cartas_Jogo[id_card, 1] });
                Validation = false;
            }
            return Validation;
        }

        //Atributos da Classe
        public List<Body_Card_One> Mao_One = new List<Body_Card_One>();
        public List<Body_Card_Omaha_HI> Mao_Omaha = new List<Body_Card_Omaha_HI>();
        public List<Body_Card_Texas_Holdem> Mao_Texas = new List<Body_Card_Texas_Holdem>();
    }
}
