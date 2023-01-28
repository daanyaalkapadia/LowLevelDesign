using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Adapter
{
    internal interface IBankAdapter
    {
        bool Authenticate(int accountNumber, int pin);
        decimal GetBalance(int accountNumber);
        bool DoTransaction(int fromAccountNumber, int toAccountNumber, decimal amount);
    }
}
