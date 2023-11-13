using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Services
{
    internal class TransportLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport Loan is calculate !");
        }
    }
}
