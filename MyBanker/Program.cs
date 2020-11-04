using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Will run the will loop as long as "trueorfalse" equals to true, and until "trueorfalse" gets set to false.
            bool trueorfalse = true;
            while (trueorfalse)
            {
                Console.WriteLine("Select your prefered card");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1) Mastercard - min. age is 18");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("2) Maestro - min. age is 18");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("3) Withdrawcard - min. age is 18");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("4) VisaElectron - min. age is 15");
                Console.WriteLine("--------------------------------");



                int selectedNumber = Convert.ToInt32(Console.ReadLine());
                switch (selectedNumber)
                {
                    //Mastercard
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Insert your name:");
                        string nameMastercard = Console.ReadLine();
                        Console.WriteLine("Insert your age:");
                        int ageMastercard = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (ageMastercard >= 18)
                        {
                            trueorfalse = false;
                            Card mastercard = new Mastercard(nameMastercard, ageMastercard);
                            Console.WriteLine("Accountnumber: " + mastercard.AccountNumber);
                            Console.WriteLine("Cardholder Name: " + mastercard.CardholderName);
                            Console.WriteLine("Cardnumber: " + mastercard.CardNumber);
                            Console.WriteLine("Expiredate : " + mastercard.ExpireDate);
                            Console.WriteLine("Overdraft: " + ((Mastercard)mastercard).Overdraft);
                            Console.WriteLine("\nPress 'enter' to close");
                        }
                        else
                        {
                            Console.WriteLine("Not old enough for at Mastercard, press 'enter' return to start");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    //Maestro
                    case 2:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Insert your name:");
                        string nameMaestro = Console.ReadLine();
                        Console.WriteLine("Insert your age:");
                        int ageMaestro = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (ageMaestro >= 18)
                        {
                            trueorfalse = false;
                            Card maestro = new Maestro(nameMaestro, ageMaestro);
                            Console.WriteLine("Accountnumber: " + maestro.AccountNumber);
                            Console.WriteLine("Cardholder Name: " + maestro.CardholderName);
                            Console.WriteLine("Cardnumber: " + maestro.CardNumber);
                            Console.WriteLine("Expiredate: " + maestro.ExpireDate);
                            Console.WriteLine("\nPress 'enter' to close");
                        }
                        else
                        {
                            Console.WriteLine("Not old enough for at Maestro, press 'enter' return to start");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    //Withdrawcard
                    case 3:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Insert your name:");
                        string nameWithdrawcard = Console.ReadLine();
                        Console.WriteLine("Insert your age:");
                        int ageWithdrawcard = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (ageWithdrawcard >= 18)
                        {
                            trueorfalse = false;
                            Card withdrawcard = new Withdrawcard(nameWithdrawcard, ageWithdrawcard);
                            Console.WriteLine("Accountnumber: " + withdrawcard.AccountNumber);
                            Console.WriteLine("Cardholder Name: " + withdrawcard.CardholderName);
                            Console.WriteLine("Cardnumber: " + withdrawcard.CardNumber);
                            Console.WriteLine("Expiredate: " + withdrawcard.ExpireDate);
                            Console.WriteLine("Max withdraw: " + ((Withdrawcard)withdrawcard).WithdrawAmount);
                            Console.WriteLine("\nPress 'enter' to close");
                        }
                        else
                        {
                            Console.WriteLine("Not old enough for at Withdrawcard, press 'enter' return to start");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    //VisaElectron
                    case 4:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Insert your name:");
                        string nameVisaElectron = Console.ReadLine();
                        Console.WriteLine("Insert your age:");
                        int ageVisaElectron = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (ageVisaElectron >= 15)
                        {
                            trueorfalse = false;
                            Card visaElectron = new VisaElectron(nameVisaElectron, ageVisaElectron);
                            Console.WriteLine("Accountnumber: " + visaElectron.AccountNumber);
                            Console.WriteLine("Cardholder Name: " + visaElectron.CardholderName);
                            Console.WriteLine("Cardnumber: " + visaElectron.CardNumber);
                            Console.WriteLine("Expiredate: " + visaElectron.ExpireDate);
                            Console.WriteLine("Max usage: " + ((VisaElectron)visaElectron).MaxUsage);
                            Console.WriteLine("\nPress 'enter' to close");
                        }
                        else
                        {
                            Console.WriteLine("Not old enough for at VisaElectron, press 'enter' return to start");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    default:
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
