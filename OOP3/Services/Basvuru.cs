using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Services
{
     class Basvuru
    {


        public void basvuruYap(ILoanManager loanManager , ILogger logger)
        {

            loanManager.Calculate();
            logger.Log();
        }

        public void CreditPreliminaryInformation(List<ILoanManager> loanManagers)
        {

            foreach (var item in loanManagers)
            {
                item.Calculate();
                
                
            }



        }

    }
}
