namespace LowLevelDesign.Adapter
{
    internal class YesBankAdapter : IBankAdapter
    {
        //all these method will call YesBankApi
        public bool Authenticate(int accountNumber, int pin)
        {
            if (pin > 999 && pin < 10000)
            {
                return true;
            }
            return false;
        }

        public bool DoTransaction(int fromAccountNumber, int toAccountNumber, decimal amount)
        {
            return true;
        }

        public decimal GetBalance(int accountNumber)
        {
            return 100000;
        }
    }
}
