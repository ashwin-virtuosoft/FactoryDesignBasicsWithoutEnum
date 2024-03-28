using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignBasics
{
    public interface ICard
    {
        string CardType();

        int CreditLimit();

        int AnnualCharge(); 
    }
}
