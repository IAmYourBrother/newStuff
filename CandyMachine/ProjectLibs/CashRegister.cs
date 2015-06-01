using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibs
{
    public class CashRegister
    {
        private int cashOnHand;

        public CashRegister(int cashOnHand) 
        {
            this.cashOnHand = cashOnHand;            
        }

        public int CurrentBalance()
        {
            return cashOnHand;
        }

        public void AcceptAmount(int cashOnhand)
        {
            this.cashOnHand = this.cashOnHand + cashOnHand;
        }

    }
}
