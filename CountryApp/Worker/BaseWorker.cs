using CountryApp.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryApp.Worker
{
    class BaseWorker : IWorker
    {
        public string CompanyName { get ; set; }
        public string Department { get ; set; }
        public string Designation { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public DateTime DateOfBirth { get ; set ; }
         public long SocialSecurityNumber { get ; set ; }

        public void GetPaid()
        {
            
        }

        public void Move()
        {
            
        }

        public void PayTax()
        {
            
        }

        public void Sleep()
        {
            
        }

        public void Talk()
        {
            
        }

        public void WakeUp()
        {
            
        }

        public void work()
        {
            
        }


    }
}
