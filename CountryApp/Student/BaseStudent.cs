using CountryApp.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryApp.Student
{
    abstract class BaseStudent : IStudent
    {
        public string SchoolName { get ; set ; }
        public string Course { get ; set ; }
        public string Level { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public DateTime DateOfBirth { get ; set ; }
        public long SocialSecurityNumber { get ; set ; }

        public void AttendLectures()
        {
            
        }

        public void Move()
        {
            
        }

        public void Sleep()
        {
            
        }

        public void Study()
        {
            
        }

        public void Talk()
        {
            
        }

        public void WakeUp()
        {
            
        }

        public void WriteExam()
        {
            
        }
    }
}
