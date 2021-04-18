using System;
using System.Collections.Generic;
using System.Text;

namespace PVAO.ApplicationCore.DTOs
{
    public class VeteranDTO
    {
        public int vdmsno { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string extensionName { get; set; }
        public string currentAddress1 { get; set; }
        public string currentAddress2 { get; set; }
        public string currentAddress3 { get; set; }
        public string currentZipCode { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string placeOfBirth { get; set; }
        public int? age { get; set; }
        public string nationality { get; set; }
        public string mortalStatus { get; set; }
        public DateTime? dateOfDeath { get; set; }
        public string causeOfDeath { get; set; }
        public string placeOfDeath { get; set; }
        public string sex { get; set; }
        public string country { get; set; }
        public string vfpOrganization { get; set; }
        public DateTime? dateCreated { get; set; }
        public DateTime? dateModified { get; set; }
    }
}
