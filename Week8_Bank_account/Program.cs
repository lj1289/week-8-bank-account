using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week8_Bank_account
{
    class Program
    {
        static void Main(string[] args)

        {
            ////----------------Calling Classess 
            Client Lawrence = new Client();//Client information
            BankAccount MyAccount = new BankAccount();//Bank Account info 
            HammerTime TransactionTime = new HammerTime();// Time of transaction

            //View Clients Information
            // View Accounts 
            //Deposit Funds
            //Withdraw Funds 

            Console.WriteLine("*********Bank Account*********\n\n");//------Main Menu List 
            //Console.WriteLine("\n1. View Client Information \n2. View Accounts \n3. Deposit Funds \n4. Withdraw Funds \n5. Exit");

            List<string> menu = new List<string>();//--------Main Menu
            menu.Add("1. View Client Information");
            menu.Add("2. View Accounts Balance");
            menu.Add("3. Deposit Funds");
            menu.Add("4. Withdraw Funds");
            menu.Add("5. Exit");

            //int mainMenuList = int.Parse(Console.ReadLine());
            bool looptyLoop = true;

            while(looptyLoop)
            {
                viewMenu(menu);
                Console.WriteLine("Please make a selection: ");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (num)

                {
                    case 1:
                        Console.WriteLine("\n\n1. View Client Information");
                        Console.WriteLine("***************************");
                        Console.WriteLine(Lawrence.Accountnumber);//Account Number 
                        Console.Write(Lawrence.Firstname);// First Name
                        Console.WriteLine(Lawrence.Lastname); // Last Name 
                        Console.WriteLine("***************************\n\n");
                        
                        //Console.WriteLine("\nEnter in User's Full Name: ");
                        //BankAccount BankAccount = new BankAccount();
                        // string userInputAccountName = Console.ReadLine(BankAccount);
                        break;
                    case 2:
                        Console.WriteLine(" 2. View Accounts ");
                        Console.WriteLine("***************************");
                        Console.WriteLine(Lawrence.Accountnumber);//Account Number 
                        Console.Write(Lawrence.Firstname);// First Name
                        Console.WriteLine(Lawrence.Lastname); // Last Name 
                        Console.WriteLine(MyAccount.Balance);                  
                        Console.WriteLine("***************************\n\n");
                        //Console.Write("\nEnter in User's Account info: ");
                        //string userInputAccountNumber = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\n\n3. Deposit Funds");
                        Console.WriteLine("***************************");
                        Console.WriteLine(Lawrence.Accountnumber);//Account Number 
                        Console.Write(Lawrence.Firstname);// First Name
                        Console.WriteLine(Lawrence.Lastname); // Last Name 
                        Console.WriteLine("***************************\n\n");
                        Console.Write("\nEnter in Deposit amount: + $ ");
                        decimal userInputDepositAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("New Balance: $" + MyAccount.Deposit(userInputDepositAmount) + TransactionTime.GoodTiming);
                        //Console.WriteLine(MyAccount.Balance);//Class Bank Account                   
                        break;
                    case 4:                       
                        Console.WriteLine("4. Withdraw Funds");
                        //StreamReader Week8_Bank_account = new StreamReader(@"c:\users\wecancodeit\documents\visual studio 2015\Projects\Week8_Bank_account\Week8_Bank_account\Program");
                        Console.WriteLine("***************************");
                        Console.WriteLine(Lawrence.Accountnumber);//Account Number 
                        Console.Write(Lawrence.Firstname);// First Name
                        Console.WriteLine(Lawrence.Lastname); // Last Name                                   
                        Console.WriteLine("***************************\n\n");
                        Console.Write("\nEnter in Withdraw amount: - $ ");
                        Console.WriteLine(MyAccount.Balance);
                        decimal userInputWithdrawAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("New Balance: $" + MyAccount.Withdraw(userInputWithdrawAmount) + TransactionTime.GoodTiming);
                        //reader.Close();
                        break;
                    case 5:
                        Console.WriteLine("***************************\n\n");
                        Console.WriteLine("6. Exit");
                        Console.WriteLine("***************************\n\n");
                        Console.WriteLine("\nGoodbye . . .");
                        //Console.Clear();
                        looptyLoop = false;
                        break;
                }
            
                    
            }

            ///-------------------User input
            







        }
        static void viewMenu(List<string> menu)
        {
            foreach(string item in menu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
