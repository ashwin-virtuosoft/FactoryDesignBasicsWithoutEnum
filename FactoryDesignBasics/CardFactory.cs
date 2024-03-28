using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignBasics
{
    public class CardFactory
    {
        public ICard CreateCardInstance(string cardType)
        {
            ICard icard = null;

            switch (cardType)
            {
                case "pl":
                    icard=new PlatinumCard();
                    break;
                case "t1":
                    icard=new TitaniumCard();
                    break;
                case "g1":
                    icard=new GoldCard();
                    break;
            }

            return icard;
        }
    }
}
