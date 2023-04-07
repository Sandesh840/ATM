using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.heritance
{
    internal class CardHolder
    {
        public int pin { get; set; }
        public string cardNum { get; set; }
        public string name { get; set; }
        // string lname;
         public double balance { get; set; }
        

        public CardHolder(int pin, string cardNum, string name, double balance)
        {
            this.pin = pin;
            this.cardNum = cardNum;
            this.name = name;
            this.balance = balance;
        }

      
        public int getpin()
        {
            return pin;
        }
        
        public string getcardNum()
        {
            return cardNum;
        }
       
        public string getname()
        {
            return name;
        }
       
        //public string getlname()
        //{
        //    return lname;
        //}
        public double getbalance()
        {
            return balance;
        }
        
        public void setCardNum(string newcardNum)
        {
            cardNum = newcardNum;
        }
        public void setName(string newfname)
        {
            name = newfname;
        }
        
        public void setBalance(double newbalance)
        {
            balance = newbalance;
        }
        

    }
    
    
}
