using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace Week8_Bank_account
{
    class BankAccount 
    {
        // 2nd project accountType 
        //-----------------------------------
        //public string accountNumber;
        private decimal balance;
        //-----------------------------------
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public decimal Deposit(decimal amount)//------Deposit Method
        {
                
            decimal newBalance = this.Balance + amount;
            Balance = newBalance;
            return newBalance;
        }
        
        public decimal Withdraw(decimal amount) //-------Withdraw Method
        {
            decimal newBalance = this.Balance - amount;
            Balance = newBalance;
            return newBalance;
        }
        public BankAccount()
        {
            this.balance = 100;// starting value for the account is $100
        }

        /*open()decimal
        close()
        deposit()
        withdraw()*/
    }
    

}
