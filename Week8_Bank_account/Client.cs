using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_Bank_account
{
    class Client
    { //2fields
        private string firstName;
        private string lastName;
        private string accountNumber;
        // 2 properties
        public string Firstname
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Lastname
        {
            get { return this.lastName; } //name
            set { this.lastName = value; }
        } 
        public string Accountnumber
        {
            get { return this.accountNumber; } //account number
            set { this.accountNumber = value; }
        }       
        // 1 Method 
        

        // 1 Constructor
        public Client()
        {
            this.Firstname = "Name: Lawrence ";
            this.Lastname = "Hudson ";
            this.accountNumber = "Account #: 003245308474";
        }


    }
}
