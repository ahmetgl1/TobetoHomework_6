using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Services
{
    internal class MorgageLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Morgage is calculate !");
        }
    }
}
