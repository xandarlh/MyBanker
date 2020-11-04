using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Debetcard : Card
    {
        public Debetcard(string cardholderName, int cardholderAge) : base(cardholderName, cardholderAge)
        {

        }
    }
}
