using System;
using System.Collections.Generic;
using System.Text;

namespace PVAO.ApplicationCore.DTOs
{
    public class BeneficiaryDTO
    {
        public int Id { get; set; }
        public string VdmsNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
    }
}
