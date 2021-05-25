using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHospital.Core
{
    public class CharityHospital : Hospital
    {
        public override void DisplayPatientList()
        {
            base.DisplayPatientList();
            const int AgeLimit = 65;

            foreach (var patient in patients)
            {
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan timeSpan = (DateTime.Now - patient.DateOfBirth);
                int Age = ((zeroTime + timeSpan).Year - 1);

                if (Age > AgeLimit)
                {                    
                    Console.WriteLine(patient.Name + " is eligible for free treatment.");                    
                }                
            }
        }
    }
}
