using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo
{
    internal class ATMMachine : IATMState
    {
        public IATMState aTMState = null;

        public ATMMachine()
        {
            aTMState=new DebitCardNotInsertState();
        }
        public void InsertDebitCard()
        {
            aTMState.InsertDebitCard();
            if(aTMState is DebitCardNotInsertState)
            {
                aTMState=new DebitCardInsertedStatecs();
                Console.WriteLine($"ATM Machine internal state has been changed to : {aTMState.GetType().Name}");
            }
        }
        public void EjectDebitCard()
        {
            aTMState.EjectDebitCard();
            if (aTMState is DebitCardInsertedStatecs)
            {
                aTMState = new DebitCardNotInsertState();
                Console.WriteLine($"ATM Machine internal state has been Changed to : {aTMState.GetType().Name}");
            }
        }
        public void EnterPin()
        {
            aTMState.EnterPin();
        }
        public void WithdrawMoney()
        {
            aTMState.WithdrawMoney();
        }
    }
}
