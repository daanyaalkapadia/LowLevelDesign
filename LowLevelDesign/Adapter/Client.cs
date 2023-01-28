using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Adapter
{
    internal class Client
    {
        public static void AdapterMain()
        {
            GooglePay gpay = new GooglePay(new YesBankAdapter());
            if(gpay.TransferMoney(1234567865, 1454367864, 5467, 1000))
            {
                Console.WriteLine("Transaction Successfull");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }
    }
}
