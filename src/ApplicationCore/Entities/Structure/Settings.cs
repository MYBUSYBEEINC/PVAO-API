using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class Settings : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FromEmail { get; set; }

        [DataMember]
        public string FromName { get; set; }

        [DataMember]
        public string ServerName { get; set; }

        [DataMember]
        public int SMTPPort { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool EnableSSL { get; set; }

        [DataMember]
        public int MaxSignOnAttempts { get; set; }

        [DataMember]
        public int ExpiresIn { get; set; }

        [DataMember]
        public int MinPasswordLength { get; set; }

        [DataMember]
        public int MinSpecialCharacters { get; set; }

        [DataMember]
        public int EnforcePasswordHistory { get; set; }

        [DataMember]
        public int ActivationLinkExpiresIn { get; set; }

        [DataMember]
        public string BaseUrl { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public int? UpdatedBy { get; set; }

        [DataMember]
        public DateTime? DateUpdated { get; set; }
    }
}
