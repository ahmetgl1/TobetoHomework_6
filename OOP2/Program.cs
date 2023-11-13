using OOP2.Entities;
using OOP2.Services;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Coorporate akbank = new Coorporate();   
            akbank.Id = 1;                          
            akbank.CompanyName = "Akbank";          
            akbank.CustomerNo = "212121";           
            akbank.TaxNo = "10";                    
           

            Individual ahmet = new Individual();    
            ahmet.Id = 2;                           
            ahmet.IdentityNumber = "545454582";     
            ahmet.CustomerName = "Ahmet";           
            ahmet.CustomerLastName = "Güzeller";    
            ahmet.CustomerNo = "15";                
            


            CustomerManager customerManager = new CustomerManager();


            customerManager.Add(ahmet);
            customerManager.Add(akbank);







        }
    }
}