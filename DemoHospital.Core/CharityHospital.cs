using System;

namespace DemoHospital.Core
{
    public class CharityHospital : Hospital
    {        
        public void DisplayTreatmentChargeExemptPatients()
        {
            const int AgeLimit = 65;

            foreach (var patient in base.patients)
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
