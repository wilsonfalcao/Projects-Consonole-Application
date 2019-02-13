using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Mao;

namespace Poker.Jogo
{
    public class Analitcs_Game
    {
        public Analitcs_Game(List<Body_Card_Texas_Holdem> Mao,List<Card_One> Mesa)
        {
            string[] ID_Card_Hand = new string[2];
            string[] ID_Card_Mesa = new string[5];
            int cont=0;
            foreach (var Data in Mao)
            {
                ID_Card_Hand[cont] = Data.CARTA;
                cont = cont+1;
            }
            cont = 0;
            foreach (var Data in Mesa)
            {
                ID_Card_Mesa[cont] = Data.CARTA;
                cont = cont + 1;
            }
            if (Hand_One(ID_Card_Hand,ID_Card_Mesa))
            {

            }
            else if(Hand_Three(ID_Card_Hand,ID_Card_Mesa))
            {

            }
        }

        public Analitcs_Game(Body_Card_Omaha_HI Mao, Card_One Mesa)
        {

        }

        //Metodos de analise a classe
        private bool Hand_Flush(int[]ID_Card_Hand, int[] ID_Card_Mesa)
        {
            return false;
        }
        private bool Hand_Royal_Flush(int[] ID_Card_Hand, int[] ID_Card_Mesa)
        {
            return false;
        }
        private bool Hand_Four(int[] ID_Card_Hand, int[] ID_Card_Mesa)
        {
            return false;
        }
        private bool Hand_Straght_Flush(int[] ID_Card_Hand, int[] ID_Card_Mesa)
        {
            return false;
        }
        private bool Hand_Straght(int[] ID_Card_Hand, int[] ID_Card_Mesa)
        {
            return false;
        }
        private bool Hand_Full_House(int[] ID_Card_Hand, int[] ID_Card_Mesa)
        {
            return false;
        }
        private bool Hand_Three(string[] ID_Card_Hand, string[] ID_Card_Mesa)
        {
            bool Validation = false;
            for (int cont = 0; cont < ID_Card_Hand.Length; cont++)
            {
                for (int cont1 = 0; cont1 < ID_Card_Mesa.Length; cont1++)
                {
                    string nome = ID_Card_Hand[cont].ToString().Substring(0, 1);
                    if (ID_Card_Hand[cont].ToString().Substring(0, 1) == ID_Card_Mesa[cont1].ToString().Substring(0, 1) &&
                        ID_Card_Hand[cont].ToString().Substring(0, 1) == ID_Card_Mesa[cont1+1].ToString().Substring(0, 1))
                    {
                        Jogada_Mao = "Trinca de " + ID_Card_Hand[cont].ToString();
                        Validation = true;
                    }
                    else if (ID_Card_Hand.Length == 2)
                    {
                        if (ID_Card_Hand[0].ToString().Substring(0, 1) == ID_Card_Hand[1].ToString().Substring(0, 1) &&
                        ID_Card_Hand[0].ToString().Substring(0, 1) == ID_Card_Mesa[cont1].ToString().Substring(0, 1))
                        {
                            Jogada_Mao = "Trinca de " + ID_Card_Hand[cont].ToString();
                            Validation = true;
                        }
                    }
                }
            }
            return Validation;
        }
        private bool Hand_One(string[] ID_Card_Hand, string[] ID_Card_Mesa)
        {
            bool Validation = false;
            string ct1 = ID_Card_Hand[0].ToString().Substring(0, 1);
            string ct2 = ID_Card_Hand[1].ToString().Substring(0, 1);
            if (ID_Card_Hand[0].ToString().Substring(0, 1) == ID_Card_Hand[1].ToString().Substring(0, 1))
            {
                        Jogada_Mao = "Par de "+ID_Card_Hand[0].ToString() + " Par na mão";
                        Validation = true;
            }
            if(Validation == false)
            {
            for (int cont = 0; cont < ID_Card_Hand.Length; cont++)
            {
                for (int cont1 = 0; cont1 < ID_Card_Mesa.Length; cont1++)
                {
                    string nome = ID_Card_Hand[cont].ToString().Substring(0,1);
                    if (ID_Card_Hand[cont].ToString().Substring(0, 1) == ID_Card_Mesa[cont1].ToString().Substring(0, 1))
                    {
                        Jogada_Mao = "Par de "+ID_Card_Hand[cont].ToString();
                        Validation = true;
                    }
                }
            }
            }
            return Validation;
        }


        //Atributo
        public string Jogada_Mao { get; set; }
    }
}
