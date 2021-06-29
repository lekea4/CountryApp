using CountryApp.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryApp.Worker
{
    interface IWorker : IPerson
    {
        string CompanyName
        {
            get; set;
        }

        string Department
        {
            get; set;
        }

        string Designation
        {
            get; set;
        }

        void work();
        void GetPaid();
        void PayTax();

    }
}
