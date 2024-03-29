﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PVAO.ApplicationCore.DTOs
{
    public class BeneficiaryDTO
    {
        public int id { get; set; }
        public string vdmsNo { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string extensionName { get; set; }
        public string relationCode { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string placeOfBirth { get; set; }
        public string mortalStatus { get; set; }
        public string sex { get; set; }
        public string mobile { get; set; }
        public string telephone { get; set; }
        public DateTime? dateOfDeath { get; set; }
        public string placeOfDeath { get; set; }
        public string currentAddress1 { get; set; }
        public string currentAddress2 { get; set; }
        public string currentAddress3 { get; set; }
        public string currentZipCode { get; set; }
        public string emailaddress { get; set; }
        public DateTime? dateCreated { get; set; }
    }
}
