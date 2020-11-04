using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectron : Debetcard
    {
        public override DateTime? ExpireDate { get; protected set; } = DateTime.Now.AddYears(5);

        public string MaxUsage { get; protected set; } = "Max usage is 15.000 kr. pr. month";

        List<int> Prefix = new List<int>() {4026,4175,4508,4844,4913,4917};

        public VisaElectron(string cardholderName, int cardholderAge) : base(cardholderName, cardholderAge)
        {

        }

        public override string GenerateCardNumber()
        {
            Random random = new Random();
            int index = random.Next(Prefix.Count);


            //length set to 12 because the Prefix for VisaElectron is 4 digits long, and the cardnumber should only be 16 digits long
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
