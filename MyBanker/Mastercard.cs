using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Creditcard
    {
        public override string Overdraft { get; protected set; } = "5.000 kr pr. day, max 30.000 kr a month";
        public override DateTime? ExpireDate { get; protected set; } = DateTime.Now.AddYears(5); 
        List<int> Prefix = new List<int>() {51,52,53,54,55};


        public Mastercard(string cardholderName, int cardholderAge) : base(cardholderName, cardholderAge)
        {
            
        }
        public override string GenerateCardNumber()
        {
            Random random = new Random();
            int index = random.Next(Prefix.Count);
            
         
            //length set to 14 because the Prefix for Mastercard is 2 digit, and the cardnumber should only be 16 digits long
            int length = 14; 
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
