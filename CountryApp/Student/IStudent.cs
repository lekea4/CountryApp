using CountryApp.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryApp.Student
{
    interface IStudent : IPerson
    {
        string SchoolName
        {
            get; set;
        }
        string Course
        {
            set; get;
        }
         string Level
        {
            get; set;
        }

        void Study();
        void AttendLectures();
        void WriteExam();



    }
}
