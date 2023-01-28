using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Adapter
{
    internal class ICICIBankAdapter : IBankAdapter
    {
        //all these method will call ICICIBankApi
        public bool Authenticate(int accountNumber, int pin)
        {
            throw new NotImplementedException();
        }

        public bool DoTransaction(int fromAccountNumber, int toAccountNumber, decimal amount)
        {
            throw new NotImplementedException();
        }

        public decimal GetBalance(int accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
