using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHospital.Core
{
    public class Hospital
    {
        protected List<Patient> patients { get; set; }
        public string Name { get; set; }

        public Hospital()
        {
            patients = new List<Patient>();
        }
        public void AddPatient(Patient patientToAdd)
        {
            patients.Add(patientToAdd);
        }
        public ReadOnlyCollection<Patient> GetPatientList()
        {
            return patients.AsReadOnly();
        }
        public virtual void DisplayPatientList()
        {
            foreach (Patient item in patients)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.InsuranceNo);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.DateOfBirth);
            }
        }
    }
}
