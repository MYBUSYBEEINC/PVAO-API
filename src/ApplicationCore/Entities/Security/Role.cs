using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Security
{
    public class Role
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string userRole { get; set; }
    }
}
