using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignBasics
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Card Type");
            string cardType=Console.ReadLine();

            CardFactory cardFactory = new CardFactory();
            ICard icard=cardFactory.CreateCardInstance(cardType);   
            Console.WriteLine("Card Type= {0} \n Card Limit={1} \n Annual Charge={2}",icard.CardType(),icard.CreditLimit(),icard.AnnualCharge());
            Console.ReadLine();
        }
    }
}
