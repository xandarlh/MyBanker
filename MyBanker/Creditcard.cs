using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{ 
    public abstract class Creditcard : Card
    {
        public Creditcard(string cardholderName, int cardholderAge) : base(cardholderName, cardholderAge)
        {

        }
        public abstract string Overdraft { get; protected set; }
    } 
}
