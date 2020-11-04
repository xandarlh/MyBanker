using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Debetcard
    {
        public override DateTime? ExpireDate { get; protected set; } = DateTime.Now.AddYears(5).AddMonths(8);
        List<int> Prefix = new List<int>() {5018,5020,5038,5893,6304,6759,6761,6762,6763};

        public Maestro(string cardholderName, int cardholderAge) : base(cardholderName, cardholderAge)
        {

        }

        public override string GenerateCardNumber()
        {
            Random random = new Random();
            int index = random.Next(Prefix.Count);


            //length set to 15 because the Prefix for Mastercard is 4 digits long, and the cardnumber should only be 19 digits long
            int length = 15;
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
