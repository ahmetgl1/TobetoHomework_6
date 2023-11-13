using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database' e Loglandı !");
        }
    }
}
