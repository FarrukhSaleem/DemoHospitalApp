using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoHospital.Core;

namespace AccessModifierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new CharityHospital();

            hospital.AddPatient(new Patient
            {
                id = 1,
                DateOfBirth = new DateTime(1983, 07, 25),
                InsuranceNo = 23232432,
                Name = "farrukh SALEEM",
                Surname = "SHEIKH"
            });
            hospital.AddPatient(new Patient
            {
                id = 1,
                DateOfBirth = new DateTime(1923, 07, 25),
                InsuranceNo = 1111111,
                Name = "Older MAN",
                Surname = "MAN"
            });
            hospital.DisplayPatientList();
            Console.Read();
        }
        
    }
}
