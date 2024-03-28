using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignBasics
{
    public class PlatinumCard : ICard
    {
        public int AnnualCharge()
        {
            return 10000;
        }

        public string CardType()
        {
            return "Platinum Card";
        }

        public int CreditLimit()
        {
            return 5000;
        }
    }
}
