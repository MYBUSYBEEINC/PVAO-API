using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.Security
{
    public class TokenOptions
    {
        [DataMember]
        public string Issuer { get; set; }

        [DataMember]
        public string Audience { get; set; }

        [DataMember]
        public int ExpiresInMinutes { get; set; }
    }
}
