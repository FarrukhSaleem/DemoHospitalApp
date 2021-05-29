using System;
namespace DemoHospital.Core
{
    public class Patient
    {
        public int id { get; set; }
        public int InsuranceNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
