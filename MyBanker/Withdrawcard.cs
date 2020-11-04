using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Withdrawcard : Debetcard
    {
        public override DateTime? ExpireDate { get; protected set; } = null;

        public string WithdrawAmount { get; protected set; } = "Max 20.000 kr. pr. month";

        List<int> Prefix = new List<int>() {2400};

        public Withdrawcard(string cardholderName, int cardholderAge) : base(cardholderName, cardholderAge)
        {

        }
        public override string GenerateCardNumber()
        {
            Random random = new Random();
            int index = random.Next(Prefix.Count);


            //length set to 12 because the Prefix for Withdrawcard is 4 digits long, and the cardnumber should only be 16 digits long
            int length = 12;
            string rString = "";
            rString += Prefix.ElementAt(index);

            Random random1 = new Random();
            for (int i = 0; i < length; i++)
            {
                rString += (random1.Next(0, 10));
            }

            return rString;
        }
    }
}
