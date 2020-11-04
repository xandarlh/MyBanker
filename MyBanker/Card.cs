using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card : IAccount
    {
        private string cardholderName;
        public string CardholderName
        {
            get { return cardholderName; }
            protected set { cardholderName = value; }
        }
        private int cardholderAge;
        public int CardholderAge
        {
            get { return cardholderAge; }
            protected set { cardholderAge = value; }
        }
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            protected set { cardNumber = value; }
        }
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            protected set { accountNumber = value; }
        }

        public abstract DateTime? ExpireDate { get; protected set; }
        
        public string GenerateAccountNumber()
        {
            Random random = new Random();
            int length = 10;
            string registrationNumber = "3520";
            string rString = "";
            rString += registrationNumber;
            for (var i = 0; i < length; i++)
            {
                rString += (random.Next(0, 10));
            }

            return rString;
        }

        public abstract string GenerateCardNumber();

        public Card(string cardholderName, int cardholderAge)
        {
            this.CardholderName = cardholderName;
            this.CardholderAge = cardholderAge;
            this.CardNumber = GenerateCardNumber();
            this.AccountNumber = GenerateAccountNumber();
        }




    }
}
