using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Security
{
    public class PasswordHistory : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }
    }
}
