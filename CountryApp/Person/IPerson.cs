using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryApp.Person
{
    interface IPerson
    {
        string FirstName
        {
            get; set;
        }

        string LastName
        {
            get; set;
        }

        DateTime DateOfBirth
        {
            get; set;
        }

        long SocialSecurityNumber
        {
            get; set;
        }
      
        void Sleep();
        void WakeUp();
        void Move();
        void Talk();


    }
}
