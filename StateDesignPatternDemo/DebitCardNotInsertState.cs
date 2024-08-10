using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo
{
    internal class DebitCardNotInsertState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit CardNo,Debit Card is not inserted in ATM Machine");
        }

        public void EnterPin()
        {
            Console.WriteLine("you cannot enter the pin,Debit Card is not inserted in ATM Machine");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("you cannot withdraw money,Debit Card is not inserted in ATM Machine");
        }
    }
}
