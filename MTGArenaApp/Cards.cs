using System.Collections.Generic;

namespace MTGArenaApp
{
    class Cards
    {

        public class Rootobject
        {
            public List<Card> Cards { get; set; }
        }

        public class Card
        {
            public string name { get; set; }
            public string set { get; set; }
            public Images images { get; set; }
            public string type { get; set; }
            public string[] cost { get; set; }
            public int cmc { get; set; }
            public string rarity { get; set; }
            public string cid { get; set; }
            public int?[] frame { get; set; }
            public string artist { get; set; }
            public string dfc { get; set; }
            public bool collectible { get; set; }
            public bool craftable { get; set; }
            public int dfcId { get; set; }
            public int rank { get; set; }
            public string grpId { get; set; }
        }

        public class Images
        {
            public string small { get; set; }
            public string normal { get; set; }
            public string large { get; set; }
            public string art_crop { get; set; }
        }

    }
}
