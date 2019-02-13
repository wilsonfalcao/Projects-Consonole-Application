using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Mao
{
    public class Body_Card_One
    {
        public int PlayerID { get; set; }
        public string ID { get; set; }
        public string CARTA { get; set; }
    }
    public class Body_Card_Texas_Holdem
    {
        public int PlayerID { get; set; }
        public string ID { get; set; }
        public string CARTA { get; set; }
    }
    public class Body_Card_Omaha_HI
    {
        /*public int PlayerID { get; set; }
        public string ID1 { get; set; }
        public string CARTA1 { get; set; }
        public string ID2 { get; set; }
        public string CARTA2 { get; set; }
        public string ID3 { get; set; }
        public string CARTA3 { get; set; }
        public string ID4 { get; set; }
        public string CARTA4 { get; set; }*/
        public int PlayerID { get; set; }
        public string ID { get; set; }
        public string CARTA { get; set; }
    }
    public class Card_One
    {
        public string ID { get; set; }
        public string CARTA { get; set; }
        public int ROUND { get; set; }
    }
}
