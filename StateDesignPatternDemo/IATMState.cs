using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo
{
    internal interface IATMState
    {
        public void InsertDebitCard();
        public void EjectDebitCard();
        public void EnterPin();
        public void WithdrawMoney();

    }
}
