using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DemoHospital.Core
{
    public class Hospital
    {
        //private
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
    }
}
