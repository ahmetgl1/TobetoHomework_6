using OOP3.Services;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ILoanManager mortgage = new MorgageLoan();
            

            ILoanManager transport = new TransportLoan();

            ILoanManager personal = new PersonalFinance();


            Basvuru basvuru = new Basvuru();
            //basvuru.basvuruYap(personal);

            ILogger fileLogger = new FileLoggerService();
            ILogger database = new DatabaseLoggerService();

            basvuru.basvuruYap(personal, fileLogger);
            List<ILoanManager> loanManagers = new List<ILoanManager>() { mortgage, personal , transport };




        }


    }
}