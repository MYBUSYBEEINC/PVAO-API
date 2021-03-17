using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.Security
{
    public class User
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public string userPassword { get; set; }

        [DataMember]
        public string fullName { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public DateTime? passwordExpiry { get; set; }

        [DataMember]
        public string userEnabled { get; set; }

        [DataMember]
        public DateTime? lastLogin { get; set; }

        [DataMember]
        public string userRole { get; set; }

        [DataMember]
        public string dockOff { get; set; }

        [DataMember]
        public string divisionCode { get; set; }

        [DataMember]
        public string createdBy { get; set; }

        [DataMember]
        public DateTime? dateCreated { get; set; }

        [DataMember]
        public string modifiedBy { get; set; }

        [DataMember]
        public DateTime? dateModified { get; set; }
    }
}
