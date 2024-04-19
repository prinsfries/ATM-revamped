using atmBL;
using atmDL;
using ATMMODEL;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Aguas E-wallet ATM");
            Console.WriteLine("Please insert your E-wallet card pin");
            Console.Write("Input: ");
            string Pin = Console.ReadLine();
            EWDataServices data = new EWDataServices();
            EWService service = new EWService();
            MoneyService monkey = new MoneyService();
            bool result = service.VerifyPin(Pin);
            if (result)
            {
                if (Pin == "12")
                {
                    EWallet show = data.GetUser1();
                    int bank = show.money.amount;
                    Console.WriteLine();
                    Console.WriteLine($"Hello, {show.name}!");
                    Console.WriteLine($"EWallet Money: {show.money.amount}php");
                    Proceed(bank);

                }
                else if (Pin == "123")
                {
                    EWallet show = data.GetUser2();
                    int bank = show.money.amount;
                    Console.WriteLine();
                    Console.WriteLine($"Hello, {show.name}!");
                    Console.WriteLine($"EWallet Money: {show.money.amount}php");
                    Proceed(bank);
                }
                else if (Pin == "1234")
                {
                    EWallet show = data.GetUser3();
                    int bank = show.money.amount;
                    Console.WriteLine();
                    Console.WriteLine($"Hello, {show.name}!");
                    Console.WriteLine($"EWallet Money: {show.money.amount}php");
                    Proceed(bank);
                }

                void Proceed(int bank)
                { 
                    Console.WriteLine($"Amount: {bank}");
                    Console.WriteLine("Please select a transaction to be done:");
                    Console.WriteLine("1. Withdraw");
                    Console.WriteLine("2. Deposit");
                    Console.Write("Input: ");
                    byte choice = Convert.ToByte(Console.ReadLine());
                    switch (choice)
                    {
                        //withdraw
                        case 1:
                            choices(bank);
                            int wd = Convert.ToInt32(Console.ReadLine());
                            if (wd == 9)
                            {
                                customAmount(bank);
                                wd = Convert.ToInt32(Console.ReadLine());
                                monkey.customInputWith(bank, wd);
                                if (monkey.customInputWith(bank, wd) == 0)
                                {
                                    insuff();
                                }
                                else
                                {
                                    CustomsuccessWith(bank, wd);
                                }
                                
                            }
                            else if (wd<= 9 && wd>0 )
                            {
                                monkey.WITH(bank, wd);
                                if (monkey.Withdraw(bank, wd) == 0)
                                {
                                    insuff();
                                }
                                else
                                {
                                    successWith(bank, wd);
                                }
                            }
                            else
                            {
                                invalid();
                            }
                            break;

                        //deposit
                        case 2:
                            choices(bank);
                            wd = Convert.ToInt32(Console.ReadLine());
                            if (wd == 9)
                            {
                                customAmount(bank);
                                wd = Convert.ToInt32(Console.ReadLine());
                                monkey.customInputDepo(bank, wd);
                                CustomsuccessDepo(bank, wd);
                            }
                            else if (wd <= 9 && wd > 0)
                            {
                                monkey.DEPO(bank, wd);
                                if (monkey.deposit(bank, wd) == 0)
                                {
                                    insuff();
                                }
                                else
                                {
                                    successDepo(bank, wd);
                                }
                            }
                            else
                            {
                                invalid();
                            }
                            break;

                        default:
                            invalid();
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("\nAccount does not exist bro lmao");
                invalid();
            }
            void choices(int moneymoney)
            {
                Console.WriteLine();
                Console.WriteLine("Money in account: " + moneymoney);
                Console.WriteLine("Select amount to process:");
                Console.WriteLine("1. 100");
                Console.WriteLine("2. 200");
                Console.WriteLine("3. 500");
                Console.WriteLine("4. 1,000");
                Console.WriteLine("5. 2,000");
                Console.WriteLine("6. 5,000");
                Console.WriteLine("7. 7,500");
                Console.WriteLine("8. 10,000");
                Console.WriteLine("9. Custom");
                Console.Write("Input: ");
            }
            void successWith(int bank, int wd)
            {
                Console.WriteLine("\nSuccessfully withdrawn!");
                Console.WriteLine($"Your account now contains: " + monkey.Withdraw(bank, wd) + "php");
                Console.WriteLine("Claim Your Cash and E-Wallet Card below...");
                Console.WriteLine("Thank you!\n");
            }
            void CustomsuccessWith(int bank, int wd)
            {
                Console.WriteLine("\nSuccessfully withdrawn!");
                Console.WriteLine($"Your account now contains: " + monkey.customInputWith(bank, wd) + "php");
                Console.WriteLine("Claim Your Cash and E-Wallet Card below...");
                Console.WriteLine("Thank you!\n");
            }
            void successDepo(int bank, int wd)
            {
                Console.WriteLine("\nSuccessfully deposited!");
                Console.WriteLine($"Your account now contains: " + monkey.deposit(bank, wd) + "php");
                Console.WriteLine("Claim Your Receipt and E-Wallet Card below...");
                Console.WriteLine("Thank you!\n");
            }
            void CustomsuccessDepo(int bank, int wd)
            {
                Console.WriteLine("\nSuccessfully deposited!");
                Console.WriteLine($"Your account now contains: " + monkey.customInputDepo(bank, wd) + "php");
                Console.WriteLine("Claim Your Receipt and E-Wallet Card below...");
                Console.WriteLine("Thank you!\n");

            }
            void customAmount (int moneymoney)
            {
                Console.Write("Input amount to process: ");
            }
            void insuff()
            {
                Console.WriteLine("Insufficient funds bro");
            }
            void invalid()
            {
                Console.WriteLine("\nInvalid Input " +
                    "\nPlease start over...");
            }
        }
    }
}
