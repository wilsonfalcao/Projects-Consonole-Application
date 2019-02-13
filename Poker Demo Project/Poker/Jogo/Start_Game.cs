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
        //Construindo Cartas
        Criar_Cartas Cartoes = new Criar_Cartas();


        //Construtor da Classe
        public Start_Game(byte sala)
        {
            //Zerando Tudo
            Mesa.Clear(); Mao_Texas.Clear(); Criar_Cartas.Cartas_Distribuidas.Clear();
            //Iniciando Round
            Round = 1;

            //Construindo Mãos
            this.Start_Poker_Separador_Cartas_Mao(2, Cartoes);

            //Construindo Mesa
            this.Start_Poker_Separador_Cartas_Mesa(3, Cartoes, 1);
        }

        //#####################################################################
        //Metodo de inicialização de jogo
        public void Start_Poker_Omaha(int Cont_Players)
        {

        }
        public void Round_Poker_Texas()
        {
            if (Round <= 3)
            {
                //Iniciando Round
                Round += Round;

                //Construindo Novo Round
                this.Start_Poker_Separador_Cartas_Mesa(1, Cartoes, Round);
            }
            else if (Round == 4)
            {
                WIN = Analisar_Mao(Mesa, Mao_Texas);
            }
        }

        //Metodo de separação de cartas
        private void Start_Poker_Separador_Cartas_Mao(byte Q_Carta,Criar_Cartas Cartoes) 
        {
            for (int cont = 0; cont < Q_Carta; cont++)
                    {
                        Random Embaralhar = new Random();
                        int Id_Card = Embaralhar.Next(0, 52);
                        if (Check_Card_D(Id_Card,Cartoes))
                        {
                            cont--;
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
                    }
        }
        private void Start_Poker_Separador_Cartas_Mesa(byte Q_Carta, Criar_Cartas Cartoes, byte Round)
        {
            for (int cont = 0; cont < Q_Carta; cont++)
            {
                Random Embaralhar = new Random();
                int Id_Card = Embaralhar.Next(0, 52);
                if (Check_Card_D(Id_Card, Cartoes))
                {
                    cont--;
                }
                else
                {
                    //Fazendo a mão de Poker
                    Mesa.Add(new Card_One
                    {
                        ROUND = Round,
                        ID = Cartoes.Cartas_Jogo[Id_Card, 0],
                        CARTA = Cartoes.Cartas_Jogo[Id_Card, 1],
                    });
                }
            }
        }
        
        //Metodos de analise a carta
        private bool Check_Card_D(int id_card,Criar_Cartas C_Poker)
        {
            bool Validation = false;
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

        //Metodo de analise a jogo
        private string Analisar_Mao(List<Card_One> Mesa_Analise, List<Body_Card_Texas_Holdem> Mao_Analise)
        {
            Analitcs_Game Analise = new Analitcs_Game(Mao_Analise,Mesa_Analise);
            return Analise.Jogada_Mao;
        }
        //#######################################################################


        //Atributos da Classe
        public List<Card_One> Mesa = new List<Card_One>();
        public List<Body_Card_Omaha_HI> Mao_Omaha = new List<Body_Card_Omaha_HI>();
        public List<Body_Card_Texas_Holdem> Mao_Texas = new List<Body_Card_Texas_Holdem>();
        public byte Round;
        public string WIN;
    }
}
