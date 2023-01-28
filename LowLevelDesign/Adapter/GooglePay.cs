using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Adapter
{
    internal class GooglePay
    {
        private IBankAdapter bankAdapter;
        public GooglePay(IBankAdapter bankAdapter)
        {
            this.bankAdapter = bankAdapter;
        }
        public bool TransferMoney(int fromAccountNumber, int toAccountNumber, int pin, decimal amount)
        {
            if (bankAdapter.Authenticate(fromAccountNumber, pin))
            {
                var balance = bankAdapter.GetBalance(fromAccountNumber);
                if(balance >= amount)
                {
                    if(bankAdapter.DoTransaction(fromAccountNumber, toAccountNumber, amount))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
